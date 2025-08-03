using ResourceTypeServices.R4;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.SpecialTypes;

namespace Examples
{
    /// <summary>
    /// R4 Patient 使用範例
    /// 
    /// <para>
    /// 示範如何創建和使用 R4 版本的 Patient 資源。
    /// </para>
    /// </summary>
    public class R4PatientExample
    {
        /// <summary>
        /// 創建基本的 Patient 範例
        /// </summary>
        /// <returns>配置好的 PatientR4 實例</returns>
        public static PatientR4 CreateBasicPatient()
        {
            var patient = new PatientR4("patient-r4-001")
            {
                // 設定為活躍狀態
                Active = new FhirBoolean(true),

                // 設定識別碼
                Identifier = new List<Identifier>
                {
                    new Identifier
                    {
                        Use = new FhirCode("usual"),
                        System = new FhirUri("http://hospital.example.com/patients"),
                        Value = new FhirString("12345")
                    }
                },

                // 設定姓名
                Name = new List<HumanName>
                {
                    new HumanName
                    {
                        Use = new FhirCode("official"),
                        Family = new FhirString("陳"),
                        Given = new List<FhirString> 
                        { 
                            new FhirString("小明") 
                        }
                    }
                },

                // 設定性別
                Gender = new FhirCode("male"),

                // 設定出生日期
                BirthDate = new FhirDate("1985-03-15"),

                // 設定聯絡方式
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

                // 設定地址
                Address = new List<Address>
                {
                    new Address
                    {
                        Use = new FhirCode("home"),
                        Type = new FhirCode("both"),
                        Line = new List<FhirString> 
                        { 
                            new FhirString("台北市信義區信義路五段7號") 
                        },
                        City = new FhirString("台北市"),
                        PostalCode = new FhirString("110"),
                        Country = new FhirString("台灣")
                    }
                }
            };

            return patient;
        }

        /// <summary>
        /// 創建帶有緊急聯絡人的 Patient 範例
        /// </summary>
        /// <returns>包含聯絡人資訊的 PatientR4 實例</returns>
        public static PatientR4 CreatePatientWithContact()
        {
            var patient = CreateBasicPatient();

            // 添加緊急聯絡人
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
                        Family = new FhirString("李"),
                        Given = new List<FhirString> 
                        { 
                            new FhirString("小華") 
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
        /// 創建多語言患者範例
        /// </summary>
        /// <returns>支援多語言的 PatientR4 實例</returns>
        public static PatientR4 CreateMultilingualPatient()
        {
            var patient = CreateBasicPatient();

            // 添加語言偏好
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
        /// 示範驗證功能
        /// </summary>
        public static void DemonstrateValidation()
        {
            Console.WriteLine("=== R4 Patient 驗證示範 ===");

            // 創建有效的患者
            var validPatient = CreateBasicPatient();
            Console.WriteLine($"有效患者: {validPatient}");
            
            var validationResult = validPatient.ValidateVersionSpecific();
            if (validationResult == null)
            {
                Console.WriteLine("? 驗證通過");
            }
            else
            {
                Console.WriteLine($"? 驗證失敗: {validationResult.ErrorMessage}");
            }

            Console.WriteLine();

            // 創建無效的患者（無姓名和識別碼）
            var invalidPatient = new PatientR4("invalid-patient")
            {
                Active = new FhirBoolean(true),
                Gender = new FhirCode("unknown")
            };

            Console.WriteLine($"無效患者: {invalidPatient}");
            
            var invalidResult = invalidPatient.ValidateVersionSpecific();
            if (invalidResult == null)
            {
                Console.WriteLine("? 驗證通過");
            }
            else
            {
                Console.WriteLine($"? 驗證失敗: {invalidResult.ErrorMessage}");
            }

            Console.WriteLine();

            // 創建有錯誤性別的患者
            var wrongGenderPatient = CreateBasicPatient();
            wrongGenderPatient.Gender = new FhirCode("invalid-gender");

            Console.WriteLine($"錯誤性別患者: {wrongGenderPatient}");
            
            var genderResult = wrongGenderPatient.ValidateVersionSpecific();
            if (genderResult == null)
            {
                Console.WriteLine("? 驗證通過");
            }
            else
            {
                Console.WriteLine($"? 驗證失敗: {genderResult.ErrorMessage}");
            }
        }

        /// <summary>
        /// 主要示範方法
        /// </summary>
        public static void RunExample()
        {
            Console.WriteLine("=== FHIR R4 Patient 範例 ===");
            Console.WriteLine();

            // 基本患者
            var basicPatient = CreateBasicPatient();
            Console.WriteLine($"基本患者: {basicPatient}");
            Console.WriteLine($"FHIR 版本: {basicPatient.GetFhirVersion()}");
            Console.WriteLine();

            // 帶聯絡人的患者
            var patientWithContact = CreatePatientWithContact();
            Console.WriteLine($"帶聯絡人的患者: {patientWithContact}");
            Console.WriteLine($"聯絡人數量: {patientWithContact.Contact?.Count ?? 0}");
            Console.WriteLine();

            // 多語言患者
            var multilingualPatient = CreateMultilingualPatient();
            Console.WriteLine($"多語言患者: {multilingualPatient}");
            Console.WriteLine($"支援語言數量: {multilingualPatient.Communication?.Count ?? 0}");
            Console.WriteLine();

            // 驗證示範
            DemonstrateValidation();
        }
    }
}