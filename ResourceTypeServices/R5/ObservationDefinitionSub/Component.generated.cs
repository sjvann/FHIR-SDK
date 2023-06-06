
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ObservationDefinitionSub
{
    public class Component : BackboneElement<Component>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("permittedDataType", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> PermittedDataType {get; set;}
[Element("permittedUnit", typeof(Coding), false, true, false, false)]
public IEnumerable<Coding> PermittedUnit {get; set;}

        #endregion
        #region Constructor
        public  Component() { }
        public  Component(string value) : base(value) { }
        public  Component(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Component";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
