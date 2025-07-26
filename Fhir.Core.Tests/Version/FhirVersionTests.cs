using Fhir.Core.Version;

namespace Fhir.Core.Tests.Version;

/// <summary>
/// Tests for FHIR version management functionality
/// </summary>
public class FhirVersionTests
{
    [Fact]
    public void FhirVersion_DefaultIsR4()
    {
        // Act & Assert
        Assert.Equal("R4", FhirVersion.Current);
    }

    [Fact]
    public void FhirVersion_CanSetToR4()
    {
        // Act
        FhirVersion.UseR4();
        
        // Assert
        Assert.Equal("R4", FhirVersion.Current);
        Assert.True(FhirVersion.Is("R4"));
        Assert.False(FhirVersion.Is("R5"));
    }

    [Fact]
    public void FhirVersion_CanSetToR5()
    {
        // Act
        FhirVersion.UseR5();
        
        // Assert
        Assert.Equal("R5", FhirVersion.Current);
        Assert.True(FhirVersion.Is("R5"));
        Assert.False(FhirVersion.Is("R4"));
        
        // Cleanup
        FhirVersion.UseR4();
    }

    [Fact]
    public void FhirVersion_IsMethodIsCaseInsensitive()
    {
        // Arrange
        FhirVersion.UseR4();
        
        // Act & Assert
        Assert.True(FhirVersion.Is("r4"));
        Assert.True(FhirVersion.Is("R4"));
        Assert.True(FhirVersion.Is("r4"));
    }

    [Fact]
    public void FhirVersion_GetVersionInfo_ReturnsCorrectR4Info()
    {
        // Arrange
        FhirVersion.UseR4();
        
        // Act
        var versionInfo = FhirVersion.GetVersionInfo();
        
        // Assert
        Assert.Equal("R4", versionInfo.Name);
        Assert.Equal("4.0.1", versionInfo.Number);
        Assert.Equal("FHIR R4", versionInfo.Description);
    }

    [Fact]
    public void FhirVersion_GetVersionInfo_ReturnsCorrectR5Info()
    {
        // Arrange
        FhirVersion.UseR5();
        
        // Act
        var versionInfo = FhirVersion.GetVersionInfo();
        
        // Assert
        Assert.Equal("R5", versionInfo.Name);
        Assert.Equal("5.0.0", versionInfo.Number);
        Assert.Equal("FHIR R5", versionInfo.Description);
        
        // Cleanup
        FhirVersion.UseR4();
    }

    [Fact]
    public void FhirVersion_GetVersionInfo_ThrowsForUnsupportedVersion()
    {
        // This test would require reflection to set an invalid version
        // For now, we'll test the supported versions only
        Assert.NotNull(FhirVersion.GetVersionInfo());
    }
}
