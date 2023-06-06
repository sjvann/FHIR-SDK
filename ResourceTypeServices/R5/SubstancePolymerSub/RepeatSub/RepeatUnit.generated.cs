
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.SubstancePolymerSub.RepeatSub.RepeatUnitSub;

namespace ResourceTypeServices.R5.SubstancePolymerSub.RepeatSub
{
    public class RepeatUnit : BackboneElement<RepeatUnit>
    {

        #region Property
        [Element("unit", typeof(FhirString), true, false, false, false)]
public FhirString Unit {get; set;}
[Element("orientation", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Orientation {get; set;}
[Element("amount", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Amount {get; set;}
[Element("degreeOfPolymerisation", typeof(DegreeOfPolymerisation), false, true, false, true)]
public IEnumerable<DegreeOfPolymerisation> DegreeOfPolymerisation {get; set;}
[Element("structuralRepresentation", typeof(StructuralRepresentation), false, true, false, true)]
public IEnumerable<StructuralRepresentation> StructuralRepresentation {get; set;}

        #endregion
        #region Constructor
        public  RepeatUnit() { }
        public  RepeatUnit(string value) : base(value) { }
        public  RepeatUnit(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "RepeatUnit";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
