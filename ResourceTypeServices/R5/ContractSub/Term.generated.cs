
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ContractSub.TermSub;

namespace ResourceTypeServices.R5.ContractSub
{
    public class Term : BackboneElement<Term>
    {

        #region Property
        [Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("issued", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Issued {get; set;}
[Element("applies", typeof(Period), false, false, false, false)]
public Period Applies {get; set;}
[Element("topic", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Topic {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("subType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept SubType {get; set;}
[Element("securityLabel", typeof(SecurityLabel), false, true, false, true)]
public IEnumerable<SecurityLabel> SecurityLabel {get; set;}
[Element("offer", typeof(Offer), false, false, false, true)]
public Offer Offer {get; set;}
[Element("asset", typeof(Asset), false, true, false, true)]
public IEnumerable<Asset> Asset {get; set;}
[Element("action", typeof(ResourceTypeServices.R5.ContractSub.TermSub.Action), false, true, false, true)]
public IEnumerable<ResourceTypeServices.R5.ContractSub.TermSub.Action> Action {get; set;}

        #endregion
        #region Constructor
        public  Term() { }
        public  Term(string value) : base(value) { }
        public  Term(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Term";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
