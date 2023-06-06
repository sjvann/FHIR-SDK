
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TerminologyCapabilitiesSub
{
    public class Implementation : BackboneElement<Implementation>
    {

        #region Property
        [Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("url", typeof(FhirUrl), true, false, false, false)]
public FhirUrl Url {get; set;}

        #endregion
        #region Constructor
        public  Implementation() { }
        public  Implementation(string value) : base(value) { }
        public  Implementation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Implementation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
