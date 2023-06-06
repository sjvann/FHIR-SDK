

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AppointmentSub
{
    public class Appointment : DomainResource<Appointment>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("cancellationReason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept CancellationReason {get; set;}
[Element("class", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Class {get; set;}
[Element("serviceCategory", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ServiceCategory {get; set;}
[Element("serviceType", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> ServiceType {get; set;}
[Element("specialty", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Specialty {get; set;}
[Element("appointmentType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AppointmentType {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("priority", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Priority {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("replaces", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Replaces {get; set;}
[Element("virtualService", typeof(VirtualServiceDetail), false, true, false, false)]
public IEnumerable<VirtualServiceDetail> VirtualService {get; set;}
[Element("supportingInformation", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingInformation {get; set;}
[Element("previousAppointment", typeof(Reference), false, false, false, false)]
public Reference PreviousAppointment {get; set;}
[Element("originatingAppointment", typeof(Reference), false, false, false, false)]
public Reference OriginatingAppointment {get; set;}
[Element("start", typeof(FhirInstant), true, false, false, false)]
public FhirInstant Start {get; set;}
[Element("end", typeof(FhirInstant), true, false, false, false)]
public FhirInstant End {get; set;}
[Element("minutesDuration", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt MinutesDuration {get; set;}
[Element("requestedPeriod", typeof(Period), false, true, false, false)]
public IEnumerable<Period> RequestedPeriod {get; set;}
[Element("slot", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Slot {get; set;}
[Element("account", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Account {get; set;}
[Element("created", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Created {get; set;}
[Element("cancellationDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime CancellationDate {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("patientInstruction", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> PatientInstruction {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("participant", typeof(Participant), false, true, false, true)]
public IEnumerable<Participant> Participant {get; set;}
[Element("recurrenceId", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt RecurrenceId {get; set;}
[Element("occurrenceChanged", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean OccurrenceChanged {get; set;}
[Element("recurrenceTemplate", typeof(RecurrenceTemplate), false, true, false, true)]
public IEnumerable<RecurrenceTemplate> RecurrenceTemplate {get; set;}

        #endregion
        #region Constructor
        public  Appointment() { }

        public  Appointment(string value) : base(value) { }
        public  Appointment(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Appointment";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
