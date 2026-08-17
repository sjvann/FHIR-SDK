using Fhir.Path.R5;
using Fhir.Path.R5.Patch;
using Fhir.Resources.R5;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.Interop;

namespace Fhir.Path.Tests;

public class FhirPathPatchTests
{
  private readonly FhirPathR5 _sdk = FhirPathR5.Create();

  [Fact]
  public void Add_birthDate_matches_hl7_example()
  {
    var patient = new Patient { Name = [new HumanName().WithFamily("Test")] };
    var patch = FhirPathPatchBuilder.Create()
      .Add("Patient", "birthDate", "1930-01-01".ToFhirDateFromLexical())
      .BuildParameters();

    var patched = _sdk.ApplyPatch(patient, patch);
    Assert.Equal("1930-01-01", patched.BirthDate?.StringValue);
  }

  [Fact]
  public void Add_processing_with_anonymous_parts()
  {
    var specimen = new Specimen();
    var patch = FhirPathPatchBuilder.Create()
      .Add("Specimen", "processing", new Dictionary<string, object?>
      {
        ["description"] = "test".ToFhirString(),
        ["time"] = "2021-08-13T07:44:38.342+00:00".ToFhirDateTimeFromLexical()
      })
      .BuildParameters();

    var patched = _sdk.ApplyPatch(specimen, patch);
    Assert.NotNull(patched.Processing);
    Assert.Single(patched.Processing!);
    Assert.Equal("test", patched.Processing![0].Description?.StringValue);
  }

  [Fact]
  public void Delete_removes_element()
  {
    var patient = new Patient { Active = true.ToFhirBoolean() };
    var patch = FhirPathPatchBuilder.Create()
      .Delete("Patient.active")
      .BuildParameters();

    var patched = _sdk.ApplyPatch(patient, patch);
    Assert.Null(patched.Active);
  }
}
