

namespace DataTypeService.BaseTypes
{
    public interface IValue<out T1>
    {
        public abstract T1? Value { get; }
    }

    public interface IStringValue : IValue<string> { }
    public interface IDateTimeValue : IValue<DateTimeOffset>
    {
        public abstract string? StringValue { get; }
    }

    public interface INullableValue<T> : IValue<T?> where T : struct { }
    public interface INullableIntegerValue : INullableValue<int> { }

    public interface IValueElement<out T2> where T2 : DataType
    {
        public abstract T2? ValueElement { get; }
    }



}
