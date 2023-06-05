using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class RelatedArtifact : ComplexType<RelatedArtifact>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Type { get; set; }
        [Element("classifier", typeof(CodeableConcept), false, true, false, false)]
        public IEnumerable<CodeableConcept>? Classifier { get; set; }
        [Element("label", typeof(FhirString), true, false, false, false)]
        public FhirString? Label { get; set; }
        [Element("display", typeof(FhirString), true, false, false, false)]
        public FhirString? Display { get; set; }
        [Element("citation", typeof(FhirMarkdown), true, false, false, false)]
        public FhirMarkdown? Citation { get; set; }
        [Element("document", typeof(Attachment), false, false, false, false)]
        public Attachment? Document { get; set; }
        [Element("resource", typeof(FhirCanonical), true, false, false, false)]
        public FhirCanonical? Resource { get; set; }
        [Element("resourceReference", typeof(Reference), false, false, false, false)]
        public Reference? ResourceReference { get; set; }
        [Element("publicationStatus", typeof(FhirCode), true, false, false, false)]
        public FhirCode? PublicationStatus { get; set; }
        [Element("publicationDate", typeof(FhirDate), true, false, false, false)]
        public FhirDate? PublicationDate { get; set; }
        #endregion
        #region Constructor
        public RelatedArtifact() { }
        public RelatedArtifact(string? value) : base(value) { }
        public RelatedArtifact(JsonNode? source) : base(source)
        { }

        #endregion
        #region From Parent
        protected override string _TypeName => "RelatedArtifact";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
