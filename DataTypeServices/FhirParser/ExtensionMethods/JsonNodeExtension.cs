using DataTypeServices.TypeFramework;
using FhirCore.ExtensionMethods;
using FhirCore.Interfaces;
using System.Collections;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DataTypeServices.FhirParser.ExtensionMethods
{
    public static class JsonNodeExtension
    {
        #region For DataType
        public static T? ParseForFhirDataType<T>(this string value) where T : IDataType, new()
        {
            if (JsonNode.Parse(value) is JsonObject jsonObject)
            {
                return jsonObject.ParseForFhirDataType<T>();
            }
            else
            {
                return default;
            }

        }
        public static T ParseForFhirDataType<T>(this JsonNode node) where T : IDataType, new()
        {

            PropertyInfo[] propertyInfos = typeof(T).GetProperties();
            T instance = Activator.CreateInstance<T>();
            foreach (PropertyInfo property in propertyInfos)
            {
                Type propertyType = property.PropertyType;
                var propertyValue = node[property.Name.ToTitleCase(false)];

                bool? isMulti = propertyType.IsGenericType;

                if (propertyValue != null)
                {

                    if (isMulti == true && propertyType is IList)
                    {
                        var listType = typeof(List<>);
                        var genericArgs = propertyType.GetGenericArguments()[0];
                        var constructedListType = listType.MakeGenericType(genericArgs);
                        var list = Activator.CreateInstance(constructedListType);
                        if (propertyValue is JsonArray jsonArray)
                        {
                            foreach (JsonNode? item in jsonArray)
                            {
                                if (item != null)
                                {
                                    var valueType = Activator.CreateInstance(genericArgs, item);
                                    if (valueType != null && list != null)
                                    {
                                        list.GetType().GetMethod("Add")?.Invoke(list, [valueType]);
                                    }
                                }

                            }
                        }
                        property.SetValue(instance, list);
                    }
                    else
                    {
                        var propertyInstance = Activator.CreateInstance(propertyType, propertyValue);
                        bool? isPrimitive = (bool?)propertyType.GetMethod("IsPrimitive")?.Invoke(propertyInstance, null);
                        if (isPrimitive == true && node[$"_{property.Name.ToTitleCase(false)}"] is JsonObject elementObject)
                        {
                            ElementImp elementValue = new(elementObject);
                            propertyType.GetMethod("SetElementValue")?.Invoke(propertyInstance, [elementValue]);
                        }
                        property.SetValue(instance, propertyInstance);
                    }

                }
            }
            return instance;
        }
        #endregion

        #region For Resource


        #endregion
    }
}

