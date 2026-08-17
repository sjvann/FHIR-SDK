using Fhir.Resources.R5;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.Interop;

namespace Fhir.TypeFramework.Interop.Tests;

public class ChoiceAccessorTests
{
    [Fact]
    public void SetDeceased_boolean_clears_sibling_and_reads_back()
    {
        var patient = new Patient
        {
            DeceasedDateTime = new FhirDateTime("2020-01-01")
        };

        patient.SetDeceased(new FhirBoolean(true));

        Assert.True(patient.HasDeceased);
        Assert.Equal("boolean", patient.GetDeceasedChoiceType());
        Assert.Null(patient.DeceasedDateTime);
        Assert.NotNull(patient.DeceasedBoolean);
    }

    [Fact]
    public void SetChoice_via_extension_matches_accessor()
    {
        var patient = new Patient();
        patient.SetChoice("multipleBirth", new FhirInteger(2));

        Assert.True(patient.TryGetChoice("multipleBirth", out var value));
        Assert.IsType<FhirInteger>(value);
        Assert.Equal("integer", patient.GetActiveChoiceType("multipleBirth"));
    }

    [Fact]
    public void Clear_removes_all_variants()
    {
        var patient = new Patient();
        patient.SetDeceased(new FhirBoolean(false));
        patient.ClearDeceased();

        Assert.False(patient.HasDeceased);
        Assert.Null(patient.DeceasedBoolean);
    }
}
