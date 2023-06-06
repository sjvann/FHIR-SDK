
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImplementationGuideSub.DefinitionSub
{
    public class Grouping : BackboneElement<Grouping>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}

        #endregion
        #region Constructor
        public  Grouping() { }
        public  Grouping(string value) : base(value) { }
        public  Grouping(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Grouping";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
