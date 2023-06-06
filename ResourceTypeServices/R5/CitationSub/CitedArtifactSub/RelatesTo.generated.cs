
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub
{
    public class RelatesTo : BackboneElement<RelatesTo>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("classifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Classifier {get; set;}
[Element("label", typeof(FhirString), true, false, false, false)]
public FhirString Label {get; set;}
[Element("display", typeof(FhirString), true, false, false, false)]
public FhirString Display {get; set;}
[Element("citation", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Citation {get; set;}
[Element("document", typeof(Attachment), false, false, false, false)]
public Attachment Document {get; set;}
[Element("resource", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Resource {get; set;}
[Element("resourceReference", typeof(Reference), false, false, false, false)]
public Reference ResourceReference {get; set;}

        #endregion
        #region Constructor
        public  RelatesTo() { }
        public  RelatesTo(string value) : base(value) { }
        public  RelatesTo(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "RelatesTo";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
