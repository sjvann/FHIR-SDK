using Core.Attribute;
using Core.Extension;
using DataTypeService.Models;
using System.Reflection;
using System.Text;
using System.Text.Json.Nodes;

namespace DataTypeService.BaseTypes
{
    public abstract class Element<T> : Element where T : Element
    {
        protected Element() { }
        protected Element(string? value) : base(value) { }
        protected Element(JsonNode? source) : base(source) { }
        protected static void SetupExtension(JsonNode? cv, ref T target)
        {
            var tSource = cv?.AsObject();
            if (tSource != null)
            {
                target.Id = new FhirString(tSource["id"]);
                target.Extension = tSource["extension"]?.AsArray().Select(x => new Extension(x));
            }
        }
        protected static void SetupExtensions(JsonNode? cv, ref IEnumerable<T> targets)
        {
            var tSource = cv?.AsArray();
            int index = 0;
            foreach (var item in targets)
            {
                var itemSource = tSource?[index];
                item.Id = new FhirString(itemSource?["id"]);
                item.Extension = itemSource?["extension"]?.AsArray().Select(x => new Extension(x));
                index++;
            }
        }
        
        //protected void SetElement(JsonNode? source)
        //{
        //    if (source != null)
        //    {
        //        var properties = typeof(T).GetProperties().Where(x => x.GetCustomAttribute<ElementAttribute>()?.JsonName != "skip");
        //        foreach (var p in properties)
        //        {
        //            var attr = p.GetCustomAttribute<ElementAttribute>();
        //            var jsonName = p.Name.FirstCharToLowerCase() ?? "value";
        //            var value = p.GetValue(this);
        //            if (attr != null && attr.IsMulti)
        //            {
        //                if (value is List<DataType> list)
        //                {
        //                    SetupExtensions(source[jsonName], ref list);
        //                }
        //            }
        //            else
        //            {
        //                if (value is IPrimitiveType pt)
        //                {
        //                    pt.SetJsonValue(source[jsonName]);
        //                    var extensionValue = source["_" + jsonName];
        //                    if (extensionValue != null)
        //                    {
        //                        pt.SetExtension(extensionValue);
        //                    }
        //                }
        //                else if (value is IComplexType ct)
        //                {
        //                    ct.SetJsonNode(source[jsonName]);
        //                    var extensionValue = source["_" + jsonName];
        //                    if (extensionValue != null)
        //                    {
        //                        ct.SetExtension(extensionValue);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        //protected static void SetupElemments<T>(JsonNode? source) where T : Element
        //{
        //    if (source != null)
        //    {
        //        var properties = typeof(T).GetProperties().Where(x => x.GetCustomAttribute<ElementAttribute>()?.JsonName != "skip");
        //        foreach (var p in properties)
        //        {
        //            var attr = p.GetCustomAttribute<ElementAttribute>();
        //            var jsonName = p.Name.FirstCharToLowerCase() ?? "value";
        //            var value = p.GetValue(this);
        //            if (attr != null && attr.IsMulti)
        //            {
        //                if (value is List<DataType> list)
        //                {
        //                    SetupExtensions(source[jsonName], ref list);
        //                }
        //            }
        //            else
        //            {
        //                if (value is IPrimitiveType pt)
        //                {
        //                    pt.SetJsonValue(source[jsonName]);
        //                    var extensionValue = source["_" + jsonName];
        //                }
        //            }
        //        }
        //    }
        //}
    }

}
