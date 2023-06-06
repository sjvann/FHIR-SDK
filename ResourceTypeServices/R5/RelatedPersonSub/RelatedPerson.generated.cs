

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.RelatedPersonSub
{
    public class RelatedPerson : DomainResource<RelatedPerson>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("active", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Active {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("relationship", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Relationship {get; set;}
[Element("name", typeof(HumanName), false, true, false, false)]
public IEnumerable<HumanName> Name {get; set;}
[Element("telecom", typeof(ContactPoint), false, true, false, false)]
public IEnumerable<ContactPoint> Telecom {get; set;}
[Element("gender", typeof(FhirCode), true, false, false, false)]
public FhirCode Gender {get; set;}
[Element("birthDate", typeof(FhirDate), true, false, false, false)]
public FhirDate BirthDate {get; set;}
[Element("address", typeof(Address), false, true, false, false)]
public IEnumerable<Address> Address {get; set;}
[Element("photo", typeof(Attachment), false, true, false, false)]
public IEnumerable<Attachment> Photo {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("communication", typeof(Communication), false, true, false, true)]
public IEnumerable<Communication> Communication {get; set;}

        #endregion
        #region Constructor
        public  RelatedPerson() { }

        public  RelatedPerson(string value) : base(value) { }
        public  RelatedPerson(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "RelatedPerson";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
