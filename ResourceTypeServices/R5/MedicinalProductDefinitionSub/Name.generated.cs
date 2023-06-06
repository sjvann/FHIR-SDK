
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.MedicinalProductDefinitionSub.NameSub;

namespace ResourceTypeServices.R5.MedicinalProductDefinitionSub
{
    public class Name : BackboneElement<Name>
    {

        #region Property
        [Element("productName", typeof(FhirString), true, false, false, false)]
public FhirString ProductName {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("part", typeof(Part), false, true, false, true)]
public IEnumerable<Part> Part {get; set;}
[Element("usage", typeof(Usage), false, true, false, true)]
public IEnumerable<Usage> Usage {get; set;}

        #endregion
        #region Constructor
        public  Name() { }
        public  Name(string value) : base(value) { }
        public  Name(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Name";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
