using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Interop;

/// <summary>常用 complex 型別的流暢建構擴充。</summary>
public static class ComplexInteropExtensions
{
    public static Coding WithSystem(this Coding coding, string system)
    {
        coding.System = system.ToFhirUri();
        return coding;
    }

    public static Coding WithCode(this Coding coding, string code)
    {
        coding.Code = code.ToFhirString();
        return coding;
    }

    public static Coding WithDisplay(this Coding coding, string display)
    {
        coding.Display = display.ToFhirString();
        return coding;
    }

    public static Coding CreateCoding(string system, string code, string? display = null)
    {
        var c = new Coding { System = system.ToFhirUri(), Code = code.ToFhirString() };
        if (display is not null) c.Display = display.ToFhirString();
        return c;
    }

    public static HumanName WithText(this HumanName name, string text)
    {
        name.Text = text.ToFhirString();
        return name;
    }

    public static HumanName WithFamily(this HumanName name, string family)
    {
        name.Family = family.ToFhirString();
        return name;
    }

    public static HumanName WithGiven(this HumanName name, params string[] given)
    {
        name.Given = given.Select(g => g.ToFhirString()).ToList();
        return name;
    }

    public static HumanName CreateHumanName(string text)
        => new HumanName().WithText(text);

    public static Identifier WithSystem(this Identifier identifier, string system)
    {
        identifier.System = system.ToFhirUri();
        return identifier;
    }

    public static Identifier WithValue(this Identifier identifier, string value)
    {
        identifier.Value = value.ToFhirString();
        return identifier;
    }

    public static Reference WithReference(this Reference reference, string refValue)
    {
        reference.ReferenceValue = refValue.ToFhirString();
        return reference;
    }
}
