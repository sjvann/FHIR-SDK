using System.Xml.Linq;
using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Serialization;

internal static class FhirXmlReader
{
    public static T? Read<T>(string xml, IReadOnlyDictionary<string, Type>? resourceTypes)
        where T : Base
        => Read(xml, typeof(T), resourceTypes) as T;

    public static Resource? ReadResource(string xml, IReadOnlyDictionary<string, Type> resourceTypes)
        => Read(xml, typeof(Resource), resourceTypes) as Resource;

    public static Base? Read(string xml, Type expectedType, IReadOnlyDictionary<string, Type>? resourceTypes)
    {
        var doc = XDocument.Parse(xml, LoadOptions.PreserveWhitespace);
        var root = doc.Root ?? throw new InvalidOperationException("XML document has no root element.");
        return ReadElement(root, expectedType, resourceTypes, isResourceHint: typeof(Resource).IsAssignableFrom(expectedType));
    }

    private static Base? ReadElement(
        XElement element,
        Type expectedType,
        IReadOnlyDictionary<string, Type>? resourceTypes,
        bool isResourceHint)
    {
        var type = ResolveConcreteType(element, expectedType, resourceTypes, isResourceHint);
        var instance = FhirXmlReflection.CreateInstance(type);
        Populate(instance, element, resourceTypes, instance is Resource);
        return instance as Base;
    }

    private static Type ResolveConcreteType(
        XElement element,
        Type expectedType,
        IReadOnlyDictionary<string, Type>? resourceTypes,
        bool isResourceHint)
    {
        if (expectedType == typeof(IExtension) || expectedType == typeof(Extension))
            return typeof(Extension);

        if (!expectedType.IsAbstract && expectedType != typeof(Resource) && expectedType != typeof(DomainResource)
            && expectedType != typeof(Base))
            return expectedType;

        if ((isResourceHint || FhirXmlReflection.IsResource(expectedType)) && resourceTypes is not null)
        {
            var name = element.Name.LocalName;
            if (resourceTypes.TryGetValue(name, out var mapped))
                return mapped;
        }

        throw new InvalidOperationException(
            $"Cannot resolve FHIR XML element '{element.Name.LocalName}' to a concrete type for {expectedType.Name}.");
    }

    private static void Populate(
        object instance,
        XElement element,
        IReadOnlyDictionary<string, Type>? resourceTypes,
        bool isResource)
    {
        var idAttr = (string?)element.Attribute("id");
        if (idAttr is not null && instance is Element el && !isResource)
            el.Id = new FhirString(idAttr);

        if (instance is Extension ext && (string?)element.Attribute("url") is { } url)
            ext.Url = url;

        if (instance is PrimitiveType)
        {
            var valueAttr = (string?)element.Attribute("value");
            if (valueAttr is not null)
                FhirXmlReflection.SetPrimitiveString(instance, valueAttr);
        }

        var map = FhirXmlReflection.GetMap(instance.GetType());
        foreach (var child in element.Elements())
        {
            var local = child.Name.LocalName;
            if (local.Length == 0)
                continue;

            if (instance is Extension parentExt && local.StartsWith("value", StringComparison.Ordinal) && local.Length > 5)
            {
                parentExt.Value = ReadExtensionValue(child, local[5..], resourceTypes);
                continue;
            }

            if (instance is FhirXhtml)
            {
                FhirXmlReflection.SetPrimitiveString(instance, child.ToString(SaveOptions.DisableFormatting));
                continue;
            }

            if (!map.ByElementName.TryGetValue(local, out var property))
            {
                if (local == "div" && TrySetXhtml(instance, child))
                    continue;
                continue;
            }

            var item = ReadPropertyItem(child, property, resourceTypes);
            if (item is null)
                continue;

            if (property.IsList)
                FhirXmlReflection.AddToList(instance, property, item);
            else if (property.Property.CanWrite)
                property.Property.SetValue(instance, item);
        }
    }

    private static bool TrySetXhtml(object instance, XElement div)
    {
        var map = FhirXmlReflection.GetMap(instance.GetType());
        if (!map.ByElementName.TryGetValue("div", out var property))
            return false;

        var xhtml = new FhirXhtml(div.ToString(SaveOptions.DisableFormatting));
        if (property.Property.CanWrite)
            property.Property.SetValue(instance, xhtml);
        return true;
    }

    private static object? ReadPropertyItem(
        XElement element,
        FhirXmlProperty property,
        IReadOnlyDictionary<string, Type>? resourceTypes)
    {
        var itemType = property.ItemType;

        if (itemType == typeof(FhirXhtml) || property.ElementName == "div")
            return new FhirXhtml(ReadXhtml(element));

        if (FhirXmlReflection.IsResource(itemType))
        {
            var resourceElement = element.Elements().FirstOrDefault()
                                  ?? throw new InvalidOperationException(
                                      $"Nested resource element '{property.ElementName}' has no resource child.");
            var resolved = ResolveConcreteType(resourceElement, itemType, resourceTypes, isResourceHint: true);
            var resource = FhirXmlReflection.CreateInstance(resolved);
            Populate(resource, resourceElement, resourceTypes, isResource: true);
            return resource;
        }

        if (itemType == typeof(IExtension) || itemType == typeof(Extension))
        {
            var extension = new Extension();
            Populate(extension, element, resourceTypes, isResource: false);
            return extension;
        }

        var created = FhirXmlReflection.CreateInstance(itemType);
        Populate(created, element, resourceTypes, created is Resource);
        return created;
    }

    private static object? ReadExtensionValue(
        XElement element,
        string fhirTypeName,
        IReadOnlyDictionary<string, Type>? resourceTypes)
    {
        if (resourceTypes is not null && resourceTypes.TryGetValue(fhirTypeName, out var resourceType))
        {
            var resource = FhirXmlReflection.CreateInstance(resourceType);
            Populate(resource, element, resourceTypes, isResource: true);
            return resource;
        }

        var type = FhirXmlReflection.ResolveFhirType(fhirTypeName)
                   ?? throw new InvalidOperationException($"Unknown extension value type '{fhirTypeName}'.");
        var instance = FhirXmlReflection.CreateInstance(type);
        Populate(instance, element, resourceTypes, instance is Resource);
        return instance;
    }

    private static string ReadXhtml(XElement element)
    {
        if (element.Name.LocalName == "div")
            return element.ToString(SaveOptions.DisableFormatting);

        var div = element.Elements().FirstOrDefault(e => e.Name.LocalName == "div");
        return div?.ToString(SaveOptions.DisableFormatting) ?? element.ToString(SaveOptions.DisableFormatting);
    }
}
