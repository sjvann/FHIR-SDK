using DataTypeServices.Attributes;
using DataTypeServices.TypeFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace DataTypeServices.Validation
{
    /// <summary>
    /// 自定義驗證引擎
    /// </summary>
    public static class CustomValidationEngine
    {
        /// <summary>
        /// 驗證對象的所有自定義驗證屬性
        /// </summary>
        /// <param name="obj">要驗證的對象</param>
        /// <returns>驗證結果</returns>
        public static ValidationResults ValidateCustomAttributes(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            var results = new ValidationResults();
            var type = obj.GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                var validationAttributes = property.GetCustomAttributes<FhirValidationAttribute>();
                if (validationAttributes.Any())
                {
                    var propertyResults = ValidateProperty(obj, property, validationAttributes);
                    results.AddRange(propertyResults.Results);
                }
            }

            return results;
        }

        /// <summary>
        /// 驗證單一屬性的自定義驗證屬性
        /// </summary>
        /// <param name="obj">包含屬性的對象</param>
        /// <param name="property">要驗證的屬性</param>
        /// <param name="validationAttributes">驗證屬性列表</param>
        /// <returns>驗證結果</returns>
        public static ValidationResults ValidateProperty(object obj, PropertyInfo property, IEnumerable<FhirValidationAttribute> validationAttributes)
        {
            var results = new ValidationResults();
            var propertyValue = property.GetValue(obj);
            var propertyName = property.Name;

            // 如果屬性值是 FHIR 類型，提取其實際值
            if (propertyValue != null)
            {
                var valueProperty = propertyValue.GetType().GetProperty("Value");
                if (valueProperty != null)
                {
                    propertyValue = valueProperty.GetValue(propertyValue);
                }
            }

            // 按優先級排序驗證屬性
            var sortedAttributes = validationAttributes.OrderBy(attr => attr.Priority).ToList();

            foreach (var attribute in sortedAttributes)
            {
                ValidationResult result;

                // 處理內建驗證屬性
                if (attribute is EmailValidationAttribute)
                {
                    result = ValidateEmail(propertyValue, propertyName);
                }
                else if (attribute is UrlValidationAttribute)
                {
                    result = ValidateUrl(propertyValue, propertyName);
                }
                else if (attribute is PhoneValidationAttribute)
                {
                    result = ValidatePhone(propertyValue, propertyName);
                }
                else if (attribute is DateRangeValidationAttribute dateRangeAttr)
                {
                    result = ValidateDateRange(propertyValue, propertyName, dateRangeAttr.MinDate, dateRangeAttr.MaxDate);
                }
                else if (attribute is NumericRangeValidationAttribute numericRangeAttr)
                {
                    result = ValidateNumericRange(propertyValue, propertyName,
                        numericRangeAttr.MinValue == double.MinValue ? null : numericRangeAttr.MinValue,
                        numericRangeAttr.MaxValue == double.MaxValue ? null : numericRangeAttr.MaxValue);
                }
                else if (attribute is RegexValidationAttribute regexAttr)
                {
                    result = ValidateRegex(propertyValue, propertyName, regexAttr.Pattern);
                }
                else
                {
                    // 執行自定義驗證方法
                    result = attribute.Validate(propertyValue, obj, propertyName);
                }

                results.Add(result);

                // 如果驗證失敗且設定了停止後續驗證
                if (!result.IsValid && attribute.StopOnFirstFailure)
                {
                    break;
                }
            }

            return results;
        }

        #region 內建驗證方法

        /// <summary>
        /// 驗證電子郵件格式
        /// </summary>
        private static ValidationResult ValidateEmail(object? value, string propertyName)
        {
            if (value == null)
                return ValidationResult.Success();

            var email = value.ToString();
            if (string.IsNullOrWhiteSpace(email))
                return ValidationResult.Success();

            var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(email, emailPattern))
            {
                return ValidationResult.Success();
            }

            return ValidationResult.Error($"Invalid email format: {email}", propertyName);
        }

        /// <summary>
        /// 驗證 URL 格式
        /// </summary>
        private static ValidationResult ValidateUrl(object? value, string propertyName)
        {
            if (value == null)
                return ValidationResult.Success();

            var url = value.ToString();
            if (string.IsNullOrWhiteSpace(url))
                return ValidationResult.Success();

            if (Uri.TryCreate(url, UriKind.Absolute, out var uri) && 
                (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps))
            {
                return ValidationResult.Success();
            }

            return ValidationResult.Error($"Invalid URL format: {url}", propertyName);
        }

        /// <summary>
        /// 驗證電話號碼格式
        /// </summary>
        private static ValidationResult ValidatePhone(object? value, string propertyName)
        {
            if (value == null)
                return ValidationResult.Success();

            var phone = value.ToString();
            if (string.IsNullOrWhiteSpace(phone))
                return ValidationResult.Success();

            // 簡單的電話號碼驗證（可以根據需要調整）
            var phonePattern = @"^[\+]?[1-9][\d]{0,15}$";
            var cleanPhone = Regex.Replace(phone, @"[\s\-\(\)]", "");
            
            if (Regex.IsMatch(cleanPhone, phonePattern))
            {
                return ValidationResult.Success();
            }

            return ValidationResult.Error($"Invalid phone number format: {phone}", propertyName);
        }

        /// <summary>
        /// 驗證日期範圍
        /// </summary>
        private static ValidationResult ValidateDateRange(object? value, string propertyName, DateTime? minDate, DateTime? maxDate)
        {
            if (value == null)
                return ValidationResult.Success();

            DateTime date;
            if (value is DateTime dateTime)
            {
                date = dateTime;
            }
            else if (DateTime.TryParse(value.ToString(), out var parsedDate))
            {
                date = parsedDate;
            }
            else
            {
                return ValidationResult.Error($"Invalid date format: {value}", propertyName);
            }

            if (minDate.HasValue && date < minDate.Value)
            {
                return ValidationResult.Error($"Date {date:yyyy-MM-dd} is before minimum allowed date {minDate.Value:yyyy-MM-dd}", propertyName);
            }

            if (maxDate.HasValue && date > maxDate.Value)
            {
                return ValidationResult.Error($"Date {date:yyyy-MM-dd} is after maximum allowed date {maxDate.Value:yyyy-MM-dd}", propertyName);
            }

            return ValidationResult.Success();
        }

        /// <summary>
        /// 驗證數值範圍
        /// </summary>
        private static ValidationResult ValidateNumericRange(object? value, string propertyName, double? minValue, double? maxValue)
        {
            if (value == null)
                return ValidationResult.Success();

            double number;
            if (value is double doubleValue)
            {
                number = doubleValue;
            }
            else if (value is int intValue)
            {
                number = intValue;
            }
            else if (value is decimal decimalValue)
            {
                number = (double)decimalValue;
            }
            else if (double.TryParse(value.ToString(), out var parsedNumber))
            {
                number = parsedNumber;
            }
            else
            {
                return ValidationResult.Error($"Invalid numeric format: {value}", propertyName);
            }

            if (minValue.HasValue && number < minValue.Value)
            {
                return ValidationResult.Error($"Value {number} is below minimum allowed value {minValue.Value}", propertyName);
            }

            if (maxValue.HasValue && number > maxValue.Value)
            {
                return ValidationResult.Error($"Value {number} is above maximum allowed value {maxValue.Value}", propertyName);
            }

            return ValidationResult.Success();
        }

        /// <summary>
        /// 驗證正則表達式
        /// </summary>
        private static ValidationResult ValidateRegex(object? value, string propertyName, string pattern)
        {
            if (value == null)
                return ValidationResult.Success();

            var text = value.ToString();
            if (string.IsNullOrWhiteSpace(text))
                return ValidationResult.Success();

            try
            {
                if (Regex.IsMatch(text, pattern))
                {
                    return ValidationResult.Success();
                }

                return ValidationResult.Error($"Value '{text}' does not match required pattern", propertyName);
            }
            catch (Exception ex)
            {
                return ValidationResult.Error($"Error validating regex pattern: {ex.Message}", propertyName);
            }
        }

        #endregion
    }
}
