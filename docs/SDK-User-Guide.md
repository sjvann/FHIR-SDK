# FHIR SDK - Developer Guide

Audience: Application developers using the generated SDK.

## Overview
- Assemblies: FhirSDK.Resources.<VER>, FhirCore, DataTypeServices
- Each resource (e.g., Patient) is a partial class with strongly-typed properties
- Nested backbone elements are emitted as nested partial classes (e.g., Observation.Component)
- Examples are embedded as JSON for quick prototyping

## Getting Started
- Reference the resources assembly (e.g., FhirSDK.Resources.R5)
- Instantiate resources via constructors or JSON payloads
- ResourceType is enforced per class (e.g., new Patient().ResourceType == "Patient")

## Fluent API
- For each resource, CodeGen emits extension methods:
  - With<Property>(T value) for scalar properties
  - Add<Property>(T item) for list properties
  - For choice [x] properties, With<PropertySuffix>(MappedType value)
- Example (Patient):
  - new Patient().WithActive(new FhirBoolean(true)).AddName(new HumanName().WithFamily(new FhirString("Doe")))

## Choice Types
- Properties that accept multiple FHIR datatypes are generated as separate properties (e.g., DeceasedBoolean, DeceasedDateTime)
- Fluent extensions use the proper suffix per datatype (e.g., WithDeceasedBoolean, WithDeceasedDateTime)
- Mutually exclusive semantics are maintained by property setters

## References and CodeableConcept helpers
- Use Reference by setting Reference string (e.g., "Patient/123") or using typed helper (future extension)
- For CodeableConcept, provide code/system/display through fluent helpers or direct construction

## JSON
- From raw JSON: new Patient(jsonString)
- Serialize via ToJson() (if available) or use FhirCore serializers (planned)

## Versioning
- R4/R5/R6 assemblies can co-exist; select the correct namespace
- Breaking changes are isolated per versioned assembly

## Embedded Examples
- Examples live under Examples/{Resource}/*.json and are embedded into the assembly
- Use reflection or helper utilities to enumerate embedded examples for demos/tests

## FAQ
- Why partial classes? To allow custom extensions without touching generated files
- Where are the generated files? Under Generated/* in the resources project
- How to extend Fluent for special rules? Add a separate hand-written extension; generated ones are additive

