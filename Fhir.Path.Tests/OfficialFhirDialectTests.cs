using Fhir.Path.R4;
using Fhir.Resources.R4;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.Path.Tests;

public sealed class OfficialFhirDialectTests
{
    private readonly FhirPathR4 _sdk = FhirPathR4.Create();

    [Fact]
    public void Backtick_identifier_reads_narrative_div()
    {
        var result = _sdk.Evaluate("text.`div`.exists()", PatientWithNarrative());
        Assert.True((bool)result.Single()!);
    }

    [Fact]
    public void Div_after_dot_is_identifier_not_operator()
    {
        var result = _sdk.Evaluate("text.div.exists()", PatientWithNarrative());
        Assert.True((bool)result.Single()!);
    }

    [Fact]
    public void As_function_filters_canonical_descendants()
    {
        var plan = new CarePlan
        {
            InstantiatesCanonical = [new FhirCanonical("http://example.org/PlanDefinition/x")]
        };
        var result = _sdk.Evaluate("descendants().as(canonical)", plan);
        Assert.Contains("http://example.org/PlanDefinition/x", result.Select(v => v?.ToString()));
    }

    [Fact]
    public void Hash_plus_id_in_reference_collection()
    {
        var plan = new CarePlan
        {
            Id = new FhirId("cp1"),
            Contained =
            [
                new Condition { Id = new FhirId("cond1") }
            ],
            Addresses =
            [
                new Reference { ReferenceValue = new FhirString("#cond1") }
            ]
        };
        var ctx = new FhirPathEvaluationContext();
        ctx.SetVariable("resource", Fhir.Path.Navigation.PocoElementNavigator.Wrap(plan));
        var result = _sdk.Evaluate("'#'+contained.id in %resource.descendants().reference", plan, ctx);
        Assert.True((bool)result.Single()!);
    }

    [Fact]
    public void HtmlChecks_accepts_basic_xhtml()
    {
        var result = _sdk.Evaluate("text.div.htmlChecks()", PatientWithNarrative());
        Assert.True((bool)result.Single()!);
    }

    [Fact]
    public void HtmlChecks_rejects_script()
    {
        var patient = PatientWithNarrative("<div xmlns=\"http://www.w3.org/1999/xhtml\"><script>x</script>hi</div>");
        var result = _sdk.Evaluate("text.div.htmlChecks()", patient);
        Assert.False((bool)result.Single()!);
    }

    [Fact]
    public void Not_function_on_empty_is_empty()
    {
        var result = _sdk.Evaluate("contained.exists().not()", new CarePlan());
        Assert.True((bool)result.Single()!);
    }

    [Fact]
    public void Official_dom6_and_htmlChecks_pass()
    {
        var patient = PatientWithNarrative();
        Assert.True((bool)_sdk.Evaluate("text.`div`.exists()", patient).Single()!);
        Assert.True((bool)_sdk.Evaluate("text.`div`.htmlChecks()", patient).Single()!);
    }

    [Fact]
    public void This_variable_is_the_focus()
    {
        var patient = PatientWithNarrative();
        patient.Name = [new HumanName { Family = new FhirString("Doe") }];
        var result = _sdk.Evaluate("name.where($this.family = 'Doe').exists()", patient);
        Assert.True((bool)result.Single()!);
    }

    private static Patient PatientWithNarrative(string? div = null)
        => new()
        {
            Id = new FhirId("qa-p"),
            Text = new Narrative
            {
                Status = new FhirString("generated"),
                Div = new FhirXhtml(div ?? "<div xmlns=\"http://www.w3.org/1999/xhtml\">Care plan</div>")
            }
        };
}
