using Fhir.TypeFramework.Bases;

namespace Fhir.Validation;

public interface IProfileValidator
{
    ProfileValidationReport Validate(
        Base instance,
        IReadOnlyList<string> profileCanonicals,
        ProfileValidationOptions? options = null);
}
