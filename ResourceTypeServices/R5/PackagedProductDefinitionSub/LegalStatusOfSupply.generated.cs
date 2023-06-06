
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.PackagedProductDefinitionSub
{
    public class LegalStatusOfSupply : BackboneElement<LegalStatusOfSupply>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("jurisdiction", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Jurisdiction {get; set;}

        #endregion
        #region Constructor
        public  LegalStatusOfSupply() { }
        public  LegalStatusOfSupply(string value) : base(value) { }
        public  LegalStatusOfSupply(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "LegalStatusOfSupply";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
