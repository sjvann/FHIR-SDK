

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EncounterHistorySub
{
    public class EncounterHistory : DomainResource<EncounterHistory>
    {
        #region Property
        [Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("class", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Class {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("serviceType", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> ServiceType {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("subjectStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept SubjectStatus {get; set;}
[Element("actualPeriod", typeof(Period), false, false, false, false)]
public Period ActualPeriod {get; set;}
[Element("plannedStartDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime PlannedStartDate {get; set;}
[Element("plannedEndDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime PlannedEndDate {get; set;}
[Element("length", typeof(Duration), false, false, false, false)]
public Duration Length {get; set;}
[Element("location", typeof(Location), false, true, false, true)]
public IEnumerable<Location> Location {get; set;}

        #endregion
        #region Constructor
        public  EncounterHistory() { }

        public  EncounterHistory(string value) : base(value) { }
        public  EncounterHistory(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "EncounterHistory";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
