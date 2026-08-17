using Fhir.TypeFramework.Choices;

namespace Fhir.TypeFramework.Interop;

/// <summary>資源級 choice 存取擴充（適用於 ResourceCreator 產生的 <c>elementType</c> 屬性組）。</summary>
public static class ChoiceInteropExtensions
{
    public static object? GetChoice(this object resource, string elementName)
        => ChoiceAccessor.GetValue(resource, elementName);

    public static bool TryGetChoice(this object resource, string elementName, out object? value)
        => ChoiceAccessor.TryGetValue(resource, elementName, out value);

    public static void SetChoice(this object resource, string elementName, object? value)
        => ChoiceAccessor.SetValue(resource, elementName, value);

    public static void SetChoice(this object resource, string elementName, string typeSuffix, object? value)
        => ChoiceAccessor.SetValue(resource, elementName, typeSuffix, value);

    public static void ClearChoice(this object resource, string elementName)
        => ChoiceAccessor.Clear(resource, elementName);

    public static bool HasChoice(this object resource, string elementName)
        => ChoiceAccessor.HasValue(resource, elementName);

    public static string? GetActiveChoiceType(this object resource, string elementName)
        => ChoiceAccessor.GetActiveTypeName(resource, elementName);
}
