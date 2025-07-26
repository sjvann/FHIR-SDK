using System.ComponentModel.DataAnnotations;
using Fhir.Core.Abstractions;

namespace Fhir.Core.Tests.Abstractions;

/// <summary>
/// Tests for IResource interface functionality
/// </summary>
public class IResourceTests
{
    /// <summary>
    /// Test implementation of IResource for testing purposes
    /// </summary>
    private class TestResource : IResource
    {
        public string? Id { get; set; }
        public string ResourceType => "TestResource";

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(Id))
                yield return new ValidationResult("Id is required");
        }
    }

    [Fact]
    public void IResource_CanSetAndGetId()
    {
        // Arrange
        var resource = new TestResource();
        
        // Act
        resource.Id = "test-123";
        
        // Assert
        Assert.Equal("test-123", resource.Id);
    }

    [Fact]
    public void IResource_ResourceTypeIsCorrect()
    {
        // Arrange & Act
        var resource = new TestResource();
        
        // Assert
        Assert.Equal("TestResource", resource.ResourceType);
    }

    [Fact]
    public void IResource_ValidateReturnsErrorWhenIdIsNull()
    {
        // Arrange
        var resource = new TestResource { Id = null };
        var context = new ValidationContext(resource);
        
        // Act
        var results = resource.Validate(context).ToList();
        
        // Assert
        Assert.Single(results);
        Assert.Equal("Id is required", results[0].ErrorMessage);
    }

    [Fact]
    public void IResource_ValidateReturnsNoErrorWhenIdIsSet()
    {
        // Arrange
        var resource = new TestResource { Id = "test-123" };
        var context = new ValidationContext(resource);
        
        // Act
        var results = resource.Validate(context).ToList();
        
        // Assert
        Assert.Empty(results);
    }
}
