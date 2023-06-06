

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.NutritionProductSub
{
    public class NutritionProduct : DomainResource<NutritionProduct>
    {
        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("manufacturer", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Manufacturer {get; set;}
[Element("nutrient", typeof(Nutrient), false, true, false, true)]
public IEnumerable<Nutrient> Nutrient {get; set;}
[Element("ingredient", typeof(Ingredient), false, true, false, true)]
public IEnumerable<Ingredient> Ingredient {get; set;}
[Element("knownAllergen", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> KnownAllergen {get; set;}
[Element("characteristic", typeof(Characteristic), false, true, false, true)]
public IEnumerable<Characteristic> Characteristic {get; set;}
[Element("instance", typeof(Instance), false, true, false, true)]
public IEnumerable<Instance> Instance {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  NutritionProduct() { }

        public  NutritionProduct(string value) : base(value) { }
        public  NutritionProduct(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "NutritionProduct";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
