using FhirCore.Interfaces;

namespace TerminologyService.ValueSet
{
    /// <summary>
    /// 表示 FHIR 星期幾的值集
    /// 
    /// <para>
    /// 定義一週中的各天，用於時間安排和重複事件的定義。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 星期幾值集用於 Timing 資源中指定事件應在
    /// 一週中的哪些天發生，支援週期性事件的安排。
    /// </para>
    /// </remarks>
    public class DaysOfWeek : ValueSetBase<EnumDaysOfWeek>, IValueSetClass
    {
        /// <summary>
        /// 初始化 DaysOfWeek 類別的新執行個體
        /// </summary>
        public DaysOfWeek() { }
        
        /// <summary>
        /// 使用指定的枚舉值初始化 DaysOfWeek 類別的新執行個體
        /// </summary>
        /// <param name="value">星期幾枚舉值</param>
        public DaysOfWeek(EnumDaysOfWeek value) : base(value) { }

        /// <summary>
        /// 取得枚舉名稱
        /// </summary>
        /// <returns>星期幾的字串表示</returns>
        public string GetEnumName() => GetStringValue() ?? string.Empty;
    }
    
    /// <summary>
    /// 星期幾枚舉
    /// 
    /// <para>
    /// 定義一週中的七天，使用標準的三字母縮寫。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 這些值遵循 ISO 8601 標準，星期一為一週的開始。
    /// </para>
    /// </remarks>
    public enum EnumDaysOfWeek
    {
        /// <summary>
        /// 星期一 (Monday)
        /// 
        /// <para>
        /// 一週的第一天（根據 ISO 8601 標準）。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 通常是工作週的開始，常用於週期性醫療安排。
        /// </para>
        /// </remarks>
        mon,
        
        /// <summary>
        /// 星期二 (Tuesday)
        /// 
        /// <para>
        /// 一週的第二天。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 工作週中的常規日子，適合安排定期治療。
        /// </para>
        /// </remarks>
        tue,
        
        /// <summary>
        /// 星期三 (Wednesday)
        /// 
        /// <para>
        /// 一週的第三天，通常被視為週中。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 週中時間點，常用於週期性檢查和治療。
        /// </para>
        /// </remarks>
        wed,
        
        /// <summary>
        /// 星期四 (Thursday)
        /// 
        /// <para>
        /// 一週的第四天。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 接近週末的工作日，適合安排週期性活動。
        /// </para>
        /// </remarks>
        thu,
        
        /// <summary>
        /// 星期五 (Friday)
        /// 
        /// <para>
        /// 一週的第五天，通常是工作週的最後一天。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 工作週結束，適合週總結性的醫療活動。
        /// </para>
        /// </remarks>
        fri,
        
        /// <summary>
        /// 星期六 (Saturday)
        /// 
        /// <para>
        /// 一週的第六天，週末的第一天。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 週末時間，可能有不同的醫療服務安排。
        /// </para>
        /// </remarks>
        sat,
        
        /// <summary>
        /// 星期日 (Sunday)
        /// 
        /// <para>
        /// 一週的第七天，週末的第二天。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 傳統的休息日，醫療服務可能有所調整。
        /// </para>
        /// </remarks>
        sun
    }
}
