using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    public class FhirUuidTests : PrimitiveTypeTestBase<FhirUuid>
    {
        public override string[] GetValidValues()
        {
            return new[]
            {
                "urn:uuid:12345678-1234-1234-1234-123456789abc",
                "urn:uuid:00000000-0000-0000-0000-000000000000",
                "urn:uuid:ffffffff-ffff-ffff-ffff-ffffffffffff",
                "urn:uuid:550e8400-e29b-41d4-a716-446655440000"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "12345678-1234-1234-1234-123456789ab",
                "12345678-1234-1234-1234-123456789abcd",
                "12345678-1234-1234-1234-123456789abg",
                "12345678123412341234123456789abc",
                "12345678_1234_1234_1234_123456789abc"
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Uuid";
        }

        public override FhirUuid CreateInstance(string value)
        {
            return new FhirUuid(value);
        }

        public override FhirUuid CreateNullInstance()
        {
            return new FhirUuid((string?)null);
        }

        protected override object? GetValueFromInstance(FhirUuid instance)
        {
            return instance.Value;
        }
    }
} 