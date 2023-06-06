
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.StructureMapSub.GroupSub.RuleSub.TargetSub;

namespace ResourceTypeServices.R5.StructureMapSub.GroupSub.RuleSub
{
    public class Target : BackboneElement<Target>
    {

        #region Property
        [Element("context", typeof(FhirString), true, false, false, false)]
public FhirString Context {get; set;}
[Element("element", typeof(FhirString), true, false, false, false)]
public FhirString Element {get; set;}
[Element("variable", typeof(FhirId), true, false, false, false)]
public FhirId Variable {get; set;}
[Element("listMode", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> ListMode {get; set;}
[Element("listRuleId", typeof(FhirId), true, false, false, false)]
public FhirId ListRuleId {get; set;}
[Element("transform", typeof(FhirCode), true, false, false, false)]
public FhirCode Transform {get; set;}
[Element("parameter", typeof(Parameter), false, true, false, true)]
public IEnumerable<Parameter> Parameter {get; set;}

        #endregion
        #region Constructor
        public  Target() { }
        public  Target(string value) : base(value) { }
        public  Target(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Target";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
