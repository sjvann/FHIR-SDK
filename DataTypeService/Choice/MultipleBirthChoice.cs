using DataTypeService.Based;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Choice
{
    public class MultipleBirthChoice : ChoiceBased
    {
        #region Prperty 

        #endregion

        public MultipleBirthChoice()
        {
        }

        public MultipleBirthChoice(KeyValuePair<string, JsonNode?> current) : base(current)
        {
        }

        public MultipleBirthChoice(string? keyName, JsonNode? value) : base(keyName, value)
        {
        }

        public MultipleBirthChoice(string prefix, IComplexType? value) : base(prefix, value)
        {
        }

        public MultipleBirthChoice(string prefix, IPrimitiveType? value) : base(prefix, value)
        {
        }
    }
}
