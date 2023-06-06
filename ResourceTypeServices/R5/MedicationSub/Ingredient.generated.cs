
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MedicationSub
{
    public class Ingredient : BackboneElement<Ingredient>
    {

        #region Property
        [Element("item", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Item {get; set;}
[Element("isActive", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean IsActive {get; set;}
[Element("strength", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Strength {get; set;}

        #endregion
        #region Constructor
        public  Ingredient() { }
        public  Ingredient(string value) : base(value) { }
        public  Ingredient(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Ingredient";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
