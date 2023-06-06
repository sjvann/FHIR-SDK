
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub
{
    public class CareTeam : BackboneElement<CareTeam>
    {

        #region Property
        [Element("sequence", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt Sequence {get; set;}
[Element("provider", typeof(Reference), false, false, false, false)]
public Reference Provider {get; set;}
[Element("responsible", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Responsible {get; set;}
[Element("role", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Role {get; set;}
[Element("specialty", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Specialty {get; set;}

        #endregion
        #region Constructor
        public  CareTeam() { }
        public  CareTeam(string value) : base(value) { }
        public  CareTeam(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "CareTeam";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
