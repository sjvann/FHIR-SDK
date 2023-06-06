
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.CitationSub.CitedArtifactSub;

namespace ResourceTypeServices.R5.CitationSub
{
    public class CitedArtifact : BackboneElement<CitedArtifact>
    {

        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("relatedIdentifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> RelatedIdentifier {get; set;}
[Element("dateAccessed", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime DateAccessed {get; set;}
[Element("version", typeof(ResourceTypeServices.R5.CitationSub.CitedArtifactSub.Version), false, false, false, true)]
public ResourceTypeServices.R5.CitationSub.CitedArtifactSub.Version Version {get; set;}
[Element("currentState", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> CurrentState {get; set;}
[Element("statusDate", typeof(StatusDate), false, true, false, true)]
public IEnumerable<StatusDate> StatusDate {get; set;}
[Element("title", typeof(Title), false, true, false, true)]
public IEnumerable<Title> Title {get; set;}
[Element("abstract", typeof(Abstract), false, true, false, true)]
public IEnumerable<Abstract> Abstract {get; set;}
[Element("part", typeof(Part), false, false, false, true)]
public Part Part {get; set;}
[Element("relatesTo", typeof(RelatesTo), false, true, false, true)]
public IEnumerable<RelatesTo> RelatesTo {get; set;}
[Element("publicationForm", typeof(PublicationForm), false, true, false, true)]
public IEnumerable<PublicationForm> PublicationForm {get; set;}
[Element("webLocation", typeof(WebLocation), false, true, false, true)]
public IEnumerable<WebLocation> WebLocation {get; set;}
[Element("classification", typeof(Classification), false, true, false, true)]
public IEnumerable<Classification> Classification {get; set;}
[Element("contributorship", typeof(Contributorship), false, false, false, true)]
public Contributorship Contributorship {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  CitedArtifact() { }
        public  CitedArtifact(string value) : base(value) { }
        public  CitedArtifact(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "CitedArtifact";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
