using DataTypeServices.TypeFramework;
using System;
using System.Reflection;

namespace DataTypeServices.Attributes
{
    /// <summary>
    /// FHIR 自定義驗證屬性
    /// 允許指定自定義驗證方法來驗證屬性值
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    public class FhirValidationAttribute : Attribute
    {
        /// <summary>
        /// 驗證方法名稱
        /// </summary>
        public string MethodName { get; }

        /// <summary>
        /// 錯誤訊息模板
        /// </summary>
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 驗證失敗時的錯誤代碼
        /// </summary>
        public string? ErrorCode { get; set; }

        /// <summary>
        /// 驗證的優先級（數字越小優先級越高）
        /// </summary>
        public int Priority { get; set; } = 100;

        /// <summary>
        /// 是否在第一個驗證失敗時停止後續驗證
        /// </summary>
        public bool StopOnFirstFailure { get; set; } = false;

        /// <summary>
        /// 建構函數
        /// </summary>
        /// <param name="methodName">驗證方法名稱</param>
        public FhirValidationAttribute(string methodName)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Method name cannot be null or empty", nameof(methodName));

            MethodName = methodName;
        }

        /// <summary>
        /// 執行驗證
        /// </summary>
        /// <param name="value">要驗證的值</param>
        /// <param name="instance">包含驗證方法的實例</param>
        /// <param name="propertyName">屬性名稱</param>
        /// <returns>驗證結果</returns>
        public ValidationResult Validate(object? value, object instance, string propertyName)
        {
            try
            {
                var method = FindValidationMethod(instance.GetType());
                if (method == null)
                {
                    return ValidationResult.Error(
                        $"Validation method '{MethodName}' not found in type '{instance.GetType().Name}'",
                        propertyName
                    );
                }

                var result = InvokeValidationMethod(method, instance, value, propertyName);
                return result ?? ValidationResult.Success();
            }
            catch (Exception ex)
            {
                return ValidationResult.Error(
                    $"Error executing validation method '{MethodName}': {ex.Message}",
                    propertyName
                );
            }
        }

        /// <summary>
        /// 尋找驗證方法
        /// </summary>
        /// <param name="type">類型</param>
        /// <returns>方法信息</returns>
        private MethodInfo? FindValidationMethod(Type type)
        {
            // 尋找符合簽名的方法
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            
            foreach (var method in methods)
            {
                if (method.Name != MethodName)
                    continue;

                var parameters = method.GetParameters();
                
                // 支援的方法簽名：
                // 1. ValidationResult MethodName(object value)
                // 2. ValidationResult MethodName(object value, string propertyName)
                // 3. ValidationResult MethodName()
                // 4. bool MethodName(object value)
                // 5. bool MethodName(object value, string propertyName)
                // 6. bool MethodName()
                
                if (method.ReturnType == typeof(ValidationResult) || method.ReturnType == typeof(bool))
                {
                    if (parameters.Length == 0 ||
                        parameters.Length == 1 ||
                        (parameters.Length == 2 && parameters[1].ParameterType == typeof(string)))
                    {
                        return method;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// 調用驗證方法
        /// </summary>
        /// <param name="method">方法信息</param>
        /// <param name="instance">實例</param>
        /// <param name="value">值</param>
        /// <param name="propertyName">屬性名稱</param>
        /// <returns>驗證結果</returns>
        private ValidationResult? InvokeValidationMethod(MethodInfo method, object instance, object? value, string propertyName)
        {
            var parameters = method.GetParameters();
            object?[] args;

            // 根據參數數量準備參數
            switch (parameters.Length)
            {
                case 0:
                    args = Array.Empty<object>();
                    break;
                case 1:
                    args = new object?[] { value };
                    break;
                case 2:
                    args = new object?[] { value, propertyName };
                    break;
                default:
                    throw new InvalidOperationException($"Unsupported method signature for '{MethodName}'");
            }

            var result = method.Invoke(instance, args);

            // 處理返回值
            if (result is ValidationResult validationResult)
            {
                return validationResult;
            }
            else if (result is bool boolResult)
            {
                if (boolResult)
                {
                    return ValidationResult.Success();
                }
                else
                {
                    var errorMessage = ErrorMessage ?? $"Validation failed for property '{propertyName}'";
                    return ValidationResult.Error(errorMessage, propertyName);
                }
            }

            return null;
        }
    }

    /// <summary>
    /// 電子郵件驗證屬性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class EmailValidationAttribute : FhirValidationAttribute
    {
        public EmailValidationAttribute() : base("ValidateEmail")
        {
            ErrorMessage = "Invalid email format";
            ErrorCode = "INVALID_EMAIL";
        }
    }

    /// <summary>
    /// URL 驗證屬性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class UrlValidationAttribute : FhirValidationAttribute
    {
        public UrlValidationAttribute() : base("ValidateUrl")
        {
            ErrorMessage = "Invalid URL format";
            ErrorCode = "INVALID_URL";
        }
    }

    /// <summary>
    /// 電話號碼驗證屬性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class PhoneValidationAttribute : FhirValidationAttribute
    {
        public PhoneValidationAttribute() : base("ValidatePhone")
        {
            ErrorMessage = "Invalid phone number format";
            ErrorCode = "INVALID_PHONE";
        }
    }

    /// <summary>
    /// 日期範圍驗證屬性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class DateRangeValidationAttribute : FhirValidationAttribute
    {
        public DateTime? MinDate { get; set; }
        public DateTime? MaxDate { get; set; }

        public DateRangeValidationAttribute() : base("ValidateDateRange")
        {
            ErrorMessage = "Date is outside the allowed range";
            ErrorCode = "DATE_OUT_OF_RANGE";
        }
    }

    /// <summary>
    /// 數值範圍驗證屬性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class NumericRangeValidationAttribute : FhirValidationAttribute
    {
        public double MinValue { get; set; } = double.MinValue;
        public double MaxValue { get; set; } = double.MaxValue;

        public NumericRangeValidationAttribute() : base("ValidateNumericRange")
        {
            ErrorMessage = "Value is outside the allowed range";
            ErrorCode = "VALUE_OUT_OF_RANGE";
        }

        public NumericRangeValidationAttribute(double minValue, double maxValue) : this()
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }
    }

    /// <summary>
    /// 正則表達式驗證屬性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class RegexValidationAttribute : FhirValidationAttribute
    {
        public string Pattern { get; }

        public RegexValidationAttribute(string pattern) : base("ValidateRegex")
        {
            Pattern = pattern ?? throw new ArgumentNullException(nameof(pattern));
            ErrorMessage = "Value does not match the required pattern";
            ErrorCode = "PATTERN_MISMATCH";
        }
    }
}
