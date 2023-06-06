
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using ResourceTypeServices.R5.ImplementationGuideSub.DefinitionSub;

namespace ResourceTypeServices.R5.ImplementationGuideSub
{
    public class Definition : BackboneElement<Definition>
    {

        #region Property
        [Element("grouping", typeof(Grouping), false, true, false, true)]
public IEnumerable<Grouping> Grouping {get; set;}
[Element("resource", typeof(Resource), false, true, false, true)]
public IEnumerable<Resource> Resource {get; set;}
[Element("page", typeof(Page), false, false, false, true)]
public Page Page {get; set;}
[Element("parameter", typeof(Parameter), false, true, false, true)]
public IEnumerable<Parameter> Parameter {get; set;}
[Element("template", typeof(Template), false, true, false, true)]
public IEnumerable<Template> Template {get; set;}

        #endregion
        #region Constructor
        public  Definition() { }
        public  Definition(string value) : base(value) { }
        public  Definition(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Definition";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
