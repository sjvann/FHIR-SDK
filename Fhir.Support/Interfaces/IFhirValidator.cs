namespace Fhir.Support.Interfaces;

using Fhir.Support.Models;
using System.Collections.Generic;

/// <summary>
/// Defines the interface for a FHIR resource validator.
/// </summary>
public interface IFhirValidator
{
    /// <summary>
    /// Validates a resource.
    /// </summary>
    /// <param name="resource">The resource to validate.</param>
    /// <returns>A list of validation issues.</returns>
    List<ValidationIssue> Validate(IResource resource);
} 