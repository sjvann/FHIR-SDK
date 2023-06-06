
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub
{
    public class WebLocation : BackboneElement<WebLocation>
    {

        #region Property
        [Element("classifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Classifier {get; set;}
[Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}

        #endregion
        #region Constructor
        public  WebLocation() { }
        public  WebLocation(string value) : base(value) { }
        public  WebLocation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "WebLocation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
