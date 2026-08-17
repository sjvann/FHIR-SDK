using Fhir.Resources.R4;
using Fhir.Sdk.R4;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Fhir.TypeFramework.Serialization;
using Fhir.Validation.Packages;

namespace Fhir.Validation.Tests;

public sealed class ProfileValidatorTests
{
    private const string ObservationProfile = "http://hl7.org/fhir/StructureDefinition/Observation";

    [Fact]
    public void Unknown_canonical_is_error()
    {
        var catalog = new ProfileCatalog();
        var validator = FhirSdkR4.CreateValidator(catalog);
        var report = validator.Validate(ValidObservation(), [ObservationProfile]);
        Assert.False(report.Passed);
        Assert.Contains(report.Issues, i => i.Code == "structure");
    }

    [Fact]
    public void Valid_observation_passes_required_status_and_code()
    {
        var validator = CreateValidator(ObservationSd());
        var report = validator.Validate(ValidObservation(), [ObservationProfile]);
        Assert.True(report.Passed, string.Join("; ", report.Issues.Select(i => i.Diagnostics)));
    }

    [Fact]
    public void Missing_status_fails_cardinality()
    {
        var obs = ValidObservation();
        obs.Status = null;
        var validator = CreateValidator(ObservationSd());
        var report = validator.Validate(obs, [ObservationProfile]);
        Assert.False(report.Passed);
        Assert.Contains(report.Issues, i => i.Code == "required" && i.Location == "Observation.status");
    }

    [Fact]
    public void Missing_code_fails_cardinality()
    {
        var obs = ValidObservation();
        obs.Code = null;
        var validator = CreateValidator(ObservationSd());
        var report = validator.Validate(obs, [ObservationProfile]);
        Assert.False(report.Passed);
        Assert.Contains(report.Issues, i => i.Code == "required" && i.Location == "Observation.code");
    }

    [Fact]
    public void Binding_without_valueset_is_warning_when_lenient()
    {
        var sd = ObservationSd();
        sd.Snapshot!.Element!.First(e => e.Path?.StringValue == "Observation.status").Binding =
            new ElementDefinitionBindingComponent
            {
                Strength = new FhirCode("required"),
                ValueSet = new FhirCanonical("http://hl7.org/fhir/ValueSet/observation-status")
            };

        var validator = FhirSdkR4.CreateValidator(Catalog(sd), new ProfileValidationOptions
        {
            Handling = ProfileHandling.Lenient,
            EvaluateInvariants = false
        });
        var report = validator.Validate(ValidObservation(), [ObservationProfile]);
        Assert.True(report.Passed);
        Assert.Contains(report.Issues, i => i.Severity == "warning" && i.Code == "binding");
    }

    [Fact]
    public void Binding_uses_catalog_valueset_when_present()
    {
        var sd = ObservationSd();
        sd.Snapshot!.Element!.First(e => e.Path?.StringValue == "Observation.status").Binding =
            new ElementDefinitionBindingComponent
            {
                Strength = new FhirCode("required"),
                ValueSet = new FhirCanonical("http://hl7.org/fhir/ValueSet/observation-status")
            };

        var vs = new ValueSet
        {
            Url = new FhirUri("http://hl7.org/fhir/ValueSet/observation-status"),
            Compose = new ValueSet.ComposeComponent
            {
                Include =
                [
                    new ValueSet.ComposeComponent.ComposeIncludeComponent
                    {
                        System = new FhirUri("http://hl7.org/fhir/observation-status"),
                        Concept =
                        [
                            new ValueSet.ComposeComponent.ComposeIncludeComponent.ComposeIncludeConceptComponent
                            {
                                Code = new FhirCode("final")
                            }
                        ]
                    }
                ]
            }
        };

        var catalog = Catalog(sd);
        catalog.Add(vs);
        var validator = FhirSdkR4.CreateValidator(catalog);
        Assert.True(validator.Validate(ValidObservation(), [ObservationProfile]).Passed);

        var bad = ValidObservation();
        bad.Status = new FhirCode("not-a-status");
        Assert.False(validator.Validate(bad, [ObservationProfile]).Passed);
    }

    [Fact]
    public void Invariant_fails_when_expression_is_false()
    {
        var sd = ObservationSd();
        sd.Snapshot!.Element![0].Constraint =
        [
            new ElementDefinitionConstraintComponent
            {
                Key = new FhirId("obs-status"),
                Severity = new FhirCode("error"),
                Human = new FhirString("status must be final"),
                Expression = new FhirString("false")
            }
        ];

        var validator = FhirSdkR4.CreateValidator(Catalog(sd));
        var bad = ValidObservation();
        bad.Status = new FhirCode("registered");
        var report = validator.Validate(bad, [ObservationProfile]);
        Assert.False(report.Passed);
        Assert.Contains(report.Issues, i => i.Code == "invariant");
    }

    [Fact]
    public void Value_slicing_enforces_slice_cardinality()
    {
        var sd = ObservationSd();
        sd.Snapshot!.Element!.Add(new ElementDefinition
        {
            Path = new FhirString("Observation.category"),
            Min = new FhirUnsignedInt(0),
            Max = new FhirString("*"),
            Slicing = new ElementDefinitionSlicingComponent
            {
                Rules = new FhirCode("open"),
                Discriminator =
                [
                    new ElementDefinitionSlicingDiscriminatorComponent
                    {
                        Type = new FhirCode("value"),
                        Path = new FhirString("coding")
                    }
                ]
            }
        });
        sd.Snapshot.Element.Add(new ElementDefinition
        {
            Path = new FhirString("Observation.category:vital"),
            SliceName = new FhirString("vital"),
            Min = new FhirUnsignedInt(1),
            Max = new FhirString("1"),
            PatternCodeableConcept = new CodeableConcept
            {
                Coding = [new Coding { Code = new FhirString("vital-signs") }]
            }
        });

        var validator = FhirSdkR4.CreateValidator(Catalog(sd));
        var missing = validator.Validate(ValidObservation(), [ObservationProfile]);
        Assert.False(missing.Passed);
        Assert.Contains(missing.Issues, i => i.Location == "Observation.category:vital" && i.Code == "required");

        var obs = ValidObservation();
        obs.Category =
        [
            new CodeableConcept
            {
                Coding = [new Coding { System = new FhirUri("http://terminology.hl7.org/CodeSystem/observation-category"), Code = new FhirString("vital-signs") }]
            }
        ];
        var ok = validator.Validate(obs, [ObservationProfile]);
        Assert.True(ok.Passed, string.Join("; ", ok.Issues.Select(i => i.Diagnostics)));
    }

    [Fact]
    public void ElementDefinition_json_keeps_binding_constraint_and_slicing()
    {
        var ed = new ElementDefinition
        {
            Path = new FhirString("Observation.status"),
            Min = new FhirUnsignedInt(1),
            Max = new FhirString("1"),
            Binding = new ElementDefinitionBindingComponent
            {
                Strength = new FhirCode("required"),
                ValueSet = new FhirCanonical("http://hl7.org/fhir/ValueSet/observation-status")
            },
            Constraint =
            [
                new ElementDefinitionConstraintComponent
                {
                    Key = new FhirId("k"),
                    Expression = new FhirString("true")
                }
            ],
            Slicing = new ElementDefinitionSlicingComponent
            {
                Rules = new FhirCode("open"),
                Discriminator =
                [
                    new ElementDefinitionSlicingDiscriminatorComponent
                    {
                        Type = new FhirCode("value"),
                        Path = new FhirString("coding.code")
                    }
                ]
            }
        };

        var back = FhirJsonSerializer.Deserialize<ElementDefinition>(FhirJsonSerializer.Serialize(ed))!;
        Assert.Equal("required", back.Binding?.Strength?.StringValue);
        Assert.Equal("k", back.Constraint![0].Key?.StringValue);
        Assert.Equal("value", back.Slicing?.Discriminator![0].Type?.StringValue);
    }

    [Fact]
    public void Package_reader_enumerates_structuredefinition_json()
    {
        var json = """{"resourceType":"StructureDefinition","url":"http://example.org/sd"}""";
        using var tgz = CreateTgz("package/StructureDefinition-x.json", json);
        var artifacts = FhirPackageArtifactReader.Read(tgz);
        Assert.Single(artifacts);
        Assert.Equal("StructureDefinition", artifacts[0].ResourceType);
    }

    private static IProfileValidator CreateValidator(StructureDefinition sd)
        => FhirSdkR4.CreateValidator(Catalog(sd));

    private static ProfileCatalog Catalog(params Fhir.TypeFramework.Bases.Base[] resources)
    {
        var catalog = new ProfileCatalog();
        foreach (var r in resources)
            catalog.Add(r);
        return catalog;
    }

    private static Observation ValidObservation() => new()
    {
        Status = new FhirCode("final"),
        Code = new CodeableConcept
        {
            Coding = [new Coding { System = new FhirUri("http://loinc.org"), Code = new FhirString("29463-7") }]
        }
    };

    private static StructureDefinition ObservationSd() => new()
    {
        Url = new FhirUri(ObservationProfile),
        Type = new FhirUri("Observation"),
        Snapshot = new StructureDefinition.SnapshotComponent
        {
            Element =
            [
                new ElementDefinition { Path = new FhirString("Observation"), Min = new FhirUnsignedInt(0), Max = new FhirString("*") },
                new ElementDefinition
                {
                    Path = new FhirString("Observation.status"),
                    Min = new FhirUnsignedInt(1),
                    Max = new FhirString("1"),
                    Type = [new ElementDefinitionTypeComponent { Code = new FhirUri("code") }]
                },
                new ElementDefinition
                {
                    Path = new FhirString("Observation.code"),
                    Min = new FhirUnsignedInt(1),
                    Max = new FhirString("1"),
                    Type = [new ElementDefinitionTypeComponent { Code = new FhirUri("CodeableConcept") }]
                }
            ]
        }
    };

    private static MemoryStream CreateTgz(string entryName, string json)
    {
        var ms = new MemoryStream();
        using (var gzip = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Compress, leaveOpen: true))
        using (var tar = new System.Formats.Tar.TarWriter(gzip))
        {
            var data = System.Text.Encoding.UTF8.GetBytes(json);
            var entry = new System.Formats.Tar.PaxTarEntry(System.Formats.Tar.TarEntryType.RegularFile, entryName)
            {
                DataStream = new MemoryStream(data)
            };
            tar.WriteEntry(entry);
        }

        ms.Position = 0;
        return ms;
    }
}
