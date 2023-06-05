
using DataTypeService.Complex;
using System.Text.Json.Nodes;

namespace DataTypeService.Based
{
    public abstract class BackboneType : DataType, IComplexType
    {
        private List<Extension>? _ModifierExtension;
        public List<Extension>? ModifierExtension
        {
            get { return _ModifierExtension ?? new List<Extension>(); }
            set { _ModifierExtension = value; OnPropertyChanged("ModifierExtension"); }
        }

        public JsonNode? GetJsonNode()
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

        public IEnumerable<KeyValuePair<string, JsonNode?>>? GetProperties()
        {
            if (_Properties == null) SetProperties();
            return _Properties;
        }

        public abstract void SetProperties();
    }
}
