using FhirCore.Interfaces;

namespace TerminologyService.ValueSet
{
    /// <summary>
    /// 表示 FHIR 數量比較器的值集
    /// 
    /// <para>
    /// 定義數量比較時使用的比較運算符，如小於、大於等。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 數量比較器用於表示測量值的關係，常用於實驗室結果、
    /// 生命體徵和其他數值測量中。
    /// </para>
    /// </remarks>
    public class QuantityComparator : ValueSetBase<EnumQuantityComparator>, IValueSetClass
    {
        /// <summary>
        /// 初始化 QuantityComparator 類別的新執行個體
        /// </summary>
        public QuantityComparator() { }
        
        /// <summary>
        /// 使用指定的枚舉值初始化 QuantityComparator 類別的新執行個體
        /// </summary>
        /// <param name="value">數量比較器枚舉值</param>
        public QuantityComparator(EnumQuantityComparator value) : base(value) { }

        /// <summary>
        /// 取得枚舉名稱
        /// </summary>
        /// <returns>比較器的字串表示</returns>
        public string GetEnumName() => GetStringValue() ?? string.Empty;
    }
    
    /// <summary>
    /// 數量比較器枚舉
    /// 
    /// <para>
    /// 定義用於數量比較的運算符。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 這些比較器遵循 FHIR 規範中定義的數量比較運算符。
    /// </para>
    /// </remarks>
    public enum EnumQuantityComparator
    {
        /// <summary>
        /// 小於 (&lt;)
        /// 
        /// <para>
        /// 表示實際值小於指定值。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 常用於實驗室結果中表示檢測限以下的值。
        /// </para>
        /// </remarks>
        LessThan,
        
        /// <summary>
        /// 小於或等於 (&lt;=)
        /// 
        /// <para>
        /// 表示實際值小於或等於指定值。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 用於表示範圍的上限值。
        /// </para>
        /// </remarks>
        LessOrEqualTo,
        
        /// <summary>
        /// 大於 (&gt;)
        /// 
        /// <para>
        /// 表示實際值大於指定值。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 常用於表示超出正常範圍的高值。
        /// </para>
        /// </remarks>
        GreaterThan,
        
        /// <summary>
        /// 大於或等於 (&gt;=)
        /// 
        /// <para>
        /// 表示實際值大於或等於指定值。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 用於表示範圍的下限值。
        /// </para>
        /// </remarks>
        GreaterOrEqualTo
    }
}
