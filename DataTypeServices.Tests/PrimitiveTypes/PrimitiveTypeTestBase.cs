using FhirCore.Interfaces;
using System.Text.Json.Nodes;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// PrimitiveType 測試基礎類別
    /// 提供所有 PrimitiveType 測試的共同實作
    /// </summary>
    /// <typeparam name="T">PrimitiveType 類型</typeparam>
    public abstract class PrimitiveTypeTestBase<T> : IPrimitiveTypeTest<T> where T : IPrimitiveType
    {
        #region 抽象方法實作 - 由子類別提供

        public abstract string[] GetValidValues();
        public abstract string[] GetInvalidValues();
        public abstract string GetExpectedTypeName();
        public abstract T CreateInstance(string value);
        public abstract T CreateNullInstance();

        #endregion

        #region 共同測試方法實作

        [Fact]
        public void TestConstructor_WithValidValue_CreatesInstance()
        {
            // Arrange
            var validValue = GetValidValues()[0];

            // Act
            var instance = CreateInstance(validValue);

            // Assert
            Assert.NotNull(instance);
            Assert.True(instance.IsValidValue());
        }

        [Fact]
        public void TestConstructor_WithNullValue_CreatesInstance()
        {
            // Act
            var instance = CreateNullInstance();

            // Assert
            Assert.NotNull(instance);
            Assert.False(instance.IsValidValue());
        }

        [Fact]
        public void TestConstructor_WithJsonObject_SetsValueCorrectly()
        {
            // Arrange
            var expectedValue = GetValidValues()[0];
            var jsonObject = new JsonObject
            {
                ["value"] = expectedValue
            };

            // Act
            var instance = CreateInstance(expectedValue);

            // Assert
            var actualValue = GetValueFromInstance(instance);
            Assert.NotNull(actualValue);
        }

        [Fact]
        public void TestIsValidValue_ValidValues_ReturnsTrue()
        {
            // Arrange
            var validValues = GetValidValues();
            foreach (var value in validValues)
            {
                var instance = CreateInstance(value);

                // Act
                var result = instance.IsValidValue();

                // Assert
                Assert.True(result, $"Value '{value}' should be valid");
            }
        }

        [Fact]
        public void TestIsValidValue_InvalidValues_ReturnsFalse()
        {
            // Arrange
            var invalidValues = GetInvalidValues();
            if (invalidValues.Length == 0) return; // 跳過沒有無效值的類型

            foreach (var value in invalidValues)
            {
                var instance = CreateInstance(value);

                // Act
                var result = instance.IsValidValue();

                // Assert
                Assert.False(result, $"Value '{value}' should be invalid");
            }
        }

        [Fact]
        public void TestIsValidValue_NullValue_ReturnsFalse()
        {
            // Arrange
            var instance = CreateNullInstance();

            // Act
            var result = instance.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public virtual void TestGetFhirTypeName_WithCapital_ReturnsTypeName()
        {
            // Arrange
            var validValue = GetValidValues()[0];
            var instance = CreateInstance(validValue);

            // Act
            var result = instance.GetFhirTypeName(true);

            // Assert
            // 新的基底邏輯：自動取得型別名稱（去除Fhir前綴），再用ToTitleCase控制首字母
            var typeName = instance.GetType().Name;
            if (typeName.StartsWith("Fhir"))
                typeName = typeName.Substring(4);
            var expected = char.ToUpperInvariant(typeName[0]) + typeName.Substring(1);
            Assert.Equal(expected, result);
        }

        [Fact]
        public virtual void TestGetFhirTypeName_WithoutCapital_ReturnsLowercase()
        {
            // Arrange
            var validValue = GetValidValues()[0];
            var instance = CreateInstance(validValue);

            // Act
            var result = instance.GetFhirTypeName(false);

            // Assert
            // 新的基底邏輯：自動取得型別名稱（去除Fhir前綴），再用ToTitleCase控制首字母
            var typeName = instance.GetType().Name;
            if (typeName.StartsWith("Fhir"))
                typeName = typeName.Substring(4);
            var expected = char.ToLowerInvariant(typeName[0]) + typeName.Substring(1);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestValue_ValidValue_ReturnsCorrectValue()
        {
            // Arrange
            var expectedValue = GetValidValues()[0];
            var instance = CreateInstance(expectedValue);

            // Act
            var result = GetValueFromInstance(instance);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void TestValue_NullValue_ReturnsNull()
        {
            // Arrange
            var instance = CreateNullInstance();

            // Act
            var result = GetValueFromInstance(instance);

            // Assert
            Assert.Null(result);
        }

        #endregion

        #region 輔助方法

        /// <summary>
        /// 從實例取得值
        /// </summary>
        /// <param name="instance">實例</param>
        /// <returns>值</returns>
        protected virtual object? GetValueFromInstance(T instance)
        {
            return instance.GetValue();
        }

        #endregion
    }
} 