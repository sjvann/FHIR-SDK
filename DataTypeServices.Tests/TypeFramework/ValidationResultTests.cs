using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.TypeFramework
{
    public class ValidationResultTests
    {
        [Fact]
        public void Success_CreatesValidResult()
        {
            // Act
            var result = ValidationResult.Success();

            // Assert
            Assert.True(result.IsValid);
            Assert.Null(result.ErrorMessage);
            Assert.Equal(ValidationSeverity.Error, result.Severity);
        }

        [Fact]
        public void Error_CreatesInvalidResult()
        {
            // Arrange
            var message = "Test error message";
            var path = "test.property";

            // Act
            var result = ValidationResult.Error(message, path);

            // Assert
            Assert.False(result.IsValid);
            Assert.Equal(message, result.ErrorMessage);
            Assert.Equal(path, result.PropertyPath);
            Assert.Equal(ValidationSeverity.Error, result.Severity);
        }

        [Fact]
        public void Warning_CreatesValidResultWithWarning()
        {
            // Arrange
            var message = "Test warning message";

            // Act
            var result = ValidationResult.Warning(message);

            // Assert
            Assert.True(result.IsValid); // 警告不影響整體驗證結果
            Assert.Equal(message, result.ErrorMessage);
            Assert.Equal(ValidationSeverity.Warning, result.Severity);
        }

        [Fact]
        public void Information_CreatesValidResultWithInfo()
        {
            // Arrange
            var message = "Test info message";

            // Act
            var result = ValidationResult.Information(message);

            // Assert
            Assert.True(result.IsValid);
            Assert.Equal(message, result.ErrorMessage);
            Assert.Equal(ValidationSeverity.Information, result.Severity);
        }

        [Fact]
        public void Combine_AllValid_ReturnsSuccess()
        {
            // Arrange
            var results = new[]
            {
                ValidationResult.Success(),
                ValidationResult.Warning("Warning"),
                ValidationResult.Information("Info")
            };

            // Act
            var combined = ValidationResult.Combine(results);

            // Assert
            Assert.True(combined.IsValid);
        }

        [Fact]
        public void Combine_HasErrors_ReturnsError()
        {
            // Arrange
            var results = new[]
            {
                ValidationResult.Success(),
                ValidationResult.Error("Error 1"),
                ValidationResult.Error("Error 2")
            };

            // Act
            var combined = ValidationResult.Combine(results);

            // Assert
            Assert.False(combined.IsValid);
            Assert.Contains("Error 1", combined.ErrorMessage);
            Assert.Contains("Error 2", combined.ErrorMessage);
        }

        [Fact]
        public void GetFormattedMessage_Error_ReturnsFormattedString()
        {
            // Arrange
            var result = ValidationResult.Error("Test error", "test.path");

            // Act
            var formatted = result.GetFormattedMessage();

            // Assert
            Assert.Contains("[ERROR]", formatted);
            Assert.Contains("at test.path", formatted);
            Assert.Contains("Test error", formatted);
        }

        [Fact]
        public void GetFormattedMessage_Warning_ReturnsFormattedString()
        {
            // Arrange
            var result = ValidationResult.Warning("Test warning");

            // Act
            var formatted = result.GetFormattedMessage();

            // Assert
            Assert.Contains("[WARNING]", formatted);
            Assert.Contains("Test warning", formatted);
        }
    }

    public class ValidationResultsTests
    {
        [Fact]
        public void IsValid_AllValid_ReturnsTrue()
        {
            // Arrange
            var results = new ValidationResults();
            results.Add(ValidationResult.Success());
            results.Add(ValidationResult.Warning("Warning"));

            // Act & Assert
            Assert.True(results.IsValid);
        }

        [Fact]
        public void IsValid_HasErrors_ReturnsFalse()
        {
            // Arrange
            var results = new ValidationResults();
            results.Add(ValidationResult.Success());
            results.Add(ValidationResult.Error("Error"));

            // Act & Assert
            Assert.False(results.IsValid);
        }

        [Fact]
        public void ErrorCount_CountsOnlyErrors()
        {
            // Arrange
            var results = new ValidationResults();
            results.Add(ValidationResult.Error("Error 1"));
            results.Add(ValidationResult.Warning("Warning"));
            results.Add(ValidationResult.Error("Error 2"));

            // Act & Assert
            Assert.Equal(2, results.ErrorCount);
        }

        [Fact]
        public void WarningCount_CountsOnlyWarnings()
        {
            // Arrange
            var results = new ValidationResults();
            results.Add(ValidationResult.Error("Error"));
            results.Add(ValidationResult.Warning("Warning 1"));
            results.Add(ValidationResult.Warning("Warning 2"));

            // Act & Assert
            Assert.Equal(2, results.WarningCount);
        }

        [Fact]
        public void GetErrorMessages_ReturnsOnlyErrors()
        {
            // Arrange
            var results = new ValidationResults();
            results.Add(ValidationResult.Error("Error 1"));
            results.Add(ValidationResult.Warning("Warning"));
            results.Add(ValidationResult.Error("Error 2"));

            // Act
            var errorMessages = results.GetErrorMessages().ToList();

            // Assert
            Assert.Equal(2, errorMessages.Count);
            Assert.All(errorMessages, msg => Assert.Contains("ERROR", msg));
        }

        [Fact]
        public void GetWarningMessages_ReturnsOnlyWarnings()
        {
            // Arrange
            var results = new ValidationResults();
            results.Add(ValidationResult.Error("Error"));
            results.Add(ValidationResult.Warning("Warning 1"));
            results.Add(ValidationResult.Warning("Warning 2"));

            // Act
            var warningMessages = results.GetWarningMessages().ToList();

            // Assert
            Assert.Equal(2, warningMessages.Count);
            Assert.All(warningMessages, msg => Assert.Contains("WARNING", msg));
        }
    }
}
