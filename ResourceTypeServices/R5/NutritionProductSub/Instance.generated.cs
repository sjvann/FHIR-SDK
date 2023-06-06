
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.NutritionProductSub
{
    public class Instance : BackboneElement<Instance>
    {

        #region Property
        [Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("lotNumber", typeof(FhirString), true, false, false, false)]
public FhirString LotNumber {get; set;}
[Element("expiry", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Expiry {get; set;}
[Element("useBy", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime UseBy {get; set;}
[Element("biologicalSourceEvent", typeof(Identifier), false, false, false, false)]
public Identifier BiologicalSourceEvent {get; set;}

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
