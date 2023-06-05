using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml.Serialization;

namespace DataTypeService.Based
{
    public abstract class Base : IBase
    {
        protected virtual string? _TypeName { get; }
        protected IEnumerable<KeyValuePair<string, JsonNode?>>? _Properties;
        protected JsonNode? _JsonNode;
        protected event System.ComponentModel.PropertyChangedEventHandler? PropertyChanged;

        public string GetTypeName()
        {
            return _TypeName ?? "Base";
        }

        protected void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(property));
        }
        protected static JsonSerializerOptions JsonSerializerOptions
        {
            get
            {
                return new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true,
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
            }
        }
        protected static string? GetXmlStringImp<T>(T source) where T : Base
        {
            XmlSerializer xmlSerializer = new(typeof(T));
            using StringWriter textWriter = new();
            xmlSerializer.Serialize(textWriter, source);
            return textWriter.ToString();
        }
        protected static JsonArray GetJsonArray<T>(IEnumerable<T>? source) where T : Base
        {
            JsonArray target = new();
            if (source != null)
            {
                foreach (var item in source)
                {  
                    if (item is IPrimitiveType pt)
                    {
                        target.Add(pt.GetJsonValue());
                    }
                    else if (item is IComplexType ct)
                    {
                        var result = ct.GetJsonNode();
                        target.Add(result);
                    }
                }
            }
            return target;
        }
        #region 共用服務
        public static KeyValuePair<string, JsonNode?> ForPrimitiveType(string tagName, IPrimitiveType source)
        {
            return new KeyValuePair<string, JsonNode?>(tagName, source.GetJsonValue());
        }
        public static KeyValuePair<string, JsonNode?> ForComplexType(string tagName, IComplexType source)
        {
           
            return new KeyValuePair<string, JsonNode?>(tagName, source.GetJsonNode());
        }
        public static KeyValuePair<string, JsonNode?> ForArrayType<T>(string tagName, IEnumerable<T>? source) where T : Base
        {  

            return new KeyValuePair<string, JsonNode?>(tagName, GetJsonArray(source));
        }

        #endregion
    }
}
