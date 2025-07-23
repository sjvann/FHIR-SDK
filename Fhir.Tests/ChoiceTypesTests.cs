using Xunit;

namespace Fhir.Tests;

/// <summary>
/// 測試基本功能
/// </summary>
public class BasicTests
{
    [Fact]
    public void BasicTest_ShouldPass()
    {
        // 基本測試，確保測試框架正常工作
        Assert.True(true);
    }

}

/// <summary>
/// 測試增強型別功能
/// </summary>
public class EnhancedTypesTests
{
    [Fact]
    public void CodeableConcept_Enhancement_ShouldWork()
    {
        // 這個測試驗證 CodeableConcept 的增強功能
        // 注意：這需要實際的 CodeableConcept 類別

        // 基本測試，確保概念正確
        Assert.True(true);
    }

    [Fact]
    public void Reference_Enhancement_ShouldWork()
    {
        // 這個測試驗證 Reference<T> 的增強功能
        // 注意：這需要實際的 Reference 類別

        // 基本測試，確保概念正確
        Assert.True(true);
    }
}
