using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;


namespace DataTypeService.Complex
{
    public class Dosage : ComplexType<Dosage>
    {

        #region Property
        [Element("modifierExtension", typeof(Extension), false, true, false, false)]
        public IEnumerable<Extension>? ModifierExtension { get; set; }
        [Element("sequence", typeof(FhirInteger), true, false, false, false)]
        public FhirInteger? Sequence { get; set; }
        [Element("text", typeof(FhirString), true, false, false, false)]
        public FhirString? Text { get; set; }
        [Element("additionalInstruction", typeof(CodeableConcept), false, true, false, false)]
        public IEnumerable<CodeableConcept>? AdditionalInstruction { get; set; }
        [Element("patientInstruction", typeof(FhirString), true, false, false, false)]
        public FhirString? PatientInstruction { get; set; }
        [Element("timing", typeof(Timing), false, false, false, false)]
        public Timing? Timing { get; set; }
        [Element("asNeeded", typeof(FhirBoolean), true, false, false, false)]
        public FhirBoolean? AsNeeded { get; set; }
        [Element("asNeededFor", typeof(CodeableConcept), false, true, false, false)]
        public IEnumerable<CodeableConcept>? AsNeededFor { get; set; }
        [Element("site", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Site { get; set; }
        [Element("route", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Route { get; set; }
        [Element("method", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Method { get; set; }
        [Element("doseAndRateValue", typeof(DoseAndRate), false, true, false, false)]
        public IEnumerable<DoseAndRate>? DoseAndRateValue { get; set; }
        [Element("maxDosePerPeriod", typeof(Ratio), false, true, false, false)]
        public IEnumerable<Ratio>? MaxDosePerPeriod { get; set; }
        [Element("maxDosePerAdministration", typeof(SimpleQuantity), false, false, false, false)]
        public SimpleQuantity? MaxDosePerAdministration { get; set; }
        [Element("maxDosePerLifetime", typeof(SimpleQuantity), false, false, false, false)]
        public SimpleQuantity? MaxDosePerLifetime { get; set; }
        #endregion
        #region Constructor
        public Dosage()
        { }
        public Dosage(string? value) : base(value) { }
        public Dosage(JsonNode? source) : base(source)
        {

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "Dosage";

        #endregion

        #region public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }


        #endregion
    }

    public class DoseAndRate : ComplexType<DoseAndRate>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Type { get; set; }
        [Element("dose", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Dose { get; set; }
        [Element("rate", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Rate { get; set; }
        #endregion
        #region Constructor
        public DoseAndRate() { }
        public DoseAndRate(string? value) : base(value) { }
        public DoseAndRate(JsonNode? source) : base(source)
        {
        }

        #endregion
        #region From Parent
        protected override string _TypeName => "DoseAndRate";

        #endregion

        #region public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion


    }
}
