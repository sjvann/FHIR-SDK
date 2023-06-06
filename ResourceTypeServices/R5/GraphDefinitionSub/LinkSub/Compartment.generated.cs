
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.GraphDefinitionSub.LinkSub
{
    public class Compartment : BackboneElement<Compartment>
    {

        #region Property
        [Element("use", typeof(FhirCode), true, false, false, false)]
public FhirCode Use {get; set;}
[Element("rule", typeof(FhirCode), true, false, false, false)]
public FhirCode Rule {get; set;}
[Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("expression", typeof(FhirString), true, false, false, false)]
public FhirString Expression {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}

        #endregion
        #region Constructor
        public  Compartment() { }
        public  Compartment(string value) : base(value) { }
        public  Compartment(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Compartment";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
