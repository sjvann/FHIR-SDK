using DataTypeService.Based;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Choice
{
    public class AuthorChoice : ChoiceBased
    {
        #region Prperty 

        #endregion

        public AuthorChoice()
        {
        }

        public AuthorChoice(KeyValuePair<string, JsonNode?> current) : base(current)
        {
        }

        public AuthorChoice(string? keyName, JsonNode? value) : base(keyName, value)
        {
        }

        public AuthorChoice(string prefix, IComplexType? value) : base(prefix, value)
        {
        }

        public AuthorChoice(string prefix, IPrimitiveType? value) : base(prefix, value)
        {
        }
    }
}
