using System.Collections;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Serialization;

internal static class FhirXmlWriter
{
    public static string Write(Base instance)
    {
        var settings = new XmlWriterSettings
        {
            Indent = true,
            OmitXmlDeclaration = false,
            Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false)
        };

        var sb = new StringBuilder();
        using (var writer = XmlWriter.Create(sb, settings))
        {
            if (instance is Resource resource)
                WriteResource(writer, resource, declareNamespace: true);
            else
            {
                writer.WriteStartElement(instance.TypeName, FhirXmlSerializer.FhirNamespace);
                WriteObjectContent(writer, instance, isResource: false);
                writer.WriteEndElement();
            }
        }

        return sb.ToString();
    }

    private static void WriteResource(XmlWriter writer, Resource resource, bool declareNamespace)
    {
        var name = FhirXmlReflection.GetResourceTypeName(resource);
        if (declareNamespace)
            writer.WriteStartElement(name, FhirXmlSerializer.FhirNamespace);
        else
            writer.WriteStartElement(name, FhirXmlSerializer.FhirNamespace);

        WriteObjectContent(writer, resource, isResource: true);
        writer.WriteEndElement();
    }

    private static void WriteObjectContent(XmlWriter writer, object instance, bool isResource)
    {
        if (instance is Element element && !isResource && element.Id?.StringValue is { Length: > 0 } elementId)
            writer.WriteAttributeString("id", elementId);

        if (instance is Extension extension && extension.Url?.StringValue is { Length: > 0 } url)
            writer.WriteAttributeString("url", url);

        if (instance is PrimitiveType primitive)
        {
            var lexical = FhirXmlReflection.GetPrimitiveString(primitive);
            if (!string.IsNullOrEmpty(lexical))
                writer.WriteAttributeString("value", lexical);

            WriteExtensions(writer, elementOf(instance));
            return;
        }

        var map = FhirXmlReflection.GetMap(instance.GetType());
        foreach (var property in map.ByElementName.Values)
        {
            if (ShouldSkipAsAttribute(instance, property, isResource))
                continue;

            var value = property.Property.GetValue(instance);
            if (value is null)
                continue;

            if (property.IsList)
            {
                if (value is not IEnumerable items)
                    continue;
                foreach (var item in items)
                {
                    if (item is not null)
                        WriteProperty(writer, property.ElementName, item);
                }
            }
            else
            {
                WriteProperty(writer, property.ElementName, value);
            }
        }

        if (instance is Extension extWithValue && extWithValue.Value is not null)
            WriteExtensionValue(writer, extWithValue.Value);
    }

    private static Element? elementOf(object instance) => instance as Element;

    private static bool ShouldSkipAsAttribute(object instance, FhirXmlProperty property, bool isResource)
    {
        if (property.ElementName == "value" && instance is PrimitiveType)
            return true;
        if (property.ElementName == "id" && !isResource && instance is Element)
            return true;
        if (property.ElementName == "url" && instance is Extension)
            return true;
        return false;
    }

    private static void WriteProperty(XmlWriter writer, string elementName, object value)
    {
        if (value is FhirXhtml xhtml)
        {
            WriteXhtml(writer, xhtml);
            return;
        }

        if (value is Resource resource)
        {
            writer.WriteStartElement(elementName, FhirXmlSerializer.FhirNamespace);
            WriteResource(writer, resource, declareNamespace: false);
            writer.WriteEndElement();
            return;
        }

        writer.WriteStartElement(elementName, FhirXmlSerializer.FhirNamespace);
        if (value is IExtension ext && value is not Extension)
        {
            var concrete = new Extension { Url = ext.Url, Value = ext is Extension inner ? inner.Value : null };
            WriteObjectContent(writer, concrete, isResource: false);
        }
        else
            WriteObjectContent(writer, value, isResource: false);
        writer.WriteEndElement();
    }

    private static void WriteExtensions(XmlWriter writer, Element? element)
    {
        if (element?.Extension is null)
            return;
        foreach (var ext in element.Extension)
        {
            if (ext is not null)
                WriteProperty(writer, "extension", ext);
        }
    }

    private static void WriteExtensionValue(XmlWriter writer, object value)
    {
        var fhirName = value is Resource resource
            ? FhirXmlReflection.GetResourceTypeName(resource)
            : FhirXmlReflection.ToFhirTypeName(value.GetType());
        WriteProperty(writer, "value" + fhirName, value);
    }

    private static void WriteXhtml(XmlWriter writer, FhirXhtml xhtml)
    {
        var raw = xhtml.StringValue;
        if (string.IsNullOrWhiteSpace(raw))
            return;

        try
        {
            var parsed = XElement.Parse(raw);
            using var reader = parsed.CreateReader();
            writer.WriteNode(reader, defattr: false);
        }
        catch (XmlException)
        {
            writer.WriteStartElement("div", FhirXmlSerializer.XhtmlNamespace);
            writer.WriteString(raw);
            writer.WriteEndElement();
        }
    }
}
