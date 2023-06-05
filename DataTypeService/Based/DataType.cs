using System.Text.Json.Nodes;

namespace DataTypeService.Based
{
    public abstract class DataType : Element, IDataType
    {
        protected override string _TypeName => "DataType";

        public string? GetJsonString()
        { 
          return  _JsonNode?.ToJsonString();
        }

        public string? GetXmlString()
        {
            return GetXmlStringImp(this);
        }
    }
}
