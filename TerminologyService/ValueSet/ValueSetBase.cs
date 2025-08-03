using FhirCore.Interfaces;
using System.Threading.Tasks.Sources;
using TerminologyService.Models;

namespace TerminologyService.ValueSet
{
    /// <summary>
    /// 值集基礎類別
    /// 
    /// <para>
    /// 為所有 FHIR 值集類別提供通用功能的泛型基礎類別。
    /// 提供枚舉值與字串值之間的轉換和管理功能。
    /// </para>
    /// </summary>
    /// <typeparam name="T">枚舉類型，必須繼承自 Enum</typeparam>
    /// <remarks>
    /// <para>
    /// 此基礎類別實作了值集的核心功能，包括：
    /// - 枚舉值的儲存和檢索
    /// - 字串表示的產生
    /// - 類型安全的值集操作
    /// </para>
    /// </remarks>
    public class ValueSetBase<T> : IValueSet<T> where T : Enum
    {
        private readonly string? _value;
        /// <summary>
        /// 初始化 ValueSetBase 類別的新執行個體
        /// </summary>
        public ValueSetBase() { }

        /// <summary>
        /// 使用指定的枚舉值初始化 ValueSetBase 類別的新執行個體
        /// </summary>
        /// <param name="value">要設定的枚舉值</param>
        public ValueSetBase(T value)
        {
            _value = value.ToString();
        }

        /// <summary>
        /// 使用指定的函數取得枚舉值
        /// </summary>
        /// <param name="func">用於從枚舉值產生字串的函數</param>
        /// <returns>處理後的枚舉值</returns>
        /// <remarks>
        /// <para>
        /// 此方法提供靈活的枚舉值處理機制，允許自訂轉換邏輯。
        /// </para>
        /// </remarks>
        public T GetEnum(Func<T, string> func)
        {
            return (T)Enum.Parse(typeof(T), func.ToString() ?? string.Empty);
        }

        /// <summary>
        /// 取得當前值的字串表示
        /// </summary>
        /// <returns>值的字串表示，如果沒有值則返回 null</returns>
        /// <remarks>
        /// <para>
        /// 此方法將枚舉值轉換為其對應的字串表示，
        /// 通常用於序列化和顯示目的。
        /// </para>
        /// </remarks>
        public virtual string? GetStringValue() => _value;

        /// <summary>
        /// 從字串值取得對應的枚舉值
        /// </summary>
        /// <param name="value">要轉換的字串值</param>
        /// <returns>對應的枚舉值</returns>
        /// <remarks>
        /// <para>
        /// 此方法提供從字串反向解析為枚舉值的功能，
        /// 用於反序列化和字串輸入處理。
        /// </para>
        /// </remarks>
        public T GetValue(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }
    }
}