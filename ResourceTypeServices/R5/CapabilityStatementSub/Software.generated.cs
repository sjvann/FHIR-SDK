
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CapabilityStatementSub
{
    public class Software : BackboneElement<Software>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("releaseDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime ReleaseDate {get; set;}

        #endregion
        #region Constructor
        public  Software() { }
        public  Software(string value) : base(value) { }
        public  Software(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Software";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
