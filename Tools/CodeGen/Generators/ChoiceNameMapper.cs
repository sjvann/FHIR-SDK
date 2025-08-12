namespace CodeGen.Generators
{
    internal static class ChoiceNameMapper
    {
        public static string ToPropertySuffix(string fhirTypeCode)
        {
            return fhirTypeCode switch
            {
                "string" => "String",
                "boolean" => "Boolean",
                "integer" => "Integer",
                "dateTime" => "DateTime",
                "time" => "Time",
                "decimal" => "Decimal",
                "instant" => "Instant",
                _ => fhirTypeCode
            };
        }

        public static string ToChoicePropertyName(string baseElementPathWithX, string suffix)
        {
            // Generic: take the last segment, remove [x], PascalCase it as the prefix
            var lastDot = baseElementPathWithX.LastIndexOf('.');
            var lastSeg = lastDot >= 0 ? baseElementPathWithX.Substring(lastDot + 1) : baseElementPathWithX;
            var baseName = lastSeg.Replace("[x]", string.Empty);
            if (string.IsNullOrEmpty(baseName)) return suffix;
            var prefix = char.ToUpperInvariant(baseName[0]) + baseName.Substring(1);
            return prefix + suffix;
        }
    }
}

