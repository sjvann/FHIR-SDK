using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Abstractions;

namespace Fhir.TypeFramework.Bases;

/// <summary>
/// Base definition for all types defined in FHIR type system.
/// 所有 FHIR 型別的最基礎類別
/// </summary>
/// <remarks>
/// FHIR R5 Base (Abstract)
/// This is the root of the FHIR type hierarchy.
/// 提供所有 FHIR 型別的基本功能，包括型別名稱、深層複製、相等性比較和驗證。
/// 未知／跨版本元素保留於 <see cref="Overflow"/>，供 Lenient 序列化 round-trip。
/// </remarks>
public abstract class Base : ITypeFramework, IValidatableObject
{
    /// <summary>
    /// 取得型別名稱
    /// </summary>
    /// <returns>型別的名稱</returns>
    [JsonIgnore]
    public virtual string TypeName => GetType().Name;

    /// <summary>
    /// 未對應到強型別屬性的 JSON 元素（含 FHIR primitive companion <c>_name</c>）。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? Overflow { get; set; }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Base 物件的深層複本</returns>
    public abstract Base DeepCopy();

    /// <summary>
    /// 判斷與另一個 Base 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public abstract bool IsExactly(Base other);

    /// <summary>
    /// ITypeFramework 實作 - 建立物件的深層複本
    /// </summary>
    /// <returns>ITypeFramework 物件的深層複本</returns>
    ITypeFramework ITypeFramework.DeepCopy() => DeepCopy();

    /// <summary>
    /// ITypeFramework 實作 - 判斷與另一個物件是否相等
    /// </summary>
    /// <param name="other">要比較的 ITypeFramework 物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    bool ITypeFramework.IsExactly(ITypeFramework? other) => other is Base baseOther && IsExactly(baseOther);

    /// <summary>
    /// 基礎驗證 - 子類別可以覆寫以提供特定驗證邏輯
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        yield break;
    }

    /// <summary>是否為 FHIR JSON 合法但非 POCO 屬性的名稱（primitive companion、註解）。</summary>
    public static bool IsFhirCompanionName(string name) =>
        name.StartsWith('_') || name.Equals("fhir_comments", StringComparison.Ordinal);

    /// <summary>Overflow 中非 companion 的未知元素名。</summary>
    [JsonIgnore]
    public IReadOnlyList<string> UnknownElementNames =>
        Overflow is null
            ? []
            : Overflow.Keys.Where(k => !IsFhirCompanionName(k)).ToArray();

    public bool TryGetValue(string name, out object? value)
    {
        if (TryGetKnownElement(name, out value))
            return true;

        if (Overflow is not null && Overflow.TryGetValue(name, out var element))
        {
            value = element;
            return true;
        }

        value = null;
        return false;
    }

    public void SetValue(string name, object? value)
    {
        if (TrySetKnownElement(name, value))
            return;

        Overflow ??= new Dictionary<string, JsonElement>(StringComparer.Ordinal);
        Overflow[name] = value switch
        {
            JsonElement je => je.Clone(),
            null => default,
            _ => JsonSerializer.SerializeToElement(value)
        };
    }

    public IEnumerable<KeyValuePair<string, object?>> EnumerateElements()
    {
        foreach (var kv in EnumerateKnownElements())
            yield return kv;

        if (Overflow is null)
            yield break;

        foreach (var kv in Overflow)
            yield return new KeyValuePair<string, object?>(kv.Key, kv.Value);
    }

    protected void CopyOverflowTo(Base target)
    {
        if (Overflow is null || Overflow.Count == 0)
        {
            target.Overflow = null;
            return;
        }

        var copy = new Dictionary<string, JsonElement>(Overflow.Count, StringComparer.Ordinal);
        foreach (var kv in Overflow)
            copy[kv.Key] = kv.Value.Clone();
        target.Overflow = copy;
    }

    protected bool OverflowEquals(Base other)
    {
        var a = Overflow;
        var b = other.Overflow;
        if (a is null || a.Count == 0)
            return b is null || b.Count == 0;
        if (b is null || a.Count != b.Count)
            return false;

        foreach (var kv in a)
        {
            if (!b.TryGetValue(kv.Key, out var otherEl))
                return false;
            if (!string.Equals(kv.Value.GetRawText(), otherEl.GetRawText(), StringComparison.Ordinal))
                return false;
        }

        return true;
    }

    private bool TryGetKnownElement(string name, out object? value)
    {
        var map = KnownElementCache.For(GetType());
        if (map.TryGetValue(name, out var prop) && prop.CanRead)
        {
            value = prop.GetValue(this);
            return true;
        }

        value = null;
        return false;
    }

    private bool TrySetKnownElement(string name, object? value)
    {
        var map = KnownElementCache.For(GetType());
        if (!map.TryGetValue(name, out var prop) || !prop.CanWrite)
            return false;

        prop.SetValue(this, value);
        return true;
    }

    private IEnumerable<KeyValuePair<string, object?>> EnumerateKnownElements()
    {
        foreach (var (name, prop) in KnownElementCache.For(GetType()))
        {
            if (!prop.CanRead)
                continue;
            yield return new KeyValuePair<string, object?>(name, prop.GetValue(this));
        }
    }

    private static class KnownElementCache
    {
        private static readonly System.Collections.Concurrent.ConcurrentDictionary<Type, Dictionary<string, PropertyInfo>> Cache = new();

        public static Dictionary<string, PropertyInfo> For(Type type) => Cache.GetOrAdd(type, Build);

        private static Dictionary<string, PropertyInfo> Build(Type type)
        {
            var map = new Dictionary<string, PropertyInfo>(StringComparer.Ordinal);
            foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (prop.GetCustomAttribute<JsonIgnoreAttribute>() is not null)
                    continue;
                if (prop.GetCustomAttribute<JsonExtensionDataAttribute>() is not null)
                    continue;
                if (prop.Name is "Overflow" or "ResourceTypeJson")
                    continue;

                var jsonName = prop.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name;
                if (jsonName is null or "resourceType")
                    continue;
                map[jsonName] = prop;
            }

            return map;
        }
    }
}
