
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.MedicationRequestSub.DispenseRequestSub;

namespace ResourceTypeServices.R5.MedicationRequestSub
{
    public class DispenseRequest : BackboneElement<DispenseRequest>
    {

        #region Property
        [Element("initialFill", typeof(InitialFill), false, false, false, true)]
public InitialFill InitialFill {get; set;}
[Element("dispenseInterval", typeof(Duration), false, false, false, false)]
public Duration DispenseInterval {get; set;}
[Element("validityPeriod", typeof(Period), false, false, false, false)]
public Period ValidityPeriod {get; set;}
[Element("numberOfRepeatsAllowed", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt NumberOfRepeatsAllowed {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("expectedSupplyDuration", typeof(Duration), false, false, false, false)]
public Duration ExpectedSupplyDuration {get; set;}
[Element("dispenser", typeof(Reference), false, false, false, false)]
public Reference Dispenser {get; set;}
[Element("dispenserInstruction", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> DispenserInstruction {get; set;}
[Element("doseAdministrationAid", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept DoseAdministrationAid {get; set;}

        #endregion
        #region Constructor
        public  DispenseRequest() { }
        public  DispenseRequest(string value) : base(value) { }
        public  DispenseRequest(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "DispenseRequest";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
