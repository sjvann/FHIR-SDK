using DataTypeService.Based;
using System.Text.Json.Nodes;

namespace DataTypeService.Choice
{
    public class ValueChoice : ChoiceBased
    {

        #region Properies

        #endregion

        #region Constructor

        public ValueChoice()
        {
        }

        public ValueChoice(KeyValuePair<string, JsonNode?> current) : base(current)
        {
        }

        public ValueChoice(string? keyName, JsonNode? value) : base(keyName, value)
        {
        }

        public ValueChoice(string prefix, IComplexType? value) : base(prefix, value)
        {
        }

        public ValueChoice(string prefix, IPrimitiveType value) : base(prefix, value)
        {
        }
        #endregion

        #region Private Method

        #endregion

    }
}
