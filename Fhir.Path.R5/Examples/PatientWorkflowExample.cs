using Fhir.Path;
using Fhir.Path.R5;
using Fhir.Path.R5.Patch;
using Fhir.Resources.R5;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.Interop;

namespace Fhir.Path.R5.Examples;

/// <summary>易用性 API 範例（Patient 工作流）。</summary>
public static class PatientWorkflowExample
{
    public static Patient Run()
    {
        var patient = new Patient
        {
            Name = [new HumanName().WithFamily("Doe").WithGiven("John")]
        };

        var sdk = FhirPathR5.Create();
        var given = patient.FhirPath("name.given");
        _ = given;

        var patch = FhirPathPatchBuilder.Create()
            .Add("Patient", "birthDate", "1930-01-01".ToFhirDateFromLexical())
            .BuildParameters();

        patient = sdk.ApplyPatch(patient, patch);

        var query =
            "Observation?code=http://loinc.org|65972-2&subject={{%patient.id}}";
        var ctx = new FhirPathEvaluationContext();
        ctx.SetVariable("patient", Navigation.PocoElementNavigator.Wrap(patient));
        _ = sdk.ResolveXQuery(query, ctx);

        return patient;
    }
}
