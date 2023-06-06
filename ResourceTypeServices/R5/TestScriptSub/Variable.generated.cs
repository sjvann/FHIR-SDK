
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TestScriptSub
{
    public class Variable : BackboneElement<Variable>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("defaultValue", typeof(FhirString), true, false, false, false)]
public FhirString DefaultValue {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("expression", typeof(FhirString), true, false, false, false)]
public FhirString Expression {get; set;}
[Element("headerField", typeof(FhirString), true, false, false, false)]
public FhirString HeaderField {get; set;}
[Element("hint", typeof(FhirString), true, false, false, false)]
public FhirString Hint {get; set;}
[Element("path", typeof(FhirString), true, false, false, false)]
public FhirString Path {get; set;}
[Element("sourceId", typeof(FhirId), true, false, false, false)]
public FhirId SourceId {get; set;}

        #endregion
        #region Constructor
        public  Variable() { }
        public  Variable(string value) : base(value) { }
        public  Variable(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Variable";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
