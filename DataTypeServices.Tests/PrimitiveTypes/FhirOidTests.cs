using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    public class FhirOidTests : PrimitiveTypeTestBase<FhirOid>
    {
        public override string[] GetValidValues()
        {
            return new[]
            {
                "urn:oid:2.16.840.1.113883.2.4.6.1",
                "urn:oid:1.2.3.4.5.6.7.8.9",
                "urn:oid:2.16.840.1.113883.2.4.6.1.1",
                "urn:oid:1.3.6.1.4.1.5220.1.1.1"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "2.16.840.1.113883.2.4.6",
                "2.16.840.1.113883.2.4.6.1.",
                ".2.16.840.1.113883.2.4.6.1",
                "2..16.840.1.113883.2.4.6.1",
                "2.16.840.1.113883.2.4.6.1a"
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Oid";
        }

        public override FhirOid CreateInstance(string value)
        {
            return new FhirOid(value);
        }

        public override FhirOid CreateNullInstance()
        {
            return new FhirOid((string?)null);
        }

        protected override object? GetValueFromInstance(FhirOid instance)
        {
            return instance.Value;
        }
    }
} 