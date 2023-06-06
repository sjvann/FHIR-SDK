
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TerminologyCapabilitiesSub
{
    public class ValidateCode : BackboneElement<ValidateCode>
    {

        #region Property
        [Element("translations", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Translations {get; set;}

        #endregion
        #region Constructor
        public  ValidateCode() { }
        public  ValidateCode(string value) : base(value) { }
        public  ValidateCode(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ValidateCode";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
