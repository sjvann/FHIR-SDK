

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.OrganizationAffiliationSub
{
    public class OrganizationAffiliation : DomainResource<OrganizationAffiliation>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("active", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Active {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("organization", typeof(Reference), false, false, false, false)]
public Reference Organization {get; set;}
[Element("participatingOrganization", typeof(Reference), false, false, false, false)]
public Reference ParticipatingOrganization {get; set;}
[Element("network", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Network {get; set;}
[Element("code", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Code {get; set;}
[Element("specialty", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Specialty {get; set;}
[Element("location", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Location {get; set;}
[Element("healthcareService", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> HealthcareService {get; set;}
[Element("contact", typeof(ExtendedContactDetail), false, true, false, false)]
public IEnumerable<ExtendedContactDetail> Contact {get; set;}
[Element("endpoint", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Endpoint {get; set;}

        #endregion
        #region Constructor
        public  OrganizationAffiliation() { }

        public  OrganizationAffiliation(string value) : base(value) { }
        public  OrganizationAffiliation(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "OrganizationAffiliation";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
