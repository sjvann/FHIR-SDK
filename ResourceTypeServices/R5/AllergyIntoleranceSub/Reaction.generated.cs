
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AllergyIntoleranceSub
{
    public class Reaction : BackboneElement<Reaction>
    {

        #region Property
        [Element("substance", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Substance {get; set;}
[Element("manifestation", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Manifestation {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("onset", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Onset {get; set;}
[Element("severity", typeof(FhirCode), true, false, false, false)]
public FhirCode Severity {get; set;}
[Element("exposureRoute", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ExposureRoute {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  Reaction() { }
        public  Reaction(string value) : base(value) { }
        public  Reaction(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Reaction";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
