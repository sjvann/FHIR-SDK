

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.InventoryItemSub
{
    public class InventoryItem : DomainResource<InventoryItem>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("code", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Code {get; set;}
[Element("name", typeof(Name), false, true, false, true)]
public IEnumerable<Name> Name {get; set;}
[Element("responsibleOrganization", typeof(ResponsibleOrganization), false, true, false, true)]
public IEnumerable<ResponsibleOrganization> ResponsibleOrganization {get; set;}
[Element("description", typeof(Description), false, false, false, true)]
public Description Description {get; set;}
[Element("inventoryStatus", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> InventoryStatus {get; set;}
[Element("baseUnit", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept BaseUnit {get; set;}
[Element("netContent", typeof(Quantity), false, false, false, false)]
public Quantity NetContent {get; set;}
[Element("association", typeof(Association), false, true, false, true)]
public IEnumerable<Association> Association {get; set;}
[Element("characteristic", typeof(Characteristic), false, true, false, true)]
public IEnumerable<Characteristic> Characteristic {get; set;}
[Element("instance", typeof(Instance), false, false, false, true)]
public Instance Instance {get; set;}
[Element("productReference", typeof(Reference), false, false, false, false)]
public Reference ProductReference {get; set;}

        #endregion
        #region Constructor
        public  InventoryItem() { }

        public  InventoryItem(string value) : base(value) { }
        public  InventoryItem(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "InventoryItem";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
