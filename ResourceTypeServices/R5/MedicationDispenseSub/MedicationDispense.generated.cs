

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MedicationDispenseSub
{
    public class MedicationDispense : DomainResource<MedicationDispense>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("partOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PartOf {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("notPerformedReason", typeof(CodeableReference), false, false, false, false)]
public CodeableReference NotPerformedReason {get; set;}
[Element("statusChanged", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime StatusChanged {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("medication", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Medication {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("supportingInformation", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingInformation {get; set;}
[Element("performer", typeof(Performer), false, true, false, true)]
public IEnumerable<Performer> Performer {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("authorizingPrescription", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> AuthorizingPrescription {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("daysSupply", typeof(Quantity), false, false, false, false)]
public Quantity DaysSupply {get; set;}
[Element("recorded", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Recorded {get; set;}
[Element("whenPrepared", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime WhenPrepared {get; set;}
[Element("whenHandedOver", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime WhenHandedOver {get; set;}
[Element("destination", typeof(Reference), false, false, false, false)]
public Reference Destination {get; set;}
[Element("receiver", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Receiver {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("renderedDosageInstruction", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown RenderedDosageInstruction {get; set;}
[Element("dosageInstruction", typeof(Dosage), false, true, false, false)]
public IEnumerable<Dosage> DosageInstruction {get; set;}
[Element("substitution", typeof(Substitution), false, false, false, true)]
public Substitution Substitution {get; set;}
[Element("eventHistory", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> EventHistory {get; set;}

        #endregion
        #region Constructor
        public  MedicationDispense() { }

        public  MedicationDispense(string value) : base(value) { }
        public  MedicationDispense(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "MedicationDispense";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
