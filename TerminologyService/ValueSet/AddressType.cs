using FhirCore.Interfaces;

namespace TerminologyService.ValueSet
{
    public class AddressType : ValueSetBase<EnumAddressType>, IValueSetClass
    {
        public AddressType() { }
        public AddressType(EnumAddressType value) : base(value) { }

        public string GetEnumName() => GetStringValue() ?? string.Empty;

    }
    public enum EnumAddressType
    {
        postal,
        physical,
        both

    }
}
