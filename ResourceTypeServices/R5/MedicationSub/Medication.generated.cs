

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MedicationSub
{
    public class Medication : DomainResource<Medication>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("marketingAuthorizationHolder", typeof(Reference), false, false, false, false)]
public Reference MarketingAuthorizationHolder {get; set;}
[Element("doseForm", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept DoseForm {get; set;}
[Element("totalVolume", typeof(Quantity), false, false, false, false)]
public Quantity TotalVolume {get; set;}
[Element("ingredient", typeof(Ingredient), false, true, false, true)]
public IEnumerable<Ingredient> Ingredient {get; set;}
[Element("batch", typeof(Batch), false, false, false, true)]
public Batch Batch {get; set;}
[Element("definition", typeof(Reference), false, false, false, false)]
public Reference Definition {get; set;}

        #endregion
        #region Constructor
        public  Medication() { }

        public  Medication(string value) : base(value) { }
        public  Medication(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Medication";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
