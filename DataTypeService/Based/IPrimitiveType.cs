using System.Text.Json.Nodes;

namespace DataTypeService.Based
{
    public interface IPrimitiveType : IDataType
    {
        bool IsValidValue(string value);
        JsonNode? GetJsonValue();


    }


}
