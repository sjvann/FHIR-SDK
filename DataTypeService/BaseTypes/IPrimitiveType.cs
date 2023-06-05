using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.BaseTypes
{
    public interface IPrimitiveType:IDataType
    {
        public JsonNode? GetJsonValue();
        public bool IsValidValue(string? value);
        public JsonNode? GetElementProperties();
    }
}
