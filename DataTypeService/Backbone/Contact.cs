using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Backbone
{
    public class Contact : ComplexType<Contact>
    {
        #region Property
        [Element("relationship", typeof(CodeableConcept), false, true, false, false)]
        public IEnumerable<CodeableConcept>? Relationship { get; set; }
        [Element("name", typeof(HumanName), false, false, false, false)]
        public HumanName? Name { get; set; }
        [Element("telecom", typeof(ContactPoint), false, true, false, false)]
        public IEnumerable<ContactPoint>? Telecom { get; set; }
        [Element("address", typeof(Address), false, false, false, false)]
        public Address? Address { get; set; }
        [Element("gender", typeof(FhirCode),true, false, false, false)]
        public FhirCode? Gender { get; set; }
        [Element("organization", typeof(Reference), false, false, false, false)]
        public Reference? Organization { get; set; }
        [Element("period", typeof(Period), false, false, false, false)]
        public Period? Period { get; set; }
        #endregion
        #region Constructor
        public Contact() { }
        public Contact(string? value) : base(value)
        {

        }
        public Contact(JsonNode? source): base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "Contact";

        #endregion

        #region public Method 
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
