using FhirCore.Interfaces;

namespace TerminologyService.ValueSet
{
    /// <summary>
    /// 表示 FHIR 事件時機的值集
    /// 
    /// <para>
    /// 定義醫療事件發生的時機，如用餐前後、睡前、起床後等。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 事件時機值集用於 Timing 資源中指定事件與日常活動
    /// 的時間關係，特別常用於藥物給藥時間的安排。
    /// </para>
    /// </remarks>
    public class EventTiming : ValueSetBase<EnumEventTiming>, IValueSetClass
    {
        /// <summary>
        /// 初始化 EventTiming 類別的新執行個體
        /// </summary>
        public EventTiming() { }
        
        /// <summary>
        /// 使用指定的枚舉值初始化 EventTiming 類別的新執行個體
        /// </summary>
        /// <param name="value">事件時機枚舉值</param>
        public EventTiming(EnumEventTiming value) : base(value) { }

        /// <summary>
        /// 取得枚舉名稱
        /// </summary>
        /// <returns>事件時機的字串表示</returns>
        public string GetEnumName() => GetStringValue() ?? string.Empty;
    }
    
    /// <summary>
    /// 事件時機枚舉
    /// 
    /// <para>
    /// 定義醫療事件與日常活動的時間關係，
    /// 特別用於藥物給藥和治療安排。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 這些時機代碼遵循 HL7 V3 TimingEvent 值集標準。
    /// </para>
    /// </remarks>
    public enum EnumEventTiming
    {
        /// <summary>
        /// 早晨 (Morning)
        /// 
        /// <para>
        /// 早晨時段，通常指上午時間。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 一般指早上起床後至中午前的時間段。
        /// </para>
        /// </remarks>
        MORN,
        
        /// <summary>
        /// 早晨早期 (Early Morning)
        /// 
        /// <para>
        /// 早晨的較早時段。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 通常指清晨時分，比一般早晨時間更早。
        /// </para>
        /// </remarks>
        MORN_early,
        
        /// <summary>
        /// 早晨晚期 (Late Morning)
        /// 
        /// <para>
        /// 早晨的較晚時段。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 通常指接近中午的早晨時間。
        /// </para>
        /// </remarks>
        MORN_late,
        
        /// <summary>
        /// 中午 (Noon)
        /// 
        /// <para>
        /// 中午時分，通常指 12:00 左右。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 一天中的正午時刻，常用於藥物給藥安排。
        /// </para>
        /// </remarks>
        NOON,
        
        /// <summary>
        /// 下午 (Afternoon)
        /// 
        /// <para>
        /// 下午時段，中午後至傍晚前。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 通常指午後至傍晚的時間段。
        /// </para>
        /// </remarks>
        AFT,
        
        /// <summary>
        /// 下午早期 (Early Afternoon)
        /// 
        /// <para>
        /// 下午的較早時段。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 剛過中午的下午時間。
        /// </para>
        /// </remarks>
        AFT_early,
        
        /// <summary>
        /// 下午晚期 (Late Afternoon)
        /// 
        /// <para>
        /// 下午的較晚時段。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 接近傍晚的下午時間。
        /// </para>
        /// </remarks>
        AFT_late,
        
        /// <summary>
        /// 傍晚 (Evening)
        /// 
        /// <para>
        /// 傍晚時段，下午後至夜晚前。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 通常指晚餐時間前後。
        /// </para>
        /// </remarks>
        EVE,
        
        /// <summary>
        /// 傍晚早期 (Early Evening)
        /// 
        /// <para>
        /// 傍晚的較早時段。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 剛入傍晚的時間。
        /// </para>
        /// </remarks>
        EVE_early,
        
        /// <summary>
        /// 傍晚晚期 (Late Evening)
        /// 
        /// <para>
        /// 傍晚的較晚時段。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 接近夜晚的傍晚時間。
        /// </para>
        /// </remarks>
        EVE_late,
        
        /// <summary>
        /// 夜晚 (Night)
        /// 
        /// <para>
        /// 夜晚時段，傍晚後至早晨前。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 睡眠時間前後，常用於夜間藥物給藥。
        /// </para>
        /// </remarks>
        NIGHT,
        
        /// <summary>
        /// 餐後 (Post meal)
        /// 
        /// <para>
        /// 用餐後的時間。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 不特定哪一餐，通用的餐後時間。
        /// </para>
        /// </remarks>
        PHS,
        
        /// <summary>
        /// 立即 (Immediate)
        /// 
        /// <para>
        /// 立即執行，不延遲。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 用於緊急或需要立即執行的醫療活動。
        /// </para>
        /// </remarks>
        IMD,
        
        /// <summary>
        /// 睡前 (Hour of sleep/Bedtime)
        /// 
        /// <para>
        /// 睡覺前的時間。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 常用於睡前藥物給藥，如安眠藥等。
        /// </para>
        /// </remarks>
        HS,
        
        /// <summary>
        /// 起床後 (Upon waking)
        /// 
        /// <para>
        /// 起床後的時間。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 早晨起床後立即執行的活動。
        /// </para>
        /// </remarks>
        WAKE,
        
        /// <summary>
        /// 用餐時 (With meals)
        /// 
        /// <para>
        /// 與用餐同時進行。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 隨餐服用的藥物或治療。
        /// </para>
        /// </remarks>
        C,
        
        /// <summary>
        /// 早餐時 (With breakfast)
        /// 
        /// <para>
        /// 與早餐同時進行。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 隨早餐服用的藥物。
        /// </para>
        /// </remarks>
        CM,
        
        /// <summary>
        /// 午餐時 (With lunch)
        /// 
        /// <para>
        /// 與午餐同時進行。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 隨午餐服用的藥物。
        /// </para>
        /// </remarks>
        CD,
        
        /// <summary>
        /// 晚餐時 (With dinner)
        /// 
        /// <para>
        /// 與晚餐同時進行。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 隨晚餐服用的藥物。
        /// </para>
        /// </remarks>
        CV,
        
        /// <summary>
        /// 餐前 (Before meals)
        /// 
        /// <para>
        /// 用餐前的時間。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 飯前服用的藥物，通常在飯前 30 分鐘至 1 小時。
        /// </para>
        /// </remarks>
        AC,
        
        /// <summary>
        /// 早餐前 (Before breakfast)
        /// 
        /// <para>
        /// 早餐前的時間。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 早餐前服用的藥物。
        /// </para>
        /// </remarks>
        ACM,
        
        /// <summary>
        /// 午餐前 (Before lunch)
        /// 
        /// <para>
        /// 午餐前的時間。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 午餐前服用的藥物。
        /// </para>
        /// </remarks>
        ACD,
        
        /// <summary>
        /// 晚餐前 (Before dinner)
        /// 
        /// <para>
        /// 晚餐前的時間。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 晚餐前服用的藥物。
        /// </para>
        /// </remarks>
        ACV,
        
        /// <summary>
        /// 餐後 (After meals)
        /// 
        /// <para>
        /// 用餐後的時間。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 飯後服用的藥物，通常在飯後 30 分鐘至 2 小時。
        /// </para>
        /// </remarks>
        PC,
        
        /// <summary>
        /// 早餐後 (After breakfast)
        /// 
        /// <para>
        /// 早餐後的時間。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 早餐後服用的藥物。
        /// </para>
        /// </remarks>
        PCM,
        
        /// <summary>
        /// 午餐後 (After lunch)
        /// 
        /// <para>
        /// 午餐後的時間。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 午餐後服用的藥物。
        /// </para>
        /// </remarks>
        PCD,
        
        /// <summary>
        /// 晚餐後 (After dinner)
        /// 
        /// <para>
        /// 晚餐後的時間。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 晚餐後服用的藥物。
        /// </para>
        /// </remarks>
        PCV
    }
}
