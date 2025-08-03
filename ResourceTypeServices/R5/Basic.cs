using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;
namespace ResourceTypeServices.R5
{
    public class Basic : ResourceType<Basic>
    {
        #region private Property
        private List<Identifier>? _identifier;
        private CodeableConcept? _code;
        private ReferenceType? _subject;
        private FhirDateTime? _created;
        private ReferenceType? _author;
        #endregion
        #region Public Method
        public List<Identifier>? Identifier
        {
            get { return _identifier; }
            set
            {
                _identifier = value;
                OnPropertyChanged("identifier", value);
            }
        }
        public CodeableConcept? Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged("code", value);
            }
        }

        public ReferenceType? Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                OnPropertyChanged("subject", value);
            }
        }

        public FhirDateTime? Created
        {
            get { return _created; }
            set
            {
                _created = value;
                OnPropertyChanged("created", value);
            }
        }

        public ReferenceType? Author
        {
            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged("author", value);
            }
        }
        #endregion
        #region Constructor
        public Basic() { }
        public Basic(string value) : base(value) { }
        public Basic(JsonNode? source) : base(source) { }
        #endregion
    }
}
