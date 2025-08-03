using FhirCore.Interfaces;

namespace TerminologyService.ValueSet
{
    public class ContactPointUse : ValueSetBase<EnumContactPointUse>, IValueSetClass
    {
        public ContactPointUse() { }
        public ContactPointUse(EnumContactPointUse value) : base(value) { }

        public string GetEnumName() => GetStringValue() ?? string.Empty;

    }
    public enum EnumContactPointUse
    {
        home,
        work,
        temp,
        old,
        mobile
    }
}
