using Core.Attribute;
using DataTypeService.Complex;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DataTypeService.BaseTypes
{
    public abstract class BackboneElement<T> : Element where T : Element, new()
    {
        public IEnumerable<Extension>? ModifierExtension { get; set; }
        protected BackboneElement() { }
        protected BackboneElement(string? value) : base(value) { }
        protected BackboneElement(JsonNode? source) : base(source)
        {
            SetupElementsValue(source);
        }


        private void SetupElementsValue(JsonNode? source)
        {
            var sourceType = typeof(T);
            if (sourceType != null)
            {
                var properties = sourceType.GetProperties();
                if (properties != null && properties.Any())
                {
                    foreach (var item in properties)
                    {
                        var attr = item.GetCustomAttribute<ElementAttribute>();
                        if (source != null && attr != null && attr.JsonName != null && attr.DataType != null)
                        {
                            if (attr.IsChoice)
                            {
                                var keyValue = GetChoiceValue(source?.AsObject(), attr.JsonName);
                                if (keyValue.Key != null)
                                {
                                    var choiceTypeValue = Activator.CreateInstance(typeof(ChoiceBased), keyValue.Key, keyValue.Value);
                                    item.SetValue(this, choiceTypeValue);
                                }
                            }
                            else
                            {
                                var value = source[attr.JsonName];
                                if (value != null && attr.DataType != null)
                                {
                                    if (attr.IsMulti)
                                    {
                                        JsonArray? arraySourceValue = value.AsArray();

                                        var justType = item.PropertyType.GetGenericArguments()[0];
                                        var concreteType = typeof(List<>).MakeGenericType(justType);
                                        var result = Activator.CreateInstance(concreteType);
                                        if (result != null && arraySourceValue != null)
                                        {
                                            foreach (var eachItem in arraySourceValue)
                                            {
                                                if (Activator.CreateInstance(justType, eachItem) is DataType fhirTypeValue)
                                                {
                                                    result.GetType().GetMethod("Add")?.Invoke(result, new object[] { fhirTypeValue });
                                                }
                                            }
                                        }

                                        item.SetValue(this, result);
                                    }
                                    else
                                    {
                                        var itemType = attr.DataType;
                                        if (itemType != null)
                                        {
                                            var fhirTypeValue = Activator.CreateInstance(itemType, value);
                                            if (attr.IsPrimitive)
                                            {
                                                var elementValue = source?["_" + attr.JsonName];
                                                if (fhirTypeValue != null && elementValue != null)
                                                {
                                                    var method = fhirTypeValue.GetType().GetMethod("SetElementProperties");
                                                    method?.Invoke(fhirTypeValue, new object[] { elementValue });

                                                }
                                            }
                                            item.SetValue(this, fhirTypeValue);
                                        }

                                    }

                                }

                            }


                        }
                    }

                }

            }

        }
        private static KeyValuePair<string, JsonNode?> GetChoiceValue(JsonObject? source, string jsonName)
        {
            KeyValuePair<string, JsonNode?> result = new();
            if (source != null)
            {
                foreach (var item in source.Where(item => item.Key.StartsWith(jsonName)))
                {
                    result = item;
                }
            }
            return result;

        }

    }
}
