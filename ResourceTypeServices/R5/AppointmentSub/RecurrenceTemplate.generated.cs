
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.AppointmentSub.RecurrenceTemplateSub;

namespace ResourceTypeServices.R5.AppointmentSub
{
    public class RecurrenceTemplate : BackboneElement<RecurrenceTemplate>
    {

        #region Property
        [Element("timezone", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Timezone {get; set;}
[Element("recurrenceType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept RecurrenceType {get; set;}
[Element("lastOccurrenceDate", typeof(FhirDate), true, false, false, false)]
public FhirDate LastOccurrenceDate {get; set;}
[Element("occurrenceCount", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt OccurrenceCount {get; set;}
[Element("occurrenceDate", typeof(FhirDate), true, true, false, false)]
public IEnumerable<FhirDate> OccurrenceDate {get; set;}
[Element("weeklyTemplate", typeof(WeeklyTemplate), false, false, false, true)]
public WeeklyTemplate WeeklyTemplate {get; set;}
[Element("monthlyTemplate", typeof(MonthlyTemplate), false, false, false, true)]
public MonthlyTemplate MonthlyTemplate {get; set;}
[Element("yearlyTemplate", typeof(YearlyTemplate), false, false, false, true)]
public YearlyTemplate YearlyTemplate {get; set;}
[Element("excludingDate", typeof(FhirDate), true, true, false, false)]
public IEnumerable<FhirDate> ExcludingDate {get; set;}
[Element("excludingRecurrenceId", typeof(FhirPositiveInt), true, true, false, false)]
public IEnumerable<FhirPositiveInt> ExcludingRecurrenceId {get; set;}

        #endregion
        #region Constructor
        public  RecurrenceTemplate() { }
        public  RecurrenceTemplate(string value) : base(value) { }
        public  RecurrenceTemplate(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "RecurrenceTemplate";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
