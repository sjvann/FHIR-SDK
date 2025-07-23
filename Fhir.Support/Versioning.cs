using System.Reflection;

namespace Fhir.Support.Versioning
{
    /// <summary>
    /// Represents the major versions of the FHIR specification.
    /// </summary>
    public enum FhirVersion
    {
        /// <summary>
        /// FHIR Release 5
        /// </summary>
        R5,

        /// <summary>
        /// FHIR Release 6 (Future)
        /// </summary>
        R6
    }

    /// <summary>
    /// Defines the context for FHIR operations, specifying which version is currently active.
    /// This interface is intended for dependency injection.
    /// </summary>
    public interface IFhirContext
    {
        /// <summary>
        /// Gets the currently active FHIR version.
        /// </summary>
        FhirVersion Version { get; }

        /// <summary>
        /// Gets the loaded assembly containing the FHIR models for the specified version.
        /// </summary>
        Assembly ModelAssembly { get; }
    }
} 