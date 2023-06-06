
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.PlanDefinitionSub.ActorSub;

namespace ResourceTypeServices.R5.PlanDefinitionSub
{
    public class Actor : BackboneElement<Actor>
    {

        #region Property
        [Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("option", typeof(Option), false, true, false, true)]
public IEnumerable<Option> Option {get; set;}

        #endregion
        #region Constructor
        public  Actor() { }
        public  Actor(string value) : base(value) { }
        public  Actor(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Actor";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
