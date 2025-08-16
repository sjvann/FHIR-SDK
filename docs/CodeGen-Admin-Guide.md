# FHIR SDK CodeGen - Admin Guide

Audience: System administrators or release engineers who run the CLI to generate SDK resources when a new FHIR version is announced.

## Prerequisites
- .NET 9 SDK installed
- Official FHIR definitions (profiles-resources.json) downloaded locally
- This repository cloned and buildable

## Quick Start (R5 as example)
- Place definitions under ./Definitions (or any folder)
- Run:
  - dotnet run --project Tools/CodeGen/CodeGen.csproj -- --definitions-root Definitions --version R5 --output-project FhirSDK.Resources.R5 --dry-run false --emit-examples true

## Key CLI options
- --definitions-root <path>  Folder containing profiles-resources.json (or its parent)
- --version <R4|R5|R6>       FHIR version tag used for namespaces and defaults
- --output-project <path>    csproj file or folder; a new project will be created if needed
- --include A,B               Optional: only generate listed resource types
- --dry-run true|false        If true, writes nothing; prints what would be written
- --emit-examples true|false  If true, embeds Examples/**/*.json into the assembly
- --examples-source <folder>  Optional: copy examples from this folder before filling minimal ones

## Examples behavior
- If --examples-source is provided and exists, all *.json under it are copied into Examples/{Resource}/
- Then for each generated resource, if no *.json is present, a minimal basic.json is emitted: { "resourceType": "{Resource}" }
- The .csproj is updated (if needed) to embed Examples/**/*.json as EmbeddedResource

## Output layout
- FhirSDK.Resources.<VER>/Generated/*.g.cs           Resource models
- FhirSDK.Resources.<VER>/Generated/*.Fluent.g.cs     Fluent extensions
- FhirSDK.Resources.<VER>/Generated/ResourceRegistry.<VER>.g.cs
- FhirSDK.Resources.<VER>/Examples/{Resource}/*.json  Embedded example payloads

## Typical workflow when a new FHIR version drops
1) Download the official definitions and place them under a local folder
2) Run CodeGen with --version set to the new tag (e.g., R6)
3) Verify build: dotnet build FhirSDK.Resources.<VER>
4) Optional: dotnet test FhirSDK.Resources.Tests to smoke-check embedded examples
5) Package (pre-release): dotnet pack FhirSDK.Resources.<VER> -c Release

## Troubleshooting
- profiles-resources.json not found
  - Ensure --definitions-root points to a folder that contains it directly, or is the parent folder
- Missing types or compilation errors
  - Clean and rebuild; ensure FhirCore/DataTypeServices references were added to the csproj
- Embedded examples not found at runtime
  - Rebuild the resource project; verify Examples/**/*.json exist and are marked EmbeddedResource

