using DataTypeServices.DataTypes.PrimitiveTypes;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// PrimitiveType 測試模板
    /// 
    /// 使用方式：
    /// 1. 複製此檔案並重新命名為 [TypeName]Tests.cs
    /// 2. 修改 using 語句指向正確的類型
    /// 3. 修改類別名稱
    /// 4. 修改測試中的類型名稱
    /// 5. 修改有效值和無效值
    /// 6. 修改特定測試
    /// 
    /// 範例：
    /// - 將 FhirString 改為 FhirBoolean
    /// - 將 "string" 改為 "boolean"
    /// - 將有效值改為 true/false
    /// - 將無效值改為空陣列（如果沒有無效值）
    /// </summary>
    public class PrimitiveTypeTestTemplate
    {
        #region 基本測試

        [Fact]
        public void Constructor_WithValidValue_CreatesInstance()
        {
            // Arrange & Act
            var instance = new FhirString("test"); // 修改為實際類型

            // Assert
            Assert.NotNull(instance);
            Assert.True(instance.IsValidValue());
        }

        [Fact]
        public void Constructor_WithNullValue_CreatesInstance()
        {
            // Arrange & Act
            var instance = new FhirString(null); // 修改為實際類型

            // Assert
            Assert.NotNull(instance);
            Assert.False(instance.IsValidValue());
        }

        [Fact]
        public void Constructor_WithStringValue_CreatesInstance()
        {
            // Arrange & Act
            var instance = new FhirString("test"); // 修改為實際類型

            // Assert
            Assert.NotNull(instance);
            Assert.True(instance.IsValidValue());
        }

        #endregion

        #region 驗證測試

        [Theory]
        [InlineData("valid1")] // 修改為實際的有效值
        [InlineData("valid2")]
        [InlineData("valid3")]
        public void ValidValues_AreValid(string value)
        {
            // Arrange
            var instance = new FhirString(value); // 修改為實際類型

            // Act
            var result = instance.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.Equal(value, instance.Value);
        }

        [Theory]
        [InlineData("invalid1")] // 修改為實際的無效值，如果沒有則刪除此測試
        [InlineData("invalid2")]
        public void InvalidValues_AreInvalid(string value)
        {
            // Arrange
            var instance = new FhirString(value); // 修改為實際類型

            // Act
            var result = instance.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void NullValue_IsInvalid()
        {
            // Arrange
            var instance = new FhirString(null); // 修改為實際類型

            // Act
            var result = instance.IsValidValue();

            // Assert
            Assert.False(result);
        }

        #endregion

        #region 類型名稱測試

        [Fact]
        public void GetFhirTypeName_ReturnsCorrectName()
        {
            // Arrange
            var instance = new FhirString("test"); // 修改為實際類型

            // Act
            var result = instance.GetFhirTypeName(true);

            // Assert
            Assert.Equal("String", result); // 修改為實際的類型名稱
        }

        [Fact]
        public void GetFhirTypeName_Lowercase_ReturnsCorrectName()
        {
            // Arrange
            var instance = new FhirString("test"); // 修改為實際類型

            // Act
            var result = instance.GetFhirTypeName(false);

            // Assert
            Assert.Equal("string", result); // 修改為實際的類型名稱（小寫）
        }

        #endregion

        #region 詳細驗證測試

        [Fact]
        public void ValidateDetailed_ValidValue_ReturnsSuccess()
        {
            // Arrange
            var instance = new FhirString("valid"); // 修改為實際類型

            // Act
            var result = instance.ValidateDetailed();

            // Assert
            Assert.True(result.IsValid);
            Assert.Null(result.ErrorMessage);
        }

        [Fact]
        public void ValidateDetailed_InvalidValue_ReturnsError()
        {
            // Arrange
            var instance = new FhirString(null); // 修改為實際類型

            // Act
            var result = instance.ValidateDetailed();

            // Assert
            Assert.False(result.IsValid);
            Assert.NotNull(result.ErrorMessage);
        }

        #endregion

        #region 特定類型測試

        // 在這裡添加該類型特有的測試
        // 例如：FhirBoolean 的 true/false 測試
        // 例如：FhirInteger 的數字範圍測試
        // 例如：FhirDate 的日期格式測試

        [Fact]
        public void Specific_TestName()
        {
            // Arrange
            var instance = new FhirString("specific test"); // 修改為實際類型

            // Act
            var result = instance.IsValidValue();

            // Assert
            Assert.True(result);
            // 添加特定的斷言
        }

        #endregion

        #region JSON 測試

        [Fact]
        public void GetElementJsonString_ReturnsValidJson()
        {
            // Arrange
            var instance = new FhirString("test"); // 修改為實際類型

            // Act
            var result = instance.GetElementJsonString();

            // Assert
            Assert.NotNull(result);
            Assert.Contains("test", result);
        }

        [Fact]
        public void SetElementObject_WithValidJson_SetsValue()
        {
            // Arrange
            var instance = new FhirString(); // 修改為實際類型
            var jsonNode = System.Text.Json.JsonSerializer.SerializeToNode("new value");

            // Act
            instance.SetElementObject(jsonNode);

            // Assert
            Assert.True(instance.IsValidValue());
            Assert.Equal("new value", instance.Value);
        }

        #endregion

        #region 值比較測試

        [Fact]
        public void ValueEquals_SameValue_ReturnsTrue()
        {
            // Arrange
            var instance1 = new FhirString("test"); // 修改為實際類型
            var instance2 = new FhirString("test"); // 修改為實際類型

            // Act
            var result = instance1.ValueEquals(instance2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValueEquals_DifferentValue_ReturnsFalse()
        {
            // Arrange
            var instance1 = new FhirString("test1"); // 修改為實際類型
            var instance2 = new FhirString("test2"); // 修改為實際類型

            // Act
            var result = instance1.ValueEquals(instance2);

            // Assert
            Assert.False(result);
        }

        #endregion

        #region 元素測試

        [Fact]
        public void HasElement_NoElement_ReturnsFalse()
        {
            // Arrange
            var instance = new FhirString("test"); // 修改為實際類型

            // Act
            var result = instance.HasElement();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GetJsonValue_ReturnsValidJson()
        {
            // Arrange
            var instance = new FhirString("test"); // 修改為實際類型

            // Act
            var result = instance.GetJsonValue();

            // Assert
            Assert.NotNull(result);
            Assert.Equal("test", result.ToString());
        }

        #endregion
    }
} 