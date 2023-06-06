
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.PermissionSub.RuleSub;

namespace ResourceTypeServices.R5.PermissionSub
{
    public class Rule : BackboneElement<Rule>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("data", typeof(Data), false, true, false, true)]
public IEnumerable<Data> Data {get; set;}
[Element("activity", typeof(Activity), false, true, false, true)]
public IEnumerable<Activity> Activity {get; set;}
[Element("limit", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Limit {get; set;}

        #endregion
        #region Constructor
        public  Rule() { }
        public  Rule(string value) : base(value) { }
        public  Rule(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Rule";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
