using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using FhirCore.ExtensionMethods;
using FhirCore.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Nodes;
using ExtensionType = DataTypeServices.DataTypes.SpecialTypes.Extension;

namespace DataTypeServices.TypeFramework
{
    /// <summary>
    /// FHIR 元素基礎類別
    /// 
    /// <para>
    /// 此類別已經優化並整合到新的架構中，繼續提供穩定的基礎功能。
    /// </para>
    /// </summary>
    public abstract class Element : Base, IElement, INotifyPropertyChanged
    {
        #region Constructors
        protected Element() { }
        protected Element(JsonNode? value)
        {
            InitPropertyFromJsonNode(value);
        }
        protected Element(string value) : this(JsonNode.Parse(value)) { }
        #endregion
        #region Properties
        private FhirString? _id;
        public FhirString? Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged("Id", value);
                }
            }
        }
        private List<ExtensionType>? _extension;
        public List<ExtensionType>? Extension
        {
            get => _extension;
            set
            {
                if (_extension != value)
                {
                    _extension = value;
                    OnPropertyChanged("extension", value);
                }
            }
        }

        #endregion
        #region Public Methods
        public static Element? GetElementObject(JsonObject? source)
        {
            if (source == null || source.Count == 0) return null;
            return new ElementImp(source);

        }
        public string GetElementString()
        {
            var properties = GetProperties();
            JsonObject jObject = new(properties);
            return jObject.SerializeCustom();
        }
        #endregion
        #region Private Methods
        private void InitPropertyFromJsonNode(JsonNode? value)
        {

            List<KeyValuePair<string, JsonNode?>> properties = new List<KeyValuePair<string, JsonNode?>>();
            if (value == null) return;

            if (value is JsonObject jObject)
            {
                if (jObject["id"] is JsonValue id)
                {
                    string temp = id.GetValue<string>();
                    Id = new FhirString(temp);
                    properties.Add(new KeyValuePair<string, JsonNode?>("id", Id.GetJsonValue()));
                }
                if (jObject["extension"] is JsonArray jArray)
                {
                    List<ExtensionType> extensions = [];
                    foreach (JsonNode? item in jArray)
                    {
                        if (item is JsonObject extension)
                        {
                            var ext = new ExtensionType(extension);
                            extensions.Add(ext);
                        }
                    }
                    Extension = extensions;
                    properties.Add(new KeyValuePair<string, JsonNode?>("extension", Extension.GetJsonValue()));
                }
            }
        }
        #endregion

        public virtual KeyValuePair<string, JsonNode?>[] GetProperties()
        {
            List<KeyValuePair<string, JsonNode?>> properties = new List<KeyValuePair<string, JsonNode?>>();
            if (Id != null)
            {
                properties.Add(new KeyValuePair<string, JsonNode?>("id", Id.GetJsonValue()));
            }
            if (Extension != null)
            {
                properties.Add(new KeyValuePair<string, JsonNode?>("extension", Extension.GetJsonValue()));
            }
            return properties.ToArray();
        }

        public virtual void OnPropertyChanged(string propertyName, object? newValue)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        #region IElement Implementation

        /// <summary>
        /// 設定元素值
        /// </summary>
        /// <param name="value">要設定的 JSON 節點值</param>
        public virtual void SetElementValue(JsonNode? value)
        {
            InitPropertyFromJsonNode(value);
        }

        /// <summary>
        /// 獲取元素值
        /// </summary>
        /// <returns>元素的 JSON 節點值</returns>
        public virtual JsonNode? GetElementValue()
        {
            var properties = GetProperties();
            if (properties == null || properties.Length == 0)
                return null;

            return new JsonObject(properties);
        }

        #endregion
    }


}
