

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CompositionSub
{
    public class Composition : DomainResource<Composition>
    {
        #region Property
        [Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}
[Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("subject", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("useContext", typeof(UsageContext), false, true, false, false)]
public IEnumerable<UsageContext> UseContext {get; set;}
[Element("author", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Author {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("attester", typeof(Attester), false, true, false, true)]
public IEnumerable<Attester> Attester {get; set;}
[Element("custodian", typeof(Reference), false, false, false, false)]
public Reference Custodian {get; set;}
[Element("relatesTo", typeof(RelatedArtifact), false, true, false, false)]
public IEnumerable<RelatedArtifact> RelatesTo {get; set;}
[Element("event", typeof(Event), false, true, false, true)]
public IEnumerable<Event> Event {get; set;}
[Element("section", typeof(Section), false, true, false, true)]
public IEnumerable<Section> Section {get; set;}

        #endregion
        #region Constructor
        public  Composition() { }

        public  Composition(string value) : base(value) { }
        public  Composition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Composition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
