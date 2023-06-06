

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.IngredientSub
{
    public class Ingredient : DomainResource<Ingredient>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("for", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> For {get; set;}
[Element("role", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Role {get; set;}
[Element("function", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Function {get; set;}
[Element("group", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Group {get; set;}
[Element("allergenicIndicator", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean AllergenicIndicator {get; set;}
[Element("comment", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Comment {get; set;}
[Element("manufacturer", typeof(Manufacturer), false, true, false, true)]
public IEnumerable<Manufacturer> Manufacturer {get; set;}
[Element("substance", typeof(Substance), false, false, false, true)]
public Substance Substance {get; set;}

        #endregion
        #region Constructor
        public  Ingredient() { }

        public  Ingredient(string value) : base(value) { }
        public  Ingredient(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Ingredient";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
