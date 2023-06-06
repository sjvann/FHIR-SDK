
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.PermissionSub.RuleSub.DataSub
{
    public class Resource : BackboneElement<Resource>
    {

        #region Property
        [Element("meaning", typeof(FhirCode), true, false, false, false)]
public FhirCode Meaning {get; set;}
[Element("reference", typeof(Reference), false, false, false, false)]
public Reference Reference {get; set;}

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
