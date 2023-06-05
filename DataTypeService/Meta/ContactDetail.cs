using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Special
{
    public class ContactDetail : ComplexType<ContactDetail>
    {

        #region Property
        [Element("name", typeof(FhirString), false, false, false, false)]
        public FhirString? Name { get; init; }
        [Element("telecom", typeof(ContactPoint), false, true, false, false)]
        public IEnumerable<ContactPoint>? Telecom { get; init; }
        #endregion
        #region Constructor
        public ContactDetail() { }
        public ContactDetail(string? value) : base(value) { }
        public ContactDetail(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "ContactDetail";
        #endregion

        #region Public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
