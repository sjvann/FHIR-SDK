

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.HealthcareServiceSub
{
    public class HealthcareService : DomainResource<HealthcareService>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("active", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Active {get; set;}
[Element("providedBy", typeof(Reference), false, false, false, false)]
public Reference ProvidedBy {get; set;}
[Element("offeredIn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> OfferedIn {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("specialty", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Specialty {get; set;}
[Element("location", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Location {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("comment", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Comment {get; set;}
[Element("extraDetails", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown ExtraDetails {get; set;}
[Element("photo", typeof(Attachment), false, false, false, false)]
public Attachment Photo {get; set;}
[Element("contact", typeof(ExtendedContactDetail), false, true, false, false)]
public IEnumerable<ExtendedContactDetail> Contact {get; set;}
[Element("coverageArea", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> CoverageArea {get; set;}
[Element("serviceProvisionCode", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ServiceProvisionCode {get; set;}
[Element("eligibility", typeof(Eligibility), false, true, false, true)]
public IEnumerable<Eligibility> Eligibility {get; set;}
[Element("program", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Program {get; set;}
[Element("characteristic", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Characteristic {get; set;}
[Element("communication", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Communication {get; set;}
[Element("referralMethod", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ReferralMethod {get; set;}
[Element("appointmentRequired", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean AppointmentRequired {get; set;}
[Element("availability", typeof(Availability), false, true, false, false)]
public IEnumerable<Availability> Availability {get; set;}
[Element("endpoint", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Endpoint {get; set;}

        #endregion
        #region Constructor
        public  HealthcareService() { }

        public  HealthcareService(string value) : base(value) { }
        public  HealthcareService(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "HealthcareService";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
