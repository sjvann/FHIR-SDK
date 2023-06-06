
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.InventoryItemSub
{
    public class Instance : BackboneElement<Instance>
    {

        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("lotNumber", typeof(FhirString), true, false, false, false)]
public FhirString LotNumber {get; set;}
[Element("expiry", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Expiry {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}

        #endregion
        #region Constructor
        public  Instance() { }
        public  Instance(string value) : base(value) { }
        public  Instance(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Instance";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
