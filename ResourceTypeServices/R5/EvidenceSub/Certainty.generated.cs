
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EvidenceSub
{
    public class Certainty : BackboneElement<Certainty>
    {

        #region Property
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("rating", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Rating {get; set;}
[Element("rater", typeof(FhirString), true, false, false, false)]
public FhirString Rater {get; set;}

        #endregion
        #region Constructor
        public  Certainty() { }
        public  Certainty(string value) : base(value) { }
        public  Certainty(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Certainty";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
