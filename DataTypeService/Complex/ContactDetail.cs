using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class ContactDetail : ComplexType<ContactDetail>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
        public FhirString? Name { get; set; }
        [Element("telecom", typeof(ContactPoint), false, true, false, false)]
        public IEnumerable<ContactPoint>? Telecom { get; set; }
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
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
