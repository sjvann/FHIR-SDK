using BenchmarkDotNet.Attributes;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using DataTypeServices.Validation;

namespace PerformanceTests
{
    [MemoryDiagnoser]
    [SimpleJob]
    public class ValidationBenchmarks
    {
        private FhirValidationEngine _validationEngine;
        private Patient _testPatient;
        private Observation _testObservation;
        private Address _testAddress;

        [GlobalSetup]
        public void Setup()
        {
            // 建立驗證引擎
            _validationEngine = new FhirValidationEngine(new FhirR4Version());

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
                BirthDate = new FhirDate(DateTime.Parse("1990-01-01"))
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

            // 建立測試 Address
            _testAddress = new Address
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
            };
        }

        [Benchmark]
        public void ValidatePatient()
        {
            var result = _validationEngine.ValidateResource(_testPatient);
        }

        [Benchmark]
        public void ValidateObservation()
        {
            var result = _validationEngine.ValidateResource(_testObservation);
        }

        [Benchmark]
        public void ValidateAddress()
        {
            var result = _validationEngine.ValidateResource(_testAddress);
        }

        [Benchmark]
        public void ValidateComplexPatient()
        {
            // 建立複雜的 Patient 進行驗證
            var complexPatient = new Patient
            {
                Id = new FhirString("patient-complex-123"),
                Identifier = new List<Identifier>
                {
                    new Identifier
                    {
                        System = new FhirUri("http://hospital.example.com/identifiers/patient"),
                        Value = new FhirString("MRN12345")
                    },
                    new Identifier
                    {
                        System = new FhirUri("http://insurance.example.com/identifiers/patient"),
                        Value = new FhirString("INS789")
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
                    },
                    new HumanName
                    {
                        Use = new FhirCode("nickname"),
                        Given = new List<FhirString>
                        {
                            new FhirString("Johnny")
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
                    },
                    new Address
                    {
                        Use = FhirCode<EnumAddressUse>.Init(EnumAddressUse.work),
                        Type = FhirCode<EnumAddressType>.Init(EnumAddressType.physical),
                        Line = new List<FhirString>
                        {
                            new FhirString("456 Business Ave")
                        },
                        City = new FhirString("Worktown"),
                        State = new FhirString("CA"),
                        PostalCode = new FhirString("90210"),
                        Country = new FhirString("USA")
                    }
                },
                Contact = new List<ContactPoint>
                {
                    new ContactPoint
                    {
                        System = new FhirCode("phone"),
                        Value = new FhirString("+1-555-123-4567"),
                        Use = new FhirCode("home")
                    },
                    new ContactPoint
                    {
                        System = new FhirCode("email"),
                        Value = new FhirString("john.doe@example.com"),
                        Use = new FhirCode("work")
                    }
                }
            };

            var result = _validationEngine.ValidateResource(complexPatient);
        }

        [Benchmark]
        public void ValidateMultipleResources()
        {
            var resources = new object[] { _testPatient, _testObservation, _testAddress };
            
            foreach (var resource in resources)
            {
                var result = _validationEngine.ValidateResource(resource);
            }
        }
    }
} 