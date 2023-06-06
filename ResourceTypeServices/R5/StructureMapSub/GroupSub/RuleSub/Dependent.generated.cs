
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.StructureMapSub.GroupSub.RuleSub
{
    public class Dependent : BackboneElement<Dependent>
    {

        #region Property
        [Element("name", typeof(FhirId), true, false, false, false)]
public FhirId Name {get; set;}

        #endregion
        #region Constructor
        public  Dependent() { }
        public  Dependent(string value) : base(value) { }
        public  Dependent(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Dependent";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
