using FhirCore.Interfaces;

namespace TerminologyService.ValueSet
{

    public class IdentityAssuranceLevel: ValueSetBase<EnumIdentityAssuranceLevel>, IValueSetClass
    {
        public IdentityAssuranceLevel() { }
        public IdentityAssuranceLevel(EnumIdentityAssuranceLevel value) : base(value) { }

        public string GetEnumName() => GetStringValue() ?? string.Empty;
    }

    public enum EnumIdentityAssuranceLevel
    {
        Level1,
        Level2,
        Level3,
        Level4
    }
}
