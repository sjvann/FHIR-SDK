
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicinalProductDefinitionSub
{
    public class Contact : BackboneElement<Contact>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("contact", typeof(Reference), false, false, false, false)]
public Reference ContactProp {get; set;}

        #endregion
        #region Constructor
        public  Contact() { }
        public  Contact(string value) : base(value) { }
        public  Contact(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Contact";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
