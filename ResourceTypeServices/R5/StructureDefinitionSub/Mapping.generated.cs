
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.StructureDefinitionSub
{
    public class Mapping : BackboneElement<Mapping>
    {

        #region Property
        [Element("identity", typeof(FhirId), true, false, false, false)]
public FhirId Identity {get; set;}
[Element("uri", typeof(FhirUri), true, false, false, false)]
public FhirUri Uri {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("comment", typeof(FhirString), true, false, false, false)]
public FhirString Comment {get; set;}

        #endregion
        #region Constructor
        public  Mapping() { }
        public  Mapping(string value) : base(value) { }
        public  Mapping(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Mapping";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
