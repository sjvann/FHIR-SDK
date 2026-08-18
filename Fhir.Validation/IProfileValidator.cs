using Fhir.TypeFramework.Bases;

namespace Fhir.Validation;

public interface IProfileValidator
{
    ProfileValidationReport Validate(
        Base instance,
        IReadOnlyList<string> profileCanonicals,
        ProfileValidationOptions? options = null);

    ProfileValidationReport Validate(Base instance, ProfileValidationOptions? options = null)
        => Validate(instance, Array.Empty<string>(), options);
}
