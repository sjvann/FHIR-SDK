using System.Reflection;
using Fhir.Support.Versioning;

namespace Fhir.Support
{
    /// <summary>
    /// Provides a concrete implementation of IFhirContext.
    /// It is responsible for loading the correct model assembly based on the specified FHIR version.
    /// </summary>
    public class FhirContext : IFhirContext
    {
        /// <inheritdoc/>
        public Versioning.FhirVersion Version { get; }

        /// <inheritdoc/>
        public Assembly ModelAssembly { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirContext"/> class for a specific FHIR version.
        /// </summary>
        /// <param name="version">The FHIR version to use.</param>
        /// <exception cref="TypeLoadException">Thrown if the required model assembly (e.g., Fhir.Models.R5.dll) cannot be found. This typically means the corresponding NuGet package is not referenced.</exception>
        public FhirContext(Versioning.FhirVersion version)
        {
            Version = version;
            ModelAssembly = LoadModelAssembly(version);
        }

        private Assembly LoadModelAssembly(Versioning.FhirVersion version)
        {
            // The assembly name convention is assumed to be "Fhir.Models.{Version}", e.g., "Fhir.Models.R5"
            // Note: This requires the corresponding model project (e.g., Fhir.Models.R5) to be built and its DLL present in the output directory.
            var assemblyName = new AssemblyName($"Fhir.Models.{version}");
            try
            {
                return Assembly.Load(assemblyName);
            }
            catch (Exception ex)
            {
                throw new TypeLoadException($"Could not load the model assembly for FHIR version {version}. Ensure the '{assemblyName}.dll' project/package is referenced and built.", ex);
            }
        }
    }
} 