
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.InventoryReportSub.InventoryListingSub;

namespace ResourceTypeServices.R5.InventoryReportSub
{
    public class InventoryListing : BackboneElement<InventoryListing>
    {

        #region Property
        [Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("itemStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ItemStatus {get; set;}
[Element("countingDateTime", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime CountingDateTime {get; set;}
[Element("item", typeof(Item), false, true, false, true)]
public IEnumerable<Item> Item {get; set;}

        #endregion
        #region Constructor
        public  InventoryListing() { }
        public  InventoryListing(string value) : base(value) { }
        public  InventoryListing(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "InventoryListing";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
