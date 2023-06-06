

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.NutritionOrderSub
{
    public class NutritionOrder : DomainResource<NutritionOrder>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("instantiatesCanonical", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> InstantiatesCanonical {get; set;}
[Element("instantiatesUri", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> InstantiatesUri {get; set;}
[Element("instantiates", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> Instantiates {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("groupIdentifier", typeof(Identifier), false, false, false, false)]
public Identifier GroupIdentifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("intent", typeof(FhirCode), true, false, false, false)]
public FhirCode Intent {get; set;}
[Element("priority", typeof(FhirCode), true, false, false, false)]
public FhirCode Priority {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("supportingInformation", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingInformation {get; set;}
[Element("dateTime", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime DateTime {get; set;}
[Element("orderer", typeof(Reference), false, false, false, false)]
public Reference Orderer {get; set;}
[Element("performer", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Performer {get; set;}
[Element("allergyIntolerance", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> AllergyIntolerance {get; set;}
[Element("foodPreferenceModifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> FoodPreferenceModifier {get; set;}
[Element("excludeFoodModifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ExcludeFoodModifier {get; set;}
[Element("outsideFoodAllowed", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean OutsideFoodAllowed {get; set;}
[Element("oralDiet", typeof(OralDiet), false, false, false, true)]
public OralDiet OralDiet {get; set;}
[Element("supplement", typeof(Supplement), false, true, false, true)]
public IEnumerable<Supplement> Supplement {get; set;}
[Element("enteralFormula", typeof(EnteralFormula), false, false, false, true)]
public EnteralFormula EnteralFormula {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  NutritionOrder() { }

        public  NutritionOrder(string value) : base(value) { }
        public  NutritionOrder(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "NutritionOrder";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
