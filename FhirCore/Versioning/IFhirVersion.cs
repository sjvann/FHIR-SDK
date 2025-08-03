using System.Collections.Generic;

namespace FhirCore.Versioning
{
    /// <summary>
    /// FHIR 版本介面
    /// 定義特定 FHIR 版本的功能
    /// </summary>
    public interface IFhirVersion
    {
        /// <summary>
        /// 取得 FHIR 版本號
        /// </summary>
        string Version { get; }
        
        /// <summary>
        /// 檢查是否支援指定的資源類型
        /// </summary>
        /// <param name="resourceType">資源類型</param>
        /// <returns>是否支援</returns>
        bool SupportsResourceType(string resourceType);
        
        /// <summary>
        /// 檢查是否支援指定的資料類型
        /// </summary>
        /// <param name="dataType">資料類型</param>
        /// <returns>是否支援</returns>
        bool SupportsDataType(string dataType);
        
        /// <summary>
        /// 取得支援的資源類型列表
        /// </summary>
        /// <returns>支援的資源類型</returns>
        IEnumerable<string> GetSupportedResourceTypes();
        
        /// <summary>
        /// 取得支援的資料類型列表
        /// </summary>
        /// <returns>支援的資料類型</returns>
        IEnumerable<string> GetSupportedDataTypes();
        
        /// <summary>
        /// 驗證資源是否符合 FHIR 標準
        /// </summary>
        /// <param name="resource">要驗證的資源</param>
        /// <returns>驗證結果</returns>
        ValidationResult ValidateResource(object resource);
    }
} 