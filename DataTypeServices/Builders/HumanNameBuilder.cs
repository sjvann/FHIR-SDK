using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using TerminologyService.ValueSet;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataTypeServices.Builders
{
    /// <summary>
    /// HumanName 的 Fluent Builder
    /// </summary>
    public class HumanNameBuilder : ComplexTypeBuilder<HumanNameBuilder, HumanName>
    {
        public HumanNameBuilder() : base() { }
        public HumanNameBuilder(HumanName humanName) : base(humanName) { }

        /// <summary>
        /// 設定姓名用途（字符串）
        /// </summary>
        /// <param name="use">姓名用途字符串</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithUse(string use)
        {
            _instance.Use = new FhirCode(use);
            return this;
        }

        /// <summary>
        /// 設定完整姓名文本
        /// </summary>
        /// <param name="text">完整姓名</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithText(string text)
        {
            _instance.Text = new FhirString(text);
            return this;
        }

        /// <summary>
        /// 設定姓氏
        /// </summary>
        /// <param name="family">姓氏</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithFamily(string family)
        {
            _instance.Family = new FhirString(family);
            return this;
        }

        /// <summary>
        /// 添加名字
        /// </summary>
        /// <param name="given">名字</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithGiven(string given)
        {
            _instance.Given ??= new List<FhirString>();
            _instance.Given.Add(new FhirString(given));
            return this;
        }

        /// <summary>
        /// 添加多個名字
        /// </summary>
        /// <param name="givenNames">名字列表</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithGiven(params string[] givenNames)
        {
            foreach (var given in givenNames)
            {
                WithGiven(given);
            }
            return this;
        }

        /// <summary>
        /// 添加多個名字
        /// </summary>
        /// <param name="givenNames">名字集合</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithGiven(IEnumerable<string> givenNames)
        {
            foreach (var given in givenNames)
            {
                WithGiven(given);
            }
            return this;
        }

        /// <summary>
        /// 清空並設定名字
        /// </summary>
        /// <param name="givenNames">名字列表</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder SetGiven(params string[] givenNames)
        {
            _instance.Given = givenNames.Select(name => new FhirString(name)).ToList();
            return this;
        }

        /// <summary>
        /// 添加前綴
        /// </summary>
        /// <param name="prefix">前綴</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithPrefix(string prefix)
        {
            _instance.Prefix ??= new List<FhirString>();
            _instance.Prefix.Add(new FhirString(prefix));
            return this;
        }

        /// <summary>
        /// 添加多個前綴
        /// </summary>
        /// <param name="prefixes">前綴列表</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithPrefix(params string[] prefixes)
        {
            foreach (var prefix in prefixes)
            {
                WithPrefix(prefix);
            }
            return this;
        }

        /// <summary>
        /// 清空並設定前綴
        /// </summary>
        /// <param name="prefixes">前綴列表</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder SetPrefix(params string[] prefixes)
        {
            _instance.Prefix = prefixes.Select(prefix => new FhirString(prefix)).ToList();
            return this;
        }

        /// <summary>
        /// 添加後綴
        /// </summary>
        /// <param name="suffix">後綴</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithSuffix(string suffix)
        {
            _instance.Suffix ??= new List<FhirString>();
            _instance.Suffix.Add(new FhirString(suffix));
            return this;
        }

        /// <summary>
        /// 添加多個後綴
        /// </summary>
        /// <param name="suffixes">後綴列表</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithSuffix(params string[] suffixes)
        {
            foreach (var suffix in suffixes)
            {
                WithSuffix(suffix);
            }
            return this;
        }

        /// <summary>
        /// 清空並設定後綴
        /// </summary>
        /// <param name="suffixes">後綴列表</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder SetSuffix(params string[] suffixes)
        {
            _instance.Suffix = suffixes.Select(suffix => new FhirString(suffix)).ToList();
            return this;
        }

        /// <summary>
        /// 設定有效期間
        /// </summary>
        /// <param name="period">有效期間</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithPeriod(Period period)
        {
            _instance.Period = period;
            return this;
        }

        /// <summary>
        /// 設定有效期間
        /// </summary>
        /// <param name="start">開始時間</param>
        /// <param name="end">結束時間</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithPeriod(DateTime? start = null, DateTime? end = null)
        {
            var period = new Period();
            if (start.HasValue)
            {
                period.Start = new FhirDateTime(start.Value);
            }
            if (end.HasValue)
            {
                period.End = new FhirDateTime(end.Value);
            }
            return WithPeriod(period);
        }

        /// <summary>
        /// 使用 Period Builder 設定有效期間
        /// </summary>
        /// <param name="configurePeriod">Period 配置動作</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithPeriod(Action<PeriodBuilder> configurePeriod)
        {
            var periodBuilder = new PeriodBuilder();
            configurePeriod(periodBuilder);
            return WithPeriod(periodBuilder.Build());
        }

        /// <summary>
        /// 設定完整的西方姓名
        /// </summary>
        /// <param name="firstName">名</param>
        /// <param name="lastName">姓</param>
        /// <param name="middleName">中間名（可選）</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithWesternName(string firstName, string lastName, string? middleName = null)
        {
            WithFamily(lastName).WithGiven(firstName);
            if (!string.IsNullOrEmpty(middleName))
            {
                WithGiven(middleName);
            }
            return this;
        }

        /// <summary>
        /// 設定正式姓名
        /// </summary>
        /// <param name="firstName">名</param>
        /// <param name="lastName">姓</param>
        /// <param name="title">稱謂</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithFormalName(string firstName, string lastName, string? title = null)
        {
            WithUse("official")
                .WithFamily(lastName)
                .WithGiven(firstName);

            if (!string.IsNullOrEmpty(title))
            {
                WithPrefix(title);
            }

            return this;
        }

        /// <summary>
        /// 設定暱稱
        /// </summary>
        /// <param name="nickname">暱稱</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithNickname(string nickname)
        {
            return WithUse("nickname").WithGiven(nickname);
        }

        /// <summary>
        /// 設定婚前姓名
        /// </summary>
        /// <param name="firstName">名</param>
        /// <param name="maidenName">婚前姓</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder WithMaidenName(string firstName, string maidenName)
        {
            return WithUse("maiden")
                   .WithFamily(maidenName)
                   .WithGiven(firstName);
        }

        /// <summary>
        /// 從完整姓名字符串解析
        /// </summary>
        /// <param name="fullName">完整姓名</param>
        /// <returns>Builder 實例</returns>
        public HumanNameBuilder ParseFullName(string fullName)
        {
            WithText(fullName);
            
            // 簡單的姓名解析邏輯
            var parts = fullName.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length >= 2)
            {
                // 假設最後一個是姓氏，其他是名字
                WithFamily(parts[^1]);
                for (int i = 0; i < parts.Length - 1; i++)
                {
                    WithGiven(parts[i]);
                }
            }
            else if (parts.Length == 1)
            {
                WithGiven(parts[0]);
            }
            
            return this;
        }

        /// <summary>
        /// 複製當前 Builder
        /// </summary>
        /// <returns>新的 Builder 實例</returns>
        public override HumanNameBuilder Clone()
        {
            var clonedName = new HumanName();
            
            // 複製所有屬性
            if (_instance.Use != null)
                clonedName.Use = new FhirCode(_instance.Use.Value);
            if (_instance.Text != null)
                clonedName.Text = new FhirString(_instance.Text.Value);
            if (_instance.Family != null)
                clonedName.Family = new FhirString(_instance.Family.Value);
            if (_instance.Given != null)
                clonedName.Given = _instance.Given.Select(g => new FhirString(g.Value)).ToList();
            if (_instance.Prefix != null)
                clonedName.Prefix = _instance.Prefix.Select(p => new FhirString(p.Value)).ToList();
            if (_instance.Suffix != null)
                clonedName.Suffix = _instance.Suffix.Select(s => new FhirString(s.Value)).ToList();
            if (_instance.Period != null)
                clonedName.Period = _instance.Period; // Period 需要深度複製
                
            return new HumanNameBuilder(clonedName);
        }
    }
}
