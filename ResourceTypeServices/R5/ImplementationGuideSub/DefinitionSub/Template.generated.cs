
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImplementationGuideSub.DefinitionSub
{
    public class Template : BackboneElement<Template>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("source", typeof(FhirString), true, false, false, false)]
public FhirString Source {get; set;}
[Element("scope", typeof(FhirString), true, false, false, false)]
public FhirString Scope {get; set;}

        #endregion
        #region Constructor
        public  Template() { }
        public  Template(string value) : base(value) { }
        public  Template(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Template";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
