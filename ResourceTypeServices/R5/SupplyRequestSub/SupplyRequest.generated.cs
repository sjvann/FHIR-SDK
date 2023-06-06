

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SupplyRequestSub
{
    public class SupplyRequest : DomainResource<SupplyRequest>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("priority", typeof(FhirCode), true, false, false, false)]
public FhirCode Priority {get; set;}
[Element("deliverFor", typeof(Reference), false, false, false, false)]
public Reference DeliverFor {get; set;}
[Element("item", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Item {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("parameter", typeof(Parameter), false, true, false, true)]
public IEnumerable<Parameter> Parameter {get; set;}
[Element("occurrence", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Occurrence {get; set;}
[Element("authoredOn", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime AuthoredOn {get; set;}
[Element("requester", typeof(Reference), false, false, false, false)]
public Reference Requester {get; set;}
[Element("supplier", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Supplier {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("deliverFrom", typeof(Reference), false, false, false, false)]
public Reference DeliverFrom {get; set;}
[Element("deliverTo", typeof(Reference), false, false, false, false)]
public Reference DeliverTo {get; set;}

        #endregion
        #region Constructor
        public  SupplyRequest() { }

        public  SupplyRequest(string value) : base(value) { }
        public  SupplyRequest(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "SupplyRequest";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
