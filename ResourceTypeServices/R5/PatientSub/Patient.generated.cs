

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.PatientSub
{
    public class Patient : DomainResource<Patient>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("active", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Active {get; set;}
[Element("name", typeof(HumanName), false, true, false, false)]
public IEnumerable<HumanName> Name {get; set;}
[Element("telecom", typeof(ContactPoint), false, true, false, false)]
public IEnumerable<ContactPoint> Telecom {get; set;}
[Element("gender", typeof(FhirCode), true, false, false, false)]
public FhirCode Gender {get; set;}
[Element("birthDate", typeof(FhirDate), true, false, false, false)]
public FhirDate BirthDate {get; set;}
[Element("deceased", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Deceased {get; set;}
[Element("address", typeof(Address), false, true, false, false)]
public IEnumerable<Address> Address {get; set;}
[Element("maritalStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept MaritalStatus {get; set;}
[Element("multipleBirth", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased MultipleBirth {get; set;}
[Element("photo", typeof(Attachment), false, true, false, false)]
public IEnumerable<Attachment> Photo {get; set;}
[Element("contact", typeof(Contact), false, true, false, true)]
public IEnumerable<Contact> Contact {get; set;}
[Element("communication", typeof(Communication), false, true, false, true)]
public IEnumerable<Communication> Communication {get; set;}
[Element("generalPractitioner", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> GeneralPractitioner {get; set;}
[Element("managingOrganization", typeof(Reference), false, false, false, false)]
public Reference ManagingOrganization {get; set;}
[Element("link", typeof(Link), false, true, false, true)]
public IEnumerable<Link> Link {get; set;}

        #endregion
        #region Constructor
        public  Patient() { }

        public  Patient(string value) : base(value) { }
        public  Patient(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Patient";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
