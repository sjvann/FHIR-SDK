
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.OperationDefinitionSub
{
    public class Overload : BackboneElement<Overload>
    {

        #region Property
        [Element("parameterName", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> ParameterName {get; set;}
[Element("comment", typeof(FhirString), true, false, false, false)]
public FhirString Comment {get; set;}

        #endregion
        #region Constructor
        public  Overload() { }
        public  Overload(string value) : base(value) { }
        public  Overload(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Overload";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
