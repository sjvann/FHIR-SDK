using FhirCore.R5.Resources;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;

namespace FhirCore.R5.Factory
{
    /// <summary>
    /// FHIR R5 資源工廠
    /// 提供便利的資源創建方法
    /// </summary>
    public static class R5Factory
    {
        #region Patient Factory Methods

        /// <summary>
        /// 創建新的 Patient 資源
        /// </summary>
        /// <returns>新的 Patient 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個空的 Patient 資源，所有屬性都初始化為 null。
        /// 建議在創建後立即設定必要的屬性。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var patient = R5Factory.CreatePatient();
        /// patient.Id = "patient-001";
        /// patient.Active = new FhirBoolean(true);
        /// </code>
        /// </example>
        public static Patient CreatePatient() => new();

        /// <summary>
        /// 創建具有指定 ID 的 Patient 資源
        /// </summary>
        /// <param name="id">患者的唯一識別碼</param>
        /// <returns>新的 Patient 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個具有指定 ID 的 Patient 資源，並將 Active 設為 true。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var patient = R5Factory.CreatePatient("patient-001");
        /// // patient.Id 已設為 "patient-001"
        /// // patient.Active 已設為 true
        /// </code>
        /// </example>
        public static Patient CreatePatient(string id)
        {
            return new Patient(id)
            {
                Active = new FhirBoolean(true)
            };
        }

        /// <summary>
        /// 創建具有基本資訊的 Patient 資源
        /// </summary>
        /// <param name="id">患者的唯一識別碼</param>
        /// <param name="familyName">姓氏</param>
        /// <param name="givenName">名字</param>
        /// <param name="gender">性別代碼 (male, female, other, unknown)</param>
        /// <param name="birthDate">出生日期 (YYYY-MM-DD 格式)</param>
        /// <returns>新的 Patient 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個包含基本資訊的 Patient 資源，適用於快速創建具有必要資訊的患者記錄。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var patient = R5Factory.CreatePatient(
        ///     "patient-001", 
        ///     "王", 
        ///     "小明", 
        ///     "male", 
        ///     "1990-05-15"
        /// );
        /// </code>
        /// </example>
        /// <exception cref="ArgumentException">當性別代碼無效時擲回</exception>
        /// <exception cref="ArgumentException">當出生日期格式無效時擲回</exception>
        public static Patient CreatePatient(string id, string familyName, string givenName, string gender, string birthDate)
        {
            // 驗證性別代碼
            var validGenders = new[] { "male", "female", "other", "unknown" };
            if (!validGenders.Contains(gender))
            {
                throw new ArgumentException($"性別代碼 '{gender}' 無效。有效值為: {string.Join(", ", validGenders)}", nameof(gender));
            }

            // 驗證出生日期格式
            if (!DateTime.TryParse(birthDate, out var parsedDate))
            {
                throw new ArgumentException($"出生日期 '{birthDate}' 格式無效。請使用 YYYY-MM-DD 格式", nameof(birthDate));
            }

            // 驗證出生日期不能是未來日期
            if (parsedDate > DateTime.Now.Date)
            {
                throw new ArgumentException("出生日期不能是未來日期", nameof(birthDate));
            }

            var humanName = new HumanName
            {
                Family = new FhirString(familyName),
                Given = new List<FhirString> { new FhirString(givenName) }
            };

            return new Patient(id, humanName, gender, birthDate);
        }

        /// <summary>
        /// 創建測試用的 Patient 資源
        /// </summary>
        /// <param name="suffix">ID 後綴，用於區分不同的測試患者</param>
        /// <returns>新的 Patient 實例</returns>
        /// <remarks>
        /// <para>
        /// 此方法專門用於測試和開發環境，創建具有預設測試資料的患者記錄。
        /// 不建議在生產環境中使用。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var testPatient1 = R5Factory.CreateTestPatient("001");
        /// var testPatient2 = R5Factory.CreateTestPatient("002");
        /// </code>
        /// </example>
        public static Patient CreateTestPatient(string suffix = "001")
        {
            var id = $"test-patient-{suffix}";
            var humanName = new HumanName
            {
                Family = new FhirString("測試"),
                Given = new List<FhirString> { new FhirString($"患者{suffix}") }
            };

            return new Patient(id)
            {
                Name = new List<HumanName> { humanName },
                Gender = new FhirCode("unknown"),
                BirthDate = new FhirDate("1990-01-01"),
                Active = new FhirBoolean(true)
            };
        }

        #endregion

        #region Basic Factory Methods

        /// <summary>
        /// 創建新的 Basic 資源
        /// </summary>
        /// <returns>新的 Basic 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個空的 Basic 資源，所有屬性都初始化為 null。
        /// 必須在創建後設定 Code 屬性。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var basic = R5Factory.CreateBasic();
        /// basic.Id = "basic-001";
        /// basic.Code = new CodeableConcept { ... };
        /// </code>
        /// </example>
        public static Basic CreateBasic() => new();

        /// <summary>
        /// 創建具有指定 ID 的 Basic 資源
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <returns>新的 Basic 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個具有指定 ID 的 Basic 資源。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var basic = R5Factory.CreateBasic("basic-001");
        /// // basic.Id 已設為 "basic-001"
        /// </code>
        /// </example>
        public static Basic CreateBasic(string id) => new(id);

        /// <summary>
        /// 創建具有基本資訊的 Basic 資源
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <param name="code">資源代碼</param>
        /// <param name="subject">主體引用</param>
        /// <returns>新的 Basic 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個包含基本資訊的 Basic 資源，並自動設定建立時間。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var code = new CodeableConcept
        /// {
        ///     Coding = new List&lt;Coding&gt;
        ///     {
        ///         new Coding
        ///         {
        ///             System = new FhirUri("http://example.com/codes"),
        ///             Code = new FhirCode("consent"),
        ///             Display = new FhirString("Consent")
        ///         }
        ///     }
        /// };
        /// var subject = new ReferenceType
        /// {
        ///     Reference = new FhirString("Patient/patient-001"),
        ///     Display = new FhirString("張三")
        /// };
        /// var basic = R5Factory.CreateBasic("basic-001", code, subject);
        /// </code>
        /// </example>
        public static Basic CreateBasic(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            return new Basic(id, code, subject);
        }

        /// <summary>
        /// 創建簡單的 Basic 資源（使用文字代碼）
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <param name="codeText">代碼文字描述</param>
        /// <param name="subjectReference">主體引用字串</param>
        /// <returns>新的 Basic 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個簡單的 Basic 資源，適用於快速原型開發或測試。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var basic = R5Factory.CreateSimpleBasic(
        ///     "basic-001", 
        ///     "患者同意書", 
        ///     "Patient/patient-001"
        /// );
        /// </code>
        /// </example>
        public static Basic CreateSimpleBasic(string id, string codeText, string subjectReference)
        {
            var code = new CodeableConcept
            {
                Text = new FhirString(codeText)
            };

            var subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(subjectReference)
            };

            return new Basic(id, code, subject);
        }

        #endregion

        #region Organization Factory Methods

        /// <summary>
        /// 創建新的 Organization 資源
        /// </summary>
        /// <returns>新的 Organization 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個空的 Organization 資源，所有屬性都初始化為 null。
        /// 建議在創建後立即設定必要的屬性。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var organization = R5Factory.CreateOrganization();
        /// organization.Id = "org-001";
        /// organization.Active = new FhirBoolean(true);
        /// </code>
        /// </example>
        public static Organization CreateOrganization() => new();

        /// <summary>
        /// 創建具有指定 ID 的 Organization 資源
        /// </summary>
        /// <param name="id">組織的唯一識別碼</param>
        /// <returns>新的 Organization 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個具有指定 ID 的 Organization 資源，並將 Active 設為 true。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var organization = R5Factory.CreateOrganization("org-001");
        /// // organization.Id 已設為 "org-001"
        /// // organization.Active 已設為 true
        /// </code>
        /// </example>
        public static Organization CreateOrganization(string id) => new(id);

        /// <summary>
        /// 創建具有基本資訊的 Organization 資源
        /// </summary>
        /// <param name="id">組織的唯一識別碼</param>
        /// <param name="name">組織名稱</param>
        /// <returns>新的 Organization 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個包含基本資訊的 Organization 資源，適用於快速創建具有必要資訊的組織記錄。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var organization = R5Factory.CreateOrganization("org-001", "台北醫院");
        /// </code>
        /// </example>
        public static Organization CreateOrganization(string id, string name)
        {
            return new Organization(id, name);
        }

        /// <summary>
        /// 創建具有類型的 Organization 資源
        /// </summary>
        /// <param name="id">組織的唯一識別碼</param>
        /// <param name="name">組織名稱</param>
        /// <param name="organizationType">組織類型代碼</param>
        /// <returns>新的 Organization 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個包含名稱和類型的 Organization 資源，
        /// 類型將自動轉換為可讀的顯示名稱。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var organization = R5Factory.CreateOrganization("org-001", "台北醫院", "prov");
        /// // organization.Id 已設為 "org-001"
        /// // organization.Name 已設為 "台北醫院"
        /// // organization.Type 已設為包含 "Healthcare Provider" 的 Coding 列表
        /// </code>
        /// </example>
        public static Organization CreateOrganization(string id, string name, string organizationType)
        {
            var type = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://terminology.hl7.org/CodeSystem/organization-type"),
                        Code = new FhirCode(organizationType),
                        Display = new FhirString(GetOrganizationTypeDisplay(organizationType))
                    }
                }
            };

            return new Organization(id, name, type);
        }

        private static string GetOrganizationTypeDisplay(string code)
        {
            return code switch
            {
                "prov" => "Healthcare Provider",
                "dept" => "Hospital Department",
                "team" => "Team",
                "govt" => "Government",
                "ins" => "Insurance Company",
                "pay" => "Payer",
                "edu" => "Educational Institute",
                "reli" => "Religious Institution",
                "crs" => "Clinical Research Sponsor",
                "cg" => "Community Group",
                "bus" => "Non-Healthcare Business",
                "other" => "Other",
                _ => code
            };
        }

        #endregion

        #region Practitioner Factory Methods

        /// <summary>
        /// 創建新的 Practitioner 資源
        /// </summary>
        /// <returns>新的 Practitioner 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個空的 Practitioner 資源，所有屬性都初始化為 null。
        /// 建議在創建後立即設定必要的屬性。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var practitioner = R5Factory.CreatePractitioner();
        /// practitioner.Id = "practitioner-001";
        /// practitioner.Active = new FhirBoolean(true);
        /// </code>
        /// </example>
        public static Practitioner CreatePractitioner() => new();

        /// <summary>
        /// 創建具有指定 ID 的 Practitioner 資源
        /// </summary>
        /// <param name="id">從業人員的唯一識別碼</param>
        /// <returns>新的 Practitioner 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個具有指定 ID 的 Practitioner 資源，並將 Active 設為 true。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var practitioner = R5Factory.CreatePractitioner("practitioner-001");
        /// // practitioner.Id 已設為 "practitioner-001"
        /// // practitioner.Active 已設為 true
        /// </code>
        /// </example>
        public static Practitioner CreatePractitioner(string id) => new(id);

        /// <summary>
        /// 創建具有基本資訊的 Practitioner 資源
        /// </summary>
        /// <param name="id">從業人員的唯一識別碼</param>
        /// <param name="familyName">姓氏</param>
        /// <param name="givenName">名字</param>
        /// <returns>新的 Practitioner 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個包含基本資訊的 Practitioner 資源，適用於快速創建具有必要資訊的從業人員記錄。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var practitioner = R5Factory.CreatePractitioner("practitioner-001", "王", "小明");
        /// </code>
        /// </example>
        public static Practitioner CreatePractitioner(string id, string familyName, string givenName)
        {
            return new Practitioner(id, familyName, givenName);
        }

        /// <summary>
        /// 創建具有完整資訊的 Practitioner 資源
        /// </summary>
        /// <param name="id">從業人員的唯一識別碼</param>
        /// <param name="familyName">姓氏</param>
        /// <param name="givenName">名字</param>
        /// <param name="gender">性別代碼</param>
        /// <returns>新的 Practitioner 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個包含完整資訊的 Practitioner 資源。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var practitioner = R5Factory.CreatePractitioner("practitioner-001", "王", "小明", "male");
        /// </code>
        /// </example>
        public static Practitioner CreatePractitioner(string id, string familyName, string givenName, string gender)
        {
            var practitioner = new Practitioner(id, familyName, givenName)
            {
                Gender = new FhirCode(gender)
            };

            return practitioner;
        }

        /// <summary>
        /// 創建醫師 Practitioner 資源
        /// </summary>
        /// <param name="id">從業人員的唯一識別碼</param>
        /// <param name="familyName">姓氏</param>
        /// <param name="givenName">名字</param>
        /// <param name="licenseNumber">醫師執照識別碼</param>
        /// <returns>新的 Practitioner 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個包含醫師專屬資訊的 Practitioner 資源。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var doctor = R5Factory.CreateDoctor("practitioner-001", "王", "小明", "A123456789");
        /// </code>
        /// </example>
        public static Practitioner CreateDoctor(string id, string familyName, string givenName, string licenseNumber)
        {
            var practitioner = new Practitioner(id, familyName, givenName);

            // 添加醫師執照識別碼
            practitioner.Identifier = new List<Identifier>
            {
                new Identifier
                {
                    System = new FhirUri("http://www.mohw.gov.tw/doctor-license"),
                    Value = new FhirString(licenseNumber),
                    Type = new CodeableConcept
                    {
                        Text = new FhirString("醫師執照號碼")
                    }
                }
            };

            // 添加醫師資格
            practitioner.Qualification = new List<PractitionerQualification>
            {
                new PractitionerQualification(new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding
                        {
                            System = new FhirUri("http://snomed.info/sct"),
                            Code = new FhirCode("309343006"),
                            Display = new FhirString("Physician")
                        }
                    },
                    Text = new FhirString("醫師")
                })
            };

            return practitioner;
        }

        #endregion

        #region Medication Factory Methods

        /// <summary>
        /// 創建新的 Medication 資源
        /// </summary>
        /// <returns>新的 Medication 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個空的 Medication 資源，所有屬性都初始化為 null。
        /// 建議在創建後立即設定必要的屬性。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var medication = R5Factory.CreateMedication();
        /// medication.Id = "medication-001";
        /// </code>
        /// </example>
        public static Medication CreateMedication() => new();

        /// <summary>
        /// 創建具有指定 ID 的 Medication 資源
        /// </summary>
        /// <param name="id">藥物的唯一識別碼</param>
        /// <returns>新的 Medication 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個具有指定 ID 的 Medication 資源。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var medication = R5Factory.CreateMedication("medication-001");
        /// // medication.Id 已設為 "medication-001"
        /// </code>
        /// </example>
        public static Medication CreateMedication(string id) => new(id);

        /// <summary>
        /// 創建具有代碼的 Medication 資源
        /// </summary>
        /// <param name="id">藥物的唯一識別碼</param>
        /// <param name="code">藥物代碼</param>
        /// <returns>新的 Medication 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個具有指定 ID 和代碼的 Medication 資源。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var code = new CodeableConcept
        /// {
        ///     Coding = new List&lt;Coding&gt;
        ///     {
        ///         new Coding
        ///         {
        ///             System = new FhirUri("http://www.nlm.nih.gov/research/umls/rxnorm"),
        ///             Code = new FhirCode("24620"),
        ///             Display = new FhirString("Acetaminophen 325 MG Oral Tablet")
        ///         }
        ///     }
        /// };
        /// var medication = R5Factory.CreateMedication("medication-001", code);
        /// // medication.Id 已設為 "medication-001"
        /// // medication.Code 已設為指定的 CodeableConcept
        /// </code>
        /// </example>
        public static Medication CreateMedication(string id, CodeableConcept code)
        {
            return new Medication(id, code);
        }

        /// <summary>
        /// 創建簡單的 Medication 資源
        /// </summary>
        /// <param name="id">藥物的唯一識別碼</param>
        /// <param name="medicationName">藥物名稱</param>
        /// <param name="rxNormCode">RxNorm 代碼（選填）</param>
        /// <returns>新的 Medication 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個簡單的 Medication 資源，僅包含名稱。
        /// 可選擇性地添加 RxNorm 代碼，以便與外部系統整合。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var medication = R5Factory.CreateSimpleMedication("medication-001", "對乙醯氨基酚", "24620");
        /// // medication.Id 已設為 "medication-001"
        /// // medication.Code.Text 已設為 "對乙醯氨基酚"
        /// // medication.Code.Coding 已包含指定的 RxNorm 代碼
        /// </code>
        /// </example>
        public static Medication CreateSimpleMedication(string id, string medicationName, string rxNormCode = null)
        {
            var code = new CodeableConcept
            {
                Text = new FhirString(medicationName)
            };

            if (!string.IsNullOrEmpty(rxNormCode))
            {
                code.Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://www.nlm.nih.gov/research/umls/rxnorm"),
                        Code = new FhirCode(rxNormCode),
                        Display = new FhirString(medicationName)
                    }
                };
            }

            return new Medication(id, code);
        }

        /// <summary>
        /// 創建具有劑型的 Medication 資源
        /// </summary>
        /// <param name="id">藥物的唯一識別碼</param>
        /// <param name="medicationName">藥物名稱</param>
        /// <param name="doseForm">劑型描述</param>
        /// <returns>新的 Medication 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個包含藥物名稱和劑型的 Medication 資源。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var medication = R5Factory.CreateMedicationWithDoseForm("medication-001", "對乙醯氨基酚", "Tablet");
        /// // medication.Id 已設為 "medication-001"
        /// // medication.Code.Text 已設為 "對乙醯氨基酚"
        /// // medication.DoseForm.Text 已設為 "Tablet"
        /// </code>
        /// </example>
        public static Medication CreateMedicationWithDoseForm(string id, string medicationName, string doseForm)
        {
            var medication = CreateSimpleMedication(id, medicationName);
            
            medication.DoseForm = new CodeableConcept
            {
                Text = new FhirString(doseForm)
            };

            return medication;
        }

        /// <summary>
        /// 創建具有批次資訊的 Medication 資源
        /// </summary>
        /// <param name="id">藥物的唯一識別碼</param>
        /// <param name="medicationName">藥物名稱</param>
        /// <param name="lotNumber">批號</param>
        /// <param name="expirationDate">有效日期（選填）</param>
        /// <returns>新的 Medication 實例</returns>
        /// <remarks>
        /// <para>
        /// 創建一個包含藥物名稱和批次資訊的 Medication 資源。
        /// 可選擇性地添加有效日期。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var medication = R5Factory.CreateMedicationWithBatch("medication-001", "對乙醯氨基酚", "BATCH123", new DateTime(2023, 12, 31));
        /// // medication.Id 已設為 "medication-001"
        /// // medication.Code.Text 已設為 "對乙醯氨基酚"
        /// // medication.Batch.LotNumber 已設為 "BATCH123"
        /// // medication.Batch.ExpirationDate 已設為 2023-12-31
        /// </code>
        /// </example>
        public static Medication CreateMedicationWithBatch(string id, string medicationName, string lotNumber, DateTime? expirationDate = null)
        {
            var medication = CreateSimpleMedication(id, medicationName);
            
            medication.Batch = new MedicationBatch(lotNumber, expirationDate);

            return medication;
        }

        #endregion

        #region Observation Factory Methods

        /// <summary>
        /// 創建新的 Observation 資源
        /// </summary>
        public static Observation CreateObservation() => new();

        /// <summary>
        /// 創建具有指定 ID 的 Observation 資源
        /// </summary>
        public static Observation CreateObservation(string id) => new(id);

        /// <summary>
        /// 創建具有基本資訊的 Observation 資源
        /// </summary>
        public static Observation CreateObservation(string id, string status, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            return new Observation(id, status, code, subject);
        }

        /// <summary>
        /// 創建簡單的數值型 Observation 資源
        /// </summary>
        public static Observation CreateQuantityObservation(string id, string loincCode, string display, 
            decimal value, string unit, string subjectReference)
        {
            var code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://loinc.org"),
                        Code = new FhirCode(loincCode),
                        Display = new FhirString(display)
                    }
                }
            };

            var subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(subjectReference)
            };

            var quantity = new Quantity
            {
                Value = new FhirDecimal(value),
                Unit = new FhirString(unit),
                System = new FhirUri("http://unitsofmeasure.org"),
                Code = new FhirCode(unit)
            };

            var observation = new Observation(id, "final", code, subject);
            observation.Value = new ObservationValueChoice(quantity);
            observation.Effective = new ObservationEffectiveChoice(new FhirDateTime(DateTime.Now));

            return observation;
        }

        /// <summary>
        /// 創建生命體徵 Observation 資源
        /// </summary>
        public static Observation CreateVitalSignsObservation(string id, string vitalSignType, decimal value, 
            string unit, string subjectReference)
        {
            var vitalSignCodes = new Dictionary<string, (string code, string display)>
            {
                ["body-height"] = ("8302-2", "Body height"),
                ["body-weight"] = ("29463-7", "Body weight"),
                ["body-temperature"] = ("8310-5", "Body temperature"),
                ["heart-rate"] = ("8867-4", "Heart rate"),
                ["respiratory-rate"] = ("9279-1", "Respiratory rate"),
                ["blood-pressure-systolic"] = ("8480-6", "Systolic blood pressure"),
                ["blood-pressure-diastolic"] = ("8462-4", "Diastolic blood pressure")
            };

            if (!vitalSignCodes.ContainsKey(vitalSignType))
            {
                throw new ArgumentException($"不支援的生命體徵類型: {vitalSignType}", nameof(vitalSignType));
            }

            var (loincCode, display) = vitalSignCodes[vitalSignType];
            var observation = CreateQuantityObservation(id, loincCode, display, value, unit, subjectReference);

            // 添加生命體徵分類
            observation.Category = new List<CodeableConcept>
            {
                new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding
                        {
                            System = new FhirUri("http://terminology.hl7.org/CodeSystem/observation-category"),
                            Code = new FhirCode("vital-signs"),
                            Display = new FhirString("Vital Signs")
                        }
                    }
                }
            };

            return observation;
        }

        /// <summary>
        /// 創建實驗室檢驗 Observation 資源
        /// </summary>
        public static Observation CreateLabObservation(string id, string loincCode, string display, 
            decimal value, string unit, string subjectReference)
        {
            var observation = CreateQuantityObservation(id, loincCode, display, value, unit, subjectReference);

            // 添加實驗室分類
            observation.Category = new List<CodeableConcept>
            {
                new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding
                        {
                            System = new FhirUri("http://terminology.hl7.org/CodeSystem/observation-category"),
                            Code = new FhirCode("laboratory"),
                            Display = new FhirString("Laboratory")
                        }
                    }
                }
            };

            return observation;
        }

        /// <summary>
        /// 創建代碼型 Observation 資源
        /// </summary>
        public static Observation CreateCodedObservation(string id, string loincCode, string loincDisplay,
            string valueSystem, string valueCode, string valueDisplay, string subjectReference)
        {
            var code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://loinc.org"),
                        Code = new FhirCode(loincCode),
                        Display = new FhirString(loincDisplay)
                    }
                }
            };

            var subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(subjectReference)
            };

            var valueCodeableConcept = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri(valueSystem),
                        Code = new FhirCode(valueCode),
                        Display = new FhirString(valueDisplay)
                    }
                }
            };

            var observation = new Observation(id, "final", code, subject);
            observation.Value = new ObservationValueChoice(valueCodeableConcept);
            observation.Effective = new ObservationEffectiveChoice(new FhirDateTime(DateTime.Now));

            return observation;
        }

        /// <summary>
        /// 創建帶參考範圍的 Observation 資源
        /// </summary>
        public static Observation CreateObservationWithReferenceRange(string id, string loincCode, string display,
            decimal value, string unit, string subjectReference, decimal lowLimit, decimal highLimit)
        {
            var observation = CreateQuantityObservation(id, loincCode, display, value, unit, subjectReference);

            // 添加參考範圍
            observation.ReferenceRange = new List<ObservationReferenceRange>
            {
                new ObservationReferenceRange(
                    new Quantity
                    {
                        Value = new FhirDecimal(lowLimit),
                        Unit = new FhirString(unit),
                        System = new FhirUri("http://unitsofmeasure.org"),
                        Code = new FhirCode(unit)
                    },
                    new Quantity
                    {
                        Value = new FhirDecimal(highLimit),
                        Unit = new FhirString(unit),
                        System = new FhirUri("http://unitsofmeasure.org"),
                        Code = new FhirCode(unit)
                    }
                )
            };

            return observation;
        }

        #endregion

        #region Encounter Factory Methods

        /// <summary>
        /// 創建新的 Encounter 資源
        /// </summary>
        public static Encounter CreateEncounter() => new();

        /// <summary>
        /// 創建具有指定 ID 的 Encounter 資源
        /// </summary>
        public static Encounter CreateEncounter(string id) => new(id);

        /// <summary>
        /// 創建具有基本資訊的 Encounter 資源
        /// </summary>
        public static Encounter CreateEncounter(string id, string status, CodeableConcept encounterClass, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            return new Encounter(id, status, encounterClass, subject);
        }

        /// <summary>
        /// 創建門診 Encounter 資源
        /// </summary>
        public static Encounter CreateOutpatientEncounter(string id, string subjectReference, string practitionerReference)
        {
            var encounterClass = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActCode"),
                        Code = new FhirCode("AMB"),
                        Display = new FhirString("Ambulatory")
                    }
                }
            };

            var subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(subjectReference)
            };

            var encounter = new Encounter(id, "in-progress", encounterClass, subject);

            // 添加主治醫師
            encounter.Participant = new List<EncounterParticipant>
            {
                new EncounterParticipant(
                    new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
                    {
                        Reference = new FhirString(practitionerReference)
                    },
                    new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding
                            {
                                System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ParticipationType"),
                                Code = new FhirCode("ATND"),
                                Display = new FhirString("Attender")
                            }
                        }
                    }
                )
            };

            // 設定就診時間
            encounter.ActualPeriod = new Period
            {
                Start = new FhirDateTime(DateTime.Now)
            };

            return encounter;
        }

        /// <summary>
        /// 創建住院 Encounter 資源
        /// </summary>
        public static Encounter CreateInpatientEncounter(string id, string subjectReference, string practitionerReference, string organizationReference)
        {
            var encounterClass = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActCode"),
                        Code = new FhirCode("IMP"),
                        Display = new FhirString("Inpatient")
                    }
                }
            };

            var subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(subjectReference)
            };

            var encounter = new Encounter(id, "in-progress", encounterClass, subject);

            // 設定服務提供者
            encounter.ServiceProvider = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(organizationReference)
            };

            // 添加主治醫師
            encounter.Participant = new List<EncounterParticipant>
            {
                new EncounterParticipant(
                    new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
                    {
                        Reference = new FhirString(practitionerReference)
                    },
                    new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding
                            {
                                System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ParticipationType"),
                                Code = new FhirCode("ATND"),
                                Display = new FhirString("Attender")
                            }
                        }
                    }
                )
            };

            // 設定入院資訊
            encounter.Admission = new EncounterAdmission
            {
                AdmitSource = new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding
                        {
                            System = new FhirUri("http://terminology.hl7.org/CodeSystem/admit-source"),
                            Code = new FhirCode("emd"),
                            Display = new FhirString("From emergency department")
                        }
                    }
                }
            };

            return encounter;
        }

        /// <summary>
        /// 創建急診 Encounter 資源
        /// </summary>
        public static Encounter CreateEmergencyEncounter(string id, string subjectReference, string priority = "urgent")
        {
            var encounterClass = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActCode"),
                        Code = new FhirCode("EMER"),
                        Display = new FhirString("Emergency")
                    }
                }
            };

            var subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(subjectReference)
            };

            var encounter = new Encounter(id, "in-progress", encounterClass, subject);

            // 設定優先級
            encounter.Priority = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActPriority"),
                        Code = new FhirCode(priority),
                        Display = new FhirString(GetPriorityDisplay(priority))
                    }
                }
            };

            // 設定就診時間
            encounter.ActualPeriod = new Period
            {
                Start = new FhirDateTime(DateTime.Now)
            };

            return encounter;
        }

        /// <summary>
        /// 創建虛擬就診 Encounter 資源
        /// </summary>
        public static Encounter CreateVirtualEncounter(string id, string subjectReference, string practitionerReference)
        {
            var encounterClass = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActCode"),
                        Code = new FhirCode("VR"),
                        Display = new FhirString("Virtual")
                    }
                }
            };

            var subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(subjectReference)
            };

            var encounter = new Encounter(id, "planned", encounterClass, subject);

            // 添加醫師參與者
            encounter.Participant = new List<EncounterParticipant>
            {
                new EncounterParticipant(
                    new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
                    {
                        Reference = new FhirString(practitionerReference)
                    },
                    new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding
                            {
                                System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ParticipationType"),
                                Code = new FhirCode("ATND"),
                                Display = new FhirString("Attender")
                            }
                        }
                    }
                )
            };

            return encounter;
        }

        /// <summary>
        /// 創建帶診?的 Encounter 資源
        /// </summary>
        public static Encounter CreateEncounterWithDiagnosis(string id, string status, CodeableConcept encounterClass, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject, List<CodeableReference> diagnoses)
        {
            var encounter = new Encounter(id, status, encounterClass, subject);

            encounter.Diagnosis = diagnoses.Select(d => new EncounterDiagnosis(d)).ToList();

            return encounter;
        }

        private static string GetPriorityDisplay(string code)
        {
            return code switch
            {
                "stat" => "Stat",
                "asap" => "As soon as possible",
                "urgent" => "Urgent",
                "routine" => "Routine",
                _ => code
            };
        }

        #endregion

        #region Condition Factory Methods

        /// <summary>
        /// 創建新的 Condition 資源
        /// </summary>
        public static Condition CreateCondition() => new();

        /// <summary>
        /// 創建具有指定 ID 的 Condition 資源
        /// </summary>
        public static Condition CreateCondition(string id) => new(id);

        /// <summary>
        /// 創建具有基本資訊的 Condition 資源
        /// </summary>
        public static Condition CreateCondition(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            return new Condition(id, code, subject);
        }

        /// <summary>
        /// 創建確診的 Condition 資源
        /// </summary>
        public static Condition CreateConfirmedCondition(string id, string snomedCode, string displayName, string subjectReference)
        {
            var code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://snomed.info/sct"),
                        Code = new FhirCode(snomedCode),
                        Display = new FhirString(displayName)
                    }
                }
            };

            var subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(subjectReference)
            };

            var clinicalStatus = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-clinical"),
                        Code = new FhirCode("active"),
                        Display = new FhirString("Active")
                    }
                }
            };

            var verificationStatus = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-ver-status"),
                        Code = new FhirCode("confirmed"),
                        Display = new FhirString("Confirmed")
                    }
                }
            };

            return new Condition(id, code, subject, clinicalStatus, verificationStatus);
        }

        /// <summary>
        /// 創建主要診斷 Condition 資源
        /// </summary>
        public static Condition CreatePrimaryDiagnosis(string id, string icd10Code, string displayName, string subjectReference, string encounterReference)
        {
            var code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://hl7.org/fhir/sid/icd-10"),
                        Code = new FhirCode(icd10Code),
                        Display = new FhirString(displayName)
                    }
                }
            };

            var subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(subjectReference)
            };

            var clinicalStatus = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-clinical"),
                        Code = new FhirCode("active"),
                        Display = new FhirString("Active")
                    }
                }
            };

            var verificationStatus = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-ver-status"),
                        Code = new FhirCode("confirmed"),
                        Display = new FhirString("Confirmed")
                    }
                }
            };

            var condition = new Condition(id, code, subject, clinicalStatus, verificationStatus);

            // 設定為主要診斷
            condition.Category = new List<CodeableConcept>
            {
                new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding
                        {
                            System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-category"),
                            Code = new FhirCode("encounter-diagnosis"),
                            Display = new FhirString("Encounter Diagnosis")
                        }
                    }
                }
            };

            // 設定關聯就診
            condition.Encounter = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(encounterReference)
            };

            return condition;
        }

        /// <summary>
        /// 創建問題列表 Condition 資源
        /// </summary>
        public static Condition CreateProblemListCondition(string id, string problemText, string subjectReference, string severity = "moderate")
        {
            var code = new CodeableConcept
            {
                Text = new FhirString(problemText)
            };

            var subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(subjectReference)
            };

            var clinicalStatus = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-clinical"),
                        Code = new FhirCode("active"),
                        Display = new FhirString("Active")
                    }
                }
            };

            var condition = new Condition(id, code, subject, clinicalStatus);

            // 設定為問題列表
            condition.Category = new List<CodeableConcept>
            {
                new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding
                        {
                            System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-category"),
                            Code = new FhirCode("problem-list-item"),
                            Display = new FhirString("Problem List Item")
                        }
                    }
                }
            };

            // 設定嚴重程度
            condition.Severity = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://snomed.info/sct"),
                        Code = new FhirCode(GetSeverityCode(severity)),
                        Display = new FhirString(GetSeverityDisplay(severity))
                    }
                }
            };

            return condition;
        }

        /// <summary>
        /// 創建慢性病 Condition 資源
        /// </summary>
        public static Condition CreateChronicCondition(string id, string snomedCode, string displayName, string subjectReference, DateTime onsetDate)
        {
            var condition = CreateConfirmedCondition(id, snomedCode, displayName, subjectReference);

            // 設定發病時間
            condition.Onset = new ConditionOnsetChoice(new FhirDateTime(onsetDate));

            // 設定為慢性病
            condition.Category = new List<CodeableConcept>
            {
                new CodeableConcept
                {
                    Coding = new List<Coding>
                    {
                        new Coding
                        {
                            System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-category"),
                            Code = new FhirCode("problem-list-item"),
                            Display = new FhirString("Problem List Item")
                        }
                    }
                }
            };

            return condition;
        }

        /// <summary>
        /// 創建已解決的 Condition 資源
        /// </summary>
        public static Condition CreateResolvedCondition(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject, DateTime resolvedDate)
        {
            var clinicalStatus = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-clinical"),
                        Code = new FhirCode("resolved"),
                        Display = new FhirString("Resolved")
                    }
                }
            };

            var verificationStatus = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-ver-status"),
                        Code = new FhirCode("confirmed"),
                        Display = new FhirString("Confirmed")
                    }
                }
            };

            var condition = new Condition(id, code, subject, clinicalStatus, verificationStatus);

            // 設定緩解時間
            condition.Abatement = new ConditionAbatementChoice(new FhirDateTime(resolvedDate));

            return condition;
        }

        private static string GetSeverityCode(string severity)
        {
            return severity.ToLower() switch
            {
                "mild" => "255604002",
                "moderate" => "6736007",
                "severe" => "24484000",
                _ => "6736007" // 預設為中等
            };
        }

        private static string GetSeverityDisplay(string severity)
        {
            return severity.ToLower() switch
            {
                "mild" => "Mild",
                "moderate" => "Moderate",
                "severe" => "Severe",
                _ => "Moderate"
            };
        }

        #endregion

        #region Test Data Factory Methods

        /// <summary>
        /// 創建測試用的 Organization 資源
        /// </summary>
        /// <param name="suffix">ID 後綴，用於區分不同的測試組織</param>
        /// <returns>新的 Organization 實例</returns>
        /// <remarks>
        /// <para>
        /// 此方法專門用於測試和開發環境，創建具有預設測試資料的組織記錄。
        /// 不建議在生產環境中使用。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var testOrganization1 = R5Factory.CreateTestOrganization("001");
        /// var testOrganization2 = R5Factory.CreateTestOrganization("002");
        /// </code>
        /// </example>
        public static Organization CreateTestOrganization(string suffix = "001")
        {
            var id = $"test-org-{suffix}";
            return CreateOrganization(id, $"測試醫院{suffix}", "prov");
        }

        /// <summary>
        /// 創建測試用的 Practitioner 資源
        /// </summary>
        /// <param name="suffix">ID 後綴，用於區分不同的測試從業人員</param>
        /// <returns>新的 Practitioner 實例</returns>
        /// <remarks>
        /// <para>
        /// 此方法專門用於測試和開發環境，創建具有預設測試資料的從業人員記錄。
        /// 不建議在生產環境中使用。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var testPractitioner1 = R5Factory.CreateTestPractitioner("001");
        /// var testPractitioner2 = R5Factory.CreateTestPractitioner("002");
        /// </code>
        /// </example>
        public static Practitioner CreateTestPractitioner(string suffix = "001")
        {
            var id = $"test-practitioner-{suffix}";
            return CreatePractitioner(id, "測試", $"醫師{suffix}", "unknown");
        }

        /// <summary>
        /// 創建測試用的 Medication 資源
        /// </summary>
        /// <param name="suffix">ID 後綴，用於區分不同的測試藥物</param>
        /// <returns>新的 Medication 實例</returns>
        /// <remarks>
        /// <para>
        /// 此方法專門用於測試和開發環境，創建具有預設測試資料的藥物記錄。
        /// 不建議在生產環境中使用。
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var testMedication1 = R5Factory.CreateTestMedication("001");
        /// var testMedication2 = R5Factory.CreateTestMedication("002");
        /// </code>
        /// </example>
        public static Medication CreateTestMedication(string suffix = "001")
        {
            var id = $"test-medication-{suffix}";
            return CreateSimpleMedication(id, $"測試藥物{suffix}");
        }

        /// <summary>
        /// 創建測試用的 Observation 資源
        /// </summary>
        public static Observation CreateTestObservation(string suffix = "001")
        {
            var id = $"test-observation-{suffix}";
            return CreateVitalSignsObservation(id, "body-height", 175, "cm", $"Patient/test-patient-{suffix}");
        }

        /// <summary>
        /// 創建測試用的 Encounter 資源
        /// </summary>
        public static Encounter CreateTestEncounter(string suffix = "001")
        {
            var id = $"test-encounter-{suffix}";
            return CreateOutpatientEncounter(id, $"Patient/test-patient-{suffix}", $"Practitioner/test-practitioner-{suffix}");
        }

        /// <summary>
        /// 創建測試用的 Condition 資源
        /// </summary>
        public static Condition CreateTestCondition(string suffix = "001")
        {
            var id = $"test-condition-{suffix}";
            return CreateConfirmedCondition(id, "73211009", $"測試診斷{suffix}", $"Patient/test-patient-{suffix}");
        }

        #endregion

        #region Validation Helper Methods

        /// <summary>
        /// 驗證並創建 Patient 資源
        /// </summary>
        public static Patient CreateValidatedPatient(string id, string familyName, string givenName, string gender, string birthDate)
        {
            var patient = CreatePatient(id, familyName, givenName, gender, birthDate);
            
            var validationResult = patient.Validate();
            if (validationResult != System.ComponentModel.DataAnnotations.ValidationResult.Success)
            {
                throw new InvalidOperationException($"患者資源驗證失敗");
            }

            return patient;
        }

        /// <summary>
        /// 驗證並創建 Organization 資源
        /// </summary>
        public static Organization CreateValidatedOrganization(string id, string name)
        {
            var organization = CreateOrganization(id, name);
            
            var validationResult = organization.Validate();
            if (validationResult != System.ComponentModel.DataAnnotations.ValidationResult.Success)
            {
                throw new InvalidOperationException($"組織資源驗證失敗");
            }

            return organization;
        }

        /// <summary>
        /// 驗證並創建 Observation 資源
        /// </summary>
        public static Observation CreateValidatedObservation(string id, string status, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            var observation = CreateObservation(id, status, code, subject);
            
            var validationResult = observation.Validate();
            if (validationResult != System.ComponentModel.DataAnnotations.ValidationResult.Success)
            {
                throw new InvalidOperationException($"觀察值資源驗證失敗");
            }

            return observation;
        }

        /// <summary>
        /// 驗證並創建 Encounter 資源
        /// </summary>
        public static Encounter CreateValidatedEncounter(string id, string status, CodeableConcept encounterClass, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            var encounter = CreateEncounter(id, status, encounterClass, subject);
            
            var validationResult = encounter.Validate();
            if (validationResult != System.ComponentModel.DataAnnotations.ValidationResult.Success)
            {
                throw new InvalidOperationException($"就診資源驗證失敗");
            }

            return encounter;
        }

        /// <summary>
        /// 驗證並創建 Condition 資源
        /// </summary>
        public static Condition CreateValidatedCondition(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            var condition = CreateCondition(id, code, subject);
            
            var validationResult = condition.Validate();
            if (validationResult != System.ComponentModel.DataAnnotations.ValidationResult.Success)
            {
                throw new InvalidOperationException($"條件資源驗證失敗");
            }

            return condition;
        }

        #endregion
    }
}