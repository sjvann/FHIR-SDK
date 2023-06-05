using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeHelper
{
    public interface IDataTypeHelper<T> where T : DataType
    {
        T Get();
        void Set(T value);
    }
}
