
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CompartmentDefinitionSub
{
    public class Resource : BackboneElement<Resource>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("param", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Param {get; set;}
[Element("documentation", typeof(FhirString), true, false, false, false)]
public FhirString Documentation {get; set;}
[Element("startParam", typeof(FhirUri), true, false, false, false)]
public FhirUri StartParam {get; set;}
[Element("endParam", typeof(FhirUri), true, false, false, false)]
public FhirUri EndParam {get; set;}

        #endregion
        #region Constructor
        public  Resource() { }
        public  Resource(string value) : base(value) { }
        public  Resource(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Resource";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
