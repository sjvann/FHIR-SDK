

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubscriptionSub
{
    public class Subscription : DomainResource<Subscription>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("topic", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Topic {get; set;}
[Element("contact", typeof(ContactPoint), false, true, false, false)]
public IEnumerable<ContactPoint> Contact {get; set;}
[Element("end", typeof(FhirInstant), true, false, false, false)]
public FhirInstant End {get; set;}
[Element("managingEntity", typeof(Reference), false, false, false, false)]
public Reference ManagingEntity {get; set;}
[Element("reason", typeof(FhirString), true, false, false, false)]
public FhirString Reason {get; set;}
[Element("filterBy", typeof(FilterBy), false, true, false, true)]
public IEnumerable<FilterBy> FilterBy {get; set;}
[Element("channelType", typeof(Coding), false, false, false, false)]
public Coding ChannelType {get; set;}
[Element("endpoint", typeof(FhirUrl), true, false, false, false)]
public FhirUrl Endpoint {get; set;}
[Element("parameter", typeof(Parameter), false, true, false, true)]
public IEnumerable<Parameter> Parameter {get; set;}
[Element("heartbeatPeriod", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt HeartbeatPeriod {get; set;}
[Element("timeout", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt Timeout {get; set;}
[Element("contentType", typeof(FhirCode), true, false, false, false)]
public FhirCode ContentType {get; set;}
[Element("content", typeof(FhirCode), true, false, false, false)]
public FhirCode Content {get; set;}
[Element("maxCount", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt MaxCount {get; set;}

        #endregion
        #region Constructor
        public  Subscription() { }

        public  Subscription(string value) : base(value) { }
        public  Subscription(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Subscription";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
