namespace Fhir.TypeFramework.Validation;

/// <summary>
/// FHIR 驗證訊息常數
/// 提供統一的錯誤訊息管理
/// </summary>
/// <remarks>
/// 集中管理所有驗證錯誤訊息，確保：
/// - 訊息一致性
/// - 易於維護和更新
/// - 支援多語言（未來擴展）
/// </remarks>
public static class ValidationMessages
{
    /// <summary>
    /// Primitive Types 驗證訊息
    /// </summary>
    public static class PrimitiveTypes
    {
        public const string StringTooLong = "String value exceeds maximum length of {0} characters";
        public const string StringTooLarge = "String value exceeds maximum size of {0} bytes";
        public const string InvalidUri = "Invalid URI format";
        public const string InvalidUrl = "Invalid URL format (must be HTTP or HTTPS)";
        public const string InvalidId = "Invalid FHIR ID format (must be 1-64 characters, only letters, digits, hyphens and dots)";
        public const string InvalidCode = "Invalid FHIR code format (must not exceed 1000 characters)";
        public const string InvalidCanonical = "Invalid canonical format";
        public const string InvalidOid = "Invalid OID format (must be dot-separated numbers)";
        public const string InvalidUuid = "Invalid UUID format";
        public const string InvalidBase64Binary = "Invalid Base64Binary format";
        public const string InvalidPositiveInt = "Value must be a positive integer";
        public const string InvalidUnsignedInt = "Value must be a non-negative integer";
        public const string InvalidIntegerRange = "Integer value must be between {0} and {1}";
        public const string InvalidDate = "Invalid date format (must be ISO 8601)";
        public const string InvalidDateTime = "Invalid DateTime format (must be ISO 8601)";
        public const string InvalidTime = "Invalid time format";
    }

    /// <summary>
    /// Complex Types 驗證訊息
    /// </summary>
    public static class ComplexTypes
    {
        public const string ReferenceMissing = "Reference must have either reference or identifier";
        public const string CodeableConceptMissing = "CodeableConcept must have either coding or text";
        public const string ExtensionUrlRequired = "Extension URL is required";
        public const string ExtensionValueConflict = "Extension cannot have both value and nested extensions";
        public const string HumanNameMissing = "HumanName must have either text, given names, or family name";
        public const string AddressMissing = "Address must have at least one line or text";
        public const string ContactPointMissing = "ContactPoint must have a system and value";
        public const string IdentifierMissing = "Identifier must have a system and value";
        public const string MoneyMissing = "Money must have a currency code";
        public const string QuantityMissing = "Quantity must have a value and unit";
        public const string RatioMissing = "Ratio must have both numerator and denominator";
        public const string RangeMissing = "Range must have both low and high values";
        public const string PeriodMissing = "Period must have both start and end dates";
        public const string CodingMissing = "Coding must have a system and code";
    }

    /// <summary>
    /// Resource Types 驗證訊息
    /// </summary>
    public static class ResourceTypes
    {
        public const string ResourceIdRequired = "Resource ID is required";
        public const string ResourceTypeRequired = "Resource type is required";
        public const string ResourceMetaRequired = "Resource metadata is required";
        public const string ResourceLanguageInvalid = "Resource language must be a valid language code";
        public const string ResourceImplicitRulesInvalid = "Resource implicit rules must be a valid URI";
    }

    /// <summary>
    /// 通用驗證訊息
    /// </summary>
    public static class Common
    {
        public const string Required = "This field is required";
        public const string CannotBeEmpty = "This field cannot be empty";
        public const string InvalidFormat = "Invalid format";
        public const string TooLong = "Value is too long";
        public const string TooShort = "Value is too short";
        public const string OutOfRange = "Value is out of range";
        public const string InvalidValue = "Invalid value";
        public const string DuplicateValue = "Duplicate value not allowed";
        public const string InvalidReference = "Invalid reference";
        public const string CircularReference = "Circular reference detected";
    }

    /// <summary>
    /// 格式化驗證訊息
    /// </summary>
    public static class Formatters
    {
        /// <summary>
        /// 格式化字串長度錯誤訊息
        /// </summary>
        /// <param name="maxLength">最大長度</param>
        /// <returns>格式化的錯誤訊息</returns>
        public static string StringTooLong(int maxLength) => 
            string.Format(PrimitiveTypes.StringTooLong, maxLength);

        /// <summary>
        /// 格式化字串大小錯誤訊息
        /// </summary>
        /// <param name="maxBytes">最大位元組數</param>
        /// <returns>格式化的錯誤訊息</returns>
        public static string StringTooLarge(int maxBytes) => 
            string.Format(PrimitiveTypes.StringTooLarge, maxBytes);

        /// <summary>
        /// 格式化整數範圍錯誤訊息
        /// </summary>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        /// <returns>格式化的錯誤訊息</returns>
        public static string IntegerRange(int min, int max) => 
            string.Format(PrimitiveTypes.InvalidIntegerRange, min, max);
    }
} 