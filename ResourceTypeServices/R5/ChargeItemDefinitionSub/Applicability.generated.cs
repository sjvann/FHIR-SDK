
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ChargeItemDefinitionSub
{
    public class Applicability : BackboneElement<Applicability>
    {

        #region Property
        [Element("condition", typeof(Expression), false, false, false, false)]
public Expression Condition {get; set;}
[Element("effectivePeriod", typeof(Period), false, false, false, false)]
public Period EffectivePeriod {get; set;}
[Element("relatedArtifact", typeof(RelatedArtifact), false, false, false, false)]
public RelatedArtifact RelatedArtifact {get; set;}

        #endregion
        #region Constructor
        public  Applicability() { }
        public  Applicability(string value) : base(value) { }
        public  Applicability(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Applicability";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
