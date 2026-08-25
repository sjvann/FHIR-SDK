using System.Xml;

namespace Fhir.Path.Evaluation;

/// <summary>官方 Narrative <c>txt-1</c>／<c>txt-2</c> 使用的 <c>htmlChecks()</c>。</summary>
internal static class XhtmlChecks
{
    private static readonly HashSet<string> ForbiddenElements = new(StringComparer.OrdinalIgnoreCase)
    {
        "script", "iframe", "object", "embed", "form", "frame", "frameset",
        "applet", "base", "link", "meta", "style"
    };

    public static bool HtmlChecks(string? xhtml)
    {
        if (string.IsNullOrWhiteSpace(xhtml))
            return false;

        XmlDocument doc;
        try
        {
            using var reader = XmlReader.Create(new StringReader(xhtml), new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Prohibit,
                XmlResolver = null,
                IgnoreComments = true
            });
            doc = new XmlDocument { XmlResolver = null };
            doc.Load(reader);
        }
        catch (XmlException)
        {
            return false;
        }

        var root = doc.DocumentElement;
        if (root is null || !root.LocalName.Equals("div", StringComparison.OrdinalIgnoreCase))
            return false;
        if (root.NamespaceURI is { Length: > 0 } ns
            && !ns.Equals("http://www.w3.org/1999/xhtml", StringComparison.Ordinal))
            return false;
        if (ContainsForbidden(root))
            return false;
        return HasNonWhitespaceText(root);
    }

    private static bool ContainsForbidden(XmlNode node)
    {
        if (node is XmlElement el)
        {
            if (ForbiddenElements.Contains(el.LocalName))
                return true;
            if (el.Attributes is not null)
            {
                foreach (XmlAttribute attr in el.Attributes)
                {
                    if (attr.LocalName.StartsWith("on", StringComparison.OrdinalIgnoreCase))
                        return true;
                    if (LooksLikeJavascriptUrl(attr.Value))
                        return true;
                }
            }
        }

        return node.ChildNodes.Cast<XmlNode>().Any(ContainsForbidden);
    }

    private static bool LooksLikeJavascriptUrl(string? value)
        => value is not null
           && value.TrimStart().StartsWith("javascript:", StringComparison.OrdinalIgnoreCase);

    private static bool HasNonWhitespaceText(XmlNode node)
        => node.ChildNodes.Cast<XmlNode>().Any(child =>
            child is XmlText or XmlCDataSection
                ? !string.IsNullOrWhiteSpace(child.Value)
                : HasNonWhitespaceText(child));
}
