
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.GroupSub
{
    public class Member : BackboneElement<Member>
    {

        #region Property
        [Element("entity", typeof(Reference), false, false, false, false)]
public Reference Entity {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("inactive", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Inactive {get; set;}

        #endregion
        #region Constructor
        public  Member() { }
        public  Member(string value) : base(value) { }
        public  Member(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Member";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
