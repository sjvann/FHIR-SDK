
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TerminologyCapabilitiesSub
{
    public class Translation : BackboneElement<Translation>
    {

        #region Property
        [Element("needsMap", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean NeedsMap {get; set;}

        #endregion
        #region Constructor
        public  Translation() { }
        public  Translation(string value) : base(value) { }
        public  Translation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Translation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
