using DataTypeService.Based;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Choice
{
    public class SubjectChoice : ChoiceBased
    {
        #region Prperty 

        #endregion

        public SubjectChoice()
        {
        }

        public SubjectChoice(KeyValuePair<string, JsonNode?> current) : base(current)
        {
        }

        public SubjectChoice(string? keyName, JsonNode? value) : base(keyName, value)
        {
        }

        public SubjectChoice(string prefix, IComplexType? value) : base(prefix, value)
        {
        }

        public SubjectChoice(string prefix, IPrimitiveType value) : base(prefix, value)
        {
        }
    }
}
