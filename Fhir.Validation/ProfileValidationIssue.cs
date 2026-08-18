namespace Fhir.Validation;

public sealed record ProfileValidationIssue(
    string Severity,
    string Code,
    string Diagnostics,
    string? Location,
    string? Expression = null);

public sealed record OperationOutcomeIssueDto(
    string Severity,
    string Code,
    string Diagnostics,
    IReadOnlyList<string>? Location,
    IReadOnlyList<string>? Expression);

public sealed record ProfileValidationReport(
    bool Passed,
    IReadOnlyList<ProfileValidationIssue> Issues)
{
    public IReadOnlyList<OperationOutcomeIssueDto> ToOperationOutcomeIssues()
        => Issues.Select(i => new OperationOutcomeIssueDto(
            i.Severity,
            i.Code,
            i.Diagnostics,
            i.Location is null ? null : [i.Location],
            i.Expression is null ? null : [i.Expression])).ToList();
}
