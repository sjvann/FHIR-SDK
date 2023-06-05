using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class ExtendedContactDetail : ComplexType<ExtendedContactDetail>
    {

        #region Property
        [Element("purpose", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Purpose { get; init; }
        [Element("name", typeof(HumanName), false, true, false, false)]
        public IEnumerable<HumanName>? Name { get; init; }
        [Element("telecom", typeof(ContactPoint), false, true, false, false)]
        public IEnumerable<ContactPoint>? Telecom { get; init; }
        [Element("address", typeof(Address), false, false, false, false)]
        public Address? Address { get; init; }
        [Element("organization", typeof(Reference), false, false, false, false)]
        public Reference? Organization { get; init; }
        [Element("period", typeof(Period), false, false, false, false)]
        public Period? Period { get; init; }

        #endregion
        #region Constructor
        public ExtendedContactDetail() { }
        public ExtendedContactDetail(string? value) : base(value) { }
        public ExtendedContactDetail(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "ExtendedContactDetail";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
