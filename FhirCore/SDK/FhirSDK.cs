using FhirCore.Versioning;

namespace FhirCore.SDK
{
    /// <summary>
    /// FHIR SDK 主要類別
    /// 提供簡潔的多版本 FHIR 資源管理介面
    /// </summary>
    public static class FhirSDK
    {
        private static readonly FhirVersionManager _versionManager = new();

        /// <summary>
        /// 設定 FHIR 版本
        /// </summary>
        /// <param name="version">FHIR 版本 (R4, R5, R6)</param>
        public static void SetVersion(string version)
        {
            _versionManager.SwitchVersion(version);
        }

        /// <summary>
        /// 取得當前 FHIR 版本
        /// </summary>
        /// <returns>當前版本</returns>
        public static string GetCurrentVersion()
        {
            return _versionManager.CurrentVersion;
        }

        /// <summary>
        /// 取得支援的 FHIR 版本列表
        /// </summary>
        /// <returns>支援的版本</returns>
        public static IEnumerable<string> GetSupportedVersions()
        {
            return _versionManager.GetSupportedVersions();
        }

        /// <summary>
        /// 建立指定版本的資源
        /// </summary>
        /// <typeparam name="T">資源類型</typeparam>
        /// <param name="version">FHIR 版本</param>
        /// <returns>資源實例</returns>
        public static T CreateResource<T>(string version) where T : class
        {
            return _versionManager.GetResource<T>(version);
        }

        /// <summary>
        /// 建立當前版本的資源
        /// </summary>
        /// <typeparam name="T">資源類型</typeparam>
        /// <returns>資源實例</returns>
        public static T CreateResource<T>() where T : class
        {
            return _versionManager.GetCurrentVersionResource<T>();
        }

        /// <summary>
        /// 驗證資源
        /// </summary>
        /// <param name="resource">要驗證的資源</param>
        /// <param name="version">FHIR 版本</param>
        /// <returns>驗證結果</returns>
        public static ValidationResult ValidateResource(object resource, string version)
        {
            return _versionManager.ValidateResource(resource, version);
        }

        /// <summary>
        /// 使用當前版本驗證資源
        /// </summary>
        /// <param name="resource">要驗證的資源</param>
        /// <returns>驗證結果</returns>
        public static ValidationResult ValidateResource(object resource)
        {
            return _versionManager.ValidateResourceWithCurrentVersion(resource);
        }

        /// <summary>
        /// 檢查是否支援指定的 FHIR 版本
        /// </summary>
        /// <param name="version">要檢查的版本</param>
        /// <returns>是否支援</returns>
        public static bool IsVersionSupported(string version)
        {
            return _versionManager.IsVersionSupported(version);
        }

        /// <summary>
        /// 取得指定版本支援的資源類型
        /// </summary>
        /// <param name="version">FHIR 版本</param>
        /// <returns>支援的資源類型</returns>
        public static IEnumerable<string> GetSupportedResourceTypes(string version)
        {
            return _versionManager.GetSupportedResourceTypes(version);
        }
    }
} 