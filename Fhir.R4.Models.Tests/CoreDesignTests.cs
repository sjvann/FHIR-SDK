using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Xunit;

namespace Fhir.R4.Models.Tests;

/// <summary>
/// 核心設計驗證測試
/// 驗證我們的 FHIR SDK 設計是否正確實作
/// </summary>
public class CoreDesignTests
{
    [Fact]
    public void Base_Hierarchy_Should_Work()
    {
        // 測試基本的繼承層次
        var extension = new Extension { Url = "http://example.org/test" };
        
        // Extension 應該繼承自 Base
        Assert.IsAssignableFrom<Fhir.R4.Models.Base.Base>(extension);
        
        // 但不應該繼承自 Element（避免循環依賴）
        Assert.False(extension is Element);
    }
    
    [Fact]
    public void Extension_Choice_Type_Should_Be_Mutually_Exclusive()
    {
        var extension = new Extension
        {
            Url = "http://example.org/test"
        };
        
        // 設定 string 值
        extension.ValueString = "test";
        Assert.Equal("test", extension.ValueString);
        Assert.Null(extension.ValueInteger);
        Assert.Null(extension.ValueBoolean);
        
        // 設定 integer 值應該清除 string 值
        extension.ValueInteger = 42;
        Assert.Null(extension.ValueString);  // 應該被清除
        Assert.Equal(42, extension.ValueInteger);
        Assert.Null(extension.ValueBoolean);
        
        // 設定 boolean 值應該清除 integer 值
        extension.ValueBoolean = true;
        Assert.Null(extension.ValueString);
        Assert.Null(extension.ValueInteger);  // 應該被清除
        Assert.True(extension.ValueBoolean);
    }
    
    [Fact]
    public void Extension_Should_Validate_Correctly()
    {
        // 測試無效的 Extension（沒有 URL）
        var invalidExtension = new Extension();
        var validationContext = new ValidationContext(invalidExtension);
        var validationResults = invalidExtension.Validate(validationContext).ToList();
        
        Assert.NotEmpty(validationResults);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("url is required") == true);
        
        // 測試無效的 Extension（沒有值也沒有子 extension）
        invalidExtension.Url = "http://example.org/test";
        validationResults = invalidExtension.Validate(validationContext).ToList();
        
        Assert.NotEmpty(validationResults);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("must have either a value") == true);
        
        // 測試有效的 Extension
        var validExtension = new Extension
        {
            Url = "http://example.org/test",
            ValueString = "test value"
        };
        
        validationResults = validExtension.Validate(new ValidationContext(validExtension)).ToList();
        Assert.Empty(validationResults);
    }
    
    [Fact]
    public void Extension_Should_Not_Allow_Both_Value_And_SubExtensions()
    {
        var extension = new Extension
        {
            Url = "http://example.org/test",
            ValueString = "test",
            SubExtensions = new List<Extension>
            {
                new Extension { Url = "http://example.org/sub", ValueString = "sub" }
            }
        };
        
        var validationContext = new ValidationContext(extension);
        var validationResults = extension.Validate(validationContext).ToList();
        
        Assert.NotEmpty(validationResults);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("cannot have both") == true);
    }
    
    [Fact]
    public void ChoiceType_Should_Enforce_Type_Safety()
    {
        var choice = new ChoiceType<FhirString, FhirInteger>();
        
        // 測試隱式轉換
        choice = new FhirString("test string");
        Assert.Equal("test string", choice.AsT1()?.Value);
        Assert.Null(choice.AsT2());

        choice = new FhirInteger(42);
        Assert.Null(choice.AsT1());
        Assert.Equal(42, choice.AsT2()?.Value);
        
        // 測試型別檢查
        Assert.True(choice.IsAllowedType<FhirString>());
        Assert.True(choice.IsAllowedType<FhirInteger>());
        Assert.False(choice.IsAllowedType<FhirBoolean>());
        
        // 測試不允許的型別
        Assert.Throws<ArgumentException>(() => choice.Value = new FhirBoolean(true));
    }
    
    [Fact]
    public void ChoiceType_Should_Validate_Mutual_Exclusivity()
    {
        var choice = new ChoiceType<FhirString, FhirInteger>();
        
        // 空的 Choice Type 應該無效
        var validationContext = new ValidationContext(choice);
        var validationResults = choice.Validate(validationContext).ToList();
        
        Assert.NotEmpty(validationResults);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("must have exactly one value") == true);
        
        // 有值的 Choice Type 應該有效
        choice.Value1 = new FhirString("test");
        validationResults = choice.Validate(validationContext).ToList();
        Assert.Empty(validationResults);
    }
    
    [Fact]
    public void Element_Should_Support_Extensions()
    {
        // 建立一個測試用的 Element 子類別
        var testElement = new TestElement
        {
            Id = "test-element"
        };
        
        // 測試添加 Extension
        testElement.AddExtension("http://example.org/test", "test value");
        
        Assert.True(testElement.HasExtensions);
        Assert.Single(testElement.Extension!);
        
        var ext = testElement.GetExtension("http://example.org/test");
        Assert.NotNull(ext);
        Assert.Equal("test value", ext.ValueString);
        
        // 測試移除 Extension
        var removed = testElement.RemoveExtension("http://example.org/test");
        Assert.True(removed);
        Assert.False(testElement.HasExtensions);
    }
    
    [Fact]
    public void Element_Should_Validate_ID_Format()
    {
        var testElement = new TestElement
        {
            Id = "invalid id with spaces"  // 無效的 ID
        };
        
        var validationContext = new ValidationContext(testElement);
        var validationResults = testElement.Validate(validationContext).ToList();
        
        Assert.NotEmpty(validationResults);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("not valid") == true);
        
        // 測試有效的 ID
        testElement.Id = "valid-id.123";
        validationResults = testElement.Validate(validationContext).ToList();
        Assert.Empty(validationResults);
    }
    
    [Fact]
    public void JSON_Serialization_Should_Work_Correctly()
    {
        var extension = new Extension
        {
            Url = "http://example.org/test",
            ValueString = "test value"
        };
        
        // 序列化
        var json = JsonSerializer.Serialize(extension, new JsonSerializerOptions 
        { 
            WriteIndented = true 
        });
        
        Assert.Contains("\"url\"", json);
        Assert.Contains("\"valueString\"", json);
        Assert.Contains("\"test value\"", json);
        
        // 反序列化
        var deserializedExtension = JsonSerializer.Deserialize<Extension>(json);
        
        Assert.NotNull(deserializedExtension);
        Assert.Equal("http://example.org/test", deserializedExtension.Url);
        Assert.Equal("test value", deserializedExtension.ValueString);
    }
}

/// <summary>
/// 測試用的 Element 子類別
/// </summary>
public class TestElement : Element
{
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        return base.Validate(validationContext);
    }
}
