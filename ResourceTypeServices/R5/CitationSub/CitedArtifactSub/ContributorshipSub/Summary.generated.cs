
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub.ContributorshipSub
{
    public class Summary : BackboneElement<Summary>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("style", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Style {get; set;}
[Element("source", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Source {get; set;}
[Element("value", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Value {get; set;}

        #endregion
        #region Constructor
        public  Summary() { }
        public  Summary(string value) : base(value) { }
        public  Summary(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Summary";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
