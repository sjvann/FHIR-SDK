using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;


namespace DataTypeServices.DataTypes.MetaTypes
{
    public class RelatedArtifact : ComplexType<RelatedArtifact>
    {
        private FhirCode? _type;
        private List<CodeableConcept>? _classifier;
        private FhirString? _label;
        private FhirString? _display;
        private FhirMarkdown? _citation;
        private Attachment? _document;
        private FhirCanonical? _resource;
        private ReferenceType? _resourceReference;
        private FhirCode? _publicationStatus;
        private FhirDate? _publicationDate;

        public FhirCode? Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }
        public List<CodeableConcept>? Classifier
        {
            get { return _classifier; }
            set
            {
                _classifier = value;
                OnPropertyChanged("classifier", value);
            }
        }
        public FhirString? Label
        {
            get { return _label; }
            set
            {
                _label = value;
                OnPropertyChanged("label", value);
            }
        }
        public FhirString? Display
        {
            get { return _display; }
            set
            {
                _display = value;
                OnPropertyChanged("display", value);
            }
        }
        public FhirMarkdown? Citation
        {
            get { return _citation; }
            set
            {
                _citation = value;
                OnPropertyChanged("citation", value);
            }
        }
        public Attachment? Document
        {
            get { return _document; }
            set
            {
                _document = value;
                OnPropertyChanged("document", value);
            }
        }
        public FhirCanonical? Resource
        {
            get { return _resource; }
            set
            {
                _resource = value;
                OnPropertyChanged("resource", value);
            }
        }
        public ReferenceType? ResourceReference
        {
            get { return _resourceReference; }
            set
            {
                _resourceReference = value;
                OnPropertyChanged("resourceReference", value);
            }
        }
        public FhirCode? PublicationStatus
        {
            get { return _publicationStatus; }
            set
            {
                _publicationStatus = value;
                OnPropertyChanged("publicationStatus", value);
            }
        }
        public FhirDate? PublicationDate
        {
            get { return _publicationDate; }
            set
            {
                _publicationDate = value;
                OnPropertyChanged("publicationDate", value);
            }
        }
        public RelatedArtifact() : base() { }
        public RelatedArtifact(JsonObject? value) : base(value) { }
        public RelatedArtifact(string value) : base(value) { }
    }
}
