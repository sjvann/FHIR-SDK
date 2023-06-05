
using DataTypeService.Based;
using DataTypeService.Special;
using System.Text.Json.Nodes;
using Primitive = DataTypeService.Primitive;
namespace ResourceTypeBased
{
    public abstract class Resource : Base, IResource
    {

        private Primitive.Id? _Id;
        private Meta? _Meta;
        private Primitive.Uri? _ImplicitRules;
        private Primitive.Code? _Language;

        protected override string? _TypeName => "Resource";
        protected IEnumerable<KeyValuePair<string, JsonNode?>> GetResource()
        {
            List<KeyValuePair<string, JsonNode?>> result = new();
            if (Id is DataTypeService.Primitive.Id id)
            {
                result.Add(ForPrimitiveType("id", id));
            }
            if (Meta is Meta meta)
            {
                result.Add(ForComplexType("meta", meta));
            }
            if (ImplicitRules is DataTypeService.Primitive.Uri implicitRules)
            {
                result.Add(ForPrimitiveType("implicitRules", implicitRules));
            }
            if (Language is DataTypeService.Primitive.Code language)
            {
                result.Add(ForPrimitiveType("language", language));
            }
            return result;
        }
        protected Resource GetResource(JsonNode? source)
        {
            if(source != null)
            {
                SetResource(source);
            }
            return this;
        }
        protected void SetResource(JsonNode source)
        {
            if (source != null)
            {
                if (source["id"] != null)
                {
                    Id = new DataTypeService.Primitive.Id(source["id"]);
                }
                if (source["meta"] != null)
                {
                    Meta = new Meta(source["meta"]);
                }
                if (source["implicitRules"] != null)
                {
                    ImplicitRules = new DataTypeService.Primitive.Uri(source["implicitRules"]);
                }
                if (source["language"] != null)
                {
                    Language = new DataTypeService.Primitive.Code(source["language"]);
                }
            }
        }
        public Primitive.Id? Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged("Id"); }
        }
        public Meta? Meta
        {
            get { return _Meta; }
            set { _Meta = value; OnPropertyChanged("Meta"); }
        }
        public Primitive.Uri? ImplicitRules
        {
            get { return _ImplicitRules; }
            set { _ImplicitRules = value; OnPropertyChanged("ImplicitRules"); }
        }
        public Primitive.Code? Language
        {
            get { return _Language; }
            set { _Language = value; OnPropertyChanged("Language"); }
        }

        #region Content Service
        public JsonNode? GetJsonNode()
        {
            var p = _Properties;
            return p != null ? new JsonObject(p) : null;
        }
        public string? GetJsonString()
        {
            if (_JsonNode == null) _JsonNode = GetJsonNode();

            return _JsonNode?.ToJsonString(JsonSerializerOptions);

        }

        public string? GetXmlString()
        {
            return GetXmlStringImp(this);
        }

        public abstract void SetupProperties();

        #endregion

    }
}
