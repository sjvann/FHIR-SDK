
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.IngredientSub.SubstanceSub;

namespace ResourceTypeServices.R5.IngredientSub
{
    public class Substance : BackboneElement<Substance>
    {

        #region Property
        [Element("code", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Code {get; set;}
[Element("strength", typeof(Strength), false, true, false, true)]
public IEnumerable<Strength> Strength {get; set;}

        #endregion
        #region Constructor
        public  Substance() { }
        public  Substance(string value) : base(value) { }
        public  Substance(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Substance";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
