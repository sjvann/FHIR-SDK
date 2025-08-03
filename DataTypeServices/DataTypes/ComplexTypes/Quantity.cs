using FhirCore.Interfaces;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// 表示 FHIR Quantity 資料類型
    /// 
    /// <para>
    /// 測量金額（或可能被測量的金額）。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var quantity = new Quantity
    /// {
    ///     Value = new FhirDecimal(10.5m),
    ///     Unit = new FhirString("mg")
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Quantity 表示帶有可選比較器、單位、系統和代碼的測量金額。
    /// 它用於 FHIR 中表示各種類型的測量。
    /// </para>
    /// </remarks>
    public class Quantity : ComplexType<Quantity>
    {
        #region Private Fields

        private FhirDecimal? _Value;
        private FhirCode? _Comparator;
        private FhirString? _Unit;
        private FhirUri? _System;
        private FhirCode? _Code;

        #endregion

        #region Public Properties

        /// <summary>
        /// 取得或設定數量的數值
        /// </summary>
        /// <value>測量金額的數值</value>
        public FhirDecimal? Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                OnPropertyChanged("value", value);
            }
        }

        /// <summary>
        /// 取得或設定此數量的比較器
        /// </summary>
        /// <value>指示如何理解和評估數量的編碼值</value>
        public FhirCode? Comparator
        {
            get { return _Comparator; }
            set
            {
                _Comparator = value;
                OnPropertyChanged("comparator", value);
            }
        }

        /// <summary>
        /// 取得或設定此數量的測量單位
        /// </summary>
        /// <value>測量單位的人類可讀表示</value>
        public FhirString? Unit
        {
            get { return _Unit; }
            set
            {
                _Unit = value;
                OnPropertyChanged("unit", value);
            }
        }

        /// <summary>
        /// 取得或設定定義測量單位的系統
        /// </summary>
        /// <value>識別定義單位的系統的 URI</value>
        public FhirUri? System
        {
            get { return _System; }
            set
            {
                _System = value;
                OnPropertyChanged("system", value);
            }
        }

        /// <summary>
        /// 取得或設定單位的編碼形式
        /// </summary>
        /// <value>在指定系統中表示單位的代碼</value>
        public FhirCode? Code
        {
            get { return _Code; }
            set
            {
                _Code = value;
                OnPropertyChanged("code", value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// 初始化 Quantity 類別的新執行個體
        /// </summary>
        public Quantity() : base() { }

        /// <summary>
        /// 從 JSON 物件初始化 Quantity 類別的新執行個體
        /// </summary>
        /// <param name="value">包含數量資料的 JSON 物件</param>
        public Quantity(JsonObject value) : base(value) { }

        /// <summary>
        /// 從字串值初始化 Quantity 類別的新執行個體
        /// </summary>
        /// <param name="value">數量的字串表示</param>
        public Quantity(string value) : base(value) { }

        #endregion
    }
}
