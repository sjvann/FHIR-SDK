using System.Reflection;

namespace Fhir.TypeFramework.Choices;

public sealed record ChoiceMemberBinding(string JsonName, PropertyInfo Property, string TypeSuffix);

public sealed class ChoiceGroupBinding(string elementName, IReadOnlyList<ChoiceMemberBinding> members)
{
    public string ElementName { get; } = elementName;
    public IReadOnlyList<ChoiceMemberBinding> Members { get; } = members;
}
