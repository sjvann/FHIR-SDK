using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class Availability : ComplexType<Availability>
    {

        #region Property
        [Element("availableTime", typeof(AvailableTime), false, false, false, false)]
        public AvailableTime? AvailableTime { get; set; }
        [Element("notAvailableTime", typeof(NotAvailableTime), false, false, false, false)]
        public NotAvailableTime? NotAvailableTime { get; set; }
        #endregion
        #region Constructor
        public Availability() { }
        public Availability(string? value) : base(value) { }
        public Availability(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "Availability";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
    public class AvailableTime : ComplexType<AvailableTime>
    {
        #region Property
        [Element("daysOfWeek", typeof(FhirCode), true, false, false, false)]
        public FhirCode? DayOfWeek { get; set; }
        [Element("allDay", typeof(FhirBoolean), true, false, false, false)]
        public FhirBoolean? AllDay { get; set; }
        [Element("availableStartTime", typeof(FhirTime), true, false, false, false)]
        public FhirTime? AvailableStartTime { get; set; }
        [Element("availableEndTime", typeof(FhirTime), true, false, false, false)]
        public FhirTime? AvailableEndTime { get; set; }
        #endregion
        #region Constructor
        public AvailableTime() { }
        public AvailableTime(string? value) : base(value) { }
        public AvailableTime(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "AvailableTime";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
    public class NotAvailableTime : ComplexType<NotAvailableTime>
    {
        #region Property
        [Element("description", typeof(FhirString), true, false, false, false)]
        public FhirString? Description { get; set; }
        [Element("during", typeof(Period), false, false, false, false)]
        public Period? During { get; set; }

        #endregion
        #region Constructor
        public NotAvailableTime() { }
        public NotAvailableTime(string? value) : base(value) { }
        public NotAvailableTime(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "NotAvailableTime";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }

}
