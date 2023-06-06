
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.OperationDefinitionSub.ParameterSub
{
    public class ReferencedFrom : BackboneElement<ReferencedFrom>
    {

        #region Property
        [Element("source", typeof(FhirString), true, false, false, false)]
public FhirString Source {get; set;}
[Element("sourceId", typeof(FhirString), true, false, false, false)]
public FhirString SourceId {get; set;}

        #endregion
        #region Constructor
        public  ReferencedFrom() { }
        public  ReferencedFrom(string value) : base(value) { }
        public  ReferencedFrom(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ReferencedFrom";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
