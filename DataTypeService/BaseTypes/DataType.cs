

namespace DataTypeService.BaseTypes
{
    public abstract class DataType : Element, IDataType
    {
        public abstract string? ToJsonString();
    }
}
