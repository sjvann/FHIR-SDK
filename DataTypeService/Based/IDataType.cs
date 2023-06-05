using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Based
{
    public interface IDataType:IBase
    {
        public string GetTypeName();
        public string? GetJsonString();
        public string? GetXmlString();
    }
}
