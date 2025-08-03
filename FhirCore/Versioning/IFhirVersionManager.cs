using System;
using System.Collections.Generic;

namespace FhirCore.Versioning
{
    /// <summary>
    /// FHIR 版本管理器介面
    /// 提供多版本 FHIR 資源的統一管理
    /// </summary>
    public interface IFhirVersionManager
    {
        /// <summary>
        /// 取得當前使用的 FHIR 版本
        /// </summary>
        string CurrentVersion { get; }
        
        /// <summary>
        /// 切換到指定的 FHIR 版本
        /// </summary>
        /// <param name="version">目標版本 (R4, R5, R6)</param>
        void SwitchVersion(string version);
        
        /// <summary>
        /// 取得指定版本的資源實例
        /// </summary>
        /// <typeparam name="T">資源類型</typeparam>
        /// <param name="version">FHIR 版本</param>
        /// <returns>資源實例</returns>
        T GetResource<T>(string version) where T : class;
        
        /// <summary>
        /// 檢查是否支援指定的 FHIR 版本
        /// </summary>
        /// <param name="version">要檢查的版本</param>
        /// <returns>是否支援</returns>
        bool IsVersionSupported(string version);
        
        /// <summary>
        /// 取得所有支援的 FHIR 版本
        /// </summary>
        /// <returns>支援的版本列表</returns>
        IEnumerable<string> GetSupportedVersions();
        
        /// <summary>
        /// 取得指定版本的資源類型列表
        /// </summary>
        /// <param name="version">FHIR 版本</param>
        /// <returns>支援的資源類型</returns>
        IEnumerable<string> GetSupportedResourceTypes(string version);
        
        /// <summary>
        /// 驗證資源是否符合指定版本的規範
        /// </summary>
        /// <param name="resource">要驗證的資源</param>
        /// <param name="version">目標版本</param>
        /// <returns>驗證結果</returns>
        ValidationResult ValidateResource(object resource, string version);
    }
} 