
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubscriptionTopicSub.ResourceTriggerSub
{
    public class QueryCriteria : BackboneElement<QueryCriteria>
    {

        #region Property
        [Element("previous", typeof(FhirString), true, false, false, false)]
public FhirString Previous {get; set;}
[Element("resultForCreate", typeof(FhirCode), true, false, false, false)]
public FhirCode ResultForCreate {get; set;}
[Element("current", typeof(FhirString), true, false, false, false)]
public FhirString Current {get; set;}
[Element("resultForDelete", typeof(FhirCode), true, false, false, false)]
public FhirCode ResultForDelete {get; set;}
[Element("requireBoth", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean RequireBoth {get; set;}

        #endregion
        #region Constructor
        public  QueryCriteria() { }
        public  QueryCriteria(string value) : base(value) { }
        public  QueryCriteria(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "QueryCriteria";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
