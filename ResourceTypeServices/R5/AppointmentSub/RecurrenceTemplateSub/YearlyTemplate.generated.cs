
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AppointmentSub.RecurrenceTemplateSub
{
    public class YearlyTemplate : BackboneElement<YearlyTemplate>
    {

        #region Property
        [Element("yearInterval", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt YearInterval {get; set;}

        #endregion
        #region Constructor
        public  YearlyTemplate() { }
        public  YearlyTemplate(string value) : base(value) { }
        public  YearlyTemplate(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "YearlyTemplate";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
