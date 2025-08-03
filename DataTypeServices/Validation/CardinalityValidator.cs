using DataTypeServices.Attributes;
using DataTypeServices.TypeFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DataTypeServices.Validation
{
    /// <summary>
    /// FHIR Cardinality 驗證器
    /// </summary>
    public static class CardinalityValidator
    {
        /// <summary>
        /// 驗證對象的所有 cardinality 約束
        /// </summary>
        /// <param name="obj">要驗證的對象</param>
        /// <returns>驗證結果</returns>
        public static ValidationResults ValidateCardinality(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            var results = new ValidationResults();
            var type = obj.GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                var cardinalityAttr = property.GetCustomAttribute<CardinalityAttribute>();
                if (cardinalityAttr != null)
                {
                    var result = ValidateProperty(obj, property, cardinalityAttr);
                    results.Add(result);
                }
            }

            return results;
        }

        /// <summary>
        /// 驗證單一屬性的 cardinality 約束
        /// </summary>
        /// <param name="obj">包含屬性的對象</param>
        /// <param name="property">要驗證的屬性</param>
        /// <param name="cardinalityAttr">cardinality 屬性</param>
        /// <returns>驗證結果</returns>
        public static ValidationResult ValidateProperty(object obj, PropertyInfo property, CardinalityAttribute cardinalityAttr)
        {
            try
            {
                var value = property.GetValue(obj);
                var count = GetValueCount(value);
                var propertyName = property.Name;

                // 檢查最小數量
                if (count < cardinalityAttr.Min)
                {
                    return ValidationResult.Error(
                        $"Property '{propertyName}' has {count} values but requires at least {cardinalityAttr.Min} ({cardinalityAttr.GetCardinalityString()})",
                        propertyName,
                        new Dictionary<string, object>
                        {
                            ["ActualCount"] = count,
                            ["MinRequired"] = cardinalityAttr.Min,
                            ["MaxAllowed"] = cardinalityAttr.Max,
                            ["Cardinality"] = cardinalityAttr.GetCardinalityString()
                        }
                    );
                }

                // 檢查最大數量（-1 表示無限制）
                if (cardinalityAttr.Max != -1 && count > cardinalityAttr.Max)
                {
                    return ValidationResult.Error(
                        $"Property '{propertyName}' has {count} values but allows at most {cardinalityAttr.Max} ({cardinalityAttr.GetCardinalityString()})",
                        propertyName,
                        new Dictionary<string, object>
                        {
                            ["ActualCount"] = count,
                            ["MinRequired"] = cardinalityAttr.Min,
                            ["MaxAllowed"] = cardinalityAttr.Max,
                            ["Cardinality"] = cardinalityAttr.GetCardinalityString()
                        }
                    );
                }

                return ValidationResult.Success();
            }
            catch (Exception ex)
            {
                return ValidationResult.Error(
                    $"Error validating cardinality for property '{property.Name}': {ex.Message}",
                    property.Name
                );
            }
        }

        /// <summary>
        /// 取得值的數量
        /// </summary>
        private static int GetValueCount(object? value)
        {
            if (value == null)
                return 0;

            // 如果是集合類型
            if (value is ICollection collection)
                return collection.Count;

            // 如果是可枚舉類型但不是字符串
            if (value is IEnumerable enumerable && value is not string)
            {
                var count = 0;
                foreach (var _ in enumerable)
                    count++;
                return count;
            }

            // 單一值
            return 1;
        }

        /// <summary>
        /// 取得對象所有屬性的 cardinality 信息
        /// </summary>
        /// <param name="type">要檢查的類型</param>
        /// <returns>cardinality 信息字典</returns>
        public static Dictionary<string, CardinalityInfo> GetCardinalityInfo(Type type)
        {
            var result = new Dictionary<string, CardinalityInfo>();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                var cardinalityAttr = property.GetCustomAttribute<CardinalityAttribute>();
                if (cardinalityAttr != null)
                {
                    result[property.Name] = new CardinalityInfo
                    {
                        PropertyName = property.Name,
                        PropertyType = property.PropertyType,
                        Min = cardinalityAttr.Min,
                        Max = cardinalityAttr.Max,
                        IsRequired = cardinalityAttr.IsRequired,
                        AllowsMultiple = cardinalityAttr.AllowsMultiple,
                        CardinalityString = cardinalityAttr.GetCardinalityString()
                    };
                }
            }

            return result;
        }

        /// <summary>
        /// 檢查類型是否有任何 cardinality 約束
        /// </summary>
        /// <param name="type">要檢查的類型</param>
        /// <returns>如果有 cardinality 約束則返回 true</returns>
        public static bool HasCardinalityConstraints(Type type)
        {
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            return properties.Any(p => p.GetCustomAttribute<CardinalityAttribute>() != null);
        }

        /// <summary>
        /// 取得類型的所有必填屬性
        /// </summary>
        /// <param name="type">要檢查的類型</param>
        /// <returns>必填屬性列表</returns>
        public static List<PropertyInfo> GetRequiredProperties(Type type)
        {
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            return properties
                .Where(p => p.GetCustomAttribute<CardinalityAttribute>()?.IsRequired == true)
                .ToList();
        }

        /// <summary>
        /// 取得類型的所有多值屬性
        /// </summary>
        /// <param name="type">要檢查的類型</param>
        /// <returns>多值屬性列表</returns>
        public static List<PropertyInfo> GetMultipleValueProperties(Type type)
        {
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            return properties
                .Where(p => p.GetCustomAttribute<CardinalityAttribute>()?.AllowsMultiple == true)
                .ToList();
        }
    }

    /// <summary>
    /// Cardinality 信息類型
    /// </summary>
    public class CardinalityInfo
    {
        public string PropertyName { get; set; } = "";
        public Type PropertyType { get; set; } = typeof(object);
        public int Min { get; set; }
        public int Max { get; set; }
        public bool IsRequired { get; set; }
        public bool AllowsMultiple { get; set; }
        public string CardinalityString { get; set; } = "";

        public override string ToString()
        {
            return $"{PropertyName}: {CardinalityString} ({PropertyType.Name})";
        }
    }
}
