
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.PaymentReconciliationSub
{
    public class Allocation : BackboneElement<Allocation>
    {

        #region Property
        [Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("predecessor", typeof(Identifier), false, false, false, false)]
public Identifier Predecessor {get; set;}
[Element("target", typeof(Reference), false, false, false, false)]
public Reference Target {get; set;}
[Element("targetItem", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased TargetItem {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("account", typeof(Reference), false, false, false, false)]
public Reference Account {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("submitter", typeof(Reference), false, false, false, false)]
public Reference Submitter {get; set;}
[Element("response", typeof(Reference), false, false, false, false)]
public Reference Response {get; set;}
[Element("date", typeof(FhirDate), true, false, false, false)]
public FhirDate Date {get; set;}
[Element("responsible", typeof(Reference), false, false, false, false)]
public Reference Responsible {get; set;}
[Element("payee", typeof(Reference), false, false, false, false)]
public Reference Payee {get; set;}
[Element("amount", typeof(Money), false, false, false, false)]
public Money Amount {get; set;}

        #endregion
        #region Constructor
        public  Allocation() { }
        public  Allocation(string value) : base(value) { }
        public  Allocation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Allocation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
