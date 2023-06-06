
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.PackagedProductDefinitionSub.PackagingSub;

namespace ResourceTypeServices.R5.PackagedProductDefinitionSub
{
    public class Packaging : BackboneElement<Packaging>
    {

        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("componentPart", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean ComponentPart {get; set;}
[Element("quantity", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Quantity {get; set;}
[Element("material", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Material {get; set;}
[Element("alternateMaterial", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> AlternateMaterial {get; set;}
[Element("shelfLifeStorage", typeof(ProductShelfLife), false, true, false, false)]
public IEnumerable<ProductShelfLife> ShelfLifeStorage {get; set;}
[Element("manufacturer", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Manufacturer {get; set;}
[Element("property", typeof(Property), false, true, false, true)]
public IEnumerable<Property> Property {get; set;}
[Element("containedItem", typeof(ContainedItem), false, true, false, true)]
public IEnumerable<ContainedItem> ContainedItem {get; set;}

        #endregion
        #region Constructor
        public  Packaging() { }
        public  Packaging(string value) : base(value) { }
        public  Packaging(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Packaging";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
