
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubscriptionTopicSub
{
    public class CanFilterBy : BackboneElement<CanFilterBy>
    {

        #region Property
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("resource", typeof(FhirUri), true, false, false, false)]
public FhirUri Resource {get; set;}
[Element("filterParameter", typeof(FhirString), true, false, false, false)]
public FhirString FilterParameter {get; set;}
[Element("filterDefinition", typeof(FhirUri), true, false, false, false)]
public FhirUri FilterDefinition {get; set;}
[Element("comparator", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Comparator {get; set;}
[Element("modifier", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Modifier {get; set;}

        #endregion
        #region Constructor
        public  CanFilterBy() { }
        public  CanFilterBy(string value) : base(value) { }
        public  CanFilterBy(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "CanFilterBy";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
