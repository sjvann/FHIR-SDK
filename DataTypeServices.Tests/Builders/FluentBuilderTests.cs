using DataTypeServices.Builders;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using TerminologyService.ValueSet;
using System;
using System.Linq;
using Xunit;

namespace DataTypeServices.Tests.Builders
{
    public class FluentBuilderTests
    {
        [Fact]
        public void AddressBuilder_BasicUsage_CreatesValidAddress()
        {
            // Act
            var address = Address.Builder()
                .WithUse("home")
                .WithType("physical")
                .WithLine("123 Main Street")
                .WithLine("Apt 4B")
                .WithCity("Anytown")
                .WithState("NY")
                .WithPostalCode("12345")
                .WithCountry("USA")
                .Build();

            // Assert
            Assert.NotNull(address);
            Assert.Equal("home", address.Use?.Value);
            Assert.Equal("physical", address.Type?.Value);
            Assert.Equal(2, address.Line?.Count);
            Assert.Equal("123 Main Street", address.Line?[0].Value);
            Assert.Equal("Apt 4B", address.Line?[1].Value);
            Assert.Equal("Anytown", address.City?.Value);
            Assert.Equal("NY", address.State?.Value);
            Assert.Equal("12345", address.PostalCode?.Value);
            Assert.Equal("USA", address.Country?.Value);
        }

        [Fact]
        public void AddressBuilder_USAddress_CreatesCorrectAddress()
        {
            // Act
            var address = Address.Builder()
                .WithUSAddress("123 Main St", "New York", "NY", "10001")
                .Build();

            // Assert
            Assert.Equal("123 Main St", address.Line?[0].Value);
            Assert.Equal("New York", address.City?.Value);
            Assert.Equal("NY", address.State?.Value);
            Assert.Equal("10001", address.PostalCode?.Value);
            Assert.Equal("USA", address.Country?.Value);
        }

        [Fact]
        public void AddressBuilder_WithPeriod_SetsCorrectPeriod()
        {
            // Arrange
            var start = DateTime.Today;
            var end = DateTime.Today.AddYears(1);

            // Act
            var address = Address.Builder()
                .WithCity("Test City")
                .WithPeriod(start, end)
                .Build();

            // Assert
            Assert.NotNull(address.Period);
            Assert.Equal(start, address.Period.Start?.Value);
            Assert.Equal(end, address.Period.End?.Value);
        }

        [Fact]
        public void AddressBuilder_StaticFactoryMethods_CreateCorrectAddresses()
        {
            // Act
            var homeAddress = Address.Home(builder => builder
                .WithCity("Home City")
                .WithCountry("USA"));

            var workAddress = Address.Work(builder => builder
                .WithCity("Work City")
                .WithCountry("USA"));

            // Assert
            Assert.Equal("home", homeAddress.Use?.Value);
            Assert.Equal("Home City", homeAddress.City?.Value);

            Assert.Equal("work", workAddress.Use?.Value);
            Assert.Equal("Work City", workAddress.City?.Value);
        }

        [Fact]
        public void HumanNameBuilder_BasicUsage_CreatesValidName()
        {
            // Act
            var name = HumanName.Builder()
                .WithUse("official")
                .WithFamily("Doe")
                .WithGiven("John", "William")
                .WithPrefix("Mr.")
                .WithSuffix("Jr.")
                .Build();

            // Assert
            Assert.NotNull(name);
            Assert.Equal("official", name.Use?.Value);
            Assert.Equal("Doe", name.Family?.Value);
            Assert.Equal(2, name.Given?.Count);
            Assert.Equal("John", name.Given?[0].Value);
            Assert.Equal("William", name.Given?[1].Value);
            Assert.Equal("Mr.", name.Prefix?[0].Value);
            Assert.Equal("Jr.", name.Suffix?[0].Value);
        }

        [Fact]
        public void HumanNameBuilder_WesternName_CreatesCorrectName()
        {
            // Act
            var name = HumanName.Builder()
                .WithWesternName("John", "Doe", "William")
                .Build();

            // Assert
            Assert.Equal("Doe", name.Family?.Value);
            Assert.Equal(2, name.Given?.Count);
            Assert.Equal("John", name.Given?[0].Value);
            Assert.Equal("William", name.Given?[1].Value);
        }

        [Fact]
        public void HumanNameBuilder_ParseFullName_ParsesCorrectly()
        {
            // Act
            var name = HumanName.Builder()
                .ParseFullName("John William Doe")
                .Build();

            // Assert
            Assert.Equal("John William Doe", name.Text?.Value);
            Assert.Equal("Doe", name.Family?.Value);
            Assert.Equal(2, name.Given?.Count);
            Assert.Equal("John", name.Given?[0].Value);
            Assert.Equal("William", name.Given?[1].Value);
        }

        [Fact]
        public void HumanNameBuilder_StaticFactoryMethods_CreateCorrectNames()
        {
            // Act
            var officialName = HumanName.Official("John", "Doe");
            var nickname = HumanName.Nickname("Johnny");
            var fullName = HumanName.FromFullName("Jane Mary Smith");

            // Assert
            Assert.Equal("official", officialName.Use?.Value);
            Assert.Equal("John", officialName.Given?[0].Value);
            Assert.Equal("Doe", officialName.Family?.Value);

            Assert.Equal("nickname", nickname.Use?.Value);
            Assert.Equal("Johnny", nickname.Given?[0].Value);

            Assert.Equal("Jane Mary Smith", fullName.Text?.Value);
            Assert.Equal("Smith", fullName.Family?.Value);
        }

        [Fact]
        public void PeriodBuilder_BasicUsage_CreatesValidPeriod()
        {
            // Arrange
            var start = DateTime.Today;
            var end = DateTime.Today.AddDays(30);

            // Act
            var period = Period.Builder()
                .WithStart(start)
                .WithEnd(end)
                .Build();

            // Assert
            Assert.NotNull(period);
            Assert.Equal(start, period.Start?.Value);
            Assert.Equal(end, period.End?.Value);
        }

        [Fact]
        public void PeriodBuilder_Range_CreatesCorrectPeriod()
        {
            // Arrange
            var start = DateTime.Today;
            var end = DateTime.Today.AddDays(7);

            // Act
            var period = Period.Builder()
                .WithRange(start, end)
                .Build();

            // Assert
            Assert.Equal(start, period.Start?.Value);
            Assert.Equal(end, period.End?.Value);
        }

        [Fact]
        public void PeriodBuilder_ConvenienceMethods_CreateCorrectPeriods()
        {
            // Act
            var thisWeek = Period.Builder().ThisWeek().Build();
            var thisMonth = Period.Builder().ThisMonth().Build();
            var fromNow = Period.Builder().FromNow(TimeSpan.FromDays(30)).Build();

            // Assert
            Assert.NotNull(thisWeek.Start);
            Assert.NotNull(thisWeek.End);
            Assert.NotNull(thisMonth.Start);
            Assert.NotNull(thisMonth.End);
            Assert.NotNull(fromNow.Start);
            Assert.NotNull(fromNow.End);
        }

        [Fact]
        public void PeriodBuilder_StaticFactoryMethods_CreateCorrectPeriods()
        {
            // Arrange
            var start = DateTime.Today;
            var end = DateTime.Today.AddDays(7);

            // Act
            var rangePeriod = Period.Range(start, end);
            var fromNowPeriod = Period.FromNow(TimeSpan.FromDays(30));
            var thisWeekPeriod = Period.ThisWeek();

            // Assert
            Assert.Equal(start, rangePeriod.Start?.Value);
            Assert.Equal(end, rangePeriod.End?.Value);
            Assert.NotNull(fromNowPeriod.Start);
            Assert.NotNull(fromNowPeriod.End);
            Assert.NotNull(thisWeekPeriod.Start);
            Assert.NotNull(thisWeekPeriod.End);
        }

        [Fact]
        public void FluentBuilder_ChainedCalls_WorksCorrectly()
        {
            // Act
            var address = Address.Builder()
                .WithUse("home")
                .WithCity("Test City")
                .When(true, builder => builder.WithCountry("USA"))
                .When(false, builder => builder.WithCountry("Canada"))
                .Configure(addr => addr.Text = new FhirString("Custom text"))
                .Build();

            // Assert
            Assert.Equal("home", address.Use?.Value);
            Assert.Equal("Test City", address.City?.Value);
            Assert.Equal("USA", address.Country?.Value);
            Assert.Equal("Custom text", address.Text?.Value);
        }

        [Fact]
        public void FluentBuilder_Clone_CreatesIndependentCopy()
        {
            // Arrange
            var originalBuilder = Address.Builder()
                .WithCity("Original City")
                .WithCountry("USA");

            // Act
            var clonedBuilder = originalBuilder.Clone();
            clonedBuilder.WithCity("Cloned City");

            var originalAddress = originalBuilder.Build();
            var clonedAddress = clonedBuilder.Build();

            // Assert
            Assert.Equal("Original City", originalAddress.City?.Value);
            Assert.Equal("Cloned City", clonedAddress.City?.Value);
            Assert.Equal("USA", originalAddress.Country?.Value);
            Assert.Equal("USA", clonedAddress.Country?.Value);
        }

        [Fact]
        public void FluentBuilder_ImplicitConversion_WorksCorrectly()
        {
            // Act
            Address address = Address.Builder()
                .WithCity("Test City")
                .WithCountry("USA");

            // Assert
            Assert.NotNull(address);
            Assert.Equal("Test City", address.City?.Value);
            Assert.Equal("USA", address.Country?.Value);
        }

        [Fact]
        public void FluentBuilder_Validation_WorksCorrectly()
        {
            // Arrange
            var builder = Address.Builder()
                .WithCity("Test City");

            // Act
            var validationResults = builder.Validate();
            var address = builder.TryBuild();

            // Assert
            Assert.True(validationResults.IsValid);
            Assert.NotNull(address);
        }
    }
}
