
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.SubscriptionTopicSub.ResourceTriggerSub;

namespace ResourceTypeServices.R5.SubscriptionTopicSub
{
    public class ResourceTrigger : BackboneElement<ResourceTrigger>
    {

        #region Property
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("resource", typeof(FhirUri), true, false, false, false)]
public FhirUri Resource {get; set;}
[Element("supportedInteraction", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> SupportedInteraction {get; set;}
[Element("queryCriteria", typeof(QueryCriteria), false, false, false, true)]
public QueryCriteria QueryCriteria {get; set;}
[Element("fhirPathCriteria", typeof(FhirString), true, false, false, false)]
public FhirString FhirPathCriteria {get; set;}

        #endregion
        #region Constructor
        public  ResourceTrigger() { }
        public  ResourceTrigger(string value) : base(value) { }
        public  ResourceTrigger(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ResourceTrigger";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
