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

                // Complex/common types
                case "Quantity": return "Quantity";
                case "CodeableConcept": return "CodeableConcept";
                case "Period": return "Period";
                case "Timing": return "Timing";
                case "Age": return "Age";
                case "Range": return "DataTypeServices.DataTypes.ComplexTypes.Range"; // avoid System.Range ambiguity
                case "Ratio": return "Ratio";
                case "RatioRange": return "RatioRange";
                case "Count": return "Count";
                case "Distance": return "Distance";
                case "Duration": return "Duration";
                case "Money": return "Money";
                case "Identifier": return "Identifier";
                case "HumanName": return "HumanName";
                case "Address": return "Address";
                case "ContactPoint": return "ContactPoint";
                case "Attachment": return "Attachment";
                case "Coding": return "Coding";
                case "Signature": return "Signature";
                case "SampledData": return "SampledData";
                // Special types
                case "Reference": return "ReferenceType";
                case "CodeableReference": return "CodeableReference";
                case "Dosage": return "Dosage";
                case "Meta": return "FhirCore.Interfaces.Meta"; // avoid Fhir.TypeFramework dependency
                case "Narrative": return "Narrative";
                case "Extension": return "Extension";
                case "Expression": return "DataTypeServices.DataTypes.MetaTypes.ExpressionType";
                case "Element": return "DataTypeServices.TypeFramework.ElementImp"; // ensure concrete implementation

                default:
                    // Fallback: return original to avoid blocking generation; follow-up to expand mapping
                    return fhirTypeCode;
            }
        }
    }
}

