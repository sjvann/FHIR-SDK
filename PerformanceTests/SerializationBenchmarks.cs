using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.Serialization;
using DataTypeServices.TypeFramework;

namespace PerformanceTests
{
    [MemoryDiagnoser]
    [SimpleJob]
    public class SerializationBenchmarks
    {
        private Patient _testPatient;
        private Observation _testObservation;
        private string _patientJson;
        private string _observationJson;

        [GlobalSetup]
        public void Setup()
        {
            // 建立測試 Patient
            _testPatient = new Patient
            {
                Id = new FhirString("patient-123"),
                Identifier = new List<Identifier>
                {
                    new Identifier
                    {
                        System = new FhirUri("http://hospital.example.com/identifiers/patient"),
                        Value = new FhirString("MRN12345")
                    }
                },
                Name = new List<HumanName>
                {
                    new HumanName
                    {
                        Use = new FhirCode("official"),
                        Family = new FhirString("Doe"),
                        Given = new List<FhirString>
                        {
                            new FhirString("John"),
                            new FhirString("William")
                        }
                    }
                },
                Gender = new FhirCode("male"),
                BirthDate = new FhirDate(DateTime.Parse("1990-01-01")),
                Address = new List<Address>
                {
                    new Address
                    {
                        Use = FhirCode<EnumAddressUse>.Init(EnumAddressUse.home),
                        Type = FhirCode<EnumAddressType>.Init(EnumAddressType.physical),
                        Line = new List<FhirString>
                        {
                            new FhirString("123 Main St")
                        },
                        City = new FhirString("Anytown"),
                        State = new FhirString("NY"),
                        PostalCode = new FhirString("12345"),
                        Country = new FhirString("USA")
                    }
                }
            };

            // 建立測試 Observation
            _testObservation = new Observation
            {
                Id = new FhirString("observation-123"),
                Status = new FhirCode("final"),
                Code = new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding
                        {
                            System = new FhirUri("http://loinc.org"),
                            Code = new FhirCode("8302-2"),
                            Display = new FhirString("Body height")
                        }
                    }
                },
                Subject = new ReferenceType
                {
                    Reference = new FhirString("Patient/patient-123")
                },
                Value = new Quantity
                {
                    Value = new FhirDecimal(175.0m),
                    Unit = new FhirString("cm"),
                    System = new FhirUri("http://unitsofmeasure.org"),
                    Code = new FhirCode("cm")
                }
            };

            // 預序列化 JSON
            _patientJson = FhirSerializer.Serialize(_testPatient);
            _observationJson = FhirSerializer.Serialize(_testObservation);
        }

        [Benchmark]
        public void SerializePatient()
        {
            var json = FhirSerializer.Serialize(_testPatient);
        }

        [Benchmark]
        public void SerializeObservation()
        {
            var json = FhirSerializer.Serialize(_testObservation);
        }

        [Benchmark]
        public void DeserializePatient()
        {
            var patient = FhirSerializer.Deserialize<Patient>(_patientJson);
        }

        [Benchmark]
        public void DeserializeObservation()
        {
            var observation = FhirSerializer.Deserialize<Observation>(_observationJson);
        }

        [Benchmark]
        public void SerializeComplexAddress()
        {
            var address = new Address
            {
                Use = FhirCode<EnumAddressUse>.Init(EnumAddressUse.home),
                Type = FhirCode<EnumAddressType>.Init(EnumAddressType.physical),
                Line = new List<FhirString>
                {
                    new FhirString("123 Main St"),
                    new FhirString("Apt 4B")
                },
                City = new FhirString("New York"),
                State = new FhirString("NY"),
                PostalCode = new FhirString("10001"),
                Country = new FhirString("USA"),
                Period = new Period
                {
                    Start = new FhirDateTime(DateTime.Parse("2020-01-01")),
                    End = new FhirDateTime(DateTime.Parse("2025-12-31"))
                }
            };

            var json = FhirSerializer.Serialize(address);
        }

        [Benchmark]
        public void SerializeCodeableConcept()
        {
            var concept = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://snomed.info/sct"),
                        Code = new FhirCode("73211009"),
                        Display = new FhirString("Diabetes mellitus")
                    },
                    new Coding
                    {
                        System = new FhirUri("http://loinc.org"),
                        Code = new FhirCode("250-8"),
                        Display = new FhirString("Glucose")
                    }
                },
                Text = new FhirString("Diabetes mellitus")
            };

            var json = FhirSerializer.Serialize(concept);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SerializationBenchmarks>();
        }
    }
} 