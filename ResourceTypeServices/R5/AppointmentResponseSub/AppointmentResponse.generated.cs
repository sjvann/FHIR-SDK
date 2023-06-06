

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AppointmentResponseSub
{
    public class AppointmentResponse : DomainResource<AppointmentResponse>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("appointment", typeof(Reference), false, false, false, false)]
public Reference Appointment {get; set;}
[Element("proposedNewTime", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean ProposedNewTime {get; set;}
[Element("start", typeof(FhirInstant), true, false, false, false)]
public FhirInstant Start {get; set;}
[Element("end", typeof(FhirInstant), true, false, false, false)]
public FhirInstant End {get; set;}
[Element("participantType", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ParticipantType {get; set;}
[Element("actor", typeof(Reference), false, false, false, false)]
public Reference Actor {get; set;}
[Element("participantStatus", typeof(FhirCode), true, false, false, false)]
public FhirCode ParticipantStatus {get; set;}
[Element("comment", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Comment {get; set;}
[Element("recurring", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Recurring {get; set;}
[Element("occurrenceDate", typeof(FhirDate), true, false, false, false)]
public FhirDate OccurrenceDate {get; set;}
[Element("recurrenceId", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt RecurrenceId {get; set;}

        #endregion
        #region Constructor
        public  AppointmentResponse() { }

        public  AppointmentResponse(string value) : base(value) { }
        public  AppointmentResponse(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "AppointmentResponse";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
