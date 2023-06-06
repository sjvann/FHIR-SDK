
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ConceptMapSub
{
    public class AdditionalAttribute : BackboneElement<AdditionalAttribute>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("uri", typeof(FhirUri), true, false, false, false)]
public FhirUri Uri {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}

        #endregion
        #region Constructor
        public  AdditionalAttribute() { }
        public  AdditionalAttribute(string value) : base(value) { }
        public  AdditionalAttribute(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "AdditionalAttribute";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
