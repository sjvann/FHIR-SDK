using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    public class FhirPositiveIntTests : PrimitiveTypeTestBase<FhirPositiveInt>
    {
        public override string[] GetValidValues()
        {
            return new[]
            {
                "1",
                "123",
                "2147483647", // 最大 positive int
                "1000",
                "999999"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "0",
                "-1",
                "-123",
                "abc",
                "12.34",
                "1.23"
            };
        }

        public override string GetExpectedTypeName()
        {
            return "PositiveInt";
        }

        public override FhirPositiveInt CreateInstance(string value)
        {
            return new FhirPositiveInt(value);
        }

        public override FhirPositiveInt CreateNullInstance()
        {
            return new FhirPositiveInt((int?)null);
        }

        protected override object? GetValueFromInstance(FhirPositiveInt instance)
        {
            return instance.Value;
        }
    }
} 