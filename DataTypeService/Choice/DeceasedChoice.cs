using DataTypeService.Based;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Choice
{
    public class DeceasedChoice : ChoiceBased
    {
        #region Prperty 

        #endregion

        public DeceasedChoice()
        {
        }

        public DeceasedChoice(KeyValuePair<string, JsonNode?> current) : base(current)
        {
        }

        public DeceasedChoice(string? keyName, JsonNode? value) : base(keyName, value)
        {
        }

        public DeceasedChoice(string prefix, IComplexType? value) : base(prefix, value)
        {
        }

        public DeceasedChoice(string prefix, IPrimitiveType? value) : base(prefix, value)
        {
        }
    }
}
