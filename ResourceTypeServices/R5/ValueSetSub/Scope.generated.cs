
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ValueSetSub
{
    public class Scope : BackboneElement<Scope>
    {

        #region Property
        [Element("inclusionCriteria", typeof(FhirString), true, false, false, false)]
public FhirString InclusionCriteria {get; set;}
[Element("exclusionCriteria", typeof(FhirString), true, false, false, false)]
public FhirString ExclusionCriteria {get; set;}

        #endregion
        #region Constructor
        public  Scope() { }
        public  Scope(string value) : base(value) { }
        public  Scope(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Scope";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
