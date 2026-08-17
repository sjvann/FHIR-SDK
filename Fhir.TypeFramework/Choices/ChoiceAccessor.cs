namespace Fhir.TypeFramework.Choices;

/// <summary>對 ResourceCreator 產生的 choice 屬性（<c>deceasedBoolean</c> 等）提供讀寫，並確保僅一個變體有值。</summary>
public static class ChoiceAccessor
{
    public static bool HasValue(object target, string elementName)
        => GetValue(target, elementName) is not null;

    public static object? GetValue(object target, string elementName)
    {
        ArgumentNullException.ThrowIfNull(target);
        if (!ChoiceBindingCache.TryGetGroup(target.GetType(), elementName, out var group) || group is null)
            return null;

        foreach (var member in group.Members)
        {
            var value = member.Property.GetValue(target);
            if (value is not null)
                return value;
        }

        return null;
    }

    public static bool TryGetValue(object target, string elementName, out object? value)
    {
        value = GetValue(target, elementName);
        return value is not null;
    }

    /// <summary>作用中變體的 FHIR 型別尾碼（如 <c>boolean</c>、<c>dateTime</c>、<c>quantity</c>）。</summary>
    public static string? GetActiveTypeName(object target, string elementName)
    {
        ArgumentNullException.ThrowIfNull(target);
        if (!ChoiceBindingCache.TryGetGroup(target.GetType(), elementName, out var group) || group is null)
            return null;

        foreach (var member in group.Members)
        {
            if (member.Property.GetValue(target) is not null)
                return member.TypeSuffix;
        }

        return null;
    }

    public static void Clear(object target, string elementName)
    {
        ArgumentNullException.ThrowIfNull(target);
        if (!ChoiceBindingCache.TryGetGroup(target.GetType(), elementName, out var group) || group is null)
            return;

        foreach (var member in group.Members)
            member.Property.SetValue(target, null);
    }

    public static void SetValue(object target, string elementName, object? value)
    {
        ArgumentNullException.ThrowIfNull(target);
        if (value is null)
        {
            Clear(target, elementName);
            return;
        }

        if (!ChoiceBindingCache.TryGetGroup(target.GetType(), elementName, out var group) || group is null)
            throw new InvalidOperationException(
                $"Type '{target.GetType().Name}' has no choice group '{elementName}'.");

        Clear(target, elementName);

        var valueType = value.GetType();
        foreach (var member in group.Members)
        {
            if (!member.Property.PropertyType.IsInstanceOfType(value))
                continue;

            member.Property.SetValue(target, value);
            return;
        }

        throw new InvalidOperationException(
            $"No choice variant on '{elementName}' accepts {valueType.Name}.");
    }

    /// <summary>依 FHIR 型別尾碼設定 choice 變體（用於多個變體共用同一 CLR 型別時）。</summary>
    public static void SetValue(object target, string elementName, string typeSuffix, object? value)
    {
        ArgumentNullException.ThrowIfNull(target);
        ArgumentException.ThrowIfNullOrEmpty(typeSuffix);
        if (value is null)
        {
            Clear(target, elementName);
            return;
        }

        if (!ChoiceBindingCache.TryGetGroup(target.GetType(), elementName, out var group) || group is null)
            throw new InvalidOperationException(
                $"Type '{target.GetType().Name}' has no choice group '{elementName}'.");

        var member = group.Members.FirstOrDefault(m =>
            string.Equals(m.TypeSuffix, typeSuffix, StringComparison.OrdinalIgnoreCase));
        if (member is null)
            throw new InvalidOperationException(
                $"Choice '{elementName}' on '{target.GetType().Name}' has no variant '{typeSuffix}'.");

        if (!member.Property.PropertyType.IsInstanceOfType(value))
            throw new InvalidOperationException(
                $"Variant '{typeSuffix}' on '{elementName}' expects {member.Property.PropertyType.Name}, got {value.GetType().Name}.");

        Clear(target, elementName);
        member.Property.SetValue(target, value);
    }
}
