
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub.AddItemSub
{
    public class BodySite : BackboneElement<BodySite>
    {

        #region Property
        [Element("site", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Site {get; set;}
[Element("subSite", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> SubSite {get; set;}

        #endregion
        #region Constructor
        public  BodySite() { }
        public  BodySite(string value) : base(value) { }
        public  BodySite(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "BodySite";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
