
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImplementationGuideSub
{
    public class Global : BackboneElement<Global>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("profile", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Profile {get; set;}

        #endregion
        #region Constructor
        public  Global() { }
        public  Global(string value) : base(value) { }
        public  Global(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Global";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
