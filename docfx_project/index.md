# FHIR SDK DataType Services Documentation

Welcome to the FHIR SDK DataType Services documentation. This library provides comprehensive support for FHIR R5 data types, validation, and modern development patterns.

## Overview

The FHIR SDK DataType Services library is a modern, type-safe implementation of FHIR R5 data types for .NET applications. It provides:

- **Complete FHIR R5 Data Types**: All primitive and complex types as defined in the FHIR R5 specification
- **Advanced Validation**: Multi-layered validation system with custom validation attributes
- **Fluent Builder API**: Modern, readable API for constructing FHIR data types
- **Type Safety**: Strong typing with generic constraints and compile-time safety
- **Extensibility**: Support for custom validation rules and extensions

## Key Features

### 🏗️ Fluent Builder Pattern
Create FHIR data types using an intuitive, chainable API:

```csharp
var address = Address.Builder()
    .WithUse("home")
    .WithLine("123 Main Street")
    .WithCity("Anytown")
    .WithState("NY")
    .WithPostalCode("12345")
    .WithCountry("USA")
    .Build();
```

### ✅ Comprehensive Validation
Multi-layered validation system with detailed error reporting:

```csharp
// Built-in validation
var result = fhirDate.ValidateDetailed();

// Custom validation attributes
public class Patient : ComplexType<Patient>
{
    [EmailValidation]
    public FhirString? Email { get; set; }
    
    [NumericRangeValidation(18, 120)]
    public FhirInteger? Age { get; set; }
}
```

### 🔒 Type Safety
Strong typing with generic constraints ensures compile-time safety:

```csharp
// Strongly-typed references
var patientRef = new Reference<Patient>("Patient/123");

// Type-safe quantity specializations
var age = Age.Years(30);
var distance = Distance.Meters(100);
```

### 📊 Modern Serialization
Support for multiple formats with automatic detection:

```csharp
// JSON serialization with modern System.Text.Json
var json = patient.ToJsonString();

// Format conversion
var xml = FhirSerializer.ConvertFormat<Patient>(
    jsonData, 
    FhirSerializationFormat.Json, 
    FhirSerializationFormat.Xml
);
```

## Getting Started

### Installation

```bash
dotnet add package DataTypeServices
```

### Basic Usage

```csharp
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;

// Create a simple address
var address = new Address
{
    Use = FhirCode<EnumAddressUse>.Init(EnumAddressUse.home),
    Line = new List<FhirString> { new FhirString("123 Main St") },
    City = new FhirString("Anytown"),
    State = new FhirString("NY"),
    PostalCode = new FhirString("12345")
};

// Validate the address
var validationResult = address.ValidateAll();
if (!validationResult.IsValid)
{
    foreach (var error in validationResult.GetErrorMessages())
    {
        Console.WriteLine($"Error: {error}");
    }
}
```

## Architecture

The FHIR SDK is organized into several key layers:

### Core Layer
- **FhirCore.Interfaces**: Core interfaces (IResource, IDataType, IFhirVersion)
- **FhirCore.Base**: Base classes for resources and data types
- **FhirCore.Versioning**: Version management system
- **FhirCore.Client**: FHIR client for server communication

### Data Type Layer
- **DataTypeServices.DataTypes.PrimitiveTypes**: FHIR primitive types (string, integer, date, etc.)
- **DataTypeServices.DataTypes.ComplexTypes**: FHIR complex types (Address, HumanName, Period, etc.)
- **DataTypeServices.DataTypes.SpecialTypes**: Special FHIR types (Reference, Extension, Meta, etc.)
- **DataTypeServices.Builders**: Fluent builder classes for easy object construction
- **DataTypeServices.Validation**: Validation framework and custom validation attributes
- **DataTypeServices.TypeFramework**: Base classes and core infrastructure

### Resource Layer
- **ResourceTypeServices.R5**: FHIR R5 resource implementations
- **TerminologyService**: Value sets and terminology services

## API Reference

Browse the complete API documentation:

- [Core Interfaces](api/FhirCore.Interfaces.yml)
- [Data Types](api/DataTypeServices.DataTypes.yml)
- [Resource Types](api/ResourceTypeServices.R5.yml)
- [Builders](api/DataTypeServices.Builders.yml)
- [Validation](api/DataTypeServices.Validation.yml)

## Examples

Check out the comprehensive examples:

- [Fluent Builder Examples](articles/fluent-builder-examples.md)
- [Validation Examples](articles/validation-examples.md)
- [Custom Validation Examples](articles/custom-validation-examples.md)
- [Serialization Examples](articles/serialization-examples.md)

## Contributing

We welcome contributions! Please see our [Contributing Guide](articles/contributing.md) for details.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
