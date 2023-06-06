

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImmunizationSub
{
    public class Immunization : DomainResource<Immunization>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("statusReason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept StatusReason {get; set;}
[Element("vaccineCode", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept VaccineCode {get; set;}
[Element("administeredProduct", typeof(CodeableReference), false, false, false, false)]
public CodeableReference AdministeredProduct {get; set;}
[Element("manufacturer", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Manufacturer {get; set;}
[Element("lotNumber", typeof(FhirString), true, false, false, false)]
public FhirString LotNumber {get; set;}
[Element("expirationDate", typeof(FhirDate), true, false, false, false)]
public FhirDate ExpirationDate {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("supportingInformation", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingInformation {get; set;}
[Element("occurrence", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Occurrence {get; set;}
[Element("primarySource", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean PrimarySource {get; set;}
[Element("informationSource", typeof(CodeableReference), false, false, false, false)]
public CodeableReference InformationSource {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("site", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Site {get; set;}
[Element("route", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Route {get; set;}
[Element("doseQuantity", typeof(Quantity), false, false, false, false)]
public Quantity DoseQuantity {get; set;}
[Element("performer", typeof(Performer), false, true, false, true)]
public IEnumerable<Performer> Performer {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("isSubpotent", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean IsSubpotent {get; set;}
[Element("subpotentReason", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> SubpotentReason {get; set;}
[Element("programEligibility", typeof(ProgramEligibility), false, true, false, true)]
public IEnumerable<ProgramEligibility> ProgramEligibility {get; set;}
[Element("fundingSource", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept FundingSource {get; set;}
[Element("reaction", typeof(Reaction), false, true, false, true)]
public IEnumerable<Reaction> Reaction {get; set;}
[Element("protocolApplied", typeof(ProtocolApplied), false, true, false, true)]
public IEnumerable<ProtocolApplied> ProtocolApplied {get; set;}

        #endregion
        #region Constructor
        public  Immunization() { }

        public  Immunization(string value) : base(value) { }
        public  Immunization(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Immunization";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
