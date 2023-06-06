
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CapabilityStatementSub.RestSub
{
    public class Interaction : BackboneElement<Interaction>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("documentation", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Documentation {get; set;}

        #endregion
        #region Constructor
        public  Interaction() { }
        public  Interaction(string value) : base(value) { }
        public  Interaction(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Interaction";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
