

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SupplyDeliverySub
{
    public class SupplyDelivery : DomainResource<SupplyDelivery>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("partOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PartOf {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("suppliedItem", typeof(SuppliedItem), false, true, false, true)]
public IEnumerable<SuppliedItem> SuppliedItem {get; set;}
[Element("occurrence", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Occurrence {get; set;}
[Element("supplier", typeof(Reference), false, false, false, false)]
public Reference Supplier {get; set;}
[Element("destination", typeof(Reference), false, false, false, false)]
public Reference Destination {get; set;}
[Element("receiver", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Receiver {get; set;}

        #endregion
        #region Constructor
        public  SupplyDelivery() { }

        public  SupplyDelivery(string value) : base(value) { }
        public  SupplyDelivery(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "SupplyDelivery";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
