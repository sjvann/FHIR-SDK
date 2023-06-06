
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AppointmentSub.RecurrenceTemplateSub
{
    public class MonthlyTemplate : BackboneElement<MonthlyTemplate>
    {

        #region Property
        [Element("dayOfMonth", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt DayOfMonth {get; set;}
[Element("nthWeekOfMonth", typeof(Coding), false, false, false, false)]
public Coding NthWeekOfMonth {get; set;}
[Element("dayOfWeek", typeof(Coding), false, false, false, false)]
public Coding DayOfWeek {get; set;}
[Element("monthInterval", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt MonthInterval {get; set;}

        #endregion
        #region Constructor
        public  MonthlyTemplate() { }
        public  MonthlyTemplate(string value) : base(value) { }
        public  MonthlyTemplate(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "MonthlyTemplate";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
