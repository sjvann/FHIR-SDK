using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    public class FhirInteger64Tests : PrimitiveTypeTestBase<FhirInteger64>
    {
        public override string[] GetValidValues()
        {
            return new[]
            {
                "0",
                "1",
                "-1",
                "123",
                "-123",
                "9223372036854775807", // 最大 int64
                "-9223372036854775808" // 最小 int64
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "9223372036854775808", // 超過最大值
                "-9223372036854775809", // 低於最小值
                "abc",
                "12.34",
                "1.23"
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Integer64";
        }

        public override FhirInteger64 CreateInstance(string value)
        {
            return new FhirInteger64(value);
        }

        public override FhirInteger64 CreateNullInstance()
        {
            return new FhirInteger64((long?)null);
        }

        protected override object? GetValueFromInstance(FhirInteger64 instance)
        {
            return instance.Value;
        }
    }
} 