using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeService.BaseTypes
{
    public interface IDataType
    {
        public string GetTypeName();
        public string? ToJsonString();
    }
}
