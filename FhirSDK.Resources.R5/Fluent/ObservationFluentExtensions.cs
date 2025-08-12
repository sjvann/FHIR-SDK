using System;
using System.Collections.Generic;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace FhirSDK.Resources.R5
{
    public static class ObservationFluentExtensions
    {
        public static Observation WithStatus(this Observation obs, string statusCode)
        {
            obs.Status = new FhirCode(statusCode);
            return obs;
        }

        public static Observation WithCode(this Observation obs, string system, string code, string? display = null)
        {
            obs.Code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding { System = new FhirUri(system), Code = new FhirCode(code), Display = display != null ? new FhirString(display) : null }
                }
            };
            return obs;
        }

        public static Observation WithSubject(this Observation obs, string reference)
        {
            obs.Subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType { Reference = new FhirString(reference) };
            return obs;
        }

        public static Observation WithValueString(this Observation obs, string value)
        {
            obs.ValueString = new FhirString(value);
            return obs;
        }

        public static Observation WithValueQuantity(this Observation obs, decimal value, string unit, string? system = null, string? code = null)
        {
            obs.ValueQuantity = new Quantity
            {
                Value = new FhirDecimal(value),
                Unit = new FhirString(unit),
                System = system != null ? new FhirUri(system) : null,
                Code = code != null ? new FhirCode(code) : null
            };
            return obs;
        }

        public static Observation WithEffectiveDateTime(this Observation obs, string isoDateTime)
        {
            obs.EffectiveDateTime = new FhirDateTime(isoDateTime);
            return obs;
        }
    }
}

