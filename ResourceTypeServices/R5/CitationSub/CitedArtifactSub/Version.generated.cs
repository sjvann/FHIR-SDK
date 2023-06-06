
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub
{
    public class Version : BackboneElement<Version>
    {

        #region Property
        [Element("value", typeof(FhirString), true, false, false, false)]
public FhirString Value {get; set;}
[Element("baseCitation", typeof(Reference), false, false, false, false)]
public Reference BaseCitation {get; set;}

        #endregion
        #region Constructor
        public  Version() { }
        public  Version(string value) : base(value) { }
        public  Version(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Version";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
