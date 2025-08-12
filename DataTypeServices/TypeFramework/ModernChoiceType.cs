using FhirCore.ExtensionMethods;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;

namespace DataTypeServices.TypeFramework
{
    /// <summary>
    /// 現代化的 ChoiceType 實現，提供更好的類型安全和開發者體驗
    /// </summary>
    /// <typeparam name="T1">第一個可能的類型</typeparam>
    /// <typeparam name="T2">第二個可能的類型</typeparam>
    public class ModernChoiceType<T1, T2> : ChoiceType
        where T1 : IDataType
        where T2 : IDataType
    {
        private readonly object? _value;
        private readonly Type _currentType;
        private readonly string _prefix;

        public ModernChoiceType(string prefix, T1 value) : base(CreateChoiceTypeJson(prefix, value))
        {
            _prefix = prefix;
            _value = value;
            _currentType = typeof(T1);
        }

        public ModernChoiceType(string prefix, T2 value) : base(CreateChoiceTypeJson(prefix, value))
        {
            _prefix = prefix;
            _value = value;
            _currentType = typeof(T2);
        }

        public ModernChoiceType(string prefix, JsonObject jsonValue) : base(prefix, jsonValue, GetSupportedTypes())
        {
            _prefix = prefix;
            // 嘗試從 JSON 解析出正確的類型
            var (value, type) = ParseFromJson(prefix, jsonValue);
            _value = value;
            _currentType = type;
        }

        /// <summary>
        /// 檢查當前值是否為 T1 類型
        /// </summary>
        public bool IsT1 => _currentType == typeof(T1);

        /// <summary>
        /// 檢查當前值是否為 T2 類型
        /// </summary>
        public bool IsT2 => _currentType == typeof(T2);

        /// <summary>
        /// 安全地取得 T1 類型的值
        /// </summary>
        public T1? AsT1 => IsT1 ? (T1?)_value : default;

        /// <summary>
        /// 安全地取得 T2 類型的值
        /// </summary>
        public T2? AsT2 => IsT2 ? (T2?)_value : default;

        /// <summary>
        /// 模式匹配方法，確保處理所有可能的類型
        /// </summary>
        public TResult Match<TResult>(Func<T1, TResult> onT1, Func<T2, TResult> onT2)
        {
            if (IsT1 && _value is T1 t1)
                return onT1(t1);
            if (IsT2 && _value is T2 t2)
                return onT2(t2);

            throw new InvalidOperationException($"Unexpected type in ChoiceType: {_currentType}");
        }

        /// <summary>
        /// 執行動作的模式匹配
        /// </summary>
        public void Switch(Action<T1> onT1, Action<T2> onT2)
        {
            if (IsT1 && _value is T1 t1)
                onT1(t1);
            else if (IsT2 && _value is T2 t2)
                onT2(t2);
            else
                throw new InvalidOperationException($"Unexpected type in ChoiceType: {_currentType}");
        }

        /// <summary>
        /// 嘗試取得指定類型的值
        /// </summary>
        public bool TryGetValue<T>(out T? value) where T : IDataType
        {
            if (typeof(T) == _currentType && _value is T typedValue)
            {
                value = typedValue;
                return true;
            }
            value = default;
            return false;
        }

        public override string GetPrefixName(bool withCapital = true)
        {
            return _prefix.ToTitleCase(withCapital);
        }

        public override List<string> SetSupportDataType()
        {
            return GetSupportedTypes();
        }

        private static List<string> GetSupportedTypes()
        {
            var types = new List<string>();
            
            // 取得 T1 的 FHIR 類型名稱
            if (CreateInstance<T1>() is IDataType t1Instance)
                types.Add(t1Instance.GetFhirTypeName(false));
            
            // 取得 T2 的 FHIR 類型名稱
            if (CreateInstance<T2>() is IDataType t2Instance)
                types.Add(t2Instance.GetFhirTypeName(false));

            return types;
        }

        internal static T? CreateInstance<T>() where T : IDataType
        {
            try
            {
                return (T?)Activator.CreateInstance(typeof(T));
            }
            catch
            {
                return default;
            }
        }

        private static IDataType? GetDataTypeInterface(object value)
        {
            return value as IDataType;
        }

        private static JsonObject CreateChoiceTypeJson<T>(string prefix, T value) where T : IDataType
        {
            var typeName = value.GetFhirTypeName(true);
            var propertyName = $"{prefix}{typeName}";
            var jsonObject = new JsonObject();

            if (value is IPrimitiveType primitive)
            {
                jsonObject[propertyName] = primitive.GetJsonValue();
            }
            else if (value is IComplexType complex)
            {
                jsonObject[propertyName] = complex.GetJsonObject();
            }

            return jsonObject;
        }

        private static (object? value, Type type) ParseFromJson(string prefix, JsonObject jsonValue)
        {
            var supportedTypes = GetSupportedTypes();
            
            foreach (var typeName in supportedTypes)
            {
                var propertyName = $"{prefix}{typeName.ToTitleCase(true)}";
                if (jsonValue.ContainsKey(propertyName))
                {
                    var jsonNode = jsonValue[propertyName];
                    
                    // 嘗試創建對應的類型實例
                    if (typeName.Equals(GetTypeName<T1>(), StringComparison.OrdinalIgnoreCase))
                    {
                        var instance = CreateInstanceFromJson<T1>(jsonNode);
                        return (instance, typeof(T1));
                    }
                    if (typeName.Equals(GetTypeName<T2>(), StringComparison.OrdinalIgnoreCase))
                    {
                        var instance = CreateInstanceFromJson<T2>(jsonNode);
                        return (instance, typeof(T2));
                    }
                }
            }
            
            throw new ArgumentException($"Unable to parse ChoiceType from JSON for prefix '{prefix}'");
        }

        private static string GetTypeName<T>() where T : IDataType
        {
            var instance = CreateInstance<T>();
            return instance?.GetFhirTypeName(false) ?? typeof(T).Name.ToLower();
        }

        private static T? CreateInstanceFromJson<T>(JsonNode? jsonNode) where T : IDataType
        {
            try
            {
                // 嘗試使用 JSON 構造函數
                var constructors = typeof(T).GetConstructors();
                
                // 尋找接受 JsonNode 的構造函數
                var jsonConstructor = constructors.FirstOrDefault(c => 
                    c.GetParameters().Length == 1 && 
                    c.GetParameters()[0].ParameterType == typeof(JsonNode));
                
                if (jsonConstructor != null)
                {
                    return (T?)jsonConstructor.Invoke(new object?[] { jsonNode });
                }
                
                // 尋找接受 JsonObject 的構造函數
                var jsonObjectConstructor = constructors.FirstOrDefault(c => 
                    c.GetParameters().Length == 1 && 
                    c.GetParameters()[0].ParameterType == typeof(JsonObject));
                
                if (jsonObjectConstructor != null && jsonNode is JsonObject jsonObject)
                {
                    return (T?)jsonObjectConstructor.Invoke(new object[] { jsonObject });
                }
                
                // 尋找接受 string 的構造函數
                var stringConstructor = constructors.FirstOrDefault(c => 
                    c.GetParameters().Length == 1 && 
                    c.GetParameters()[0].ParameterType == typeof(string));
                
                if (stringConstructor != null)
                {
                    var stringValue = jsonNode?.GetValue<string>();
                    if (stringValue != null)
                    {
                        return (T?)stringConstructor.Invoke(new object[] { stringValue });
                    }
                }
                
                return default;
            }
            catch
            {
                return default;
            }
        }
    }

    /// <summary>
    /// 三個類型的 ChoiceType
    /// </summary>
    public class ModernChoiceType<T1, T2, T3> : ChoiceType
        where T1 : IDataType
        where T2 : IDataType
        where T3 : IDataType
    {
        private readonly object? _value;
        private readonly Type _currentType;
        private readonly string _prefix;

        public ModernChoiceType(string prefix, T1 value) : base(CreateChoiceTypeJson(prefix, value))
        {
            _prefix = prefix;
            _value = value;
            _currentType = typeof(T1);
        }

        public ModernChoiceType(string prefix, T2 value) : base(CreateChoiceTypeJson(prefix, value))
        {
            _prefix = prefix;
            _value = value;
            _currentType = typeof(T2);
        }

        public ModernChoiceType(string prefix, T3 value) : base(CreateChoiceTypeJson(prefix, value))
        {
            _prefix = prefix;
            _value = value;
            _currentType = typeof(T3);
        }

        public bool IsT1 => _currentType == typeof(T1);
        public bool IsT2 => _currentType == typeof(T2);
        public bool IsT3 => _currentType == typeof(T3);

        public T1? AsT1 => IsT1 ? (T1?)_value : default;
        public T2? AsT2 => IsT2 ? (T2?)_value : default;
        public T3? AsT3 => IsT3 ? (T3?)_value : default;

        public TResult Match<TResult>(Func<T1, TResult> onT1, Func<T2, TResult> onT2, Func<T3, TResult> onT3)
        {
            if (IsT1 && _value is T1 t1) return onT1(t1);
            if (IsT2 && _value is T2 t2) return onT2(t2);
            if (IsT3 && _value is T3 t3) return onT3(t3);

            throw new InvalidOperationException($"Unexpected type in ChoiceType: {_currentType}");
        }

        public override string GetPrefixName(bool withCapital = true)
        {
            return _prefix.ToTitleCase(withCapital);
        }

        public override List<string> SetSupportDataType()
        {
            var types = new List<string>();
            
            if (ModernChoiceType<T1, T2>.CreateInstance<T1>() is IDataType t1) types.Add(t1.GetFhirTypeName(false));
            if (ModernChoiceType<T1, T2>.CreateInstance<T2>() is IDataType t2) types.Add(t2.GetFhirTypeName(false));
            if (ModernChoiceType<T1, T2>.CreateInstance<T3>() is IDataType t3) types.Add(t3.GetFhirTypeName(false));

            return types;
        }

        private static JsonObject CreateChoiceTypeJson<T>(string prefix, T value) where T : IDataType
        {
            var typeName = value.GetFhirTypeName(true);
            var propertyName = $"{prefix}{typeName}";
            var jsonObject = new JsonObject();

            if (value is IPrimitiveType primitive)
            {
                jsonObject[propertyName] = primitive.GetJsonValue();
            }
            else if (value is IComplexType complex)
            {
                jsonObject[propertyName] = complex.GetJsonObject();
            }

            return jsonObject;
        }
    }
}
