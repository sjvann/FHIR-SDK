

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SpecimenSub
{
    public class Specimen : DomainResource<Specimen>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("accessionIdentifier", typeof(Identifier), false, false, false, false)]
public Identifier AccessionIdentifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("receivedTime", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime ReceivedTime {get; set;}
[Element("parent", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Parent {get; set;}
[Element("request", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Request {get; set;}
[Element("combined", typeof(FhirCode), true, false, false, false)]
public FhirCode Combined {get; set;}
[Element("role", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Role {get; set;}
[Element("feature", typeof(Feature), false, true, false, true)]
public IEnumerable<Feature> Feature {get; set;}
[Element("collection", typeof(Collection), false, false, false, true)]
public Collection Collection {get; set;}
[Element("processing", typeof(Processing), false, true, false, true)]
public IEnumerable<Processing> Processing {get; set;}
[Element("container", typeof(Container), false, true, false, true)]
public IEnumerable<Container> Container {get; set;}
[Element("condition", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Condition {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  Specimen() { }

        public  Specimen(string value) : base(value) { }
        public  Specimen(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Specimen";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
