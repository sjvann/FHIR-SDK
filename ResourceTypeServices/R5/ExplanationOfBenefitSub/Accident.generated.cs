
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub
{
    public class Accident : BackboneElement<Accident>
    {

        #region Property
        [Element("date", typeof(FhirDate), true, false, false, false)]
public FhirDate Date {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("location", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Location {get; set;}

        #endregion
        #region Constructor
        public  Accident() { }
        public  Accident(string value) : base(value) { }
        public  Accident(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Accident";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
