using FhirCore.Interfaces;

namespace TerminologyService.ValueSet
{
    public class ContactPointSystem : ValueSetBase<EnumContactPointSystem>, IValueSetClass
    {
        public ContactPointSystem() { }
        public ContactPointSystem(EnumContactPointSystem value) : base(value) { }

        public string GetEnumName() => GetStringValue() ?? string.Empty;

    }
    public enum EnumContactPointSystem
    {
        phone,
        fax,
        email,
        pager,
        url,
        sms,
        other

    }
}
