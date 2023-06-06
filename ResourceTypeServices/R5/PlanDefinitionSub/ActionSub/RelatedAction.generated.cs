
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.PlanDefinitionSub.ActionSub
{
    public class RelatedAction : BackboneElement<RelatedAction>
    {

        #region Property
        [Element("targetId", typeof(FhirId), true, false, false, false)]
public FhirId TargetId {get; set;}
[Element("relationship", typeof(FhirCode), true, false, false, false)]
public FhirCode Relationship {get; set;}
[Element("endRelationship", typeof(FhirCode), true, false, false, false)]
public FhirCode EndRelationship {get; set;}
[Element("offset", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Offset {get; set;}

        #endregion
        #region Constructor
        public  RelatedAction() { }
        public  RelatedAction(string value) : base(value) { }
        public  RelatedAction(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "RelatedAction";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
