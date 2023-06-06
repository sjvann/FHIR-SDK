
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MessageDefinitionSub
{
    public class AllowedResponse : BackboneElement<AllowedResponse>
    {

        #region Property
        [Element("message", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Message {get; set;}
[Element("situation", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Situation {get; set;}

        #endregion
        #region Constructor
        public  AllowedResponse() { }
        public  AllowedResponse(string value) : base(value) { }
        public  AllowedResponse(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "AllowedResponse";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
