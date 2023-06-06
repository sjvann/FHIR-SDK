
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ContractSub.TermSub.OfferSub;

namespace ResourceTypeServices.R5.ContractSub.TermSub
{
    public class Offer : BackboneElement<Offer>
    {

        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("party", typeof(Party), false, true, false, true)]
public IEnumerable<Party> Party {get; set;}
[Element("topic", typeof(Reference), false, false, false, false)]
public Reference Topic {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("decision", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Decision {get; set;}
[Element("decisionMode", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> DecisionMode {get; set;}
[Element("answer", typeof(Answer), false, true, false, true)]
public IEnumerable<Answer> Answer {get; set;}
[Element("linkId", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> LinkId {get; set;}
[Element("securityLabelNumber", typeof(FhirUnsignedInt), true, true, false, false)]
public IEnumerable<FhirUnsignedInt> SecurityLabelNumber {get; set;}

        #endregion
        #region Constructor
        public  Offer() { }
        public  Offer(string value) : base(value) { }
        public  Offer(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Offer";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
