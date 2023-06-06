
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TerminologyCapabilitiesSub.ExpansionSub
{
    public class Parameter : BackboneElement<Parameter>
    {

        #region Property
        [Element("name", typeof(FhirCode), true, false, false, false)]
public FhirCode Name {get; set;}
[Element("documentation", typeof(FhirString), true, false, false, false)]
public FhirString Documentation {get; set;}

        #endregion
        #region Constructor
        public  Parameter() { }
        public  Parameter(string value) : base(value) { }
        public  Parameter(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Parameter";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
