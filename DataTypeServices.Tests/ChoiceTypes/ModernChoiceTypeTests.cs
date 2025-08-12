using DataTypeServices.DataTypes.ChoiceTypes;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;
using Xunit;

namespace DataTypeServices.Tests.ChoiceTypes
{
    public class ModernChoiceTypeTests
    {
        [Fact]
        public void AsNeededChoice_FromBoolean_CreatesCorrectType()
        {
            // Arrange & Act
            var choice = AsNeededChoice.FromBoolean(true);

            // Assert
            Assert.True(choice.IsT1);
            Assert.False(choice.IsT2);
            Assert.True(choice.AsBooleanValue);
            Assert.Null(choice.AsCodeableConcept);
        }

        [Fact]
        public void AsNeededChoice_FromCodeableConcept_CreatesCorrectType()
        {
            // Arrange
            var concept = new CodeableConcept();
            
            // Act
            var choice = AsNeededChoice.FromCodeableConcept(concept);

            // Assert
            Assert.False(choice.IsT1);
            Assert.True(choice.IsT2);
            Assert.Null(choice.AsBooleanValue);
            Assert.NotNull(choice.AsCodeableConcept);
            Assert.Same(concept, choice.AsCodeableConcept);
        }

        [Fact]
        public void AsNeededChoice_Match_HandlesAllCases()
        {
            // Arrange
            var booleanChoice = AsNeededChoice.FromBoolean(true);
            var conceptChoice = AsNeededChoice.FromCodeableConcept(new CodeableConcept());

            // Act
            var booleanResult = booleanChoice.Match(
                boolean => "boolean",
                concept => "concept"
            );

            var conceptResult = conceptChoice.Match(
                boolean => "boolean",
                concept => "concept"
            );

            // Assert
            Assert.Equal("boolean", booleanResult);
            Assert.Equal("concept", conceptResult);
        }

        [Fact]
        public void AsNeededChoice_Switch_ExecutesCorrectAction()
        {
            // Arrange
            var booleanChoice = AsNeededChoice.FromBoolean(false);
            var executedAction = "";

            // Act
            booleanChoice.Switch(
                boolean => executedAction = "boolean",
                concept => executedAction = "concept"
            );

            // Assert
            Assert.Equal("boolean", executedAction);
        }

        [Fact]
        public void AsNeededChoice_TryGetValue_ReturnsCorrectValue()
        {
            // Arrange
            var choice = AsNeededChoice.FromBoolean(true);

            // Act
            var success = choice.TryGetValue<FhirBoolean>(out var booleanValue);
            var failure = choice.TryGetValue<CodeableConcept>(out var conceptValue);

            // Assert
            Assert.True(success);
            Assert.NotNull(booleanValue);
            Assert.True(booleanValue.Value);

            Assert.False(failure);
            Assert.Null(conceptValue);
        }

        [Fact]
        public void DeceasedChoice_FromBoolean_CreatesCorrectType()
        {
            // Arrange & Act
            var choice = DeceasedChoice.FromBoolean(true);

            // Assert
            Assert.True(choice.IsT1);
            Assert.False(choice.IsT2);
            Assert.True(choice.IsDeceased);
            Assert.Null(choice.DeceasedDateTime);
        }

        [Fact]
        public void DeceasedChoice_FromDateTime_CreatesCorrectType()
        {
            // Arrange
            var dateTime = new DateTime(2023, 12, 25);

            // Act
            var choice = DeceasedChoice.FromDateTime(dateTime);

            // Assert
            Assert.False(choice.IsT1);
            Assert.True(choice.IsT2);
            Assert.Null(choice.IsDeceased);
            Assert.Equal(dateTime, choice.DeceasedDateTime);
        }

        [Fact]
        public void DeceasedChoice_FromDateTimeString_CreatesCorrectType()
        {
            // Arrange
            var dateTimeString = "2023-12-25";

            // Act
            var choice = DeceasedChoice.FromDateTimeString(dateTimeString);

            // Assert
            Assert.False(choice.IsT1);
            Assert.True(choice.IsT2);
            Assert.Null(choice.IsDeceased);
            Assert.NotNull(choice.DeceasedDateTime);
        }

        [Fact]
        public void ServicedChoice_FromDate_CreatesCorrectType()
        {
            // Arrange
            var date = new DateTime(2023, 12, 25);

            // Act
            var choice = ServicedChoice.FromDate(date);

            // Assert
            Assert.True(choice.IsT1);
            Assert.False(choice.IsT2);
            Assert.Equal(date, choice.ServiceDate);
            Assert.Null(choice.ServicePeriod);
        }

        [Fact]
        public void ServicedChoice_FromPeriod_CreatesCorrectType()
        {
            // Arrange
            var start = new DateTime(2023, 12, 25);
            var end = new DateTime(2023, 12, 31);

            // Act
            var choice = ServicedChoice.FromPeriod(start, end);

            // Assert
            Assert.False(choice.IsT1);
            Assert.True(choice.IsT2);
            Assert.Null(choice.ServiceDate);
            Assert.NotNull(choice.ServicePeriod);
            Assert.Equal(start, choice.ServicePeriod.Start?.Value);
            Assert.Equal(end, choice.ServicePeriod.End?.Value);
        }

        [Fact]
        public void ServicedChoice_FromDateString_CreatesCorrectType()
        {
            // Arrange
            var dateString = "2023-12-25";

            // Act
            var choice = ServicedChoice.FromDateString(dateString);

            // Assert
            Assert.True(choice.IsT1);
            Assert.False(choice.IsT2);
            Assert.NotNull(choice.ServiceDate);
            Assert.Null(choice.ServicePeriod);
        }

        [Fact]
        public void ModernChoiceType_GetPrefixName_ReturnsCorrectName()
        {
            // Arrange
            var choice = AsNeededChoice.FromBoolean(true);

            // Act
            var prefixWithCapital = choice.GetPrefixName(true);
            var prefixWithoutCapital = choice.GetPrefixName(false);

            // Assert
            Assert.Equal("AsNeeded", prefixWithCapital);
            Assert.Equal("asNeeded", prefixWithoutCapital);
        }

        [Fact]
        public void ModernChoiceType_SetSupportDataType_ReturnsCorrectTypes()
        {
            // Arrange
            var choice = AsNeededChoice.FromBoolean(true);

            // Act
            var supportedTypes = choice.SetSupportDataType();

            // Assert
            Assert.Contains("boolean", supportedTypes);
            Assert.Contains("codeableConcept", supportedTypes);
            Assert.Equal(2, supportedTypes.Count);
        }

        [Fact]
        public void ModernChoiceType_IsChoiceType_ReturnsTrue()
        {
            // Arrange
            var choice = AsNeededChoice.FromBoolean(true);

            // Act & Assert
            Assert.True(choice.IsChoiceType());
            Assert.False(choice.IsPrimitive());
            Assert.False(choice.IsComplex());
        }
    }

    public class ModernChoiceTypeExamplesTests
    {
        [Fact]
        public void DemonstrateUsage_RunsWithoutException()
        {
            // Act & Assert - 確保示例代碼能正常運行
            var exception = Record.Exception(() => ModernChoiceTypeExamples.DemonstrateUsage());
            Assert.Null(exception);
        }

        [Fact]
        public void DemonstrateJsonParsing_RunsWithoutException()
        {
            // Act & Assert - 確保 JSON 解析示例能正常運行
            var exception = Record.Exception(() => ModernChoiceTypeExamples.DemonstrateJsonParsing());
            Assert.Null(exception);
        }
    }
}
