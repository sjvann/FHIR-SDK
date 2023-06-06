
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ClinicalUseDefinitionSub.ContraindicationSub
{
    public class OtherTherapy : BackboneElement<OtherTherapy>
    {

        #region Property
        [Element("relationshipType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept RelationshipType {get; set;}
[Element("treatment", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Treatment {get; set;}

        #endregion
        #region Constructor
        public  OtherTherapy() { }
        public  OtherTherapy(string value) : base(value) { }
        public  OtherTherapy(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "OtherTherapy";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
