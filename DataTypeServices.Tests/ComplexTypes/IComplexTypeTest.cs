using FhirCore.Interfaces;

namespace DataTypeServices.Tests.ComplexTypes
{
    /// <summary>
    /// ComplexType 測試介面
    /// 定義所有 ComplexType 測試的抽象方法
    /// </summary>
    /// <typeparam name="T">ComplexType 類型</typeparam>
    public interface IComplexTypeTest<T> where T : IComplexType
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

        /// <summary>
        /// 建立有效實例（用於測試）
        /// </summary>
        /// <returns>有效實例</returns>
        T CreateValidInstance();

        #endregion
    }
} 