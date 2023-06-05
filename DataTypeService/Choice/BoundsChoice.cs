using DataTypeService.Based;
using System.Text.Json.Nodes;

namespace DataTypeService.Choice
{
    public class BoundsChoice : ChoiceBased
    {
        #region Property

        #endregion

        #region Constructor


        public BoundsChoice()
        {
        }

        public BoundsChoice(KeyValuePair<string, JsonNode?> current) : base(current)
        {
        }

        public BoundsChoice(string? keyName, JsonNode? value) : base(keyName, value)
        {
        }

        public BoundsChoice(string prefix, IComplexType? value) : base(prefix, value)
        {
        }

        public BoundsChoice(string prefix, IPrimitiveType value) : base(prefix, value)
        {
        }

        #endregion
    }
}
