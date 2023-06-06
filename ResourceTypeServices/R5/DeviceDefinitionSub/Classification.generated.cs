
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.DeviceDefinitionSub
{
    public class Classification : BackboneElement<Classification>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("justification", typeof(RelatedArtifact), false, true, false, false)]
public IEnumerable<RelatedArtifact> Justification {get; set;}

        #endregion
        #region Constructor
        public  Classification() { }
        public  Classification(string value) : base(value) { }
        public  Classification(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Classification";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
