using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    public class FhirCanonicalTests : PrimitiveTypeTestBase<FhirCanonical>
    {
        public override string[] GetValidValues()
        {
            return new[]
            {
                "http://hl7.org/fhir/StructureDefinition/Patient",
                "https://fhir.hl7.org/StructureDefinition/Patient",
                "http://example.com/fhir/StructureDefinition/MyResource|1.0",
                "http://hl7.org/fhir/ValueSet/administrative-gender#active"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                ""
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Canonical";
        }

        public override FhirCanonical CreateInstance(string value)
        {
            return new FhirCanonical(value);
        }

        public override FhirCanonical CreateNullInstance()
        {
            return new FhirCanonical((string?)null);
        }

        protected override object? GetValueFromInstance(FhirCanonical instance)
        {
            return instance.Value;
        }
    }
} 