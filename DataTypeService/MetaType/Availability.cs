using Core.Extension;
using DataTypeService.BaseTypes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.MetaType
{
    public class Availability : ComplexType
    {

        #region Property
        public AvailableTime? AvailableTime { get; set; }
        public NotAvailableTime? NotAvailableTime { get; set; }
        #endregion
        #region Constructor
        public Availability() { }
        public Availability(string? value) : this(value.Parse()) { }
        public Availability(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "availableTime":
                            AvailableTime = new AvailableTime(cv);
                            break;
                        case "notAvailableTime":
                            NotAvailableTime = new NotAvailableTime(cv);
                            break;

                    }
                }
            }

        }

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
    public class AvailableTime : ComplexType
    {
        #region Property
        public FhirCode? DayOfWeek { get; init; }
        public FhirBoolean? AllDay { get; init; }
        public FhirTime? AvailableStartTime { get; init; }
        public FhirTime? AvailableEndTime { get; init; }
        #endregion
        #region Constructor
        public AvailableTime() { }
        public AvailableTime(string? value) : this(value.Parse()) { }
        public AvailableTime(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "daysOfWeek":
                            DayOfWeek = new FhirCode(cv);
                            break;
                        case "allDay":
                            AllDay = new FhirBoolean(cv);
                            break;
                        case "availableStartTime":
                            AvailableStartTime = new FhirTime(cv);
                            break;
                        case "availableEndTime":
                            AvailableEndTime = new FhirTime(cv);
                            break;
                    }
                }
            }
        }

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
    public class NotAvailableTime : ComplexType
    {
        #region Property
        public FhirString? Description { get; init; }
        public Period? During { get; init; }

        #endregion
        #region Constructor
        public NotAvailableTime() { }
        public NotAvailableTime(string? value) : this(value.Parse()) { }
        public NotAvailableTime(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "description":
                            Description = new FhirString(cv);
                            break;
                        case "during":
                            During = new Period(cv);
                            break;

                    }
                }
            }
        }

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
