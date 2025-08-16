using CodeGen.Models;

namespace CodeGen.Services;

public interface IPropertyEmitter
{
    string Emit(string elementPath, string csType, string propName, IReadOnlyDictionary<string, Cardinality> cards);
    string EmitClr(string elementPath, string csType, string propName, IReadOnlyDictionary<string, Cardinality> cards);
    string EmitClrBackbone(string elementPath, string csType, string propName, IReadOnlyDictionary<string, Cardinality> cards);
    string EmitChoice(string baseElementPathWithX, string csType, string propName, IReadOnlyDictionary<string, Cardinality> cards);
    string EmitChoiceWithMutex(string baseElementPathWithX, string csType, string propName, IReadOnlyDictionary<string, Cardinality> cards, IReadOnlyList<string> allChoicePropNames);
    string EmitChoiceWithMutexBackbone(string baseElementPathWithX, string csType, string propName, IReadOnlyDictionary<string, Cardinality> cards, IReadOnlyList<string> allChoicePropNames);
}

public sealed class PropertyEmitter : IPropertyEmitter
{
    private static string ToJsonName(string propName)
    {
        if (string.IsNullOrEmpty(propName)) return propName;
        return char.ToLowerInvariant(propName[0]) + propName.Substring(1);
    }

    public string Emit(string elementPath, string csType, string propName, IReadOnlyDictionary<string, Cardinality> cards)
    {
        cards.TryGetValue(elementPath, out var c);
        c ??= Cardinality.Optional;
        var jsonName = ToJsonName(propName);
        var field = $"_{char.ToLowerInvariant(propName[0])}{propName.Substring(1)}";

        if (c.IsList)
        {
            if (c.IsRequired)
            {
                return $"private List<{csType}> {field} = new();\n        public List<{csType}> {propName} {{ get => {field}; set {{ {field} = value; OnPropertyChanged(\"{jsonName}\", value); }} }}";
            }
            else
            {
                return $"private List<{csType}>? {field};\n        public List<{csType}>? {propName} {{ get => {field}; set {{ {field} = value; OnPropertyChanged(\"{jsonName}\", value); }} }}";
            }
        }
        else
        {
            if (c.IsRequired)
            {
                // Note: cannot use 'required' with custom setter; enforce via validation elsewhere if needed
                return $"private {csType}? {field};\n        public {csType} {propName} {{ get => {field} ?? throw new InvalidOperationException(\"{propName} is required\"); set {{ {field} = value; OnPropertyChanged(\"{jsonName}\", value); }} }}";
            }
            else
            {
                return $"private {csType}? {field};\n        public {csType}? {propName} {{ get => {field}; set {{ {field} = value; OnPropertyChanged(\"{jsonName}\", value); }} }}";
            }
        }
    }

    public string EmitClr(string elementPath, string csType, string propName, IReadOnlyDictionary<string, Cardinality> cards)
    {
        cards.TryGetValue(elementPath, out var c);
        c ??= Cardinality.Optional;
        var jsonName = ToJsonName(propName);
        var field = $"_{char.ToLowerInvariant(propName[0])}{propName.Substring(1)}";

        if (c.IsList)
        {
            if (c.IsRequired)
            {
                return $"private List<{csType}> {field} = new();\n        [JsonPropertyName(\"{jsonName}\")]\n        public List<{csType}> {propName} {{ get => {field}; set {{ {field} = value; OnPropertyChangedByClr(nameof({propName}), value); }} }}";
            }
            else
            {
                return $"private List<{csType}>? {field};\n        [JsonPropertyName(\"{jsonName}\")]\n        public List<{csType}>? {propName} {{ get => {field}; set {{ {field} = value; OnPropertyChangedByClr(nameof({propName}), value); }} }}";
            }
        }
        else
        {
            if (c.IsRequired)
            {
                // Note: cannot use 'required' with custom setter; enforce via validation elsewhere if needed
                return $"private {csType}? {field};\n        [JsonPropertyName(\"{jsonName}\")]\n        public {csType} {propName} {{ get => {field} ?? throw new InvalidOperationException(\"{propName} is required\"); set {{ {field} = value; OnPropertyChangedByClr(nameof({propName}), value); }} }}";
            }
            else
            {
                return $"private {csType}? {field};\n        [JsonPropertyName(\"{jsonName}\")]\n        public {csType}? {propName} {{ get => {field}; set {{ {field} = value; OnPropertyChangedByClr(nameof({propName}), value); }} }}";
            }
        }
    }

    public string EmitChoice(string baseElementPathWithX, string csType, string propName, IReadOnlyDictionary<string, Cardinality> cards)
    {
        // Choice follows the same cardinality as the [x] element
        return Emit(baseElementPathWithX, csType, propName, cards);
    }

    public string EmitClrBackbone(string elementPath, string csType, string propName, IReadOnlyDictionary<string, Cardinality> cards)
    {
        cards.TryGetValue(elementPath, out var c);
        c ??= Cardinality.Optional;
        var jsonName = ToJsonName(propName);
        var field = $"_{char.ToLowerInvariant(propName[0])}{propName.Substring(1)}";

        if (c.IsList)
        {
            if (c.IsRequired)
            {
                return $"private List<{csType}> {field} = new();\n        [JsonPropertyName(\"{jsonName}\")]\n        public List<{csType}> {propName} {{ get => {field}; set {{ {field} = value; }} }}";
            }
            else
            {
                return $"private List<{csType}>? {field};\n        [JsonPropertyName(\"{jsonName}\")]\n        public List<{csType}>? {propName} {{ get => {field}; set {{ {field} = value; }} }}";
            }
        }
        else
        {
            if (c.IsRequired)
            {
                return $"private {csType}? {field};\n        [JsonPropertyName(\"{jsonName}\")]\n        public {csType} {propName} {{ get => {field} ?? throw new InvalidOperationException(\"{propName} is required\"); set {{ {field} = value; }} }}";
            }
            else
            {
                return $"private {csType}? {field};\n        [JsonPropertyName(\"{jsonName}\")]\n        public {csType}? {propName} {{ get => {field}; set {{ {field} = value; }} }}";
            }
        }
    }

    public string EmitChoiceWithMutex(string baseElementPathWithX, string csType, string propName, IReadOnlyDictionary<string, Cardinality> cards, IReadOnlyList<string> allChoicePropNames)
    {
        cards.TryGetValue(baseElementPathWithX, out var c);
        c ??= Cardinality.Optional;
        var jsonName = ToJsonName(propName);
        var field = $"_{char.ToLowerInvariant(propName[0])}{propName.Substring(1)}";

        var clearOthers = new System.Text.StringBuilder();
        clearOthers.Append("if (value != null) { ");
        foreach (var other in allChoicePropNames)
        {
            if (string.Equals(other, propName, System.StringComparison.Ordinal)) continue;
            clearOthers.Append($"_{char.ToLowerInvariant(other[0])}{other.Substring(1)} = null; OnPropertyChangedByClr(nameof({other}), null); ");
        }
        clearOthers.Append("}");
        var clearStr = clearOthers.ToString().Replace("{", "{{").Replace("}", "}}");

        return $"private {csType}? {field};\n        [JsonPropertyName(\"{jsonName}\")]\n        public {csType}? {propName} {{ get => {field}; set {{ {field} = value; {clearStr}; OnPropertyChangedByClr(nameof({propName}), value); }} }}";
    }

    public string EmitChoiceWithMutexBackbone(string baseElementPathWithX, string csType, string propName, IReadOnlyDictionary<string, Cardinality> cards, IReadOnlyList<string> allChoicePropNames)
    {
        cards.TryGetValue(baseElementPathWithX, out var c);
        c ??= Cardinality.Optional;
        var jsonName = ToJsonName(propName);
        var field = $"_{char.ToLowerInvariant(propName[0])}{propName.Substring(1)}";

        var clearOthers = new System.Text.StringBuilder();
        clearOthers.Append("if (value != null) { ");
        foreach (var other in allChoicePropNames)
        {
            if (string.Equals(other, propName, System.StringComparison.Ordinal)) continue;
            var otherJson = ToJsonName(other);
            clearOthers.Append($"_{char.ToLowerInvariant(other[0])}{other.Substring(1)} = null; OnPropertyChanged(\"{otherJson}\", null); ");
        }
        clearOthers.Append("}");
        var clearStr = clearOthers.ToString().Replace("{", "{{").Replace("}", "}}");

        return $"private {csType}? {field};\n        [JsonPropertyName(\"{jsonName}\")]\n        public {csType}? {propName} {{ get => {field}; set {{ {field} = value; {clearStr}; OnPropertyChanged(\"{jsonName}\", value); }} }}";
    }

}
