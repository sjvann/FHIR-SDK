

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.GroupSub
{
    public class Group : DomainResource<Group>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("active", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Active {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("membership", typeof(FhirCode), true, false, false, false)]
public FhirCode Membership {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("quantity", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt Quantity {get; set;}
[Element("managingEntity", typeof(Reference), false, false, false, false)]
public Reference ManagingEntity {get; set;}
[Element("characteristic", typeof(Characteristic), false, true, false, true)]
public IEnumerable<Characteristic> Characteristic {get; set;}
[Element("member", typeof(Member), false, true, false, true)]
public IEnumerable<Member> Member {get; set;}

        #endregion
        #region Constructor
        public  Group() { }

        public  Group(string value) : base(value) { }
        public  Group(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Group";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
