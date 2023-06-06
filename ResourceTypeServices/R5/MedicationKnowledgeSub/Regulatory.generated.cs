
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.MedicationKnowledgeSub.RegulatorySub;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub
{
    public class Regulatory : BackboneElement<Regulatory>
    {

        #region Property
        [Element("regulatoryAuthority", typeof(Reference), false, false, false, false)]
public Reference RegulatoryAuthority {get; set;}
[Element("substitution", typeof(Substitution), false, true, false, true)]
public IEnumerable<Substitution> Substitution {get; set;}
[Element("schedule", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Schedule {get; set;}
[Element("maxDispense", typeof(MaxDispense), false, false, false, true)]
public MaxDispense MaxDispense {get; set;}

        #endregion
        #region Constructor
        public  Regulatory() { }
        public  Regulatory(string value) : base(value) { }
        public  Regulatory(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Regulatory";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
