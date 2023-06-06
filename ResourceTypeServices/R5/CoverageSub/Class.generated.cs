
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CoverageSub
{
    public class Class : BackboneElement<Class>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("value", typeof(Identifier), false, false, false, false)]
public Identifier Value {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}

        #endregion
        #region Constructor
        public  Class() { }
        public  Class(string value) : base(value) { }
        public  Class(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Class";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
