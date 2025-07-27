using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.Base;

/// <summary>
/// 基本型別基礎類別 - 提供通用實作
/// 支援 FHIR R5 的 JSON 序列化格式
/// </summary>
/// <typeparam name="TValue">基本型別的值型別</typeparam>
public abstract class PrimitiveTypeBase<TValue> : PrimitiveType, IPrimitiveType<TValue>
    where TValue : IConvertible
{
    private TValue? _value;
    private string? _stringValue;

    /// <summary>
    /// 基本型別的原始值
    /// </summary>
    public TValue? Value
    {
        get => _value;
        set
        {
            _value = value;
            _stringValue = value?.ToString();
        }
    }

    /// <summary>
    /// 字串表示值
    /// </summary>
    [JsonIgnore]
    public string? StringValue
    {
        get => _stringValue;
        set
        {
            _stringValue = value;
            if (!string.IsNullOrEmpty(value))
            {
                _value = ParseValue(value);
            }
        }
    }

    /// <summary>
    /// 檢查是否為 NULL 值
    /// </summary>
    [JsonIgnore]
    public bool IsNull => Value == null;

    /// <summary>
    /// 從字串解析值
    /// </summary>
    public abstract TValue? ParseValue(string value);

    /// <summary>
    /// 將值轉換為字串
    /// </summary>
    public abstract string? ValueToString(TValue? value);

    /// <summary>
    /// 驗證值是否符合 FHIR 規範
    /// </summary>
    public abstract bool IsValidValue(TValue? value);

    /// <summary>
    /// 取得 FHIR 型別名稱
    /// </summary>
    public override string TypeName => typeof(TValue).Name;

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    public override Base DeepCopy()
    {
        var copy = (PrimitiveTypeBase<TValue>)Activator.CreateInstance(GetType())!;
        copy.Value = Value;
        copy.Id = Id;
        
        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個物件是否相等
    /// </summary>
    public override bool IsExactly(Base other)
    {
        if (other is not PrimitiveTypeBase<TValue> otherPrimitive)
            return false;

        return Equals(Value, otherPrimitive.Value) && base.IsExactly(other);
    }

    /// <summary>
    /// 驗證基本型別是否符合 FHIR 規範
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證值是否有效
        if (Value != null && !IsValidValue(Value))
        {
            yield return new ValidationResult($"Value '{Value}' is not valid for type {TypeName}");
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }

    /// <summary>
    /// 轉換為字串
    /// </summary>
    public override string? ToString() => ValueToString(Value);

    /// <summary>
    /// 轉換為 JSON 值（簡化表示）
    /// FHIR JSON 格式：直接使用值
    /// </summary>
    public virtual JsonValue? ToJsonValue()
    {
        if (IsNull)
            return null;

        var stringValue = ValueToString(Value);
        if (stringValue == null)
            return null;

        // 根據型別決定 JSON 表示方式
        return typeof(TValue).Name switch
        {
            "String" or "DateTime" or "Time" or "Date" or "Uri" or "Url" or "Canonical" or "Code" or "Id" or "Oid" or "Uuid" or "Markdown" => JsonValue.Create(stringValue),
            "Boolean" => JsonValue.Create(Convert.ToBoolean(Value)),
            "Int32" or "Int64" or "UInt32" or "PositiveInt" or "UnsignedInt" or "Integer64" => JsonValue.Create(Convert.ToInt64(Value)),
            "Decimal" or "Double" => JsonValue.Create(Convert.ToDecimal(Value)),
            "Byte[]" => JsonValue.Create(Convert.ToBase64String((byte[])Value!)),
            _ => JsonValue.Create(stringValue)
        };
    }

    /// <summary>
    /// 從 JSON 值建立（簡化表示）
    /// </summary>
    public virtual void FromJsonValue(JsonValue? jsonValue)
    {
        if (jsonValue == null)
        {
            Value = default;
            return;
        }

        StringValue = jsonValue.ToString();
    }

    /// <summary>
    /// 轉換為完整 JSON 物件（包含 Extension）
    /// FHIR JSON 格式：包含 _propertyName 物件
    /// </summary>
    public virtual JsonObject? ToFullJsonObject()
    {
        var jsonObject = new JsonObject();

        // 添加值（簡化表示）
        var jsonValue = ToJsonValue();
        if (jsonValue != null)
        {
            jsonObject.Add("value", jsonValue);
        }

        // 添加 ID
        if (!string.IsNullOrEmpty(Id))
        {
            jsonObject.Add("id", Id);
        }

        // 添加 Extension
        if (Extension?.Any() == true)
        {
            var extensionArray = new JsonArray();
            foreach (var ext in Extension)
            {
                if (ext is DataTypes.Extension extensionImpl)
                {
                    var extObject = new JsonObject();
                    if (!string.IsNullOrEmpty(extensionImpl.Url))
                    {
                        extObject.Add("url", extensionImpl.Url);
                    }
                    if (extensionImpl.Value != null)
                    {
                        // 使用新的 ChoiceType 實作
                        var valueJson = extensionImpl.Value.ToJsonValue();
                        if (valueJson != null)
                        {
                            extObject.Add("value", valueJson);
                        }
                    }
                    extensionArray.Add(extObject);
                }
            }
            jsonObject.Add("extension", extensionArray);
        }

        return jsonObject;
    }

    /// <summary>
    /// 從完整 JSON 物件建立（包含 Extension）
    /// </summary>
    public virtual void FromFullJsonObject(JsonObject? jsonObject)
    {
        if (jsonObject == null)
            return;

        // 解析值
        if (jsonObject.TryGetPropertyValue("value", out var valueElement))
        {
            FromJsonValue(valueElement as JsonValue);
        }

        // 解析 ID
        if (jsonObject.TryGetPropertyValue("id", out var idElement))
        {
            Id = idElement?.GetValue<string>();
        }

        // 解析 Extension
        if (jsonObject.TryGetPropertyValue("extension", out var extensionElement) && extensionElement is JsonArray extensionArray)
        {
            Extension = new List<IExtension>();
            foreach (var extElement in extensionArray)
            {
                if (extElement is JsonObject extObject)
                {
                    var extension = new DataTypes.Extension();
                    if (extObject.TryGetPropertyValue("url", out var urlElement))
                    {
                        extension.Url = urlElement?.GetValue<string>();
                    }
                    if (extObject.TryGetPropertyValue("value", out var valueElement))
                    {
                        // 使用新的 ChoiceType 實作
                        extension.Value = CreateExtensionValueFromJson(valueElement);
                    }
                    Extension.Add(extension);
                }
            }
        }
    }

    /// <summary>
    /// 從 JSON 元素建立 Extension 值
    /// </summary>
    private ExtensionValueChoice? CreateExtensionValueFromJson(JsonElement? element)
    {
        if (element == null) return null;

        // 根據 JSON 型別建立對應的 FHIR 型別
        return element.Value.ValueKind switch
        {
            JsonValueKind.String => new FhirString(element.Value.GetString()),
            JsonValueKind.Number => new FhirInteger(element.Value.GetInt32()),
            JsonValueKind.True => new FhirBoolean(true),
            JsonValueKind.False => new FhirBoolean(false),
            _ => null
        };
    }
} 