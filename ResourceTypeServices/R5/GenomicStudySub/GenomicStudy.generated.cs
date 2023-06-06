

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.GenomicStudySub
{
    public class GenomicStudy : DomainResource<GenomicStudy>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("startDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime StartDate {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("referrer", typeof(Reference), false, false, false, false)]
public Reference Referrer {get; set;}
[Element("interpreter", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Interpreter {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("instantiatesCanonical", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical InstantiatesCanonical {get; set;}
[Element("instantiatesUri", typeof(FhirUri), true, false, false, false)]
public FhirUri InstantiatesUri {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("analysis", typeof(Analysis), false, true, false, true)]
public IEnumerable<Analysis> Analysis {get; set;}

        #endregion
        #region Constructor
        public  GenomicStudy() { }

        public  GenomicStudy(string value) : base(value) { }
        public  GenomicStudy(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "GenomicStudy";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
