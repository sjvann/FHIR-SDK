
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.NutritionOrderSub.EnteralFormulaSub;

namespace ResourceTypeServices.R5.NutritionOrderSub
{
    public class EnteralFormula : BackboneElement<EnteralFormula>
    {

        #region Property
        [Element("baseFormulaType", typeof(CodeableReference), false, false, false, false)]
public CodeableReference BaseFormulaType {get; set;}
[Element("baseFormulaProductName", typeof(FhirString), true, false, false, false)]
public FhirString BaseFormulaProductName {get; set;}
[Element("deliveryDevice", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> DeliveryDevice {get; set;}
[Element("additive", typeof(Additive), false, true, false, true)]
public IEnumerable<Additive> Additive {get; set;}
[Element("caloricDensity", typeof(Quantity), false, false, false, false)]
public Quantity CaloricDensity {get; set;}
[Element("routeOfAdministration", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept RouteOfAdministration {get; set;}
[Element("administration", typeof(Administration), false, true, false, true)]
public IEnumerable<Administration> Administration {get; set;}
[Element("maxVolumeToDeliver", typeof(Quantity), false, false, false, false)]
public Quantity MaxVolumeToDeliver {get; set;}
[Element("administrationInstruction", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown AdministrationInstruction {get; set;}

        #endregion
        #region Constructor
        public  EnteralFormula() { }
        public  EnteralFormula(string value) : base(value) { }
        public  EnteralFormula(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "EnteralFormula";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
