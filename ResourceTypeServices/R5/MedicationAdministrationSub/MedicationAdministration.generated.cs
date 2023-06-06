

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MedicationAdministrationSub
{
    public class MedicationAdministration : DomainResource<MedicationAdministration>
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
[Element("statusReason", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> StatusReason {get; set;}
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
[Element("occurence", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Occurence {get; set;}
[Element("recorded", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Recorded {get; set;}
[Element("isSubPotent", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean IsSubPotent {get; set;}
[Element("subPotentReason", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> SubPotentReason {get; set;}
[Element("performer", typeof(Performer), false, true, false, true)]
public IEnumerable<Performer> Performer {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("request", typeof(Reference), false, false, false, false)]
public Reference Request {get; set;}
[Element("device", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Device {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("dosage", typeof(Dosage), false, false, false, true)]
public Dosage Dosage {get; set;}
[Element("eventHistory", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> EventHistory {get; set;}

        #endregion
        #region Constructor
        public  MedicationAdministration() { }

        public  MedicationAdministration(string value) : base(value) { }
        public  MedicationAdministration(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "MedicationAdministration";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
