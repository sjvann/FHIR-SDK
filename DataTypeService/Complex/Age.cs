using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Complex
{
    public class Age : Quantity
    {
        public Age()
        {
        }

        public Age(string? value) : base(value)
        {
        }

        public Age(JsonNode? source) : base(source)
        {
        }
    }
}
