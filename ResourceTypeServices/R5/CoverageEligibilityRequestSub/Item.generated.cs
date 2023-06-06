
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.CoverageEligibilityRequestSub.ItemSub;

namespace ResourceTypeServices.R5.CoverageEligibilityRequestSub
{
    public class Item : BackboneElement<Item>
    {

        #region Property
        [Element("supportingInfoSequence", typeof(FhirPositiveInt), true, true, false, false)]
public IEnumerable<FhirPositiveInt> SupportingInfoSequence {get; set;}
[Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("productOrService", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ProductOrService {get; set;}
[Element("modifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Modifier {get; set;}
[Element("provider", typeof(Reference), false, false, false, false)]
public Reference Provider {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("unitPrice", typeof(Money), false, false, false, false)]
public Money UnitPrice {get; set;}
[Element("facility", typeof(Reference), false, false, false, false)]
public Reference Facility {get; set;}
[Element("diagnosis", typeof(Diagnosis), false, true, false, true)]
public IEnumerable<Diagnosis> Diagnosis {get; set;}
[Element("detail", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Detail {get; set;}

        #endregion
        #region Constructor
        public  Item() { }
        public  Item(string value) : base(value) { }
        public  Item(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Item";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
