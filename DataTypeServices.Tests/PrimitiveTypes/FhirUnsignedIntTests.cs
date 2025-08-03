using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    public class FhirUnsignedIntTests : PrimitiveTypeTestBase<FhirUnsignedInt>
    {
        public override string[] GetValidValues()
        {
            return new[]
            {
                "0",
                "1",
                "123",
                "4294967295", // 最大 unsigned int
                "1000",
                "999999"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "-1",
                "-123",
                "4294967296", // 超過最大值
                "abc",
                "12.34",
                "1.23"
            };
        }

        public override string GetExpectedTypeName()
        {
            return "UnsignedInt";
        }

        public override FhirUnsignedInt CreateInstance(string value)
        {
            return new FhirUnsignedInt(value);
        }

        public override FhirUnsignedInt CreateNullInstance()
        {
            return new FhirUnsignedInt((uint?)null);
        }

        protected override object? GetValueFromInstance(FhirUnsignedInt instance)
        {
            return instance.Value;
        }
    }
} 