using System;
using System.Collections.Generic;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace FhirSDK.Resources.R5
{
    /// <summary>
    /// Fluent chainable helpers for Patient creation.
    /// Implemented as extension methods to avoid impacting CodeGen output.
    /// </summary>
    public static class PatientFluentExtensions
    {
        public static Patient WithGender(this Patient patient, string code)
        {
            patient.Gender = new FhirCode(code);
            return patient;
        }

        public static Patient WithBirthDate(this Patient patient, string date)
        {
            patient.BirthDate = new FhirDate(date);
            return patient;
        }

        public static Patient WithActive(this Patient patient, bool value)
        {
            patient.Active = new FhirBoolean(value);
            return patient;
        }

        public static Patient AddName(this Patient patient, Action<HumanName> configure)
        {
            var hn = new HumanName();
            configure?.Invoke(hn);
            var list = patient.Name ?? new List<HumanName>();
            list.Add(hn);
            // reassign to trigger setter and JSON sync
            patient.Name = list;
            return patient;
        }

        public static Patient AddTelecom(this Patient patient, Action<ContactPoint> configure)
        {
            var cp = new ContactPoint();
            configure?.Invoke(cp);
            var list = patient.Telecom ?? new List<ContactPoint>();
            list.Add(cp);
            patient.Telecom = list;
            return patient;
        }

        public static Patient AddIdentifier(this Patient patient, Action<Identifier> configure)
        {
            var id = new Identifier();
            configure?.Invoke(id);
            var list = patient.Identifier ?? new List<Identifier>();
            list.Add(id);
            patient.Identifier = list;
            return patient;
        }

        public static Patient Do(this Patient patient, Action<Patient> configure)
        {
            configure?.Invoke(patient);
            return patient;
        }

        public static Patient WithDeceasedBoolean(this Patient p, bool value)
        {
            p.DeceasedBoolean = new FhirBoolean(value);
            return p;
        }

        public static Patient WithDeceasedDateTime(this Patient p, string iso)
        {
            p.DeceasedDateTime = new FhirDateTime(iso);
            return p;
        }

    }
}

