using FhirResourceCreator.Models;

namespace FhirResourceCreator.Generation;

/// <summary>為含 choice 元素的資源產生 partial 強型別 helper（<c>SetDeceased</c> 等）。</summary>
public static class ChoiceHelperGenerator
{
    public static string? Generate(ResourceModel model, string rootNamespace)
    {
        var name = model.ResourceName ?? throw new InvalidOperationException("Resource name missing.");
        var choices = model.Elements?
            .Where(e => e.IsChoice && e.ParentPath == name && !e.IsSkip && !string.IsNullOrEmpty(e.OriginalElementName))
            .ToList() ?? [];

        if (choices.Count == 0)
            return null;

        var groups = choices.Select(el =>
        {
            var stem = el.OriginalElementName!;
            var members = el.ChoiceTypeCodes
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .Select(code => new ChoiceEmitMember(
                    ChoiceJsonPropertyName(stem, code),
                    ToTypeSuffix(code),
                    MapChoiceClrType(code)))
                .ToList();
            return new ChoiceEmitGroup(stem, members);
        }).ToList();

        return ChoiceHelperCodeEmitter.Generate(rootNamespace, [name], groups);
    }

    private static string MapChoiceClrType(string fhirCode)
    {
        var lower = fhirCode.ToLowerInvariant();
        if (PrimitiveTypeMapper.IsPrimitiveCode(lower))
            return PrimitiveTypeMapper.ToClrTypeName(lower);
        var pascal = IdentifierUtility.ToPascalCase(fhirCode);
        return pascal switch
        {
            "Range" => "global::Fhir.TypeFramework.DataTypes.Range",
            _ => pascal
        };
    }

    private static string ChoiceJsonPropertyName(string elementName, string fhirCode)
    {
        var tail = MapChoiceClrType(fhirCode).Replace("Fhir", "").Replace("global::Fhir.TypeFramework.DataTypes.", "");
        return char.ToLowerInvariant(elementName[0]) + elementName[1..] + tail;
    }

    private static string ToTypeSuffix(string fhirCode)
        => char.ToLowerInvariant(fhirCode[0]) + fhirCode[1..];
}
