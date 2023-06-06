
using System.Text.Json.Nodes;
using DataTypeService.BaseTypes;
using Core.Attribute;
using DataTypeService.Primitive;
using DataTypeService.Complex;
using System.Reflection;
using Core.ExtensionImp;

namespace ResourceTypeBased
{
    public abstract class ResourceAbstract : Base
    {
        [Element("id", typeof(FhirId), true, false, false, false)]
        public FhirId? Id { get; set; }
        [Element("meta", typeof(Meta), false, false, false, false)]
        public Meta? Meta { get; set; }
        [Element("implicitRules", typeof(FhirUri), true, false, false, false)]
        public FhirUri? ImplicitRules { get; set; }
        [Element("language", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Language { get; set; }

        private JsonNode? ResourceType =>_TypeName != null? JsonValue.Create(_TypeName):JsonValue.Create("Resource");
        protected void SetResource(JsonNode source)
        {

            if (source != null)
            {
                if (source["id"] != null)
                {
                    Id = new FhirId(source["id"]);
                }
                if (source["meta"] != null)
                {
                    Meta = new Meta(source["meta"]);
                }
                if (source["implicitRules"] != null)
                {
                    ImplicitRules = new FhirUri(source["implicitRules"]);
                }
                if (source["language"] != null)
                {
                    Language = new FhirCode(source["language"]);
                }
            }
        }
        protected static JsonNode SetupJsonNode<T>(T source) where T : ResourceAbstract
        {
             var header = new KeyValuePair<string, JsonNode?>("resourceType", source.ResourceType);
            List<KeyValuePair<string, JsonNode?>> headerNodes = new()
            {
                header
            };
            JsonObject result = new(headerNodes);
            var properties = source.GetType().GetProperties().Where(x => x.GetCustomAttribute<ElementAttribute>()?.JsonName != "skip");
            foreach (var item in properties)
            {
                var attr = item.GetCustomAttribute<ElementAttribute>();
                var jsonName = item.Name.FirstCharToLowerCase() ?? "value";
                var values = item.GetValue(source);
                if (attr != null && values != null)
                {
                    if (attr.IsMulti && values is IEnumerable<DataType> valueItem)
                    {
                        result.Add(jsonName, GetJsonArray(valueItem));
                        var temp = valueItem.Where(x => x.HasElementValue());
                        if (temp != null && temp.Any())
                        {
                            result.Add("_" + jsonName, GetJsonArray(temp));
                        }
                    }
                    else if( attr.IsChoice && values is ChoiceBased cb)
                    {
                        result.Add(cb.GetProperty());
                    }
                    else
                    {
                        if (values is IPrimitiveType pType)
                        {
                            result.Add(jsonName, pType.GetJsonValue());
                            var elementValue = pType.GetElementProperties();
                            if (elementValue!= null)
                            {
                                result.Add("_" + jsonName, elementValue);
                            }
                        }
                        else if (values is IComplexType cType)
                        {
                            result.Add(jsonName, cType.GetJsonNode());
                        }
                      
                    }

                }

            }
            return result;
        }

        public abstract JsonNode? GetJsonNode();
        public abstract string? ToJsonString();
    }
}
