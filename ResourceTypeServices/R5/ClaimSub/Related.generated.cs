
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ClaimSub
{
    public class Related : BackboneElement<Related>
    {

        #region Property
        [Element("claim", typeof(Reference), false, false, false, false)]
public Reference Claim {get; set;}
[Element("relationship", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Relationship {get; set;}
[Element("reference", typeof(Identifier), false, false, false, false)]
public Identifier Reference {get; set;}

        #endregion
        #region Constructor
        public  Related() { }
        public  Related(string value) : base(value) { }
        public  Related(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Related";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
