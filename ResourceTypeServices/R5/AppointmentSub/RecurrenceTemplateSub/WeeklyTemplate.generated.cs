
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AppointmentSub.RecurrenceTemplateSub
{
    public class WeeklyTemplate : BackboneElement<WeeklyTemplate>
    {

        #region Property
        [Element("monday", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Monday {get; set;}
[Element("tuesday", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Tuesday {get; set;}
[Element("wednesday", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Wednesday {get; set;}
[Element("thursday", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Thursday {get; set;}
[Element("friday", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Friday {get; set;}
[Element("saturday", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Saturday {get; set;}
[Element("sunday", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Sunday {get; set;}
[Element("weekInterval", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt WeekInterval {get; set;}

        #endregion
        #region Constructor
        public  WeeklyTemplate() { }
        public  WeeklyTemplate(string value) : base(value) { }
        public  WeeklyTemplate(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "WeeklyTemplate";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
