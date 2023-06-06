

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MedicationStatementSub
{
    public class MedicationStatement : DomainResource<MedicationStatement>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("partOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PartOf {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("medication", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Medication {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("effective", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Effective {get; set;}
[Element("dateAsserted", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime DateAsserted {get; set;}
[Element("informationSource", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> InformationSource {get; set;}
[Element("derivedFrom", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> DerivedFrom {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("relatedClinicalInformation", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> RelatedClinicalInformation {get; set;}
[Element("renderedDosageInstruction", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown RenderedDosageInstruction {get; set;}
[Element("dosage", typeof(Dosage), false, true, false, false)]
public IEnumerable<Dosage> Dosage {get; set;}
[Element("adherence", typeof(Adherence), false, false, false, true)]
public Adherence Adherence {get; set;}

        #endregion
        #region Constructor
        public  MedicationStatement() { }

        public  MedicationStatement(string value) : base(value) { }
        public  MedicationStatement(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "MedicationStatement";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
