
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.StructureMapSub.GroupSub.RuleSub;

namespace ResourceTypeServices.R5.StructureMapSub.GroupSub
{
    public class Rule : BackboneElement<Rule>
    {

        #region Property
        [Element("name", typeof(FhirId), true, false, false, false)]
public FhirId Name {get; set;}
[Element("source", typeof(Source), false, true, false, true)]
public IEnumerable<Source> Source {get; set;}
[Element("target", typeof(Target), false, true, false, true)]
public IEnumerable<Target> Target {get; set;}
[Element("dependent", typeof(Dependent), false, true, false, true)]
public IEnumerable<Dependent> Dependent {get; set;}
[Element("documentation", typeof(FhirString), true, false, false, false)]
public FhirString Documentation {get; set;}

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
