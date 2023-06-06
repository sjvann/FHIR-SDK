
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CapabilityStatementSub
{
    public class Document : BackboneElement<Document>
    {

        #region Property
        [Element("mode", typeof(FhirCode), true, false, false, false)]
public FhirCode Mode {get; set;}
[Element("documentation", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Documentation {get; set;}
[Element("profile", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Profile {get; set;}

        #endregion
        #region Constructor
        public  Document() { }
        public  Document(string value) : base(value) { }
        public  Document(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Document";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
