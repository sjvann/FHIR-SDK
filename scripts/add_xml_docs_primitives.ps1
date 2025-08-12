# PowerShell script to add XML documentation to all Primitive Types
# This script systematically adds DocFX-compliant XML documentation to all FHIR primitive types

$primitiveTypes = @(
    @{
        File = "FhirBoolean.cs"
        TypeName = "FhirBoolean"
        Description = "Represents a FHIR boolean primitive type. Value of 'true' or 'false'."
        Remarks = "The FHIR boolean type represents a binary choice between true and false. It is used for yes/no, on/off type of data elements in FHIR resources."
        Example = "var isActive = new FhirBoolean(true);"
        ValueDescription = "The boolean value (true or false), or null if no value has been set."
        UnderlyingType = "bool"
    },
    @{
        File = "FhirInteger.cs"
        TypeName = "FhirInteger"
        Description = "Represents a FHIR integer primitive type. A signed integer in the range -2,147,483,648 to +2,147,483,647 (32-bit)."
        Remarks = "The FHIR integer type is a 32-bit signed integer. It is used for counting, indexing, and other numeric operations that require whole numbers."
        Example = "var count = new FhirInteger(42);"
        ValueDescription = "The integer value, or null if no value has been set."
        UnderlyingType = "int"
    },
    @{
        File = "FhirDecimal.cs"
        TypeName = "FhirDecimal"
        Description = "Represents a FHIR decimal primitive type. Rational numbers that have a decimal representation."
        Remarks = "The FHIR decimal type represents rational numbers with decimal representation. It is used for precise numeric values such as measurements, quantities, and monetary amounts."
        Example = "var temperature = new FhirDecimal(98.6m);"
        ValueDescription = "The decimal value, or null if no value has been set."
        UnderlyingType = "decimal"
    },
    @{
        File = "FhirDate.cs"
        TypeName = "FhirDate"
        Description = "Represents a FHIR date primitive type. A date, or partial date (e.g. just year or year + month)."
        Remarks = "The FHIR date type represents a date without time information. It can represent full dates (YYYY-MM-DD) or partial dates (YYYY or YYYY-MM)."
        Example = "var birthDate = new FhirDate(""2023-12-25"");"
        ValueDescription = "The date value, or null if no value has been set."
        UnderlyingType = "DateTime"
    },
    @{
        File = "FhirDateTime.cs"
        TypeName = "FhirDateTime"
        Description = "Represents a FHIR dateTime primitive type. A date, date-time or partial date (e.g. just year or year + month)."
        Remarks = "The FHIR dateTime type represents a date and time, including timezone information. It supports various levels of precision from year to milliseconds."
        Example = "var timestamp = new FhirDateTime(""2023-12-25T10:30:00Z"");"
        ValueDescription = "The dateTime value, or null if no value has been set."
        UnderlyingType = "DateTime"
    },
    @{
        File = "FhirTime.cs"
        TypeName = "FhirTime"
        Description = "Represents a FHIR time primitive type. A time during the day, with no date specified."
        Remarks = "The FHIR time type represents a time of day without date information. It follows the format HH:MM:SS with optional milliseconds."
        Example = "var appointmentTime = new FhirTime(""14:30:00"");"
        ValueDescription = "The time value, or null if no value has been set."
        UnderlyingType = "TimeSpan"
    },
    @{
        File = "FhirInstant.cs"
        TypeName = "FhirInstant"
        Description = "Represents a FHIR instant primitive type. An instant in time - known at least to the second."
        Remarks = "The FHIR instant type represents a specific moment in time with timezone information. It is always precise to at least the second."
        Example = "var createdAt = new FhirInstant(""2023-12-25T10:30:00.123Z"");"
        ValueDescription = "The instant value, or null if no value has been set."
        UnderlyingType = "DateTimeOffset"
    },
    @{
        File = "FhirUri.cs"
        TypeName = "FhirUri"
        Description = "Represents a FHIR uri primitive type. A Uniform Resource Identifier Reference."
        Remarks = "The FHIR uri type represents a URI reference as defined by RFC 3986. It is used for identifying resources and concepts."
        Example = "var profileUri = new FhirUri(""http://hl7.org/fhir/StructureDefinition/Patient"");"
        ValueDescription = "The URI value, or null if no value has been set."
        UnderlyingType = "string"
    },
    @{
        File = "FhirUrl.cs"
        TypeName = "FhirUrl"
        Description = "Represents a FHIR url primitive type. A Uniform Resource Locator."
        Remarks = "The FHIR url type represents a URL as defined by RFC 1738. It is a specialized form of URI that specifies the location of a resource."
        Example = "var endpoint = new FhirUrl(""https://api.example.com/fhir"");"
        ValueDescription = "The URL value, or null if no value has been set."
        UnderlyingType = "string"
    },
    @{
        File = "FhirCanonical.cs"
        TypeName = "FhirCanonical"
        Description = "Represents a FHIR canonical primitive type. A URI that refers to a resource by its canonical URL."
        Remarks = "The FHIR canonical type represents a canonical URL that identifies a FHIR resource. It may include a version suffix."
        Example = "var canonical = new FhirCanonical(""http://hl7.org/fhir/StructureDefinition/Patient|4.0.1"");"
        ValueDescription = "The canonical URL value, or null if no value has been set."
        UnderlyingType = "string"
    }
)

Write-Host "Starting XML documentation addition for Primitive Types..." -ForegroundColor Green

foreach ($type in $primitiveTypes) {
    Write-Host "Processing $($type.TypeName)..." -ForegroundColor Yellow
    
    # This script provides the template for adding XML docs
    # The actual implementation will be done through the str-replace-editor tool
    
    Write-Host "  - File: $($type.File)"
    Write-Host "  - Description: $($type.Description)"
    Write-Host "  - Underlying Type: $($type.UnderlyingType)"
}

Write-Host "XML documentation template prepared for all Primitive Types." -ForegroundColor Green
Write-Host "Use the str-replace-editor tool to apply the documentation to each file." -ForegroundColor Cyan
