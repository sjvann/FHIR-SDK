

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.VerificationResultSub
{
    public class VerificationResult : DomainResource<VerificationResult>
    {
        #region Property
        [Element("target", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Target {get; set;}
[Element("targetLocation", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> TargetLocation {get; set;}
[Element("need", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Need {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("statusDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime StatusDate {get; set;}
[Element("validationType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ValidationType {get; set;}
[Element("validationProcess", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ValidationProcess {get; set;}
[Element("frequency", typeof(Timing), false, false, false, false)]
public Timing Frequency {get; set;}
[Element("lastPerformed", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime LastPerformed {get; set;}
[Element("nextScheduled", typeof(FhirDate), true, false, false, false)]
public FhirDate NextScheduled {get; set;}
[Element("failureAction", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept FailureAction {get; set;}
[Element("primarySource", typeof(PrimarySource), false, true, false, true)]
public IEnumerable<PrimarySource> PrimarySource {get; set;}
[Element("attestation", typeof(Attestation), false, false, false, true)]
public Attestation Attestation {get; set;}
[Element("validator", typeof(Validator), false, true, false, true)]
public IEnumerable<Validator> Validator {get; set;}

        #endregion
        #region Constructor
        public  VerificationResult() { }

        public  VerificationResult(string value) : base(value) { }
        public  VerificationResult(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "VerificationResult";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
