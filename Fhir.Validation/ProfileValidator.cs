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

            if (path.Contains(':', StringComparison.Ordinal))
                continue;

            var nodes = InstancePathWalker.Select(instance, path);
            CheckCardinality(element, path, nodes.Count, issues);
            CheckTypes(element, path, nodes, issues);
            CheckBinding(element, path, nodes, options, issues);
            if (options.EvaluateFixedPattern)
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
                    path,
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

    private static void CheckCardinality(
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
            if (allowed.Contains(actual) || allowed.Contains("Element") || allowed.Contains("BackboneElement"))
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
        var inCatalog = _catalog.TryGetValueSet(valueSet, out _);
        if (!inCatalog && options.Terminology is null)
        {
            var severity = options.Handling == ProfileHandling.Strict ? "error" : "warning";
            issues.Add(new ProfileValidationIssue(
                severity,
                "binding",
                $"ValueSet '{valueSet}' is not in the catalog; binding was not fully checked.",
                path));
            return;
        }

        foreach (var (system, code) in CollectCodes(nodes))
        {
            var result = terminology.ValidateCode(system, code, valueSet);
            if (!result.Ok)
            {
                issues.Add(new ProfileValidationIssue(
                    "error",
                    "binding",
                    result.Diagnostics ?? $"Code '{system}|{code}' failed binding to '{valueSet}'.",
                    path));
            }
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
            .Where(e => e.Path?.StringValue is { } p && p.StartsWith(prefix, StringComparison.Ordinal)
                        && p.IndexOf('.', prefix.Length) < 0)
            .ToList();

        foreach (var slice in slices)
        {
            var slicePath = slice.Path!.StringValue!;
            var sliceName = slice.SliceName?.StringValue
                            ?? slicePath[(slicePath.IndexOf(':') + 1)..];
            var matched = nodes.Where(n => MatchesSlice(n, sliced, slice)).ToList();
            CheckCardinality(slice, slicePath, matched.Count, issues);
            _ = sliceName;
            _ = instance;
        }
    }

    private static bool MatchesSlice(IFhirNode node, ElementDefinition sliced, ElementDefinition slice)
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
                var allowed = slice.Type?.Select(t => t.Code?.StringValue).Where(c => c is not null).ToHashSet(StringComparer.OrdinalIgnoreCase)
                              ?? [];
                var actual = InstancePathWalker.FhirTypeName(node);
                if (actual is null || !allowed.Contains(actual))
                    return false;
                continue;
            }

            var target = string.IsNullOrEmpty(dpath) || dpath == "$this"
                ? node
                : WalkRelative(node, dpath).FirstOrDefault();
            if (target is null)
                return false;

            if (slice.FixedCode?.StringValue is { } fixedCode
                && !string.Equals(target.GetValue()?.ToString(), fixedCode, StringComparison.Ordinal))
                return false;

            if (slice.FixedUri?.StringValue is { } fixedUri
                && !string.Equals(target.GetValue()?.ToString(), fixedUri, StringComparison.Ordinal))
                return false;

            if (slice.PatternCoding is { } patternCoding)
            {
                var code = target.Children("code").FirstOrDefault()?.GetValue()?.ToString()
                           ?? target.GetValue()?.ToString();
                if (patternCoding.Code?.StringValue is { } expected
                    && !string.Equals(code, expected, StringComparison.Ordinal))
                    return false;
            }

            if (slice.PatternCodeableConcept?.Coding is { Count: > 0 } patternCc)
            {
                var expected = patternCc[0].Code?.StringValue;
                var codes = target.Children("coding")
                    .Select(c => c.Children("code").FirstOrDefault()?.GetValue()?.ToString())
                    .ToList();
                if (codes.Count == 0)
                    codes.Add(target.Children("code").FirstOrDefault()?.GetValue()?.ToString());
                if (expected is not null && !codes.Contains(expected))
                    return false;
            }
        }

        return true;
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
                            "error",
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
