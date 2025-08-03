using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using System;

namespace DataTypeServices.Builders
{
    /// <summary>
    /// Period 的 Fluent Builder
    /// </summary>
    public class PeriodBuilder : ComplexTypeBuilder<PeriodBuilder, Period>
    {
        public PeriodBuilder() : base() { }
        public PeriodBuilder(Period period) : base(period) { }

        /// <summary>
        /// 設定開始時間
        /// </summary>
        /// <param name="start">開始時間</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder WithStart(DateTime start)
        {
            _instance.Start = new FhirDateTime(start);
            return this;
        }

        /// <summary>
        /// 設定開始時間
        /// </summary>
        /// <param name="start">開始時間</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder WithStart(DateTimeOffset start)
        {
            _instance.Start = new FhirDateTime(start);
            return this;
        }

        /// <summary>
        /// 設定開始時間（字符串）
        /// </summary>
        /// <param name="start">開始時間字符串</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder WithStart(string start)
        {
            _instance.Start = new FhirDateTime(start);
            return this;
        }

        /// <summary>
        /// 設定結束時間
        /// </summary>
        /// <param name="end">結束時間</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder WithEnd(DateTime end)
        {
            _instance.End = new FhirDateTime(end);
            return this;
        }

        /// <summary>
        /// 設定結束時間
        /// </summary>
        /// <param name="end">結束時間</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder WithEnd(DateTimeOffset end)
        {
            _instance.End = new FhirDateTime(end);
            return this;
        }

        /// <summary>
        /// 設定結束時間（字符串）
        /// </summary>
        /// <param name="end">結束時間字符串</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder WithEnd(string end)
        {
            _instance.End = new FhirDateTime(end);
            return this;
        }

        /// <summary>
        /// 設定時間範圍
        /// </summary>
        /// <param name="start">開始時間</param>
        /// <param name="end">結束時間</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder WithRange(DateTime start, DateTime end)
        {
            return WithStart(start).WithEnd(end);
        }

        /// <summary>
        /// 設定時間範圍
        /// </summary>
        /// <param name="start">開始時間</param>
        /// <param name="end">結束時間</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder WithRange(DateTimeOffset start, DateTimeOffset end)
        {
            return WithStart(start).WithEnd(end);
        }

        /// <summary>
        /// 設定時間範圍（字符串）
        /// </summary>
        /// <param name="start">開始時間字符串</param>
        /// <param name="end">結束時間字符串</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder WithRange(string start, string end)
        {
            return WithStart(start).WithEnd(end);
        }

        /// <summary>
        /// 設定從現在開始的期間
        /// </summary>
        /// <param name="duration">持續時間</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder FromNow(TimeSpan duration)
        {
            var now = DateTime.Now;
            return WithRange(now, now.Add(duration));
        }

        /// <summary>
        /// 設定到現在結束的期間
        /// </summary>
        /// <param name="duration">持續時間（向前）</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder ToNow(TimeSpan duration)
        {
            var now = DateTime.Now;
            return WithRange(now.Subtract(duration), now);
        }

        /// <summary>
        /// 設定從今天開始的期間
        /// </summary>
        /// <param name="days">天數</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder FromToday(int days)
        {
            var today = DateTime.Today;
            return WithRange(today, today.AddDays(days));
        }

        /// <summary>
        /// 設定過去的期間
        /// </summary>
        /// <param name="days">天數</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder LastDays(int days)
        {
            var today = DateTime.Today;
            return WithRange(today.AddDays(-days), today);
        }

        /// <summary>
        /// 設定本週期間
        /// </summary>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder ThisWeek()
        {
            var today = DateTime.Today;
            var startOfWeek = today.AddDays(-(int)today.DayOfWeek);
            var endOfWeek = startOfWeek.AddDays(7);
            return WithRange(startOfWeek, endOfWeek);
        }

        /// <summary>
        /// 設定本月期間
        /// </summary>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder ThisMonth()
        {
            var today = DateTime.Today;
            var startOfMonth = new DateTime(today.Year, today.Month, 1);
            var endOfMonth = startOfMonth.AddMonths(1);
            return WithRange(startOfMonth, endOfMonth);
        }

        /// <summary>
        /// 設定本年期間
        /// </summary>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder ThisYear()
        {
            var today = DateTime.Today;
            var startOfYear = new DateTime(today.Year, 1, 1);
            var endOfYear = startOfYear.AddYears(1);
            return WithRange(startOfYear, endOfYear);
        }

        /// <summary>
        /// 設定開放式期間（只有開始時間）
        /// </summary>
        /// <param name="start">開始時間</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder OpenEnded(DateTime start)
        {
            return WithStart(start);
        }

        /// <summary>
        /// 設定開放式期間（只有結束時間）
        /// </summary>
        /// <param name="end">結束時間</param>
        /// <returns>Builder 實例</returns>
        public PeriodBuilder EndingAt(DateTime end)
        {
            return WithEnd(end);
        }

        /// <summary>
        /// 檢查期間是否有效
        /// </summary>
        /// <returns>是否有效</returns>
        public bool IsValid()
        {
            if (_instance.Start?.Value == null || _instance.End?.Value == null)
                return true; // 開放式期間是有效的

            return _instance.Start.Value <= _instance.End.Value;
        }

        /// <summary>
        /// 取得期間長度
        /// </summary>
        /// <returns>期間長度，如果是開放式期間則返回 null</returns>
        public TimeSpan? GetDuration()
        {
            if (_instance.Start?.Value == null || _instance.End?.Value == null)
                return null;

            return _instance.End.Value - _instance.Start.Value;
        }

        /// <summary>
        /// 複製當前 Builder
        /// </summary>
        /// <returns>新的 Builder 實例</returns>
        public override PeriodBuilder Clone()
        {
            var clonedPeriod = new Period();
            
            if (_instance.Start != null)
                clonedPeriod.Start = new FhirDateTime(_instance.Start.Value);
            if (_instance.End != null)
                clonedPeriod.End = new FhirDateTime(_instance.End.Value);
                
            return new PeriodBuilder(clonedPeriod);
        }

        /// <summary>
        /// 建構並驗證期間
        /// </summary>
        /// <returns>建構完成且驗證通過的期間</returns>
        /// <exception cref="InvalidOperationException">期間無效時拋出</exception>
        public override Period BuildAndValidate()
        {
            if (!IsValid())
            {
                throw new InvalidOperationException("Period is invalid: start time must be before or equal to end time");
            }
            
            return base.BuildAndValidate();
        }
    }
}
