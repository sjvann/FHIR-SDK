
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.StructureMapSub.GroupSub;

namespace ResourceTypeServices.R5.StructureMapSub
{
    public class Group : BackboneElement<Group>
    {

        #region Property
        [Element("name", typeof(FhirId), true, false, false, false)]
public FhirId Name {get; set;}
[Element("extends", typeof(FhirId), true, false, false, false)]
public FhirId Extends {get; set;}
[Element("typeMode", typeof(FhirCode), true, false, false, false)]
public FhirCode TypeMode {get; set;}
[Element("documentation", typeof(FhirString), true, false, false, false)]
public FhirString Documentation {get; set;}
[Element("input", typeof(Input), false, true, false, true)]
public IEnumerable<Input> Input {get; set;}
[Element("rule", typeof(Rule), false, true, false, true)]
public IEnumerable<Rule> Rule {get; set;}

        #endregion
        #region Constructor
        public  Group() { }
        public  Group(string value) : base(value) { }
        public  Group(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Group";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
