using FhirCore.Interfaces;

namespace TerminologyService.ValueSet
{
    public class IdentifierUse : ValueSetBase<EnumIdentifierUse>, IValueSetClass
    {
        public IdentifierUse() { }
        public IdentifierUse(EnumIdentifierUse value) : base(value) { }

        public string GetEnumName() => GetStringValue() ?? string.Empty;

    }
    public enum EnumIdentifierUse
    {
        Usual,
        Official,
        Temp,
        Secondary,
        Old,
        NullFlavor

    }
}
