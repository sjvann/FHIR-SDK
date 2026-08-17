namespace Fhir.Validation;

public sealed record ProfileValidationIssue(
    string Severity,
    string Code,
    string Diagnostics,
    string? Location);

public sealed record ProfileValidationReport(
    bool Passed,
    IReadOnlyList<ProfileValidationIssue> Issues);
