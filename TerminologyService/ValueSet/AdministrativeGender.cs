using FhirCore.Interfaces;
using TerminologyService.Models;

namespace TerminologyService.ValueSet
{

    public class AdministrativeGender : ValueSetBase<EnumAdministrativeGender>, IValueSetClass
    {
        public AdministrativeGender() { }
        public AdministrativeGender(EnumAdministrativeGender value) : base(value) { }

        public string GetEnumName() => GetStringValue()??string.Empty;
    }
    [ValueSet("", "", "")] 
    public enum EnumAdministrativeGender
    {
        [ValueSetValue("male", "http://hl7.org/fhir/administrative-gender", "Male")]
        Male,
        [ValueSetValue("female", "http://hl7.org/fhir/administrative-gender", "Female")]
        Female,
        [ValueSetValue("other", "http://hl7.org/fhir/administrative-gender", "Other")]
        Other,
        [ValueSetValue("unknown", "http://hl7.org/fhir/administrative-gender", "Unknown")]
        Unknown
    }

}
