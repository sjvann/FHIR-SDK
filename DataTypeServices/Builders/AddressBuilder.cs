using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using TerminologyService.ValueSet;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataTypeServices.Builders
{
    /// <summary>
    /// Fluent builder for creating and configuring FHIR Address instances.
    /// Provides a convenient, readable way to construct Address objects with method chaining.
    /// </summary>
    /// <remarks>
    /// This builder follows the fluent interface pattern, allowing you to chain method calls
    /// to configure an Address instance. It provides both strongly-typed enum methods and
    /// string-based methods for flexibility.
    /// </remarks>
    /// <example>
    /// <code>
    /// var address = Address.Builder()
    ///     .WithUse(EnumAddressUse.home)
    ///     .WithType(EnumAddressType.physical)
    ///     .WithLine("123 Main Street")
    ///     .WithLine("Apt 4B")
    ///     .WithCity("Anytown")
    ///     .WithState("NY")
    ///     .WithPostalCode("12345")
    ///     .WithCountry("USA")
    ///     .Build();
    /// </code>
    /// </example>
    public class AddressBuilder : ComplexTypeBuilder<AddressBuilder, Address>
    {
        /// <summary>
        /// Initializes a new instance of the AddressBuilder class.
        /// </summary>
        public AddressBuilder() : base() { }

        /// <summary>
        /// Initializes a new instance of the AddressBuilder class with an existing Address.
        /// </summary>
        /// <param name="address">The existing Address to use as a starting point</param>
        /// <exception cref="ArgumentNullException">Thrown when address is null</exception>
        public AddressBuilder(Address address) : base(address) { }

        /// <summary>
        /// 設定地址用途
        /// </summary>
        /// <param name="use">地址用途</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithUse(EnumAddressUse use)
        {
            _instance.Use = FhirCode<EnumAddressUse>.Init(use);
            return this;
        }

        /// <summary>
        /// 設定地址用途（字符串）
        /// </summary>
        /// <param name="use">地址用途字符串</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithUse(string use)
        {
            if (Enum.TryParse<EnumAddressUse>(use, true, out var enumValue))
            {
                return WithUse(enumValue);
            }
            return this;
        }

        /// <summary>
        /// 設定地址類型
        /// </summary>
        /// <param name="type">地址類型</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithType(EnumAddressType type)
        {
            _instance.Type = FhirCode<EnumAddressType>.Init(type);
            return this;
        }

        /// <summary>
        /// 設定地址類型（字符串）
        /// </summary>
        /// <param name="type">地址類型字符串</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithType(string type)
        {
            if (Enum.TryParse<EnumAddressType>(type, true, out var enumValue))
            {
                return WithType(enumValue);
            }
            return this;
        }

        /// <summary>
        /// 設定地址文本描述
        /// </summary>
        /// <param name="text">地址文本</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithText(string text)
        {
            _instance.Text = new FhirString(text);
            return this;
        }

        /// <summary>
        /// 添加地址行
        /// </summary>
        /// <param name="line">地址行</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithLine(string line)
        {
            _instance.Line ??= new List<FhirString>();
            _instance.Line.Add(new FhirString(line));
            return this;
        }

        /// <summary>
        /// 添加多個地址行
        /// </summary>
        /// <param name="lines">地址行列表</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithLines(params string[] lines)
        {
            foreach (var line in lines)
            {
                WithLine(line);
            }
            return this;
        }

        /// <summary>
        /// 添加多個地址行
        /// </summary>
        /// <param name="lines">地址行集合</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithLines(IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                WithLine(line);
            }
            return this;
        }

        /// <summary>
        /// 清空並設定地址行
        /// </summary>
        /// <param name="lines">地址行列表</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder SetLines(params string[] lines)
        {
            _instance.Line = lines.Select(line => new FhirString(line)).ToList();
            return this;
        }

        /// <summary>
        /// 設定城市
        /// </summary>
        /// <param name="city">城市名稱</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithCity(string city)
        {
            _instance.City = new FhirString(city);
            return this;
        }

        /// <summary>
        /// 設定區域
        /// </summary>
        /// <param name="district">區域名稱</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithDistrict(string district)
        {
            _instance.District = new FhirString(district);
            return this;
        }

        /// <summary>
        /// 設定州/省
        /// </summary>
        /// <param name="state">州/省名稱</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithState(string state)
        {
            _instance.State = new FhirString(state);
            return this;
        }

        /// <summary>
        /// 設定郵政編碼
        /// </summary>
        /// <param name="postalCode">郵政編碼</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithPostalCode(string postalCode)
        {
            _instance.PostalCode = new FhirString(postalCode);
            return this;
        }

        /// <summary>
        /// 設定國家
        /// </summary>
        /// <param name="country">國家名稱</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithCountry(string country)
        {
            _instance.Country = new FhirString(country);
            return this;
        }

        /// <summary>
        /// 設定有效期間
        /// </summary>
        /// <param name="period">有效期間</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithPeriod(Period period)
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
        public AddressBuilder WithPeriod(DateTime? start = null, DateTime? end = null)
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
        public AddressBuilder WithPeriod(Action<PeriodBuilder> configurePeriod)
        {
            var periodBuilder = new PeriodBuilder();
            configurePeriod(periodBuilder);
            return WithPeriod(periodBuilder.Build());
        }

        /// <summary>
        /// 設定完整的美國地址
        /// </summary>
        /// <param name="street">街道地址</param>
        /// <param name="city">城市</param>
        /// <param name="state">州</param>
        /// <param name="zipCode">郵政編碼</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithUSAddress(string street, string city, string state, string zipCode)
        {
            return WithLine(street)
                   .WithCity(city)
                   .WithState(state)
                   .WithPostalCode(zipCode)
                   .WithCountry("USA");
        }

        /// <summary>
        /// 設定完整的地址
        /// </summary>
        /// <param name="lines">地址行</param>
        /// <param name="city">城市</param>
        /// <param name="state">州/省</param>
        /// <param name="postalCode">郵政編碼</param>
        /// <param name="country">國家</param>
        /// <returns>Builder 實例</returns>
        public AddressBuilder WithFullAddress(
            IEnumerable<string> lines,
            string city,
            string? state = null,
            string? postalCode = null,
            string? country = null)
        {
            WithLines(lines).WithCity(city);
            
            if (!string.IsNullOrEmpty(state))
                WithState(state);
            if (!string.IsNullOrEmpty(postalCode))
                WithPostalCode(postalCode);
            if (!string.IsNullOrEmpty(country))
                WithCountry(country);
                
            return this;
        }

        /// <summary>
        /// 複製當前 Builder
        /// </summary>
        /// <returns>新的 Builder 實例</returns>
        public override AddressBuilder Clone()
        {
            var clonedAddress = new Address();
            
            // 複製所有屬性
            if (_instance.Use?.Value != null)
                clonedAddress.Use = FhirCode<EnumAddressUse>.Init((EnumAddressUse)Enum.Parse(typeof(EnumAddressUse), _instance.Use.Value));
            if (_instance.Type?.Value != null)
                clonedAddress.Type = FhirCode<EnumAddressType>.Init((EnumAddressType)Enum.Parse(typeof(EnumAddressType), _instance.Type.Value));
            if (_instance.Text != null)
                clonedAddress.Text = new FhirString(_instance.Text.Value);
            if (_instance.Line != null)
                clonedAddress.Line = _instance.Line.Select(l => new FhirString(l.Value)).ToList();
            if (_instance.City != null)
                clonedAddress.City = new FhirString(_instance.City.Value);
            if (_instance.District != null)
                clonedAddress.District = new FhirString(_instance.District.Value);
            if (_instance.State != null)
                clonedAddress.State = new FhirString(_instance.State.Value);
            if (_instance.PostalCode != null)
                clonedAddress.PostalCode = new FhirString(_instance.PostalCode.Value);
            if (_instance.Country != null)
                clonedAddress.Country = new FhirString(_instance.Country.Value);
            if (_instance.Period != null)
                clonedAddress.Period = _instance.Period; // Period 需要深度複製
                
            return new AddressBuilder(clonedAddress);
        }
    }
}
