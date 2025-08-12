namespace CodeGen.Services
{
    public static class TypeMapService
    {
        // Mapping FHIR type code -> SDK C# type name
        public static string Map(string fhirTypeCode)
        {
            switch (fhirTypeCode)
            {
                // Primitive types (R5)
                case "base64Binary": return "FhirBase64Binary";
                case "boolean": return "FhirBoolean";
                case "canonical": return "FhirCanonical";
                case "code": return "FhirCode";
                case "date": return "FhirDate";
                case "dateTime": return "FhirDateTime";
                case "decimal": return "FhirDecimal";
                case "id": return "FhirId";
                case "instant": return "FhirInstant";
                case "integer": return "FhirInteger";
                case "integer64": return "FhirInteger64";
                case "markdown": return "FhirMarkdown";
                case "oid": return "FhirOid";
                case "positiveInt": return "FhirPositiveInt";
                case "string": return "FhirString";
                case "time": return "FhirTime";
                case "unsignedInt": return "FhirUnsignedInt";
                case "uri": return "FhirUri";
                case "url": return "FhirUrl";
                case "uuid": return "FhirUuid";
                case "xhtml": return "FhirXhtml";

                // Complex/common types (subset; extend as needed)
                case "Quantity": return "Quantity";
                case "CodeableConcept": return "CodeableConcept";
                case "Period": return "Period";
                case "Timing": return "Timing";
                case "Age": return "Age";
                case "Range": return "DataTypeServices.DataTypes.ComplexTypes.Range";
                case "Ratio": return "Ratio";
                case "SampledData": return "SampledData";
                case "Reference": return "ReferenceType";

                default:
                    // Fallback: return original to avoid blocking generation; follow-up to expand mapping
                    return fhirTypeCode;
            }
        }
    }
}

