using Fhir.Path.R4;
using Fhir.Resources.R4;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.Path.Tests;

public class FhirPathChoiceNavigationTests
{
    readonly FhirPathR4 _path = FhirPathR4.Create();

    [Fact]
    public void Observation_value_exists_resolves_valueQuantity()
    {
        var obs = new Observation
        {
            Status = new FhirCode("final"),
            ValueQuantity = new Quantity { Value = 98, Unit = "mmHg" },
        };

        var exists = _path.Evaluate("value.exists()", obs).SingleOrDefault();
        Assert.Equal(true, exists);
    }

    [Fact]
    public void Observation_vs2_constraint_passes_when_valueQuantity_present()
    {
        var obs = new Observation
        {
            Status = new FhirCode("final"),
            ValueQuantity = new Quantity { Value = 98, Unit = "mmHg" },
        };

        const string vs2 =
            "(component.empty() and hasMember.empty()) implies (dataAbsentReason.exists() or value.exists())";

        var result = _path.Evaluate(vs2, obs).SingleOrDefault();
        Assert.Equal(true, result);
    }
}
