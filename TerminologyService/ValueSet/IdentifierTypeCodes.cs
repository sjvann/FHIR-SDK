using FhirCore.Interfaces;

namespace TerminologyService.ValueSet
{
    public class IdentifierTypeCodes : ValueSetBase<EnumIdentifierTypeCodes>, IValueSetClass
    {
        public IdentifierTypeCodes() { }
        public IdentifierTypeCodes(EnumIdentifierTypeCodes value) : base(value) { }

        public string GetEnumName() => GetStringValue() ?? string.Empty;

    }
    public enum EnumIdentifierTypeCodes
    {
        DL,
        PPN,
        BRN,
        MR,
        MCN,
        EN,
        TAX,
        NIIP,
        PRN,
        MD,
        DR,
        ACSN,
        UDI,
        SNO,
        SB,
        PLAC,
        FILL,
        JHN
    }
}
