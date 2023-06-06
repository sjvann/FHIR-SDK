

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceSub
{
    public class Substance : DomainResource<Substance>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("instance", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Instance {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("code", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Code {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("expiry", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Expiry {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("ingredient", typeof(Ingredient), false, true, false, true)]
public IEnumerable<Ingredient> Ingredient {get; set;}

        #endregion
        #region Constructor
        public  Substance() { }

        public  Substance(string value) : base(value) { }
        public  Substance(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Substance";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
