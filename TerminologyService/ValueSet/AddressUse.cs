using FhirCore.Interfaces;

namespace TerminologyService.ValueSet
{
    public class AddressUse : ValueSetBase<EnumAddressUse>, IValueSetClass
    {
        public AddressUse() { }
        public AddressUse(EnumAddressUse value) : base(value) { }

        public string GetEnumName() => GetStringValue() ?? string.Empty;

    }
    public enum EnumAddressUse
    {
        home,
        work,
        temp,
        old,
        billing

    }
}
