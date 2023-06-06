
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubscriptionSub
{
    public class FilterBy : BackboneElement<FilterBy>
    {

        #region Property
        [Element("resourceType", typeof(FhirUri), true, false, false, false)]
public FhirUri ResourceType {get; set;}
[Element("filterParameter", typeof(FhirString), true, false, false, false)]
public FhirString FilterParameter {get; set;}
[Element("comparator", typeof(FhirCode), true, false, false, false)]
public FhirCode Comparator {get; set;}
[Element("modifier", typeof(FhirCode), true, false, false, false)]
public FhirCode Modifier {get; set;}
[Element("value", typeof(FhirString), true, false, false, false)]
public FhirString Value {get; set;}

        #endregion
        #region Constructor
        public  FilterBy() { }
        public  FilterBy(string value) : base(value) { }
        public  FilterBy(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "FilterBy";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
