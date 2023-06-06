

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EncounterSub
{
    public class Encounter : DomainResource<Encounter>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("class", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Class {get; set;}
[Element("priority", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Priority {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("serviceType", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> ServiceType {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("subjectStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept SubjectStatus {get; set;}
[Element("episodeOfCare", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> EpisodeOfCare {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("careTeam", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> CareTeam {get; set;}
[Element("partOf", typeof(Reference), false, false, false, false)]
public Reference PartOf {get; set;}
[Element("serviceProvider", typeof(Reference), false, false, false, false)]
public Reference ServiceProvider {get; set;}
[Element("participant", typeof(Participant), false, true, false, true)]
public IEnumerable<Participant> Participant {get; set;}
[Element("appointment", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Appointment {get; set;}
[Element("virtualService", typeof(VirtualServiceDetail), false, true, false, false)]
public IEnumerable<VirtualServiceDetail> VirtualService {get; set;}
[Element("actualPeriod", typeof(Period), false, false, false, false)]
public Period ActualPeriod {get; set;}
[Element("plannedStartDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime PlannedStartDate {get; set;}
[Element("plannedEndDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime PlannedEndDate {get; set;}
[Element("length", typeof(Duration), false, false, false, false)]
public Duration Length {get; set;}
[Element("reason", typeof(Reason), false, true, false, true)]
public IEnumerable<Reason> Reason {get; set;}
[Element("diagnosis", typeof(Diagnosis), false, true, false, true)]
public IEnumerable<Diagnosis> Diagnosis {get; set;}
[Element("account", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Account {get; set;}
[Element("dietPreference", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> DietPreference {get; set;}
[Element("specialArrangement", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> SpecialArrangement {get; set;}
[Element("specialCourtesy", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> SpecialCourtesy {get; set;}
[Element("admission", typeof(Admission), false, false, false, true)]
public Admission Admission {get; set;}
[Element("location", typeof(Location), false, true, false, true)]
public IEnumerable<Location> Location {get; set;}

        #endregion
        #region Constructor
        public  Encounter() { }

        public  Encounter(string value) : base(value) { }
        public  Encounter(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Encounter";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
