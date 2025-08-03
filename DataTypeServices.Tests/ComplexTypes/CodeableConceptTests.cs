using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using System.Text.Json.Nodes;
using Xunit;

namespace DataTypeServices.Tests.ComplexTypes
{
    /// <summary>
    /// CodeableConcept 測試類別
    /// </summary>
    public class CodeableConceptTests : ComplexTypeTestBase<CodeableConcept>
    {
        #region 抽象方法實作

        public override string[] GetValidValues()
        {
            return new[]
            {
                "{\"coding\":[{\"system\":\"http://snomed.info/sct\",\"code\":\"73211009\",\"display\":\"Diabetes mellitus\"}],\"text\":\"Diabetes mellitus\"}",
                "{\"coding\":[{\"system\":\"http://loinc.org\",\"code\":\"250-8\",\"display\":\"Glucose\"}],\"text\":\"Glucose measurement\"}",
                "{\"coding\":[{\"system\":\"http://www.nlm.nih.gov/research/umls/rxnorm\",\"code\":\"860975\",\"display\":\"Insulin Regular Human\"}],\"text\":\"Insulin Regular Human\"}"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "{}",
                "{\"invalid\":\"value\"}",
                "invalid json"
            };
        }

        public override CodeableConcept CreateInstance(string value)
        {
            try
            {
                var jsonObject = JsonNode.Parse(value) as JsonObject;
                return new CodeableConcept(jsonObject ?? new JsonObject());
            }
            catch
            {
                return new CodeableConcept();
            }
        }

        public override CodeableConcept CreateNullInstance()
        {
            return new CodeableConcept();
        }

        public override CodeableConcept CreateValidInstance()
        {
            return new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://snomed.info/sct"),
                        Code = new FhirCode("73211009"),
                        Display = new FhirString("Diabetes mellitus")
                    }
                },
                Text = new FhirString("Diabetes mellitus")
            };
        }

        #endregion

        #region 覆寫的共同測試方法

        public override void TestSerialization_SerializesCorrectly()
        {
            // Arrange
            var codeableConcept = CreateValidInstance();

            // Act
            var jsonObject = codeableConcept.GetJsonObject();

            // Assert
            AssertJsonObjectContainsKeys(jsonObject, "coding", "text");
        }

        public override void TestDeserialization_DeserializesCorrectly()
        {
            // Arrange
            var originalCodeableConcept = CreateValidInstance();
            var jsonObject = originalCodeableConcept.GetJsonObject();

            // Act
            var deserializedCodeableConcept = new CodeableConcept(jsonObject ?? new JsonObject());

            // Assert
            AssertInstancesAreEqual(originalCodeableConcept, deserializedCodeableConcept,
                (original, deserialized) => Assert.NotNull(original.Coding),
                (original, deserialized) => Assert.NotNull(deserialized.Coding),
                (original, deserialized) => Assert.NotNull(original.Coding),
                (original, deserialized) => Assert.NotNull(deserialized.Coding),
                (original, deserialized) => Assert.Single(original.Coding!),
                (original, deserialized) => Assert.Single(deserialized.Coding!),
                (original, deserialized) => Assert.Equal(original.Coding?[0]?.System?.Value, deserialized.Coding?[0]?.System?.Value),
                (original, deserialized) => Assert.Equal(original.Coding?[0]?.Code?.Value, deserialized.Coding?[0]?.Code?.Value),
                (original, deserialized) => Assert.Equal(original.Coding?[0]?.Display?.Value, deserialized.Coding?[0]?.Display?.Value),
                (original, deserialized) => Assert.Equal(original.Text?.Value, deserialized.Text?.Value)
            );
        }

        public override void TestPropertyChanged_RaisesEvent()
        {
            // Arrange
            var codeableConcept = new CodeableConcept();
            var eventRaised = false;
            codeableConcept.PropertyChanged += (sender, e) => eventRaised = true;

            // Act
            codeableConcept.Text = new FhirString("New text");

            // Assert
            Assert.True(eventRaised);
        }

        public override void TestWithValidProperties_SetsPropertiesCorrectly()
        {
            // Arrange
            var codeableConcept = new CodeableConcept();

            // Act
            codeableConcept.Coding = new List<Coding>
            {
                new Coding
                {
                    System = new FhirUri("http://snomed.info/sct"),
                    Code = new FhirCode("73211009"),
                    Display = new FhirString("Diabetes mellitus")
                }
            };
            codeableConcept.Text = new FhirString("Diabetes mellitus");

            // Assert
            Assert.NotNull(codeableConcept.Coding);
            Assert.Single(codeableConcept.Coding);
            Assert.Equal("http://snomed.info/sct", codeableConcept.Coding?[0]?.System?.Value);
            Assert.Equal("73211009", codeableConcept.Coding?[0]?.Code?.Value);
            Assert.Equal("Diabetes mellitus", codeableConcept.Coding?[0]?.Display?.Value);
            Assert.NotNull(codeableConcept.Text);
            Assert.Equal("Diabetes mellitus", codeableConcept.Text?.Value);
        }

        #endregion

        #region CodeableConcept 特定測試

        [Fact]
        public void TestCodeableConcept_WithMultipleCodings_SetsCodingsCorrectly()
        {
            // Arrange
            var codeableConcept = new CodeableConcept();

            // Act
            codeableConcept.Coding = new List<Coding>
            {
                new Coding
                {
                    System = new FhirUri("http://snomed.info/sct"),
                    Code = new FhirCode("73211009"),
                    Display = new FhirString("Diabetes mellitus")
                },
                new Coding
                {
                    System = new FhirUri("http://loinc.org"),
                    Code = new FhirCode("250-8"),
                    Display = new FhirString("Glucose")
                },
                new Coding
                {
                    System = new FhirUri("http://www.nlm.nih.gov/research/umls/rxnorm"),
                    Code = new FhirCode("860975"),
                    Display = new FhirString("Insulin Regular Human")
                }
            };

            // Assert
            Assert.NotNull(codeableConcept.Coding);
            Assert.Equal(3, codeableConcept.Coding?.Count);
            Assert.Equal("http://snomed.info/sct", codeableConcept.Coding?[0]?.System?.Value);
            Assert.Equal("http://loinc.org", codeableConcept.Coding?[1]?.System?.Value);
            Assert.Equal("http://www.nlm.nih.gov/research/umls/rxnorm", codeableConcept.Coding?[2]?.System?.Value);
        }

        [Fact]
        public void TestCodeableConcept_WithTextOnly_SetsTextCorrectly()
        {
            // Arrange
            var codeableConcept = new CodeableConcept();

            // Act
            codeableConcept.Text = new FhirString("Patient reported mild headache");

            // Assert
            Assert.Null(codeableConcept.Coding);
            Assert.NotNull(codeableConcept.Text);
            Assert.Equal("Patient reported mild headache", codeableConcept.Text?.Value);
        }

        [Fact]
        public void TestCodeableConcept_WithCodingOnly_SetsCodingCorrectly()
        {
            // Arrange
            var codeableConcept = new CodeableConcept();

            // Act
            codeableConcept.Coding = new List<Coding>
            {
                new Coding
                {
                    System = new FhirUri("http://snomed.info/sct"),
                    Code = new FhirCode("25064002"),
                    Display = new FhirString("Headache")
                }
            };

            // Assert
            Assert.NotNull(codeableConcept.Coding);
            Assert.Single(codeableConcept.Coding);
            Assert.Null(codeableConcept.Text);
            Assert.Equal("25064002", codeableConcept.Coding?[0]?.Code?.Value);
        }

        [Fact]
        public void TestCodeableConcept_WithCodingAndText_BothAreSet()
        {
            // Arrange
            var codeableConcept = new CodeableConcept();

            // Act
            codeableConcept.Coding = new List<Coding>
            {
                new Coding
                {
                    System = new FhirUri("http://snomed.info/sct"),
                    Code = new FhirCode("73211009"),
                    Display = new FhirString("Diabetes mellitus")
                }
            };
            codeableConcept.Text = new FhirString("Diabetes mellitus with glucose monitoring");

            // Assert
            Assert.NotNull(codeableConcept.Coding);
            Assert.Single(codeableConcept.Coding);
            Assert.NotNull(codeableConcept.Text);
            Assert.Equal("Diabetes mellitus with glucose monitoring", codeableConcept.Text?.Value);
        }

        [Fact]
        public void TestCodeableConcept_WithEmptyCodingList_IsValid()
        {
            // Arrange
            var codeableConcept = new CodeableConcept();

            // Act
            codeableConcept.Coding = new List<Coding>();

            // Assert
            Assert.NotNull(codeableConcept.Coding);
            Assert.Empty(codeableConcept.Coding);
        }

        #endregion
    }
} 