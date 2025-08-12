using FhirCore.Interfaces;

namespace TerminologyService.ValueSet
{
    /// <summary>
    /// 表示 FHIR 時間單位的值集
    /// 
    /// <para>
    /// 定義用於時間測量的標準單位，如秒、分鐘、小時、天等。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 時間單位用於 FHIR 中的各種時間相關資料類型，
    /// 如 Duration、Period 和 Timing 等。
    /// </para>
    /// </remarks>
    public class UnitsOfTime : ValueSetBase<EnumUnitsOfTime>, IValueSetClass
    {
        /// <summary>
        /// 初始化 UnitsOfTime 類別的新執行個體
        /// </summary>
        public UnitsOfTime() { }
        
        /// <summary>
        /// 使用指定的枚舉值初始化 UnitsOfTime 類別的新執行個體
        /// </summary>
        /// <param name="value">時間單位枚舉值</param>
        public UnitsOfTime(EnumUnitsOfTime value) : base(value) { }

        /// <summary>
        /// 取得枚舉名稱
        /// </summary>
        /// <returns>時間單位的字串表示</returns>
        public string GetEnumName() => GetStringValue() ?? string.Empty;
    }

    /// <summary>
    /// 時間單位枚舉
    /// 
    /// <para>
    /// 定義 FHIR 中使用的標準時間單位。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 這些時間單位遵循 UCUM（統一代碼測量單位）標準。
    /// </para>
    /// </remarks>
    public enum EnumUnitsOfTime
    {
        /// <summary>
        /// 秒 (s)
        /// 
        /// <para>
        /// 基本時間單位，國際單位制的基本單位之一。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 用於非常短暫的時間間隔測量。
        /// </para>
        /// </remarks>
        s,
        
        /// <summary>
        /// 分鐘 (min)
        /// 
        /// <para>
        /// 等於 60 秒的時間單位。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 常用於醫療程序和治療時間的記錄。
        /// </para>
        /// </remarks>
        min,
        
        /// <summary>
        /// 小時 (h)
        /// 
        /// <para>
        /// 等於 60 分鐘的時間單位。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 用於藥物給藥間隔和治療持續時間。
        /// </para>
        /// </remarks>
        h,
        
        /// <summary>
        /// 天 (d)
        /// 
        /// <para>
        /// 等於 24 小時的時間單位。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 最常用的時間單位，用於藥物治療週期和追蹤期間。
        /// </para>
        /// </remarks>
        d,
        
        /// <summary>
        /// 週 (wk)
        /// 
        /// <para>
        /// 等於 7 天的時間單位。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 用於週期性治療和定期檢查的安排。
        /// </para>
        /// </remarks>
        wk,
        
        /// <summary>
        /// 月 (mo)
        /// 
        /// <para>
        /// 約等於 30 天的時間單位。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 用於長期治療計劃和追蹤觀察。
        /// </para>
        /// </remarks>
        mo,
        
        /// <summary>
        /// 年 (a)
        /// 
        /// <para>
        /// 約等於 365 天的時間單位。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 用於長期研究、疾病追蹤和年齡計算。
        /// </para>
        /// </remarks>
        a
    }
}
