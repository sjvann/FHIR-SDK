using ResourceTypeServices.R4;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.SpecialTypes;

namespace Examples
{
    /// <summary>
    /// R4 Patient �ϥνd��
    /// 
    /// <para>
    /// �ܽd�p��ЫةM�ϥ� R4 ������ Patient �귽�C
    /// </para>
    /// </summary>
    public class R4PatientExample
    {
        /// <summary>
        /// �Ыذ򥻪� Patient �d��
        /// </summary>
        /// <returns>�t�m�n�� PatientR4 ���</returns>
        public static PatientR4 CreateBasicPatient()
        {
            var patient = new PatientR4("patient-r4-001")
            {
                // �]�w�����D���A
                Active = new FhirBoolean(true),

                // �]�w�ѧO�X
                Identifier = new List<Identifier>
                {
                    new Identifier
                    {
                        Use = new FhirCode("usual"),
                        System = new FhirUri("http://hospital.example.com/patients"),
                        Value = new FhirString("12345")
                    }
                },

                // �]�w�m�W
                Name = new List<HumanName>
                {
                    new HumanName
                    {
                        Use = new FhirCode("official"),
                        Family = new FhirString("��"),
                        Given = new List<FhirString> 
                        { 
                            new FhirString("�p��") 
                        }
                    }
                },

                // �]�w�ʧO
                Gender = new FhirCode("male"),

                // �]�w�X�ͤ��
                BirthDate = new FhirDate("1985-03-15"),

                // �]�w�p���覡
                Telecom = new List<ContactPoint>
                {
                    new ContactPoint
                    {
                        System = new FhirCode("phone"),
                        Value = new FhirString("+886-2-12345678"),
                        Use = new FhirCode("home")
                    },
                    new ContactPoint
                    {
                        System = new FhirCode("email"),
                        Value = new FhirString("patient@example.com"),
                        Use = new FhirCode("work")
                    }
                },

                // �]�w�a�}
                Address = new List<Address>
                {
                    new Address
                    {
                        Use = new FhirCode("home"),
                        Type = new FhirCode("both"),
                        Line = new List<FhirString> 
                        { 
                            new FhirString("�x�_���H�q�ϫH�q�����q7��") 
                        },
                        City = new FhirString("�x�_��"),
                        PostalCode = new FhirString("110"),
                        Country = new FhirString("�x�W")
                    }
                }
            };

            return patient;
        }

        /// <summary>
        /// �Ыرa������p���H�� Patient �d��
        /// </summary>
        /// <returns>�]�t�p���H��T�� PatientR4 ���</returns>
        public static PatientR4 CreatePatientWithContact()
        {
            var patient = CreateBasicPatient();

            // �K�[����p���H
            patient.Contact = new List<PatientContactR4>
            {
                new PatientContactR4
                {
                    Relationship = new List<CodeableConcept>
                    {
                        new CodeableConcept
                        {
                            Coding = new List<Coding>
                            {
                                new Coding
                                {
                                    System = new FhirUri("http://terminology.hl7.org/CodeSystem/v2-0131"),
                                    Code = new FhirCode("C"),
                                    Display = new FhirString("Emergency Contact")
                                }
                            }
                        }
                    },
                    Name = new HumanName
                    {
                        Family = new FhirString("��"),
                        Given = new List<FhirString> 
                        { 
                            new FhirString("�p��") 
                        }
                    },
                    Telecom = new List<ContactPoint>
                    {
                        new ContactPoint
                        {
                            System = new FhirCode("phone"),
                            Value = new FhirString("+886-912345678"),
                            Use = new FhirCode("mobile")
                        }
                    }
                }
            };

            return patient;
        }

        /// <summary>
        /// �Ыئh�y���w�̽d��
        /// </summary>
        /// <returns>�䴩�h�y���� PatientR4 ���</returns>
        public static PatientR4 CreateMultilingualPatient()
        {
            var patient = CreateBasicPatient();

            // �K�[�y�����n
            patient.Communication = new List<PatientCommunicationR4>
            {
                new PatientCommunicationR4
                {
                    Language = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding
                            {
                                System = new FhirUri("urn:ietf:bcp:47"),
                                Code = new FhirCode("zh-TW"),
                                Display = new FhirString("Chinese (Taiwan)")
                            }
                        }
                    },
                    Preferred = new FhirBoolean(true)
                },
                new PatientCommunicationR4
                {
                    Language = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding
                            {
                                System = new FhirUri("urn:ietf:bcp:47"),
                                Code = new FhirCode("en-US"),
                                Display = new FhirString("English (United States)")
                            }
                        }
                    },
                    Preferred = new FhirBoolean(false)
                }
            };

            return patient;
        }

        /// <summary>
        /// �ܽd���ҥ\��
        /// </summary>
        public static void DemonstrateValidation()
        {
            Console.WriteLine("=== R4 Patient ���ҥܽd ===");

            // �Ыئ��Ī��w��
            var validPatient = CreateBasicPatient();
            Console.WriteLine($"���ıw��: {validPatient}");
            
            var validationResult = validPatient.ValidateVersionSpecific();
            if (validationResult == null)
            {
                Console.WriteLine("? ���ҳq�L");
            }
            else
            {
                Console.WriteLine($"? ���ҥ���: {validationResult.ErrorMessage}");
            }

            Console.WriteLine();

            // �ЫصL�Ī��w�̡]�L�m�W�M�ѧO�X�^
            var invalidPatient = new PatientR4("invalid-patient")
            {
                Active = new FhirBoolean(true),
                Gender = new FhirCode("unknown")
            };

            Console.WriteLine($"�L�ıw��: {invalidPatient}");
            
            var invalidResult = invalidPatient.ValidateVersionSpecific();
            if (invalidResult == null)
            {
                Console.WriteLine("? ���ҳq�L");
            }
            else
            {
                Console.WriteLine($"? ���ҥ���: {invalidResult.ErrorMessage}");
            }

            Console.WriteLine();

            // �Ыئ����~�ʧO���w��
            var wrongGenderPatient = CreateBasicPatient();
            wrongGenderPatient.Gender = new FhirCode("invalid-gender");

            Console.WriteLine($"���~�ʧO�w��: {wrongGenderPatient}");
            
            var genderResult = wrongGenderPatient.ValidateVersionSpecific();
            if (genderResult == null)
            {
                Console.WriteLine("? ���ҳq�L");
            }
            else
            {
                Console.WriteLine($"? ���ҥ���: {genderResult.ErrorMessage}");
            }
        }

        /// <summary>
        /// �D�n�ܽd��k
        /// </summary>
        public static void RunExample()
        {
            Console.WriteLine("=== FHIR R4 Patient �d�� ===");
            Console.WriteLine();

            // �򥻱w��
            var basicPatient = CreateBasicPatient();
            Console.WriteLine($"�򥻱w��: {basicPatient}");
            Console.WriteLine($"FHIR ����: {basicPatient.GetFhirVersion()}");
            Console.WriteLine();

            // �a�p���H���w��
            var patientWithContact = CreatePatientWithContact();
            Console.WriteLine($"�a�p���H���w��: {patientWithContact}");
            Console.WriteLine($"�p���H�ƶq: {patientWithContact.Contact?.Count ?? 0}");
            Console.WriteLine();

            // �h�y���w��
            var multilingualPatient = CreateMultilingualPatient();
            Console.WriteLine($"�h�y���w��: {multilingualPatient}");
            Console.WriteLine($"�䴩�y���ƶq: {multilingualPatient.Communication?.Count ?? 0}");
            Console.WriteLine();

            // ���ҥܽd
            DemonstrateValidation();
        }
    }
}