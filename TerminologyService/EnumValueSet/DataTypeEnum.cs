using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TerminologyService.EnumValueSet
{
    public enum IdentifierUse
    {
        [EnumMember(Value = "usual")]
        Usual,
        [EnumMember(Value = "official")]
        Official,
        [EnumMember(Value = "temp")]
        Temp,
        [EnumMember(Value = "secondary")]
        Secondary,
        [EnumMember(Value = "old")]
        Old,
    }
    public enum IdentifierTypeCodes
    {
        [EnumMember(Value = "DL")]
        DriversLicenseNumber,
        [EnumMember(Value = "PPN")]
        PassportNumber,
        [EnumMember(Value = "BRN")]
        BreedRegistryNumber,
        [EnumMember(Value = "MR")]
        MedicalRecordNumber,
        [EnumMember(Value = "MCN")]
        MicrochipNumber,
        [EnumMember(Value = "EN")]
        EmployerNumber,
        [EnumMember(Value = "TAX")]
        TaxIDNumber,
        [EnumMember(Value = "NIIP")]
        NationalInsurancePayorIdentifier,
        [EnumMember(Value = "PRN")]
        ProviderNumber,
        [EnumMember(Value = "MD")]
        MedicalLicenseNumber,
        [EnumMember(Value = "DR")]
        DonorRegistrationNumber,
        [EnumMember(Value = "ACSN")]
        AccessionID,
        [EnumMember(Value = "UDI")]
        UniversalDeviceIdentifier,
        [EnumMember(Value = "SNO")]
        SerialNumber,
        [EnumMember(Value = "SB")]
        SocialBeneficiaryIdentifier,
        [EnumMember(Value = "PLAC")]
        PlacerIdentifier,
        [EnumMember(Value = "FILL")]
        FillerIdentifier,
        [EnumMember(Value = "JHN")]
        JurisdictionalHealthNumber

    }

    public enum QuantityComparator
    {
        [EnumMember(Value = "\u003c")]
        LessThan,
        [EnumMember(Value = "\u003c\u003d")]
        LessOrEqualTo,
        [EnumMember(Value = "\u003e\u003d")]
        GreaterOrEqualTo,
        [EnumMember(Value = "\u003e")]
        GreaterThan,
        [EnumMember(Value = "ad")]
        Ad
    }
    public enum DurationComparator
    {
        [EnumMember(Value = "\u003c")]
        LessThan,
        [EnumMember(Value = "\u003c\u003d")]
        LessOrEqualTo,
        [EnumMember(Value = "\u003e\u003d")]
        GreaterOrEqualTo,
        [EnumMember(Value = "\u003e")]
        GreaterThan,
        [EnumMember(Value = "ad")]
        Ad
    }
    public enum DistanceComparator
    {
        [EnumMember(Value = "\u003c")]
        LessThan,
        [EnumMember(Value = "\u003c\u003d")]
        LessOrEqualTo,
        [EnumMember(Value = "\u003e\u003d")]
        GreaterOrEqualTo,
        [EnumMember(Value = "\u003e")]
        GreaterThan,
        [EnumMember(Value = "ad")]
        Ad
    }
    public enum AgeComparator
    {
        [EnumMember(Value = "\u003c")]
        LessThan,
        [EnumMember(Value = "\u003c\u003d")]
        LessOrEqualTo,
        [EnumMember(Value = "\u003e\u003d")]
        GreaterOrEqualTo,
        [EnumMember(Value = "\u003e")]
        GreaterThan,
        [EnumMember(Value = "ad")]
        Ad
    }
    public enum NameUse
    {
        [EnumMember(Value = "usual")]
        Usual,
        [EnumMember(Value = "official")]
        Official,
        [EnumMember(Value = "temp")]
        Temporary,
        [EnumMember(Value = "nickname")]
        Nickname,
        [EnumMember(Value = "anonymous")]
        Anonymous,
        [EnumMember(Value = "old")]
        Old,
        [EnumMember(Value = "maiden")]
        Maiden
    }
    public enum AddressUse
    {
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "temp")]
        Temporary,
        [EnumMember(Value = "old")]
        Old,
        [EnumMember(Value = "billing")]
        Billing
    }
    public enum AddressType
    {
        [EnumMember(Value = "postal")]
        Postal,
        [EnumMember(Value = "physical")]
        Physical,
        [EnumMember(Value = "both")]
        Both
    }
    public enum ContactPointSystem
    {
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "fax")]
        Fax,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "pager")]
        Pager,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "other")]
        Other
    }
    public enum ContactPointUse
    {
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "temp")]
        Temporary,
        [EnumMember(Value = "old")]
        Old,
        [EnumMember(Value = "mobile")]
        Mobile
    }
    public enum UnitsOfTime
    {
        [EnumMember(Value = "s")]
        Second,
        [EnumMember(Value = "min")]
        Minute,
        [EnumMember(Value = "h")]
        Hour,
        [EnumMember(Value = "d")]
        Day,
        [EnumMember(Value = "wk")]
        Week,
        [EnumMember(Value = "mo")]
        Month,
        [EnumMember(Value = "a")]
        Year
    }
    public enum DaysOfWeek
    {
        [EnumMember(Value = "mon")]
        Monday,
        [EnumMember(Value = "tue")]
        Tuesday,
        [EnumMember(Value = "wed")]
        Wednesday,
        [EnumMember(Value = "thu")]
        Thursday,
        [EnumMember(Value = "fri")]
        Friday,
        [EnumMember(Value = "sat")]
        Saturday,
        [EnumMember(Value = "sun")]
        Sunday
    }
    public enum EventTiming
    {
        [EnumMember(Value = "MORN")]
        Morning,
        [EnumMember(Value = "MORN.early")]
        EarlyMorning,
        [EnumMember(Value = "MORN.late")]
        LateMorning,
        [EnumMember(Value = "AFT")]
        Afternoon,
        [EnumMember(Value = "AFT.early")]
        EarlyAfternoon,
        [EnumMember(Value = "AFT.late")]
        LateAfternoon,
        [EnumMember(Value = "EVE")]
        Evening,
        [EnumMember(Value = "EVE.early")]
        EarlyEvening,
        [EnumMember(Value = "EVE.late")]
        LateEvening,
        [EnumMember(Value = "NIGHT")]
        Night,
        [EnumMember(Value = "PHS")]
        AfterSleep,
        [EnumMember(Value = "HS")]
        HS,
        [EnumMember(Value = "WAKE")]
        WAKE,
        [EnumMember(Value = "C")]
        C,
        [EnumMember(Value = "CM")]
        CM,
        [EnumMember(Value = "CD")]
        CD,
        [EnumMember(Value = "CV")]
        CV,
        [EnumMember(Value = "AC")]
        AC,
        [EnumMember(Value = "ACM")]
        ACM,
        [EnumMember(Value = "ACD")]
        ACD,
        [EnumMember(Value = "ACV")]
        ACV,
        [EnumMember(Value = "PC")]
        PC,
        [EnumMember(Value = "PCM")]
        PCM,
        [EnumMember(Value = "PCD")]
        PCD,
        [EnumMember(Value = "PCV")]
        PCV

    }
    public enum TimingAbbreviation
    {
        [EnumMember(Value = "C")]
        Continuous,
        [EnumMember(Value = "BID")]
        BID,
        [EnumMember(Value = "TID")]
        TID,
        [EnumMember(Value = "QID")]
        QID,
        [EnumMember(Value = "AM")]
        AM,
        [EnumMember(Value = "PM")]
        PM,
        [EnumMember(Value = "QD")]
        QD,
        [EnumMember(Value = "QOD")]
        QOD,
        [EnumMember(Value = "Q4H")]
        Q4H,
        [EnumMember(Value = "Q6H")]
        Q6H,
        [EnumMember(Value = "Q8H")]
        Q8H,
        [EnumMember(Value = "Q1H")]
        Q1H,
        [EnumMember(Value = "Q2H")]
        Q2H,
        [EnumMember(Value = "Q3H")]
        Q3H,
        [EnumMember(Value = "BED")]
        BED,
        [EnumMember(Value = "WE")]
        Weekly,
        [EnumMember(Value = "MO")]
        Monthly
    }
    public enum NarrativeStatus
    {
        [EnumMember(Value = "generated")]
        Generated,
        [EnumMember(Value = "extensions")]
        Extensions,
        [EnumMember(Value = "additional")]
        Additional,
        [EnumMember(Value = "empty")]
        Empty
    }
}
