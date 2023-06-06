
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ProvenanceSub
{
    public class Entity : BackboneElement<Entity>
    {

        #region Property
        [Element("role", typeof(FhirCode), true, false, false, false)]
public FhirCode Role {get; set;}
[Element("what", typeof(Reference), false, false, false, false)]
public Reference What {get; set;}

        #endregion
        #region Constructor
        public  Entity() { }
        public  Entity(string value) : base(value) { }
        public  Entity(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Entity";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
