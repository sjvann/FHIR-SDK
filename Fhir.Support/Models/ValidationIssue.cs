namespace Fhir.Support.Models;

/// <summary>
/// 代表一个验证问题。
/// </summary>
public class ValidationIssue
{
    /// <summary>
    /// 问题的严重性。
    /// </summary>
    public IssueSeverity Severity { get; }

    /// <summary>
    /// 问题的详细描述。
    /// </summary>
    public string Details { get; }

    /// <summary>
    /// 发生问题的 FHIR 元素路径。
    /// </summary>
    public string Location { get; }

    public ValidationIssue(IssueSeverity severity, string details, string location)
    {
        Severity = severity;
        Details = details;
        Location = location;
    }
}

/// <summary>
/// 问题的严重性级别。
/// </summary>
public enum IssueSeverity
{
    /// <summary>
    /// 致命错误，违反了核心规范。
    /// </summary>
    Fatal,
    /// <summary>
    /// 错误，不符合 Profile 约束。
    /// </summary>
    Error,
    /// <summary>
    /// 警告，可能存在问题。
    /// </summary>
    Warning,
    /// <summary>
    /// 资讯性讯息。
    /// </summary>
    Information
} 