
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstancePolymerSub.RepeatSub.RepeatUnitSub
{
    public class DegreeOfPolymerisation : BackboneElement<DegreeOfPolymerisation>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("average", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Average {get; set;}
[Element("low", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Low {get; set;}
[Element("high", typeof(FhirInteger), true, false, false, false)]
public FhirInteger High {get; set;}

        #endregion
        #region Constructor
        public  DegreeOfPolymerisation() { }
        public  DegreeOfPolymerisation(string value) : base(value) { }
        public  DegreeOfPolymerisation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "DegreeOfPolymerisation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
