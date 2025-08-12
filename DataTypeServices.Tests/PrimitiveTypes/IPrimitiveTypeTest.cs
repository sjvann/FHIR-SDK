using FhirCore.Interfaces;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// PrimitiveType 測試介面
    /// 定義所有 PrimitiveType 測試的抽象方法
    /// </summary>
    /// <typeparam name="T">PrimitiveType 類型</typeparam>
    public interface IPrimitiveTypeTest<T> where T : IPrimitiveType
    {
        #region 抽象方法 - 每個類型需要實作

        /// <summary>
        /// 取得有效值陣列
        /// </summary>
        /// <returns>有效值陣列</returns>
        string[] GetValidValues();

        /// <summary>
        /// 取得無效值陣列
        /// </summary>
        /// <returns>無效值陣列</returns>
        string[] GetInvalidValues();

        /// <summary>
        /// 取得預期的 FHIR 類型名稱
        /// </summary>
        /// <returns>類型名稱</returns>
        string GetExpectedTypeName();

        /// <summary>
        /// 建立實例
        /// </summary>
        /// <param name="value">值</param>
        /// <returns>實例</returns>
        T CreateInstance(string value);

        /// <summary>
        /// 建立 null 實例
        /// </summary>
        /// <returns>null 實例</returns>
        T CreateNullInstance();

        #endregion
    }
} 