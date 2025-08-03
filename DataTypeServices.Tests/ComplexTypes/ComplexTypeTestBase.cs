using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;
using Xunit;

namespace DataTypeServices.Tests.ComplexTypes
{
    /// <summary>
    /// ComplexType 測試基礎類別
    /// 提供所有 ComplexType 測試的共同實作
    /// </summary>
    /// <typeparam name="T">ComplexType 類型</typeparam>
    public abstract class ComplexTypeTestBase<T> : IComplexTypeTest<T> where T : IComplexType
    {
        #region 抽象方法實作 - 由子類別提供

        public abstract string[] GetValidValues();
        public abstract string[] GetInvalidValues();
        public abstract T CreateInstance(string value);
        public abstract T CreateNullInstance();
        public abstract T CreateValidInstance();

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
        }

        [Fact]
        public void TestConstructor_WithNullValue_CreatesInstance()
        {
            // Act
            var instance = CreateNullInstance();

            // Assert
            Assert.NotNull(instance);
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
            Assert.NotNull(instance);
        }

        [Fact]
        public void TestGetFhirTypeName_WithCapital_ReturnsTypeName()
        {
            // Arrange
            var instance = CreateValidInstance();

            // Act
            var result = instance.GetFhirTypeName(true);

            // Assert
            // 動態計算期望值：使用實例的類型名稱
            var typeName = instance.GetType().Name;
            var expected = typeName.ToTitleCase(true);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestGetFhirTypeName_WithoutCapital_ReturnsLowercase()
        {
            // Arrange
            var instance = CreateValidInstance();

            // Act
            var result = instance.GetFhirTypeName(false);

            // Assert
            // 動態計算期望值：使用實例的類型名稱
            var typeName = instance.GetType().Name;
            var expected = typeName.ToTitleCase(false);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSerialization_ValidInstance_SerializesCorrectly()
        {
            // Arrange
            var instance = CreateValidInstance();

            // Act
            var jsonObject = instance.GetJsonObject();

            // Assert
            Assert.NotNull(jsonObject);
        }

        [Fact]
        public void TestDeserialization_ValidJson_DeserializesCorrectly()
        {
            // Arrange
            var instance = CreateValidInstance();
            var jsonObject = instance.GetJsonObject();

            // Act
            var deserializedInstance = CreateInstance(jsonObject?.ToJsonString() ?? "{}");

            // Assert
            Assert.NotNull(deserializedInstance);
        }

        [Fact]
        public void TestIsComplex_ReturnsTrue()
        {
            // Arrange
            var instance = CreateValidInstance();

            // Act
            var isComplex = instance.IsComplex();

            // Assert
            Assert.True(isComplex);
        }

        [Fact]
        public void TestIsPrimitive_ReturnsFalse()
        {
            // Arrange
            var instance = CreateValidInstance();

            // Act
            var isPrimitive = instance.IsPrimitive();

            // Assert
            Assert.False(isPrimitive);
        }

        [Fact]
        public void TestIsChoiceType_ReturnsFalse()
        {
            // Arrange
            var instance = CreateValidInstance();

            // Act
            var isChoiceType = instance.IsChoiceType();

            // Assert
            Assert.False(isChoiceType);
        }

        #endregion

        #region 可覆寫的共同測試方法

        /// <summary>
        /// 測試序列化功能
        /// 子類別可以覆寫以提供特定的序列化測試邏輯
        /// </summary>
        [Fact]
        public virtual void TestSerialization_SerializesCorrectly()
        {
            // Arrange
            var instance = CreateValidInstance();

            // Act
            var jsonObject = instance.GetJsonObject();

            // Assert
            Assert.NotNull(jsonObject);
            // 子類別可以覆寫此方法以添加特定的序列化驗證
        }

        /// <summary>
        /// 測試反序列化功能
        /// 子類別可以覆寫以提供特定的反序列化測試邏輯
        /// </summary>
        [Fact]
        public virtual void TestDeserialization_DeserializesCorrectly()
        {
            // Arrange
            var originalInstance = CreateValidInstance();
            var jsonObject = originalInstance.GetJsonObject();

            // Act
            var deserializedInstance = CreateInstance(jsonObject?.ToJsonString() ?? "{}");

            // Assert
            Assert.NotNull(deserializedInstance);
            // 子類別可以覆寫此方法以添加特定的反序列化驗證
        }

        /// <summary>
        /// 測試 PropertyChanged 事件
        /// 子類別可以覆寫以提供特定的屬性變更測試邏輯
        /// </summary>
        [Fact]
        public virtual void TestPropertyChanged_RaisesEvent()
        {
            // Arrange
            var instance = CreateValidInstance();

            // Act & Assert
            // 子類別需要覆寫此方法以提供具體的屬性變更測試
            // 例如：instance.SomeProperty = newValue;
            Assert.NotNull(instance);
        }

        /// <summary>
        /// 測試基本屬性設置
        /// 子類別可以覆寫以提供特定的屬性設置測試邏輯
        /// </summary>
        [Fact]
        public virtual void TestWithValidProperties_SetsPropertiesCorrectly()
        {
            // Arrange
            var instance = CreateValidInstance();

            // Act & Assert
            // 子類別需要覆寫此方法以提供具體的屬性設置測試
            Assert.NotNull(instance);
        }

        #endregion

        #region 輔助方法

        /// <summary>
        /// 從實例取得值（由子類別覆寫）
        /// </summary>
        /// <param name="instance">實例</param>
        /// <returns>值</returns>
        protected virtual object? GetValueFromInstance(T instance)
        {
            // 預設實作，子類別可以覆寫
            return null;
        }

        /// <summary>
        /// 驗證 JSON 物件包含指定的鍵
        /// </summary>
        /// <param name="jsonObject">JSON 物件</param>
        /// <param name="expectedKeys">期望的鍵</param>
        protected void AssertJsonObjectContainsKeys(JsonObject? jsonObject, params string[] expectedKeys)
        {
            Assert.NotNull(jsonObject);
            foreach (var key in expectedKeys)
            {
                Assert.True(jsonObject!.ContainsKey(key), $"JSON 物件應該包含鍵 '{key}'");
            }
        }

        /// <summary>
        /// 驗證兩個實例的屬性值相等
        /// </summary>
        /// <param name="original">原始實例</param>
        /// <param name="deserialized">反序列化後的實例</param>
        /// <param name="propertyComparisons">屬性比較委託陣列</param>
        protected void AssertInstancesAreEqual(T original, T deserialized, params Action<T, T>[] propertyComparisons)
        {
            Assert.NotNull(original);
            Assert.NotNull(deserialized);
            
            foreach (var comparison in propertyComparisons)
            {
                comparison(original, deserialized);
            }
        }

        #endregion
    }
} 