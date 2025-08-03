using FhirCore.ExtensionMethods;
using FhirCore.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeServices.TypeFramework
{
    public class BackboneElementType<T> : BackboneElement<T> where T : BackboneElement<T>, new()
    {
        public override string GetFhirTypeName(bool withCapital = true) => typeof(T).Name.ToTitleCase(withCapital);
        protected BackboneElementType() { }
        protected BackboneElementType(JsonObject? value)
        {
            if (value is JsonObject jObject)
            {
                SetupPropertyValue(jObject);
                _Properties = InitProperty(value);
            }
        }
        protected BackboneElementType(string value) : this(JsonNode.Parse(value) as JsonObject) { }
        public virtual JsonNode? GetJsonObject()
        {
            if (_Properties != null && _Properties.Count > 0)
            {
                JsonObject jObject = new();
                foreach (var item in _Properties)
                {
                    jObject.Add(item.Key, item.Value?.DeepClone());
                }
                return jObject;
            }
            else
            {
                return SetupJsonObject(this);
            }
        }
        #region Private Method
        private static JsonObject? SetupJsonObject(BackboneElement<T> source)
        {
            var propertyInfos = SetupPropertyValue((T)source);
            if (propertyInfos == null || propertyInfos.Count == 0) return null;
            JsonObject jObject = new(propertyInfos);
            return jObject;
        }
        private static List<KeyValuePair<string, JsonNode?>>? SetupPropertyValue(T source)
        {
            if (source == null) return null;
            List<KeyValuePair<string, JsonNode?>> target = [];
            var propertyInfos = typeof(T).GetProperties();
            foreach (var propertyInfo in propertyInfos)
            {
                var propertyType = propertyInfo.PropertyType;
                var propertyValue = propertyInfo.GetValue(source);
                bool isMulti = propertyType.IsGenericType;
                if (propertyValue != null)
                {
                    bool? isPrimitive = propertyType.GetMethod("IsPrimitive")?.Invoke(propertyValue, null) as bool?;
                    bool? isChoice = propertyType.GetMethod("IsChoiceType")?.Invoke(propertyValue, null) as bool?;

                    if (isMulti && propertyValue is IList)
                    {
                        JsonArray jArray = [];
                        foreach (var item in (IEnumerable)propertyValue)
                        {
                            if (item is IPrimitiveType primitiveValue)
                            {
                                jArray.Add(primitiveValue.GetJsonValue());
                                if (primitiveValue.HasElement())
                                {
                                    jArray.Add(primitiveValue.GetElementJsonObject());
                                }
                            }
                            else if (item is IComplexType complexValue)
                            {
                                jArray.Add(complexValue.GetJsonObject());
                            }
                            else if (item is ChoiceType choiceValue)
                            {
                                jArray.Add(choiceValue.GetProperty());
                            }
                        }
                        target.Add(new KeyValuePair<string, JsonNode?>(propertyInfo.Name.ToTitleCase(false), jArray));
                    }
                    else if (isPrimitive == true)
                    {
                        IPrimitiveType? primitiveValue = propertyValue as IPrimitiveType;
                        target.Add(new KeyValuePair<string, JsonNode?>(propertyInfo.Name.ToTitleCase(false), primitiveValue?.GetJsonValue()));
                        if (primitiveValue?.HasElement() == true)
                        {
                            var coneElement = primitiveValue.GetElementJsonString();
                            target.Add(new KeyValuePair<string, JsonNode?>($"_{propertyInfo.Name.ToTitleCase(false)}", JsonNode.Parse(coneElement)));
                        }
                    }
                    else if (isChoice == true && propertyValue is ChoiceType pv)
                    {
                        var key = pv.GetCurrentKeyName();
                        var value = pv.GetCurrentValueNode()?.DeepClone();
                        if (key != null && value != null)
                        {
                            target.Add(new KeyValuePair<string, JsonNode?>(key, value));
                        }
                    }
                    else
                    {
                        IComplexType? complexValue = propertyValue as IComplexType;
                        var newJsonNode = complexValue?.GetJsonObject()?.DeepClone();
                        target.Add(new KeyValuePair<string, JsonNode?>(propertyInfo.Name.ToTitleCase(false), newJsonNode));
                    }
                }
            }
            return target;
        }
        private void SetupPropertyValue(JsonObject dataSource)
        {
            if (dataSource == null) return;
            Type sourceType = typeof(T);

            PropertyInfo[] propertyInfos = sourceType.GetProperties();
            foreach (PropertyInfo property in propertyInfos)
            {
                var propertyName = property.Name.ToTitleCase(false);
                var propertyType = property.PropertyType;
                var propertyValue = dataSource[propertyName]??dataSource.FirstOrDefault(x=>x.Key.StartsWith(propertyName)).Value;
                var elementValue = dataSource["_" + propertyName];
                if (propertyType.IsGenericType && propertyType.Name == "List`1" && propertyValue is JsonArray jArray)
                {
                    //處理[0..*]與[1..*]的情況
                    var listDataType = propertyType.GetGenericArguments()[0];
                    if (listDataType == null) continue;
                    if (listDataType.IsSubclassOf(typeof(ChoiceType)))
                    {
                        var choiceValue = new List<ChoiceType>();
                        foreach (var item in jArray)
                        {
                            var instance = (ChoiceType?)Activator.CreateInstance(listDataType, [item]);
                            if (instance != null)
                            {
                                choiceValue.Add(instance);
                            }
                        }
                        property.SetValue(this, choiceValue);
                    }
                    else if (listDataType.IsSubclassOf(typeof(BackboneElement)))
                    {
                        var listType = typeof(List<>).MakeGenericType(listDataType);
                        if (listType == null) continue;
                        var backboneValue = Activator.CreateInstance(listType);

                        foreach (var item in jArray)
                        {
                            var instance = Activator.CreateInstance(listDataType, [item]);
                            if (instance != null)
                            {
                                listType.GetMethod("Add")?.Invoke(backboneValue, [instance]);
                            }
                        }
                        property.SetValue(this, backboneValue);
                    }
                    else
                    {

                        var listType = typeof(List<>).MakeGenericType(listDataType);
                        if (listType == null) continue;
                        var listTargetValue = Activator.CreateInstance(listType);
                        foreach (var item in jArray)
                        {
                            var instance = Activator.CreateInstance(listDataType, [item]);
                            if (instance != null)
                            {
                                listType.GetMethod("Add")?.Invoke(listTargetValue, [instance]);
                            }
                        }
                        property.SetValue(this, listTargetValue);
                    }
                }
                else if(propertyValue != null )
                {
                    //處理[0..1]與[1..1]的情況
                    if (propertyType.IsSubclassOf(typeof(ChoiceType)))
                    {
                        string prefix = property.Name.ToTitleCase(true);
                        var choice = Activator.CreateInstance(propertyType, [prefix, propertyValue]);
                        property.SetValue(this, choice);
                    }
                    else if (propertyType.IsSubclassOf(typeof(BackboneElement)))
                    {
                        var instance = Activator.CreateInstance(propertyType, [propertyValue]);
                        property.SetValue(this, instance);
                    }
                    else if (propertyType.IsSubclassOf(typeof(DataType)) && propertyValue != null)
                    {

                        if (propertyType.GetInterface("IPrimitiveType") != null)

                        {
                            if (elementValue != null)
                            {
                                Element? element = new ElementImp(elementValue as JsonObject);
                                var primitive = Activator.CreateInstance(propertyType, [propertyValue, element]);
                                property.SetValue(this, primitive);
                            }
                            else
                            {
                                var primitive = Activator.CreateInstance(propertyType, propertyValue);
                                property.SetValue(this, primitive);
                            }
                        }
                        else
                        {
                            var complex = Activator.CreateInstance(propertyType, propertyValue);
                            property.SetValue(this, complex);
                        }
                    }
                }
               
            }

        }
        private static List<KeyValuePair<string, JsonNode?>> InitProperty(JsonObject? dataSource)
        {
            List<KeyValuePair<string, JsonNode?>> properties = new List<KeyValuePair<string, JsonNode?>>();
            if (dataSource == null) return properties;
            foreach (var item in dataSource)
            {
                properties.Add(new KeyValuePair<string, JsonNode?>(item.Key, item.Value));
            }
            return properties;
        }
        #endregion
    }
}