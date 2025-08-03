using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace DataTypeServices.Attributes
{
    /// <summary>
    /// FHIR Cardinality 屬性，定義欄位的數量限制
    /// 對應 FHIR 規範中的 cardinality 概念 (例如: 0..1, 1..1, 0..*, 1..*)
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class CardinalityAttribute : ValidationAttribute
    {
        /// <summary>
        /// 最小數量
        /// </summary>
        public int Min { get; }

        /// <summary>
        /// 最大數量，-1 表示無限制 (*)
        /// </summary>
        public int Max { get; }

        /// <summary>
        /// 是否為必填欄位 (Min >= 1)
        /// </summary>
        public bool IsRequired => Min >= 1;

        /// <summary>
        /// 是否允許多個值 (Max > 1 或 Max == -1)
        /// </summary>
        public bool AllowsMultiple => Max > 1 || Max == -1;

        /// <summary>
        /// 建構函數
        /// </summary>
        /// <param name="min">最小數量</param>
        /// <param name="max">最大數量，-1 表示無限制</param>
        public CardinalityAttribute(int min, int max = 1)
        {
            if (min < 0)
                throw new ArgumentException("Min cardinality cannot be negative", nameof(min));
            if (max < -1 || (max != -1 && max < min))
                throw new ArgumentException("Max cardinality must be -1 (unlimited) or >= min", nameof(max));

            Min = min;
            Max = max;
        }

        /// <summary>
        /// 驗證屬性值是否符合 cardinality 約束
        /// </summary>
        public override bool IsValid(object? value)
        {
            var count = GetValueCount(value);
            
            // 檢查最小數量
            if (count < Min)
                return false;

            // 檢查最大數量（-1 表示無限制）
            if (Max != -1 && count > Max)
                return false;

            return true;
        }

        /// <summary>
        /// 格式化錯誤訊息
        /// </summary>
        public override string FormatErrorMessage(string name)
        {
            if (Max == -1)
            {
                if (Min == 0)
                    return $"The field {name} can have any number of values (0..*)";
                else if (Min == 1)
                    return $"The field {name} must have at least 1 value (1..*)";
                else
                    return $"The field {name} must have at least {Min} values ({Min}..*)";
            }
            else if (Min == Max)
            {
                if (Min == 0)
                    return $"The field {name} must be empty";
                else if (Min == 1)
                    return $"The field {name} must have exactly 1 value (1..1)";
                else
                    return $"The field {name} must have exactly {Min} values ({Min}..{Max})";
            }
            else
            {
                return $"The field {name} must have between {Min} and {Max} values ({Min}..{Max})";
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
        /// 取得 cardinality 的字符串表示
        /// </summary>
        public string GetCardinalityString()
        {
            if (Max == -1)
                return $"{Min}..*";
            else
                return $"{Min}..{Max}";
        }

        public override string ToString() => GetCardinalityString();
    }

    /// <summary>
    /// 必填欄位屬性 (1..1)
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class RequiredAttribute : CardinalityAttribute
    {
        public RequiredAttribute() : base(1, 1) { }

        public override string FormatErrorMessage(string name)
        {
            return $"The field {name} is required (1..1)";
        }
    }

    /// <summary>
    /// 可選欄位屬性 (0..1)
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class OptionalAttribute : CardinalityAttribute
    {
        public OptionalAttribute() : base(0, 1) { }

        public override string FormatErrorMessage(string name)
        {
            return $"The field {name} is optional (0..1)";
        }
    }

    /// <summary>
    /// 必填多值欄位屬性 (1..*)
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class RequiredMultipleAttribute : CardinalityAttribute
    {
        public RequiredMultipleAttribute() : base(1, -1) { }

        public override string FormatErrorMessage(string name)
        {
            return $"The field {name} must have at least one value (1..*)";
        }
    }

    /// <summary>
    /// 可選多值欄位屬性 (0..*)
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class OptionalMultipleAttribute : CardinalityAttribute
    {
        public OptionalMultipleAttribute() : base(0, -1) { }

        public override string FormatErrorMessage(string name)
        {
            return $"The field {name} can have any number of values (0..*)";
        }
    }

    /// <summary>
    /// 自定義範圍的多值欄位屬性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class MultipleAttribute : CardinalityAttribute
    {
        public MultipleAttribute(int min, int max = -1) : base(min, max) { }
    }
}
