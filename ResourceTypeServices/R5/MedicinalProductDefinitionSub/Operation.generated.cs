
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicinalProductDefinitionSub
{
    public class Operation : BackboneElement<Operation>
    {

        #region Property
        [Element("type", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Type {get; set;}
[Element("effectiveDate", typeof(Period), false, false, false, false)]
public Period EffectiveDate {get; set;}
[Element("organization", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Organization {get; set;}
[Element("confidentialityIndicator", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ConfidentialityIndicator {get; set;}

        #endregion
        #region Constructor
        public  Operation() { }
        public  Operation(string value) : base(value) { }
        public  Operation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Operation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
