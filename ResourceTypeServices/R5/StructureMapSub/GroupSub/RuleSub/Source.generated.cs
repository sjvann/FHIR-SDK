
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.StructureMapSub.GroupSub.RuleSub
{
    public class Source : BackboneElement<Source>
    {

        #region Property
        [Element("context", typeof(FhirId), true, false, false, false)]
public FhirId Context {get; set;}
[Element("min", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Min {get; set;}
[Element("max", typeof(FhirString), true, false, false, false)]
public FhirString Max {get; set;}
[Element("type", typeof(FhirString), true, false, false, false)]
public FhirString Type {get; set;}
[Element("defaultValue", typeof(FhirString), true, false, false, false)]
public FhirString DefaultValue {get; set;}
[Element("element", typeof(FhirString), true, false, false, false)]
public FhirString Element {get; set;}
[Element("listMode", typeof(FhirCode), true, false, false, false)]
public FhirCode ListMode {get; set;}
[Element("variable", typeof(FhirId), true, false, false, false)]
public FhirId Variable {get; set;}
[Element("condition", typeof(FhirString), true, false, false, false)]
public FhirString Condition {get; set;}
[Element("check", typeof(FhirString), true, false, false, false)]
public FhirString Check {get; set;}
[Element("logMessage", typeof(FhirString), true, false, false, false)]
public FhirString LogMessage {get; set;}

        #endregion
        #region Constructor
        public  Source() { }
        public  Source(string value) : base(value) { }
        public  Source(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Source";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
