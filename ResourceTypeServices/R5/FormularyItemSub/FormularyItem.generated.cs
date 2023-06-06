

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.FormularyItemSub
{
    public class FormularyItem : DomainResource<FormularyItem>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}

        #endregion
        #region Constructor
        public  FormularyItem() { }

        public  FormularyItem(string value) : base(value) { }
        public  FormularyItem(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "FormularyItem";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
