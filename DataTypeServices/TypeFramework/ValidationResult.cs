using System;
using System.Collections.Generic;
using System.Linq;

namespace DataTypeServices.TypeFramework
{
    /// <summary>
    /// 驗證嚴重程度
    /// </summary>
    public enum ValidationSeverity
    {
        Error,
        Warning,
        Information
    }

    /// <summary>
    /// Represents the result of a validation operation, providing detailed validation information.
    /// This class encapsulates the outcome of validating FHIR data types, including success/failure status,
    /// error messages, property paths, and severity levels.
    /// </summary>
    /// <remarks>
    /// ValidationResult is designed to provide comprehensive feedback about validation operations.
    /// It supports different severity levels (Error, Warning, Information) and can include additional
    /// contextual details about the validation process.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a successful validation result
    /// var success = ValidationResult.Success();
    ///
    /// // Create an error validation result
    /// var error = ValidationResult.Error("Invalid format", "patient.name");
    ///
    /// // Create a warning validation result
    /// var warning = ValidationResult.Warning("Deprecated field used", "patient.gender");
    /// </code>
    /// </example>
    public class ValidationResult
    {
        /// <summary>
        /// Gets a value indicating whether the validation was successful.
        /// </summary>
        /// <value>
        /// <c>true</c> if the validation passed; otherwise, <c>false</c>.
        /// Note that warnings and informational messages typically don't affect this value.
        /// </value>
        public bool IsValid { get; init; }

        /// <summary>
        /// Gets the error or informational message associated with this validation result.
        /// </summary>
        /// <value>
        /// A human-readable message describing the validation outcome, or <c>null</c> if no message is available.
        /// </value>
        public string? ErrorMessage { get; init; }

        /// <summary>
        /// Gets the property path where the validation issue occurred.
        /// </summary>
        /// <value>
        /// A dot-separated path indicating the location of the validation issue (e.g., "patient.name.family"),
        /// or <c>null</c> if the issue is not specific to a particular property.
        /// </value>
        public string? PropertyPath { get; init; }

        /// <summary>
        /// Gets the severity level of this validation result.
        /// </summary>
        /// <value>
        /// The severity level indicating the importance of this validation result.
        /// Defaults to <see cref="ValidationSeverity.Error"/>.
        /// </value>
        public ValidationSeverity Severity { get; init; } = ValidationSeverity.Error;

        /// <summary>
        /// Gets additional contextual details about the validation result.
        /// </summary>
        /// <value>
        /// A dictionary containing additional information that may be useful for understanding
        /// or processing the validation result, or <c>null</c> if no additional details are available.
        /// </value>
        public Dictionary<string, object>? Details { get; init; }

        /// <summary>
        /// Creates a successful validation result.
        /// </summary>
        /// <returns>A <see cref="ValidationResult"/> indicating successful validation.</returns>
        public static ValidationResult Success() => new() { IsValid = true };

        /// <summary>
        /// Creates an error validation result.
        /// </summary>
        /// <param name="message">The error message describing what went wrong.</param>
        /// <param name="path">The property path where the error occurred (optional).</param>
        /// <param name="details">Additional contextual details about the error (optional).</param>
        /// <returns>A <see cref="ValidationResult"/> indicating a validation error.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="message"/> is null.</exception>
        public static ValidationResult Error(string message, string? path = null, Dictionary<string, object>? details = null)
            => new()
            {
                IsValid = false,
                ErrorMessage = message ?? throw new ArgumentNullException(nameof(message)),
                PropertyPath = path,
                Severity = ValidationSeverity.Error,
                Details = details
            };

        /// <summary>
        /// Creates a warning validation result.
        /// </summary>
        /// <param name="message">The warning message.</param>
        /// <param name="path">The property path where the warning occurred (optional).</param>
        /// <param name="details">Additional contextual details about the warning (optional).</param>
        /// <returns>A <see cref="ValidationResult"/> indicating a validation warning.</returns>
        /// <remarks>
        /// Warnings do not affect the overall validation result (IsValid remains true).
        /// They are used to indicate potential issues that don't prevent the data from being valid.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="message"/> is null.</exception>
        public static ValidationResult Warning(string message, string? path = null, Dictionary<string, object>? details = null)
            => new()
            {
                IsValid = true, // Warnings don't affect overall validation result
                ErrorMessage = message ?? throw new ArgumentNullException(nameof(message)),
                PropertyPath = path,
                Severity = ValidationSeverity.Warning,
                Details = details
            };

        /// <summary>
        /// Creates an informational validation result.
        /// </summary>
        /// <param name="message">The informational message.</param>
        /// <param name="path">The property path where the information applies (optional).</param>
        /// <param name="details">Additional contextual details (optional).</param>
        /// <returns>A <see cref="ValidationResult"/> containing informational content.</returns>
        /// <remarks>
        /// Informational results are used to provide additional context or guidance
        /// without indicating any validation issues.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="message"/> is null.</exception>
        public static ValidationResult Information(string message, string? path = null, Dictionary<string, object>? details = null)
            => new()
            {
                IsValid = true,
                ErrorMessage = message ?? throw new ArgumentNullException(nameof(message)),
                PropertyPath = path,
                Severity = ValidationSeverity.Information,
                Details = details
            };

        /// <summary>
        /// 合併多個驗證結果
        /// </summary>
        public static ValidationResult Combine(params ValidationResult[] results)
        {
            if (results == null || results.Length == 0)
                return Success();

            var errors = results.Where(r => !r.IsValid).ToList();
            if (errors.Any())
            {
                var combinedMessage = string.Join("; ", errors.Select(e => e.ErrorMessage));
                return Error(combinedMessage, details: new Dictionary<string, object>
                {
                    ["ValidationResults"] = results
                });
            }

            return Success();
        }

        /// <summary>
        /// 取得格式化的錯誤訊息
        /// </summary>
        public string GetFormattedMessage()
        {
            if (IsValid && Severity == ValidationSeverity.Error)
                return "Validation passed";

            var prefix = Severity switch
            {
                ValidationSeverity.Error => "ERROR",
                ValidationSeverity.Warning => "WARNING",
                ValidationSeverity.Information => "INFO",
                _ => "UNKNOWN"
            };

            var pathInfo = !string.IsNullOrEmpty(PropertyPath) ? $" at {PropertyPath}" : "";
            return $"[{prefix}]{pathInfo}: {ErrorMessage}";
        }

        public override string ToString() => GetFormattedMessage();
    }

    /// <summary>
    /// Represents a collection of validation results, providing aggregate information about multiple validation operations.
    /// This class is used to collect and analyze multiple <see cref="ValidationResult"/> instances from complex validation scenarios.
    /// </summary>
    /// <remarks>
    /// ValidationResults is particularly useful when validating complex objects that may have multiple properties
    /// or when performing batch validation operations. It provides convenient methods to analyze the overall
    /// validation status and extract specific types of messages.
    /// </remarks>
    /// <example>
    /// <code>
    /// var results = new ValidationResults();
    /// results.Add(ValidationResult.Success());
    /// results.Add(ValidationResult.Error("Invalid format", "patient.name"));
    /// results.Add(ValidationResult.Warning("Deprecated field", "patient.gender"));
    ///
    /// Console.WriteLine($"Overall valid: {results.IsValid}");
    /// Console.WriteLine($"Errors: {results.ErrorCount}, Warnings: {results.WarningCount}");
    /// </code>
    /// </example>
    public class ValidationResults
    {
        private readonly List<ValidationResult> _results = new();

        /// <summary>
        /// Gets a read-only collection of all validation results.
        /// </summary>
        /// <value>
        /// An <see cref="IReadOnlyList{T}"/> containing all validation results that have been added to this collection.
        /// </value>
        public IReadOnlyList<ValidationResult> Results => _results.AsReadOnly();

        /// <summary>
        /// Gets a value indicating whether all validation results are valid.
        /// </summary>
        /// <value>
        /// <c>true</c> if all validation results have <see cref="ValidationResult.IsValid"/> set to <c>true</c>;
        /// otherwise, <c>false</c>. An empty collection is considered valid.
        /// </value>
        public bool IsValid => _results.All(r => r.IsValid);

        /// <summary>
        /// Gets the number of error-level validation results.
        /// </summary>
        /// <value>
        /// The count of validation results that have <see cref="ValidationSeverity.Error"/> severity
        /// and <see cref="ValidationResult.IsValid"/> set to <c>false</c>.
        /// </value>
        public int ErrorCount => _results.Count(r => r.Severity == ValidationSeverity.Error && !r.IsValid);

        /// <summary>
        /// Gets the number of warning-level validation results.
        /// </summary>
        /// <value>
        /// The count of validation results that have <see cref="ValidationSeverity.Warning"/> severity.
        /// </value>
        public int WarningCount => _results.Count(r => r.Severity == ValidationSeverity.Warning);

        /// <summary>
        /// 添加驗證結果
        /// </summary>
        public void Add(ValidationResult result)
        {
            if (result != null)
                _results.Add(result);
        }

        /// <summary>
        /// 添加多個驗證結果
        /// </summary>
        public void AddRange(IEnumerable<ValidationResult> results)
        {
            if (results != null)
                _results.AddRange(results.Where(r => r != null));
        }

        /// <summary>
        /// 取得所有錯誤訊息
        /// </summary>
        public IEnumerable<string> GetErrorMessages()
        {
            return _results
                .Where(r => !r.IsValid && r.Severity == ValidationSeverity.Error)
                .Select(r => r.GetFormattedMessage());
        }

        /// <summary>
        /// 取得所有警告訊息
        /// </summary>
        public IEnumerable<string> GetWarningMessages()
        {
            return _results
                .Where(r => r.Severity == ValidationSeverity.Warning)
                .Select(r => r.GetFormattedMessage());
        }

        /// <summary>
        /// 清除所有結果
        /// </summary>
        public void Clear() => _results.Clear();

        public override string ToString()
        {
            if (IsValid)
                return $"Validation passed ({_results.Count} checks, {WarningCount} warnings)";

            return $"Validation failed ({ErrorCount} errors, {WarningCount} warnings)";
        }
    }
}
