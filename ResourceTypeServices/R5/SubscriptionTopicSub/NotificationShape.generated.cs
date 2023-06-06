
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubscriptionTopicSub
{
    public class NotificationShape : BackboneElement<NotificationShape>
    {

        #region Property
        [Element("resource", typeof(FhirUri), true, false, false, false)]
public FhirUri Resource {get; set;}
[Element("include", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Include {get; set;}
[Element("revInclude", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> RevInclude {get; set;}

        #endregion
        #region Constructor
        public  NotificationShape() { }
        public  NotificationShape(string value) : base(value) { }
        public  NotificationShape(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "NotificationShape";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
