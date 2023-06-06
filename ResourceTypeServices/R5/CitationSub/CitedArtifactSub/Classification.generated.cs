
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub
{
    public class Classification : BackboneElement<Classification>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("classifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Classifier {get; set;}
[Element("artifactAssessment", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> ArtifactAssessment {get; set;}

        #endregion
        #region Constructor
        public  Classification() { }
        public  Classification(string value) : base(value) { }
        public  Classification(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Classification";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
