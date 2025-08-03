using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Threading;

namespace FhirCore.Internationalization
{
    /// <summary>
    /// FHIR 本地化管理器
    /// </summary>
    public static class FhirLocalization
    {
        private static readonly Dictionary<string, ResourceManager> _resourceManagers = new();
        private static CultureInfo _currentCulture = CultureInfo.CurrentCulture;

        /// <summary>
        /// 設定當前文化
        /// </summary>
        public static void SetCulture(string cultureName)
        {
            _currentCulture = new CultureInfo(cultureName);
            Thread.CurrentThread.CurrentCulture = _currentCulture;
            Thread.CurrentThread.CurrentUICulture = _currentCulture;
        }

        /// <summary>
        /// 取得本地化字串
        /// </summary>
        public static string GetString(string key, params object[] args)
        {
            var resourceManager = GetResourceManager();
            var value = resourceManager.GetString(key, _currentCulture);
            
            if (string.IsNullOrEmpty(value))
                return key;

            return args.Length > 0 ? string.Format(value, args) : value;
        }

        /// <summary>
        /// 取得錯誤訊息
        /// </summary>
        public static string GetErrorMessage(string errorCode, params object[] args)
        {
            return GetString($"Error_{errorCode}", args);
        }

        /// <summary>
        /// 取得驗證訊息
        /// </summary>
        public static string GetValidationMessage(string validationCode, params object[] args)
        {
            return GetString($"Validation_{validationCode}", args);
        }

        /// <summary>
        /// 取得資源類型名稱
        /// </summary>
        public static string GetResourceTypeName(string resourceType)
        {
            return GetString($"ResourceType_{resourceType}");
        }

        /// <summary>
        /// 取得資料類型名稱
        /// </summary>
        public static string GetDataTypeName(string dataType)
        {
            return GetString($"DataType_{dataType}");
        }

        private static ResourceManager GetResourceManager()
        {
            var cultureKey = _currentCulture.Name;
            
            if (!_resourceManagers.TryGetValue(cultureKey, out var resourceManager))
            {
                resourceManager = new ResourceManager("FhirCore.Resources.Messages", typeof(FhirLocalization).Assembly);
                _resourceManagers[cultureKey] = resourceManager;
            }

            return resourceManager;
        }

        /// <summary>
        /// 支援的文化清單
        /// </summary>
        public static readonly string[] SupportedCultures = 
        {
            "en-US",    // 英文（美國）
            "zh-TW",    // 繁體中文
            "zh-CN",    // 簡體中文
            "ja-JP",    // 日文
            "ko-KR",    // 韓文
            "de-DE",    // 德文
            "fr-FR",    // 法文
            "es-ES",    // 西班牙文
            "pt-BR",    // 葡萄牙文（巴西）
            "ru-RU"     // 俄文
        };

        /// <summary>
        /// 檢查是否支援指定文化
        /// </summary>
        public static bool IsCultureSupported(string cultureName)
        {
            return Array.Exists(SupportedCultures, c => c.Equals(cultureName, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// 取得當前文化
        /// </summary>
        public static CultureInfo CurrentCulture => _currentCulture;
    }

    /// <summary>
    /// 本地化屬性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class LocalizedAttribute : Attribute
    {
        public string ResourceKey { get; }

        public LocalizedAttribute(string resourceKey)
        {
            ResourceKey = resourceKey;
        }
    }

    /// <summary>
    /// 本地化擴展方法
    /// </summary>
    public static class LocalizationExtensions
    {
        /// <summary>
        /// 取得本地化顯示名稱
        /// </summary>
        public static string GetLocalizedDisplayName(this Enum value)
        {
            var enumType = value.GetType();
            var enumName = Enum.GetName(enumType, value);
            return FhirLocalization.GetString($"Enum_{enumType.Name}_{enumName}");
        }

        /// <summary>
        /// 取得本地化描述
        /// </summary>
        public static string GetLocalizedDescription(this Enum value)
        {
            var enumType = value.GetType();
            var enumName = Enum.GetName(enumType, value);
            return FhirLocalization.GetString($"Enum_{enumType.Name}_{enumName}_Description");
        }
    }

    /// <summary>
    /// 多語言錯誤訊息
    /// </summary>
    public static class LocalizedErrorMessages
    {
        public static class Validation
        {
            public static string RequiredField => FhirLocalization.GetString("Validation_RequiredField");
            public static string InvalidFormat => FhirLocalization.GetString("Validation_InvalidFormat");
            public static string OutOfRange => FhirLocalization.GetString("Validation_OutOfRange");
            public static string InvalidEmail => FhirLocalization.GetString("Validation_InvalidEmail");
            public static string InvalidUrl => FhirLocalization.GetString("Validation_InvalidUrl");
            public static string InvalidPhone => FhirLocalization.GetString("Validation_InvalidPhone");
        }

        public static class Network
        {
            public static string ConnectionFailed => FhirLocalization.GetString("Error_Network_ConnectionFailed");
            public static string Timeout => FhirLocalization.GetString("Error_Network_Timeout");
            public static string Unauthorized => FhirLocalization.GetString("Error_Network_Unauthorized");
            public static string Forbidden => FhirLocalization.GetString("Error_Network_Forbidden");
            public static string NotFound => FhirLocalization.GetString("Error_Network_NotFound");
            public static string ServerError => FhirLocalization.GetString("Error_Network_ServerError");
        }

        public static class Serialization
        {
            public static string InvalidJson => FhirLocalization.GetString("Error_Serialization_InvalidJson");
            public static string InvalidXml => FhirLocalization.GetString("Error_Serialization_InvalidXml");
            public static string DeserializationFailed => FhirLocalization.GetString("Error_Serialization_DeserializationFailed");
        }
    }

    /// <summary>
    /// 文化特定的格式化器
    /// </summary>
    public static class CultureSpecificFormatter
    {
        /// <summary>
        /// 格式化日期
        /// </summary>
        public static string FormatDate(DateTime date)
        {
            return date.ToString("d", FhirLocalization.CurrentCulture);
        }

        /// <summary>
        /// 格式化日期時間
        /// </summary>
        public static string FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString("g", FhirLocalization.CurrentCulture);
        }

        /// <summary>
        /// 格式化數字
        /// </summary>
        public static string FormatNumber(decimal number)
        {
            return number.ToString("N", FhirLocalization.CurrentCulture);
        }

        /// <summary>
        /// 格式化貨幣
        /// </summary>
        public static string FormatCurrency(decimal amount)
        {
            return amount.ToString("C", FhirLocalization.CurrentCulture);
        }

        /// <summary>
        /// 格式化百分比
        /// </summary>
        public static string FormatPercent(decimal value)
        {
            return value.ToString("P", FhirLocalization.CurrentCulture);
        }
    }
} 