
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.CapabilityStatementSub.RestSub;

namespace ResourceTypeServices.R5.CapabilityStatementSub
{
    public class Rest : BackboneElement<Rest>
    {

        #region Property
        [Element("mode", typeof(FhirCode), true, false, false, false)]
public FhirCode Mode {get; set;}
[Element("documentation", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Documentation {get; set;}
[Element("security", typeof(Security), false, false, false, true)]
public Security Security {get; set;}
[Element("resource", typeof(Resource), false, true, false, true)]
public IEnumerable<Resource> Resource {get; set;}
[Element("interaction", typeof(Interaction), false, true, false, true)]
public IEnumerable<Interaction> Interaction {get; set;}
[Element("compartment", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> Compartment {get; set;}

        #endregion
        #region Constructor
        public  Rest() { }
        public  Rest(string value) : base(value) { }
        public  Rest(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Rest";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
