
using DataTypeService.Special;
using System.Text.Json.Nodes;

namespace ResourceTypeBased
{
    public abstract class DomainResource : Resource
    {
        private Narrative? _Text;
        private IEnumerable<Resource>? _Contained;
        private IEnumerable<Extension>? _Extension;
        private IEnumerable<Extension>? _ModifierExtension;

        protected override string? _TypeName => "DomainResource";
        protected IEnumerable<KeyValuePair<string, JsonNode?>> GetDomainResource()
        {
            List<KeyValuePair<string, JsonNode?>> result = new();

            result.AddRange(GetResource());

          
            if (Text is Narrative text)
            {
                result.Add(ForComplexType("text", text));
            }
            if (Contained is IEnumerable<Resource> contained)
            {
                result.Add(ForArrayType("contained", contained));
            }
            return result;
        }
        protected void SetDomainResource(JsonNode source)
        {
            if (source != null)
            {
                SetResource(source);

                if (source["text"] != null)
                {
                    Text = new Narrative(source["text"]);
                }
                var containeds = source["contained"]?.AsArray();
                if (containeds != null)
                {
                    List<Resource> result = new();
                    foreach (var item in containeds)
                    {
                        result.Add(GetResource(item));
                    }
                    Contained = result;
                }
                var extensions = source["extension"]?.AsArray();
                if (extensions != null)
                {
                    List<Extension> result = new();
                    foreach (var item in extensions)
                    {
                        result.Add(new Extension(item));
                    }
                    Extension = result;
                }
                var modifierExtensions = source["modifierExtension"]?.AsArray();
                if (modifierExtensions != null)
                {
                    List<Extension> result = new();
                    foreach (var item in modifierExtensions)
                    {
                        result.Add(new Extension(item));
                    }
                    ModifierExtension = result;
                }
            }
        }
        public IEnumerable<KeyValuePair<string, JsonNode?>>? GetProperties()
        {
            if (_Properties == null) SetupProperties();
            return _Properties;
        }

        public Narrative? Text
        {
            get { return _Text; }
            set { _Text = value; OnPropertyChanged("Text"); }
        }

        public IEnumerable<Resource>? Contained
        {
            get { return _Contained; }
            set { _Contained = value; OnPropertyChanged("Contained"); }
        }
        public IEnumerable<Extension>? Extension
        {
            get { return _Extension; }
            set { _Extension = value; OnPropertyChanged("Extension"); }
        }
        public IEnumerable<Extension>? ModifierExtension
        {
            get { return _ModifierExtension; }
            set { _ModifierExtension = value; OnPropertyChanged("ModifierExtension"); }
        }
    }
}
