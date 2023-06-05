

using DataTypeService.Complex;
using System.Text.Json.Nodes;

namespace DataTypeService.Based
{
    public abstract class BackboneElement : Element, IComplexType
    {
        private List<Extension>? _ModifierExtension;
        public List<Extension>? ModifierExtension
        {
            get { return _ModifierExtension ?? new List<Extension>(); }
            set { _ModifierExtension = value; OnPropertyChanged("ModifierExtension"); }
        }

        public IEnumerable<KeyValuePair<string, JsonNode?>>? GetProperties()
        {
            if (_Properties == null) SetProperties();
            return _Properties;
        }
        public virtual JsonNode? GetJsonNode()
        {
            if (_Properties == null) SetProperties();
            if (_Properties != null)
            {
                return new JsonObject(_Properties);
            }
            else if (_JsonNode != null)
            {
                return _JsonNode;
            }
            return null;

        }
        public string? GetJsonString()
        {
            return _JsonNode?.ToJsonString();
        }

        public string? GetXmlString()
        {
            return GetXmlStringImp(this);
        }
        public abstract void SetProperties();
    }
}
