using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using System;
using Xunit;

namespace DataTypeServices.Tests.ComplexTypes
{
    public class NewComplexTypesTests
    {
        [Fact]
        public void Age_Constructor_WithValueAndUnit_CreatesValidAge()
        {
            // Act
            var age = new Age(25, "years");

            // Assert
            Assert.NotNull(age);
            Assert.Equal(25m, age.Value?.Value);
            Assert.Equal("years", age.Unit?.Value);
            Assert.Equal("http://unitsofmeasure.org", age.System?.Value);
            Assert.Equal("a", age.Code?.Value);
        }

        [Fact]
        public void Age_StaticFactoryMethods_CreateCorrectAges()
        {
            // Act
            var years = Age.Years(30);
            var months = Age.Months(6);
            var weeks = Age.Weeks(2);
            var days = Age.Days(10);

            // Assert
            Assert.Equal(30m, years.Value?.Value);
            Assert.Equal("years", years.Unit?.Value);
            Assert.Equal("a", years.Code?.Value);

            Assert.Equal(6m, months.Value?.Value);
            Assert.Equal("months", months.Unit?.Value);
            Assert.Equal("mo", months.Code?.Value);

            Assert.Equal(2m, weeks.Value?.Value);
            Assert.Equal("weeks", weeks.Unit?.Value);
            Assert.Equal("wk", weeks.Code?.Value);

            Assert.Equal(10m, days.Value?.Value);
            Assert.Equal("days", days.Unit?.Value);
            Assert.Equal("d", days.Code?.Value);
        }

        [Fact]
        public void Age_IsValidAge_ValidatesCorrectly()
        {
            // Arrange
            var validAge = Age.Years(25);
            var invalidAge = new Age(-5, "years");

            // Act & Assert
            Assert.True(validAge.IsValidAge());
            Assert.False(invalidAge.IsValidAge());
        }

        [Fact]
        public void Age_GetFhirTypeName_ReturnsCorrectName()
        {
            // Arrange
            var age = new Age();

            // Act & Assert
            Assert.Equal("Age", age.GetFhirTypeName(true));
            Assert.Equal("age", age.GetFhirTypeName(false));
        }

        [Fact]
        public void Distance_Constructor_WithValueAndUnit_CreatesValidDistance()
        {
            // Act
            var distance = new Distance(100, "meters");

            // Assert
            Assert.NotNull(distance);
            Assert.Equal(100m, distance.Value?.Value);
            Assert.Equal("meters", distance.Unit?.Value);
            Assert.Equal("http://unitsofmeasure.org", distance.System?.Value);
            Assert.Equal("m", distance.Code?.Value);
        }

        [Fact]
        public void Distance_StaticFactoryMethods_CreateCorrectDistances()
        {
            // Act
            var meters = Distance.Meters(100);
            var kilometers = Distance.Kilometers(5);
            var centimeters = Distance.Centimeters(50);
            var millimeters = Distance.Millimeters(25);
            var feet = Distance.Feet(10);
            var inches = Distance.Inches(12);
            var miles = Distance.Miles(2);

            // Assert
            Assert.Equal(100m, meters.Value?.Value);
            Assert.Equal("meters", meters.Unit?.Value);
            Assert.Equal("m", meters.Code?.Value);

            Assert.Equal(5m, kilometers.Value?.Value);
            Assert.Equal("kilometers", kilometers.Unit?.Value);
            Assert.Equal("km", kilometers.Code?.Value);

            Assert.Equal(50m, centimeters.Value?.Value);
            Assert.Equal("centimeters", centimeters.Unit?.Value);
            Assert.Equal("cm", centimeters.Code?.Value);

            Assert.Equal(25m, millimeters.Value?.Value);
            Assert.Equal("millimeters", millimeters.Unit?.Value);
            Assert.Equal("mm", millimeters.Code?.Value);

            Assert.Equal(10m, feet.Value?.Value);
            Assert.Equal("feet", feet.Unit?.Value);
            Assert.Equal("[ft_i]", feet.Code?.Value);

            Assert.Equal(12m, inches.Value?.Value);
            Assert.Equal("inches", inches.Unit?.Value);
            Assert.Equal("[in_i]", inches.Code?.Value);

            Assert.Equal(2m, miles.Value?.Value);
            Assert.Equal("miles", miles.Unit?.Value);
            Assert.Equal("[mi_i]", miles.Code?.Value);
        }

        [Fact]
        public void Distance_IsValidDistance_ValidatesCorrectly()
        {
            // Arrange
            var validDistance = Distance.Meters(100);
            var invalidDistance = new Distance(-50, "meters");

            // Act & Assert
            Assert.True(validDistance.IsValidDistance());
            Assert.False(invalidDistance.IsValidDistance());
        }

        [Fact]
        public void Distance_ToMeters_ConvertsCorrectly()
        {
            // Arrange
            var kilometers = Distance.Kilometers(2);
            var centimeters = Distance.Centimeters(500);
            var feet = Distance.Feet(10);

            // Act
            var kmToMeters = kilometers.ToMeters();
            var cmToMeters = centimeters.ToMeters();
            var ftToMeters = feet.ToMeters();

            // Assert
            Assert.NotNull(kmToMeters);
            Assert.Equal(2000m, kmToMeters.Value?.Value);
            Assert.Equal("meters", kmToMeters.Unit?.Value);

            Assert.NotNull(cmToMeters);
            Assert.Equal(5m, cmToMeters.Value?.Value);
            Assert.Equal("meters", cmToMeters.Unit?.Value);

            Assert.NotNull(ftToMeters);
            Assert.Equal(3.048m, ftToMeters.Value?.Value);
            Assert.Equal("meters", ftToMeters.Unit?.Value);
        }

        [Fact]
        public void Distance_GetFhirTypeName_ReturnsCorrectName()
        {
            // Arrange
            var distance = new Distance();

            // Act & Assert
            Assert.Equal("Distance", distance.GetFhirTypeName(true));
            Assert.Equal("distance", distance.GetFhirTypeName(false));
        }

        [Fact]
        public void Age_InheritsFromQuantity_HasQuantityProperties()
        {
            // Arrange
            var age = Age.Years(30);

            // Act & Assert
            Assert.IsAssignableFrom<Quantity>(age);
            Assert.NotNull(age.Value);
            Assert.NotNull(age.Unit);
            Assert.NotNull(age.System);
            Assert.NotNull(age.Code);
        }

        [Fact]
        public void Distance_InheritsFromQuantity_HasQuantityProperties()
        {
            // Arrange
            var distance = Distance.Meters(100);

            // Act & Assert
            Assert.IsAssignableFrom<Quantity>(distance);
            Assert.NotNull(distance.Value);
            Assert.NotNull(distance.Unit);
            Assert.NotNull(distance.System);
            Assert.NotNull(distance.Code);
        }

        [Fact]
        public void Age_UcumCodeMapping_WorksCorrectly()
        {
            // Test various unit mappings
            var testCases = new[]
            {
                ("years", "a"),
                ("year", "a"),
                ("yr", "a"),
                ("y", "a"),
                ("months", "mo"),
                ("month", "mo"),
                ("mo", "mo"),
                ("weeks", "wk"),
                ("week", "wk"),
                ("wk", "wk"),
                ("w", "wk"),
                ("days", "d"),
                ("day", "d"),
                ("d", "d"),
                ("hours", "h"),
                ("hour", "h"),
                ("hr", "h"),
                ("h", "h"),
                ("minutes", "min"),
                ("minute", "min"),
                ("min", "min"),
                ("seconds", "s"),
                ("second", "s"),
                ("sec", "s"),
                ("s", "s")
            };

            foreach (var (unit, expectedCode) in testCases)
            {
                var age = new Age(1, unit);
                Assert.Equal(expectedCode, age.Code?.Value);
            }
        }

        [Fact]
        public void Distance_UcumCodeMapping_WorksCorrectly()
        {
            // Test various unit mappings
            var testCases = new[]
            {
                ("meters", "m"),
                ("meter", "m"),
                ("metres", "m"),
                ("metre", "m"),
                ("m", "m"),
                ("kilometers", "km"),
                ("kilometer", "km"),
                ("kilometres", "km"),
                ("kilometre", "km"),
                ("km", "km"),
                ("centimeters", "cm"),
                ("centimeter", "cm"),
                ("centimetres", "cm"),
                ("centimetre", "cm"),
                ("cm", "cm"),
                ("millimeters", "mm"),
                ("millimeter", "mm"),
                ("millimetres", "mm"),
                ("millimetre", "mm"),
                ("mm", "mm"),
                ("feet", "[ft_i]"),
                ("foot", "[ft_i]"),
                ("ft", "[ft_i]"),
                ("inches", "[in_i]"),
                ("inch", "[in_i]"),
                ("in", "[in_i]"),
                ("yards", "[yd_i]"),
                ("yard", "[yd_i]"),
                ("yd", "[yd_i]"),
                ("miles", "[mi_i]"),
                ("mile", "[mi_i]"),
                ("mi", "[mi_i]")
            };

            foreach (var (unit, expectedCode) in testCases)
            {
                var distance = new Distance(1, unit);
                Assert.Equal(expectedCode, distance.Code?.Value);
            }
        }
    }
}
