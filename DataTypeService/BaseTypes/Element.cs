using Core.Attribute;
using Core.ExtensionImp;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DataTypeService.BaseTypes
{
    public abstract class Element : Base
    {
        protected Element() { }
        protected Element(string? value) : this(value.Parse()) { }
        protected Element(JsonNode? source)
        {
            _JsonNode = source;
        }

        public FhirString? Id { get; set; }
        public IEnumerable<Extension>? Extension { get; set; }
        public bool HasElementValue() => Id != null || Extension != null;
        protected override string _TypeName => "Element";

        public JsonNode? GetElementProperties()
        {

            JsonObject? target = new();
            if (Id is FhirString id)
            {
                target.Add("id", id.GetJsonValue());
            }
            if (Extension is IEnumerable<Extension> extensions)
            {
                JsonArray array = new();
                foreach (var item in extensions)
                {
                    array.Add(item.GetJsonNode());
                }
                target.Add("extension", array);
            }
            else
            {
                target = null;
            }
            return target;
        }
        public void SetElementProperties(JsonNode? source)
        {
            if (source != null)
            {
                if (source["id"] != null)
                {
                    Id = new FhirString(source["id"]);
                }
                if (source["extension"]?.AsArray() is JsonArray extensionSource)
                {
                    List<Extension> result = new();
                    foreach (var item in extensionSource)
                    {
                        result.Add(new Extension(item));
                    }

                    Extension = result;
                }
            }
        }

        protected static JsonNode SetupJsonNode<T>(T source) where T : Element
        {
            JsonObject target = new();
            var properties = typeof(T).GetProperties().Where(x => x.GetCustomAttribute<ElementAttribute>()?.JsonName != "skip");
            foreach (var p in properties)
            {
                var attr = p.GetCustomAttribute<ElementAttribute>();
                var jsonName = p.Name.FirstCharToLowerCase() ?? "value";
                var value = p.GetValue(source);
                if (attr != null && attr.IsMulti)
                {
                    if (value is List<DataType> list)
                    {
                        target.Add(jsonName, GetJsonArray(list));
                        var temp = list.Where(x => x.HasElementValue());
                        if (temp != null && temp.Any())
                        {
                            target.Add("_" + jsonName, GetJsonArray(temp.Select(x => x.GetElementProperties())));
                        }
                    }
                }
                else
                {
                    if (value is IPrimitiveType pt)
                    {
                        target.Add(jsonName, pt.GetJsonValue());
                        var extensionValue = pt.GetElementProperties();
                        if (extensionValue != null)
                        {
                            target.Add("_" + jsonName, extensionValue);
                        }
                    }
                    else if (value is IComplexType ct)
                    {
                        target.Add(jsonName, ct.GetJsonNode());

                    }
                    else if (value is ChoiceBased cb)
                    {
                        target.Add(cb.GetProperty());
                    }
                }
            }
            return target;

        }
    }
}
