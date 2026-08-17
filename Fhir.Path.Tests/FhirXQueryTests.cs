using Fhir.Path;
using Fhir.Path.Navigation;
using Fhir.Path.R5;
using Fhir.Resources.R5;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Fhir.TypeFramework.Interop;

namespace Fhir.Path.Tests;

public class FhirXQueryTests
{
    [Fact]
    public void Resolve_substitutes_patient_id()
    {
        var patient = new Patient { Id = "abc".ToFhirId() };
        var ctx = new FhirPathEvaluationContext();
        ctx.SetVariable("patient", PocoElementNavigator.Wrap(patient));

        var sdk = FhirPathR5.Create();
        var query = "Observation?subject={{%patient.id}}";
        var resolved = sdk.ResolveXQuery(query, ctx);

        Assert.Contains("Patient/abc", resolved);
        Assert.DoesNotContain("{{", resolved);
    }

    [Fact]
    public void Resolve_today_in_date_parameter()
    {
        var ctx = new FhirPathEvaluationContext
        {
            Clock = () => new DateTimeOffset(2026, 5, 18, 12, 0, 0, TimeSpan.Zero)
        };
        ctx.SetVariable("patient", PocoElementNavigator.Wrap(new Patient()));

        var sdk = FhirPathR5.Create();
        var resolved = sdk.ResolveXQuery("Observation?date=gt{{today()}}", ctx);
        Assert.Contains("date=gt2026-05-18", resolved);
    }
}
