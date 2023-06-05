using Core.Extension;
using DataTypeService.Based;
using DataTypeService.BaseTypes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using DataTypeService.Special;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;

namespace DataTypeService.MetaType
{
    public class RelatedArtifact : ComplexType
    {

        #region Property
        public FhirCode? Type { get; set; }
        public IEnumerable<CodeableConcept>? Classifier { get; set; }
        public FhirString? Label { get; set; }
        public FhirString? Display { get; set; }
        public FhirMarkdown? Citation { get; set; }
        public Attachment? Document { get; set; }
        public FhirCanonical? Resource { get; set; }
        public Reference? ResourceReference { get; set; }
        public FhirCode? PublicationStatus { get; set; }
        public FhirDate? PublicationDate { get; set; }
        #endregion
        #region Constructor
        public RelatedArtifact() { }
        public RelatedArtifact(string? value) : this(value.Parse()) { }
        public RelatedArtifact(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "type": Type = new(cv); break;
                        case "classifier": Classifier = cv?.AsArray().Select(x => new CodeableConcept(x)); break;
                        case "label": Label = new(cv); break;
                        case "display": Display = new(cv); break;
                        case "citation": Citation = new(cv); break;
                        case "document": Document = new(cv); break;
                        case "resource": Resource = new(cv); break;
                        case "resourceReference": ResourceReference = new(cv); break;
                        case "publicationStatus": PublicationStatus = new(cv); break;
                        case "publicationDate": PublicationDate = new(cv); break;
                        case "_type":
                            if (Type is FhirCode _type) SetupExtension(cv, ref _type);
                            break;
                        case "_classifier":
                            if (Classifier is IEnumerable<CodeableConcept> _classifier) SetupExtensions(cv, ref _classifier);
                            break;
                        case "_label":
                            if (Label is FhirString _label) SetupExtension(cv, ref _label);
                            break;
                        case "_display":
                            if (Display is FhirString _display) SetupExtension(cv, ref _display);
                            break;
                        case "_citation":
                            if (Citation is FhirMarkdown _citation) SetupExtension(cv, ref _citation);
                            break;
                        case "_document":
                            if (Document is Attachment _document) SetupExtension(cv, ref _document);
                            break;
                        case "_resource":
                            if (Resource is FhirCanonical _resource) SetupExtension(cv, ref _resource);
                            break;
                        case "_resourceReference":
                            if (ResourceReference is Reference _resourceReference) SetupExtension(cv, ref _resourceReference);
                            break;
                        case "_publicationStatus":
                            if (PublicationStatus is FhirCode _publicationStatus) SetupExtension(cv, ref _publicationStatus);
                            break;
                        case "_publicationDate":
                            if (PublicationDate is FhirDate _publicationDate) SetupExtension(cv, ref _publicationDate);
                            break;
                    }
                }
            }

        }

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
