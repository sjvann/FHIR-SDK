
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CapabilityStatementSub.RestSub.ResourceSub
{
    public class Operation : BackboneElement<Operation>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("definition", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Definition {get; set;}
[Element("documentation", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Documentation {get; set;}

        #endregion
        #region Constructor
        public  Operation() { }
        public  Operation(string value) : base(value) { }
        public  Operation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Operation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
