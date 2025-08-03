namespace FhirCore.Interfaces
{
    /// <summary>
    /// 定義具有值的泛型介面
    /// </summary>
    /// <typeparam name="T">值的型別</typeparam>
    public interface IValue<out T>
    {
        /// <summary>
        /// 取得值
        /// </summary>
        public abstract T? Value { get; }
    }
    
    /// <summary>
    /// 定義可為 null 的值型別介面，繼承自 IValue
    /// </summary>
    /// <typeparam name="T">值型別，必須為結構</typeparam>
    public interface INullableValue<T> : IValue<T?> where T : struct
    {
        /// <summary>
        /// 取得值，指示是否有值
        /// </summary>
        public abstract bool HasValue { get; }
    }
    
    /// <summary>
    /// 定義字串值介面
    /// </summary>
    public interface IStringValue : IValue<string> { }
    
    /// <summary>
    /// 定義日期時間值介面
    /// </summary>
    public interface IDateTimeValue : INullableValue<DateTime> { }
    
    /// <summary>
    /// 定義帶時區偏移的日期時間值介面
    /// </summary>
    public interface IDatetimeOffsetValue : INullableValue<DateTimeOffset> { }
    
    /// <summary>
    /// 定義布林值介面
    /// </summary>
    public interface IBooleanValue : INullableValue<bool> { }
    
    /// <summary>
    /// 定義位元組值介面
    /// </summary>
    public interface IByteValue : INullableValue<byte> { }
    
    /// <summary>
    /// 定義 32 位元整數值介面
    /// </summary>
    public interface IInteger32Value : INullableValue<int> { }
    
    /// <summary>
    /// 定義 64 位元整數值介面
    /// </summary>
    public interface IInteger64Value : INullableValue<long> { }
    
    /// <summary>
    /// 定義 32 位元無符號整數值介面
    /// </summary>
    public interface IUnsignedInteger32Value : INullableValue<uint> { }
    
    /// <summary>
    /// 定義十進位數值介面
    /// </summary>
    public interface IDecimalValue : INullableValue<decimal> { }

}
