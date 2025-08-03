using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.SpecialTypes
{
    /// <summary>
    /// 強類型的 FHIR Reference，提供編譯時期的類型安全
    /// </summary>
    /// <typeparam name="T">被引用的 Resource 類型</typeparam>
    public class Reference<T> : ComplexType<Reference<T>>
        where T : class, IResource
    {
        private FhirString? _reference;
        private FhirUri? _type;
        private Identifier? _identifier;
        private FhirString? _display;

        /// <summary>
        /// 引用的 URL 或相對路徑
        /// </summary>
        public FhirString? ReferenceValue
        {
            get { return _reference; }
            set
            {
                _reference = value;
                OnPropertyChanged("reference", value);
            }
        }

        /// <summary>
        /// 被引用資源的類型
        /// </summary>
        public FhirUri? Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }

        /// <summary>
        /// 邏輯引用的識別符
        /// </summary>
        public Identifier? Identifier
        {
            get { return _identifier; }
            set
            {
                _identifier = value;
                OnPropertyChanged("identifier", value);
            }
        }

        /// <summary>
        /// 引用的顯示文字
        /// </summary>
        public FhirString? Display
        {
            get { return _display; }
            set
            {
                _display = value;
                OnPropertyChanged("display", value);
            }
        }

        /// <summary>
        /// 取得被引用的資源類型名稱
        /// </summary>
        public string ResourceTypeName => typeof(T).Name;

        /// <summary>
        /// 檢查引用是否為空
        /// </summary>
        public bool IsEmpty => string.IsNullOrEmpty(_reference?.Value) &&
                              _identifier == null &&
                              string.IsNullOrEmpty(_type?.Value);

        /// <summary>
        /// 檢查是否為相對引用
        /// </summary>
        public bool IsRelativeReference => !string.IsNullOrEmpty(_reference?.Value) &&
                                          !_reference.Value.StartsWith("http://") &&
                                          !_reference.Value.StartsWith("https://");

        /// <summary>
        /// 檢查是否為絕對引用
        /// </summary>
        public bool IsAbsoluteReference => !string.IsNullOrEmpty(_reference?.Value) &&
                                          (_reference.Value.StartsWith("http://") ||
                                           _reference.Value.StartsWith("https://"));

        #region Constructors

        public Reference() : base() 
        {
            // 自動設置類型
            _type = new FhirUri(typeof(T).Name);
        }

        public Reference(JsonObject value) : base(value) 
        {
            // 確保類型正確
            if (_type == null || string.IsNullOrEmpty(_type.Value))
            {
                _type = new FhirUri(typeof(T).Name);
            }
        }

        public Reference(string value) : base(value) 
        {
            // 確保類型正確
            if (_type == null || string.IsNullOrEmpty(_type.Value))
            {
                _type = new FhirUri(typeof(T).Name);
            }
        }

        /// <summary>
        /// 從引用字符串創建
        /// </summary>
        public Reference(string referenceValue, string? displayText = null) : this()
        {
            _reference = new FhirString(referenceValue);
            if (!string.IsNullOrEmpty(displayText))
            {
                _display = new FhirString(displayText);
            }
        }

        /// <summary>
        /// 從資源 ID 創建相對引用
        /// </summary>
        public Reference(FhirId resourceId, string? displayText = null) : this()
        {
            _reference = new FhirString($"{typeof(T).Name}/{resourceId.Value}");
            if (!string.IsNullOrEmpty(displayText))
            {
                _display = new FhirString(displayText);
            }
        }

        /// <summary>
        /// 從 Identifier 創建邏輯引用
        /// </summary>
        public Reference(Identifier identifier, string? displayText = null) : this()
        {
            _identifier = identifier;
            if (!string.IsNullOrEmpty(displayText))
            {
                _display = new FhirString(displayText);
            }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// 創建相對引用
        /// </summary>
        public static Reference<T> ToResource(string resourceId, string? displayText = null)
        {
            return new Reference<T>($"{typeof(T).Name}/{resourceId}", displayText);
        }

        /// <summary>
        /// 創建相對引用
        /// </summary>
        public static Reference<T> ToResource(FhirId resourceId, string? displayText = null)
        {
            return new Reference<T>(resourceId, displayText);
        }

        /// <summary>
        /// 創建絕對引用
        /// </summary>
        public static Reference<T> ToAbsoluteUrl(string absoluteUrl, string? displayText = null)
        {
            return new Reference<T>(absoluteUrl, displayText);
        }

        /// <summary>
        /// 創建邏輯引用
        /// </summary>
        public static Reference<T> ToIdentifier(Identifier identifier, string? displayText = null)
        {
            return new Reference<T>(identifier, displayText);
        }

        /// <summary>
        /// 創建邏輯引用
        /// </summary>
        public static Reference<T> ToIdentifier(string system, string value, string? displayText = null)
        {
            var identifier = new Identifier
            {
                System = new FhirUri(system),
                Value = new FhirString(value)
            };
            return new Reference<T>(identifier, displayText);
        }

        #endregion

        #region Utility Methods

        /// <summary>
        /// 提取資源 ID（如果是相對引用）
        /// </summary>
        public string? ExtractResourceId()
        {
            if (string.IsNullOrEmpty(_reference?.Value))
                return null;

            var refValue = _reference.Value;
            var expectedPrefix = $"{typeof(T).Name}/";
            
            if (refValue.StartsWith(expectedPrefix))
            {
                return refValue.Substring(expectedPrefix.Length);
            }

            // 處理完整 URL 的情況
            var lastSlashIndex = refValue.LastIndexOf('/');
            if (lastSlashIndex >= 0 && lastSlashIndex < refValue.Length - 1)
            {
                var potentialId = refValue.Substring(lastSlashIndex + 1);
                // 簡單驗證是否看起來像 ID
                if (!string.IsNullOrWhiteSpace(potentialId) && !potentialId.Contains('/'))
                {
                    return potentialId;
                }
            }

            return null;
        }

        /// <summary>
        /// 驗證引用是否指向正確的資源類型
        /// </summary>
        public ValidationResult ValidateResourceType()
        {
            if (_type != null && !string.IsNullOrEmpty(_type.Value))
            {
                if (_type.Value.Equals(typeof(T).Name, StringComparison.OrdinalIgnoreCase))
                {
                    return ValidationResult.Success();
                }
                else
                {
                    return ValidationResult.Error(
                        $"Reference type mismatch. Expected '{typeof(T).Name}' but found '{_type.Value}'",
                        "type"
                    );
                }
            }

            if (_reference != null && !string.IsNullOrEmpty(_reference.Value))
            {
                var refValue = _reference.Value;
                if (refValue.StartsWith($"{typeof(T).Name}/") || 
                    refValue.Contains($"/{typeof(T).Name}/"))
                {
                    return ValidationResult.Success();
                }
                else
                {
                    return ValidationResult.Warning(
                        $"Cannot verify resource type from reference '{refValue}'. Expected reference to '{typeof(T).Name}'",
                        "reference"
                    );
                }
            }

            return ValidationResult.Information("No type validation possible - reference uses identifier only");
        }

        /// <summary>
        /// 轉換為非泛型的 ReferenceType
        /// </summary>
        public ReferenceType ToReferenceType()
        {
            var referenceType = new ReferenceType();

            if (_reference != null)
                referenceType.Reference = _reference;
            if (_type != null)
                referenceType.Type = _type;
            if (_identifier != null)
                referenceType.Identifier = _identifier;
            if (_display != null)
                referenceType.Display = _display;

            return referenceType;
        }

        /// <summary>
        /// 從非泛型的 ReferenceType 創建
        /// </summary>
        public static Reference<T> FromReferenceType(ReferenceType referenceType)
        {
            var strongRef = new Reference<T>();

            if (referenceType.Reference != null)
                strongRef.ReferenceValue = referenceType.Reference;
            if (referenceType.Type != null)
                strongRef.Type = referenceType.Type;
            if (referenceType.Identifier != null)
                strongRef.Identifier = referenceType.Identifier;
            if (referenceType.Display != null)
                strongRef.Display = referenceType.Display;

            return strongRef;
        }

        #endregion

        #region Resolution Methods

        /// <summary>
        /// 解析引用的資源
        /// </summary>
        /// <param name="resolver">資源解析器</param>
        /// <returns>解析的資源，如果找不到則返回 null</returns>
        public async Task<T?> ResolveAsync(IResourceResolver resolver)
        {
            if (resolver == null)
                throw new ArgumentNullException(nameof(resolver));

            // 優先使用 reference
            if (!string.IsNullOrEmpty(_reference?.Value))
            {
                return await resolver.GetResourceAsync<T>(_reference.Value);
            }

            // 使用 identifier
            if (_identifier?.System?.Value != null && _identifier?.Value?.Value != null)
            {
                return await resolver.GetResourceByIdentifierAsync<T>(
                    _identifier.System.Value,
                    _identifier.Value.Value);
            }

            return null;
        }

        /// <summary>
        /// 檢查引用的資源是否存在
        /// </summary>
        /// <param name="resolver">資源解析器</param>
        /// <returns>如果資源存在則返回 true</returns>
        public async Task<bool> ExistsAsync(IResourceResolver resolver)
        {
            if (resolver == null)
                throw new ArgumentNullException(nameof(resolver));

            // 優先使用 reference
            if (!string.IsNullOrEmpty(_reference?.Value))
            {
                return await resolver.ExistsAsync(_reference.Value);
            }

            // 使用 identifier（需要實際解析來檢查存在性）
            if (_identifier?.System?.Value != null && _identifier?.Value?.Value != null)
            {
                var resource = await resolver.GetResourceByIdentifierAsync<T>(
                    _identifier.System.Value,
                    _identifier.Value.Value);
                return resource != null;
            }

            return false;
        }

        /// <summary>
        /// 驗證引用的完整性（包括資源存在性）
        /// </summary>
        /// <param name="resolver">資源解析器</param>
        /// <returns>驗證結果</returns>
        public async Task<ValidationResult> ValidateAsync(IResourceResolver resolver)
        {
            var results = new ValidationResults();

            // 基本類型驗證
            results.Add(ValidateResourceType());

            // 檢查引用是否為空
            if (IsEmpty)
            {
                results.Add(ValidationResult.Error("Reference is empty", "reference"));
                return ValidationResult.Combine(results.Results.ToArray());
            }

            // 檢查資源存在性
            if (resolver != null)
            {
                try
                {
                    var exists = await ExistsAsync(resolver);
                    if (!exists)
                    {
                        results.Add(ValidationResult.Error(
                            $"Referenced {typeof(T).Name} resource does not exist",
                            "reference"));
                    }
                }
                catch (Exception ex)
                {
                    results.Add(ValidationResult.Warning(
                        $"Could not verify resource existence: {ex.Message}",
                        "reference"));
                }
            }

            return ValidationResult.Combine(results.Results.ToArray());
        }

        #endregion

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(_display?.Value))
                return _display.Value;
            if (!string.IsNullOrEmpty(_reference?.Value))
                return _reference.Value;
            if (_identifier != null && !string.IsNullOrEmpty(_identifier.Value?.Value))
                return $"{_identifier.System?.Value}|{_identifier.Value.Value}";
            
            return $"Reference<{typeof(T).Name}>";
        }
    }
}
