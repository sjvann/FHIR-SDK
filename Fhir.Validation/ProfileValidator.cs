using Fhir.Path;
using Fhir.Path.Abstractions;
using Fhir.Path.Navigation;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.Validation;

public sealed class ProfileValidator : IProfileValidator
{
    private readonly ProfileCatalog _catalog;
    private readonly ProfileValidationOptions _defaults;

    public ProfileValidator(ProfileCatalog catalog, ProfileValidationOptions? defaults = null)
    {
        _catalog = catalog;
        _defaults = defaults ?? new ProfileValidationOptions();
    }

    public ProfileValidationReport Validate(
        Base instance,
        IReadOnlyList<string> profileCanonicals,
        ProfileValidationOptions? options = null)
    {
        var opts = options ?? _defaults;
        var issues = new List<ProfileValidationIssue>();
        var canonicals = MergeCanonicals(instance, profileCanonicals, opts);

        if (canonicals.Count == 0)
            return new ProfileValidationReport(true, issues);

        foreach (var canonical in canonicals)
        {
            if (!_catalog.TryGetProfile(canonical, out var snapshot))
            {
                issues.Add(new ProfileValidationIssue(
                    "error",
                    "structure",
                    $"Profile '{canonical}' is not in the catalog.",
                    null));
                continue;
            }

            ValidateAgainstSnapshot(instance, snapshot, opts, issues);
        }

        var failed = issues.Exists(i => i.Severity is "error" or "fatal");
        return new ProfileValidationReport(!failed, issues);
    }

    private void ValidateAgainstSnapshot(
        Base instance,
        ProfileSnapshot snapshot,
        ProfileValidationOptions options,
        List<ProfileValidationIssue> issues)
    {
        foreach (var element in snapshot.Elements)
        {
            var path = element.Path?.StringValue;
            if (string.IsNullOrEmpty(path))
                continue;

            // Official snapshots keep slice entries on the unsliced path (Patient.extension
            // + sliceName=race, max=1). Colon paths (Patient.extension:race) are the other
            // style. Neither may cap the whole list — that belongs to CheckSlicing.
            if (IsSliceDefinition(element, path))
                continue;
            if (!string.IsNullOrEmpty(element.SliceName?.StringValue))
                continue;

            var nodes = InstancePathWalker.Select(instance, path);
            CheckCardinality(instance, element, path, issues);
            CheckTypes(element, path, nodes, issues);
            CheckBinding(element, path, nodes, options, issues);
            if (options.EvaluateFixedPattern && !IsChildOfSlicedElement(snapshot, path))
                CheckFixedPattern(element, path, nodes, issues);

            if (options.EvaluateSlicing && element.Slicing is not null)
                CheckSlicing(instance, snapshot, element, path, nodes, issues);
        }

        if (options.EvaluateInvariants && options.PathEngine is not null)
            CheckInvariants(instance, snapshot, options.PathEngine, issues);
    }

    private static List<string> MergeCanonicals(
        Base instance,
        IReadOnlyList<string> profileCanonicals,
        ProfileValidationOptions options)
    {
        var list = new List<string>();
        foreach (var c in profileCanonicals)
        {
            if (!string.IsNullOrWhiteSpace(c) && !list.Contains(c, StringComparer.Ordinal))
                list.Add(c);
        }

        if (!options.IncludeMetaProfile || instance is not Resource resource || resource.Meta?.Profile is null)
            return list;

        foreach (var profile in resource.Meta.Profile)
        {
            var url = profile.StringValue;
            if (!string.IsNullOrWhiteSpace(url) && !list.Contains(url, StringComparer.Ordinal))
                list.Add(url);
        }

        return list;
    }

    private static void CheckFixedPattern(
        ElementDefinition element,
        string path,
        IReadOnlyList<IFhirNode> nodes,
        List<ProfileValidationIssue> issues)
    {
        foreach (var (kind, expected) in CollectFixedOrPattern(element))
        {
            foreach (var node in nodes)
            {
                if (MatchesFixedOrPattern(node, expected))
                    continue;
                issues.Add(new ProfileValidationIssue(
                    "error",
                    kind,
                    $"Element '{path}' does not match {kind} value.",
                    path));
            }
        }
    }

    private static IEnumerable<(string Kind, object Expected)> CollectFixedOrPattern(ElementDefinition element)
    {
        if (element.FixedCode is not null) yield return ("fixed", element.FixedCode);
        if (element.FixedUri is not null) yield return ("fixed", element.FixedUri);
        if (element.FixedString is not null) yield return ("fixed", element.FixedString);
        if (element.FixedBoolean is not null) yield return ("fixed", element.FixedBoolean);
        if (element.FixedInteger is not null) yield return ("fixed", element.FixedInteger);
        if (element.PatternCoding is not null) yield return ("pattern", element.PatternCoding);
        if (element.PatternCodeableConcept is not null) yield return ("pattern", element.PatternCodeableConcept);
        if (element.PatternString is not null) yield return ("pattern", element.PatternString);
    }

    private static bool MatchesFixedOrPattern(IFhirNode node, object expected)
    {
        if (expected is PrimitiveType prim)
        {
            var actual = node.GetValue()?.ToString();
            return string.Equals(actual, prim.GetType().GetProperty("StringValue")?.GetValue(prim) as string, StringComparison.Ordinal);
        }

        if (expected is Coding coding)
        {
            var code = node.Children("code").FirstOrDefault()?.GetValue()?.ToString()
                       ?? node.GetValue()?.ToString();
            return coding.Code?.StringValue is null
                   || string.Equals(code, coding.Code.StringValue, StringComparison.Ordinal);
        }

        if (expected is CodeableConcept cc && cc.Coding is { Count: > 0 })
        {
            var expectedCode = cc.Coding[0].Code?.StringValue;
            var codes = node.Children("coding")
                .Select(c => c.Children("code").FirstOrDefault()?.GetValue()?.ToString())
                .ToList();
            if (codes.Count == 0)
                codes.Add(node.Children("code").FirstOrDefault()?.GetValue()?.ToString());
            return expectedCode is null || codes.Contains(expectedCode);
        }

        return true;
    }

    private static bool IsSliceDefinition(ElementDefinition element, string path)
        => path.Contains(':', StringComparison.Ordinal)
           || !string.IsNullOrWhiteSpace(element.SliceName?.StringValue);

    /// <summary>
    /// 切片子元素的 pattern／fixed 只屬於各 slice（由 <see cref="CheckSlicing"/> 比對），
    /// 不可套到整份清單（例如兩個 Observation.component 各有不同 LOINC）。
    /// </summary>
    private static bool IsChildOfSlicedElement(ProfileSnapshot snapshot, string path)
    {
        var lastDot = path.LastIndexOf('.');
        if (lastDot < 0)
            return false;
        var parent = path[..lastDot];
        return snapshot.Elements.Any(e =>
            string.Equals(e.Path?.StringValue, parent, StringComparison.Ordinal)
            && e.Slicing is not null);
    }

    private static void CheckCardinality(
        Base instance,
        ElementDefinition element,
        string path,
        List<ProfileValidationIssue> issues)
    {
        var lastDot = path.LastIndexOf('.');
        if (lastDot < 0)
        {
            AddCardinalityIssues(element, path, 1, issues);
            return;
        }

        var parents = InstancePathWalker.Select(instance, path[..lastDot]);
        var childName = path[(lastDot + 1)..];
        foreach (var parent in parents)
            AddCardinalityIssues(element, path, InstancePathWalker.Children(parent, childName).Count, issues);
    }

    private static void AddCardinalityIssues(
        ElementDefinition element,
        string path,
        int count,
        List<ProfileValidationIssue> issues)
    {
        var min = (int)(element.Min?.Value ?? 0);
        if (count < min)
        {
            issues.Add(new ProfileValidationIssue(
                "error",
                "required",
                $"Element '{path}' requires at least {min} value(s) but found {count}.",
                path));
        }

        var maxText = element.Max?.StringValue;
        if (!string.IsNullOrEmpty(maxText) && maxText != "*" && int.TryParse(maxText, out var max) && count > max)
        {
            issues.Add(new ProfileValidationIssue(
                "error",
                "max",
                $"Element '{path}' allows at most {max} value(s) but found {count}.",
                path));
        }
    }

    private static void CheckTypes(
        ElementDefinition element,
        string path,
        IReadOnlyList<IFhirNode> nodes,
        List<ProfileValidationIssue> issues)
    {
        if (element.Type is not { Count: > 0 })
            return;

        var allowed = element.Type
            .Select(t => t.Code?.StringValue)
            .Where(c => !string.IsNullOrEmpty(c))
            .Select(c => c!)
            .ToHashSet(StringComparer.OrdinalIgnoreCase);

        if (allowed.Count == 0)
            return;

        foreach (var node in nodes)
        {
            var actual = InstancePathWalker.FhirTypeName(node);
            if (actual is null)
                continue;
            if (FhirTypeCompatibility.IsCompatible(actual, allowed)
                || allowed.Contains("Element")
                || allowed.Contains("BackboneElement"))
                continue;
            if (allowed.Contains("Resource") && node.Native is Resource)
                continue;

            issues.Add(new ProfileValidationIssue(
                "error",
                "type",
                $"Element '{path}' has type '{actual}' which is not one of: {string.Join(", ", allowed)}.",
                path));
        }
    }

    private void CheckBinding(
        ElementDefinition element,
        string path,
        IReadOnlyList<IFhirNode> nodes,
        ProfileValidationOptions options,
        List<ProfileValidationIssue> issues)
    {
        var valueSet = element.Binding?.ValueSet?.StringValue;
        if (string.IsNullOrEmpty(valueSet) || nodes.Count == 0)
            return;

        var terminology = options.Terminology ?? new CatalogTerminologyService(_catalog);
        var inCatalog = _catalog.TryGetValueSet(valueSet, out var expansion);
        if (!inCatalog && options.Terminology is null)
        {
            issues.Add(new ProfileValidationIssue(
                "warning",
                "binding",
                $"ValueSet '{valueSet}' is not in the catalog; binding was not fully checked.",
                path));
            return;
        }

        if (inCatalog && expansion.Codes.Count == 0 && options.Terminology is null)
        {
            issues.Add(new ProfileValidationIssue(
                "warning",
                "binding",
                $"ValueSet '{valueSet}' has no enumerated concepts; binding was not fully checked.",
                path));
            return;
        }

        var strength = element.Binding?.Strength?.StringValue;
        var failSeverity = string.Equals(strength, "extensible", StringComparison.OrdinalIgnoreCase)
                           || string.Equals(strength, "preferred", StringComparison.OrdinalIgnoreCase)
                           || string.Equals(strength, "example", StringComparison.OrdinalIgnoreCase)
            ? "warning"
            : "error";

        var warnedIncomplete = false;
        foreach (var (system, code) in CollectCodes(nodes))
        {
            var result = terminology.ValidateCode(system, code, valueSet);
            if (!result.Ok)
            {
                issues.Add(new ProfileValidationIssue(
                    failSeverity,
                    "binding",
                    result.Diagnostics ?? $"Code '{ProfileCatalog.FormatCode(system, code)}' failed binding to '{valueSet}'.",
                    path));
                continue;
            }

            if (warnedIncomplete || string.IsNullOrEmpty(result.Diagnostics))
                continue;
            warnedIncomplete = true;
            issues.Add(new ProfileValidationIssue(
                "warning",
                "binding",
                result.Diagnostics,
                path));
        }
    }

    private static IEnumerable<(string? System, string? Code)> CollectCodes(IReadOnlyList<IFhirNode> nodes)
    {
        foreach (var node in nodes)
        {
            if (node.Native is PrimitiveType)
            {
                yield return (null, node.GetValue()?.ToString());
                continue;
            }

            foreach (var coding in node.Children("coding"))
            {
                yield return (
                    coding.Children("system").FirstOrDefault()?.GetValue()?.ToString(),
                    coding.Children("code").FirstOrDefault()?.GetValue()?.ToString());
            }

            var code = node.Children("code").FirstOrDefault()?.GetValue()?.ToString();
            if (code is not null && node.Children("coding").Count == 0)
                yield return (node.Children("system").FirstOrDefault()?.GetValue()?.ToString(), code);
        }
    }

    private static void CheckSlicing(
        Base instance,
        ProfileSnapshot snapshot,
        ElementDefinition sliced,
        string path,
        IReadOnlyList<IFhirNode> nodes,
        List<ProfileValidationIssue> issues)
    {
        var prefix = path + ":";
        var slices = snapshot.Elements
            .Where(e => IsSliceOf(e, path, prefix))
            .ToList();

        foreach (var slice in slices)
        {
            var slicePath = slice.Path!.StringValue!;
            var sliceName = slice.SliceName?.StringValue
                            ?? (slicePath.Contains(':', StringComparison.Ordinal)
                                ? slicePath[(slicePath.IndexOf(':') + 1)..]
                                : slicePath);
            var location = string.IsNullOrEmpty(sliceName) ? slicePath : $"{path}:{sliceName}";
            var matched = nodes.Where(n => MatchesSlice(n, snapshot, sliced, slice)).ToList();
            AddCardinalityIssues(slice, location, matched.Count, issues);
            _ = instance;
        }
    }

    private static bool IsSliceOf(ElementDefinition element, string unslicedPath, string colonPrefix)
    {
        var p = element.Path?.StringValue;
        if (string.IsNullOrEmpty(p))
            return false;

        var sliceName = element.SliceName?.StringValue;
        if (string.IsNullOrEmpty(sliceName))
            return false;

        if (string.Equals(p, unslicedPath, StringComparison.Ordinal))
            return true;

        return p.StartsWith(colonPrefix, StringComparison.Ordinal)
               && p.IndexOf('.', colonPrefix.Length) < 0;
    }

    private static bool MatchesSlice(
        IFhirNode node,
        ProfileSnapshot snapshot,
        ElementDefinition sliced,
        ElementDefinition slice)
    {
        var discriminators = sliced.Slicing?.Discriminator;
        if (discriminators is null || discriminators.Count == 0)
            return false;

        foreach (var d in discriminators)
        {
            var dtype = d.Type?.StringValue ?? "value";
            var dpath = d.Path?.StringValue ?? "";
            if (string.Equals(dtype, "type", StringComparison.OrdinalIgnoreCase))
            {
                var allowed = slice.Type?
                                  .Select(t => t.Code?.StringValue)
                                  .OfType<string>()
                                  .ToHashSet(StringComparer.OrdinalIgnoreCase)
                              ?? [];
                var actual = InstancePathWalker.FhirTypeName(node);
                if (actual is null || !FhirTypeCompatibility.IsCompatible(actual, allowed))
                    return false;
                continue;
            }

            var target = string.IsNullOrEmpty(dpath) || dpath == "$this"
                ? node
                : WalkRelative(node, dpath).FirstOrDefault();
            if (target is null)
                return false;

            // Official snapshots put pattern/fixed on the discriminator child
            // (Observation.component:systolic.code), not the slice root.
            var constraint = DiscriminatorConstraint(snapshot, slice, dpath);
            var patterns = CollectFixedOrPattern(constraint).ToList();
            foreach (var (_, expected) in patterns)
            {
                if (!MatchesFixedOrPattern(target, expected))
                    return false;
            }

            var expectedProfiles = slice.Type?
                .SelectMany(t => t.Profile ?? [])
                .Select(p => p.StringValue)
                .Where(s => !string.IsNullOrEmpty(s))
                .ToList() ?? [];
            if (expectedProfiles.Count > 0)
            {
                var actualUrl = target.GetValue()?.ToString();
                if (string.IsNullOrEmpty(actualUrl))
                    actualUrl = node.Children("url").FirstOrDefault()?.GetValue()?.ToString();
                if (!expectedProfiles.Contains(actualUrl, StringComparer.Ordinal))
                    return false;
                continue;
            }

            // value／pattern 切片必須有可區分的值，否則每個 instance 都會灌進第一個 slice。
            if (patterns.Count == 0
                && (string.Equals(dtype, "value", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(dtype, "pattern", StringComparison.OrdinalIgnoreCase)))
                return false;
        }

        return true;
    }

    /// <summary>
    /// value／pattern discriminator 的比對值在切片子元素上（例如 <c>code</c>），
    /// 找不到時才退回 slice 根（category:vital 把 pattern 寫在根上）。
    /// </summary>
    private static ElementDefinition DiscriminatorConstraint(
        ProfileSnapshot snapshot,
        ElementDefinition slice,
        string discriminatorPath)
    {
        if (string.IsNullOrEmpty(discriminatorPath) || discriminatorPath == "$this")
            return slice;

        var child = FindSliceChild(snapshot.Elements, slice, discriminatorPath);
        if (child is not null && HasFixedOrPattern(child))
            return child;
        return slice;
    }

    private static bool HasFixedOrPattern(ElementDefinition element)
        => CollectFixedOrPattern(element).Any();

    private static ElementDefinition? FindSliceChild(
        IReadOnlyList<ElementDefinition> elements,
        ElementDefinition slice,
        string relativePath)
    {
        var unsliced = UnslicedPath(slice.Path?.StringValue);
        var sliceName = slice.SliceName?.StringValue ?? "";
        var colonRoot = slice.Path?.StringValue is { } slicePath && slicePath.Contains(':', StringComparison.Ordinal)
            ? slicePath
            : $"{unsliced}:{sliceName}";
        var expectedId = $"{unsliced}:{sliceName}.{relativePath}";
        var expectedPaths = new HashSet<string>(StringComparer.Ordinal)
        {
            $"{unsliced}.{relativePath}",
            $"{colonRoot}.{relativePath}"
        };

        var start = IndexOfElement(elements, slice);
        if (start >= 0)
        {
            for (var i = start + 1; i < elements.Count; i++)
            {
                var e = elements[i];
                if (IsSliceSibling(e, unsliced, sliceName))
                    break;
                if (string.Equals(e.Id?.StringValue, expectedId, StringComparison.Ordinal)
                    || expectedPaths.Contains(e.Path?.StringValue ?? ""))
                    return e;
            }
        }

        return elements.FirstOrDefault(e =>
            string.Equals(e.Id?.StringValue, expectedId, StringComparison.Ordinal));
    }

    private static int IndexOfElement(IReadOnlyList<ElementDefinition> elements, ElementDefinition slice)
    {
        for (var i = 0; i < elements.Count; i++)
        {
            if (ReferenceEquals(elements[i], slice))
                return i;
        }

        return -1;
    }

    private static bool IsSliceSibling(ElementDefinition element, string unslicedPath, string currentSlice)
    {
        var name = element.SliceName?.StringValue;
        if (string.IsNullOrEmpty(name) || string.Equals(name, currentSlice, StringComparison.Ordinal))
            return false;

        var path = element.Path?.StringValue ?? "";
        if (string.Equals(path, unslicedPath, StringComparison.Ordinal))
            return true;

        return path.StartsWith(unslicedPath + ":", StringComparison.Ordinal)
               && path.IndexOf('.', unslicedPath.Length) < 0;
    }

    private static string UnslicedPath(string? path)
    {
        if (string.IsNullOrEmpty(path))
            return "";
        var colon = path.IndexOf(':');
        if (colon < 0)
            return path;
        var after = path[(colon + 1)..];
        var dot = after.IndexOf('.');
        return dot < 0 ? path[..colon] : $"{path[..colon]}{after[dot..]}";
    }

    private static IEnumerable<IFhirNode> WalkRelative(IFhirNode node, string relativePath)
    {
        IEnumerable<IFhirNode> current = [node];
        foreach (var segment in relativePath.Split('.', StringSplitOptions.RemoveEmptyEntries))
            current = current.SelectMany(n => InstancePathWalker.Children(n, segment)).ToList();
        return current;
    }

    private static void CheckInvariants(
        Base instance,
        ProfileSnapshot snapshot,
        IFhirPathEngine engine,
        List<ProfileValidationIssue> issues)
    {
        var root = PocoElementNavigator.Wrap(instance);
        var ctx = new FhirPathEvaluationContext();
        ctx.SetVariable("resource", root);
        ctx.SetVariable("rootResource", root);

        foreach (var element in snapshot.Elements)
        {
            if (element.Constraint is not { Count: > 0 })
                continue;
            var path = element.Path?.StringValue;
            if (string.IsNullOrEmpty(path))
                continue;

            var targets = path.Contains('.', StringComparison.Ordinal)
                ? InstancePathWalker.Select(instance, path)
                : [root];

            foreach (var constraint in element.Constraint)
            {
                var expr = constraint.Expression?.StringValue;
                if (string.IsNullOrWhiteSpace(expr))
                    continue;

                foreach (var target in targets)
                {
                    FhirPathCollection result;
                    try
                    {
                        result = engine.Evaluate(expr, target, ctx);
                    }
                    catch (Exception ex)
                    {
                        issues.Add(new ProfileValidationIssue(
                            "warning",
                            "invariant",
                            $"Constraint '{constraint.Key?.StringValue}' failed to evaluate: {ex.Message}",
                            path));
                        continue;
                    }

                    if (IsFalse(result))
                    {
                        var severity = string.Equals(constraint.Severity?.StringValue, "warning", StringComparison.OrdinalIgnoreCase)
                            ? "warning"
                            : "error";
                        issues.Add(new ProfileValidationIssue(
                            severity,
                            "invariant",
                            constraint.Human?.StringValue
                            ?? $"Constraint '{constraint.Key?.StringValue}' failed: {expr}",
                            path));
                    }
                }
            }
        }
    }

    private static bool IsFalse(FhirPathCollection result)
    {
        if (result.Count == 0)
            return true;
        if (result.Count == 1 && result[0] is bool b)
            return !b;
        if (result.Count == 1 && result[0] is IFhirNode node && node.GetValue() is bool nb)
            return !nb;
        return false;
    }
}
