
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ArtifactAssessmentSub
{
    public class Content : BackboneElement<Content>
    {

        #region Property
        [Element("informationType", typeof(FhirCode), true, false, false, false)]
public FhirCode InformationType {get; set;}
[Element("summary", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Summary {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("classifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Classifier {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("author", typeof(Reference), false, false, false, false)]
public Reference Author {get; set;}
[Element("path", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> Path {get; set;}
[Element("relatedArtifact", typeof(RelatedArtifact), false, true, false, false)]
public IEnumerable<RelatedArtifact> RelatedArtifact {get; set;}
[Element("freeToShare", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean FreeToShare {get; set;}

        #endregion
        #region Constructor
        public  Content() { }
        public  Content(string value) : base(value) { }
        public  Content(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Content";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
