using FhirCore.R5.Resources;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;

namespace FhirCore.R5.Factory
{
    /// <summary>
    /// FHIR R5 �귽�u�t
    /// ���ѫK�Q���귽�Ыؤ�k
    /// </summary>
    public static class R5Factory
    {
        #region Patient Factory Methods

        /// <summary>
        /// �Ыطs�� Patient �귽
        /// </summary>
        /// <returns>�s�� Patient ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӪŪ� Patient �귽�A�Ҧ��ݩʳ���l�Ƭ� null�C
        /// ��ĳ�b�Ыث�ߧY�]�w���n���ݩʡC
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
        /// �Ыب㦳���w ID �� Patient �귽
        /// </summary>
        /// <param name="id">�w�̪��ߤ@�ѧO�X</param>
        /// <returns>�s�� Patient ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�Ө㦳���w ID �� Patient �귽�A�ñN Active �]�� true�C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var patient = R5Factory.CreatePatient("patient-001");
        /// // patient.Id �w�]�� "patient-001"
        /// // patient.Active �w�]�� true
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
        /// �Ыب㦳�򥻸�T�� Patient �귽
        /// </summary>
        /// <param name="id">�w�̪��ߤ@�ѧO�X</param>
        /// <param name="familyName">�m��</param>
        /// <param name="givenName">�W�r</param>
        /// <param name="gender">�ʧO�N�X (male, female, other, unknown)</param>
        /// <param name="birthDate">�X�ͤ�� (YYYY-MM-DD �榡)</param>
        /// <returns>�s�� Patient ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӥ]�t�򥻸�T�� Patient �귽�A�A�Ω�ֳt�Ыب㦳���n��T���w�̰O���C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var patient = R5Factory.CreatePatient(
        ///     "patient-001", 
        ///     "��", 
        ///     "�p��", 
        ///     "male", 
        ///     "1990-05-15"
        /// );
        /// </code>
        /// </example>
        /// <exception cref="ArgumentException">��ʧO�N�X�L�Į��Y�^</exception>
        /// <exception cref="ArgumentException">��X�ͤ���榡�L�Į��Y�^</exception>
        public static Patient CreatePatient(string id, string familyName, string givenName, string gender, string birthDate)
        {
            // ���ҩʧO�N�X
            var validGenders = new[] { "male", "female", "other", "unknown" };
            if (!validGenders.Contains(gender))
            {
                throw new ArgumentException($"�ʧO�N�X '{gender}' �L�ġC���ĭȬ�: {string.Join(", ", validGenders)}", nameof(gender));
            }

            // ���ҥX�ͤ���榡
            if (!DateTime.TryParse(birthDate, out var parsedDate))
            {
                throw new ArgumentException($"�X�ͤ�� '{birthDate}' �榡�L�ġC�Шϥ� YYYY-MM-DD �榡", nameof(birthDate));
            }

            // ���ҥX�ͤ������O���Ӥ��
            if (parsedDate > DateTime.Now.Date)
            {
                throw new ArgumentException("�X�ͤ������O���Ӥ��", nameof(birthDate));
            }

            var humanName = new HumanName
            {
                Family = new FhirString(familyName),
                Given = new List<FhirString> { new FhirString(givenName) }
            };

            return new Patient(id, humanName, gender, birthDate);
        }

        /// <summary>
        /// �Ыش��եΪ� Patient �귽
        /// </summary>
        /// <param name="suffix">ID ���A�Ω�Ϥ����P�����ձw��</param>
        /// <returns>�s�� Patient ���</returns>
        /// <remarks>
        /// <para>
        /// ����k�M���Ω���թM�}�o���ҡA�Ыب㦳�w�]���ո�ƪ��w�̰O���C
        /// ����ĳ�b�Ͳ����Ҥ��ϥΡC
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
                Family = new FhirString("����"),
                Given = new List<FhirString> { new FhirString($"�w��{suffix}") }
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
        /// �Ыطs�� Basic �귽
        /// </summary>
        /// <returns>�s�� Basic ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӪŪ� Basic �귽�A�Ҧ��ݩʳ���l�Ƭ� null�C
        /// �����b�Ыث�]�w Code �ݩʡC
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
        /// �Ыب㦳���w ID �� Basic �귽
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <returns>�s�� Basic ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�Ө㦳���w ID �� Basic �귽�C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var basic = R5Factory.CreateBasic("basic-001");
        /// // basic.Id �w�]�� "basic-001"
        /// </code>
        /// </example>
        public static Basic CreateBasic(string id) => new(id);

        /// <summary>
        /// �Ыب㦳�򥻸�T�� Basic �귽
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <param name="code">�귽�N�X</param>
        /// <param name="subject">�D��ޥ�</param>
        /// <returns>�s�� Basic ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӥ]�t�򥻸�T�� Basic �귽�A�æ۰ʳ]�w�إ߮ɶ��C
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
        ///     Display = new FhirString("�i�T")
        /// };
        /// var basic = R5Factory.CreateBasic("basic-001", code, subject);
        /// </code>
        /// </example>
        public static Basic CreateBasic(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            return new Basic(id, code, subject);
        }

        /// <summary>
        /// �Ы�²�檺 Basic �귽�]�ϥΤ�r�N�X�^
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <param name="codeText">�N�X��r�y�z</param>
        /// <param name="subjectReference">�D��ޥΦr��</param>
        /// <returns>�s�� Basic ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@��²�檺 Basic �귽�A�A�Ω�ֳt�쫬�}�o�δ��աC
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var basic = R5Factory.CreateSimpleBasic(
        ///     "basic-001", 
        ///     "�w�̦P�N��", 
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
        /// �Ыطs�� Organization �귽
        /// </summary>
        /// <returns>�s�� Organization ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӪŪ� Organization �귽�A�Ҧ��ݩʳ���l�Ƭ� null�C
        /// ��ĳ�b�Ыث�ߧY�]�w���n���ݩʡC
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
        /// �Ыب㦳���w ID �� Organization �귽
        /// </summary>
        /// <param name="id">��´���ߤ@�ѧO�X</param>
        /// <returns>�s�� Organization ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�Ө㦳���w ID �� Organization �귽�A�ñN Active �]�� true�C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var organization = R5Factory.CreateOrganization("org-001");
        /// // organization.Id �w�]�� "org-001"
        /// // organization.Active �w�]�� true
        /// </code>
        /// </example>
        public static Organization CreateOrganization(string id) => new(id);

        /// <summary>
        /// �Ыب㦳�򥻸�T�� Organization �귽
        /// </summary>
        /// <param name="id">��´���ߤ@�ѧO�X</param>
        /// <param name="name">��´�W��</param>
        /// <returns>�s�� Organization ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӥ]�t�򥻸�T�� Organization �귽�A�A�Ω�ֳt�Ыب㦳���n��T����´�O���C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var organization = R5Factory.CreateOrganization("org-001", "�x�_��|");
        /// </code>
        /// </example>
        public static Organization CreateOrganization(string id, string name)
        {
            return new Organization(id, name);
        }

        /// <summary>
        /// �Ыب㦳������ Organization �귽
        /// </summary>
        /// <param name="id">��´���ߤ@�ѧO�X</param>
        /// <param name="name">��´�W��</param>
        /// <param name="organizationType">��´�����N�X</param>
        /// <returns>�s�� Organization ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӥ]�t�W�٩M������ Organization �귽�A
        /// �����N�۰��ഫ���iŪ����ܦW�١C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var organization = R5Factory.CreateOrganization("org-001", "�x�_��|", "prov");
        /// // organization.Id �w�]�� "org-001"
        /// // organization.Name �w�]�� "�x�_��|"
        /// // organization.Type �w�]���]�t "Healthcare Provider" �� Coding �C��
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
        /// �Ыطs�� Practitioner �귽
        /// </summary>
        /// <returns>�s�� Practitioner ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӪŪ� Practitioner �귽�A�Ҧ��ݩʳ���l�Ƭ� null�C
        /// ��ĳ�b�Ыث�ߧY�]�w���n���ݩʡC
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
        /// �Ыب㦳���w ID �� Practitioner �귽
        /// </summary>
        /// <param name="id">�q�~�H�����ߤ@�ѧO�X</param>
        /// <returns>�s�� Practitioner ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�Ө㦳���w ID �� Practitioner �귽�A�ñN Active �]�� true�C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var practitioner = R5Factory.CreatePractitioner("practitioner-001");
        /// // practitioner.Id �w�]�� "practitioner-001"
        /// // practitioner.Active �w�]�� true
        /// </code>
        /// </example>
        public static Practitioner CreatePractitioner(string id) => new(id);

        /// <summary>
        /// �Ыب㦳�򥻸�T�� Practitioner �귽
        /// </summary>
        /// <param name="id">�q�~�H�����ߤ@�ѧO�X</param>
        /// <param name="familyName">�m��</param>
        /// <param name="givenName">�W�r</param>
        /// <returns>�s�� Practitioner ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӥ]�t�򥻸�T�� Practitioner �귽�A�A�Ω�ֳt�Ыب㦳���n��T���q�~�H���O���C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var practitioner = R5Factory.CreatePractitioner("practitioner-001", "��", "�p��");
        /// </code>
        /// </example>
        public static Practitioner CreatePractitioner(string id, string familyName, string givenName)
        {
            return new Practitioner(id, familyName, givenName);
        }

        /// <summary>
        /// �Ыب㦳�����T�� Practitioner �귽
        /// </summary>
        /// <param name="id">�q�~�H�����ߤ@�ѧO�X</param>
        /// <param name="familyName">�m��</param>
        /// <param name="givenName">�W�r</param>
        /// <param name="gender">�ʧO�N�X</param>
        /// <returns>�s�� Practitioner ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӥ]�t�����T�� Practitioner �귽�C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var practitioner = R5Factory.CreatePractitioner("practitioner-001", "��", "�p��", "male");
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
        /// �Ы���v Practitioner �귽
        /// </summary>
        /// <param name="id">�q�~�H�����ߤ@�ѧO�X</param>
        /// <param name="familyName">�m��</param>
        /// <param name="givenName">�W�r</param>
        /// <param name="licenseNumber">��v�����ѧO�X</param>
        /// <returns>�s�� Practitioner ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӥ]�t��v�M�ݸ�T�� Practitioner �귽�C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var doctor = R5Factory.CreateDoctor("practitioner-001", "��", "�p��", "A123456789");
        /// </code>
        /// </example>
        public static Practitioner CreateDoctor(string id, string familyName, string givenName, string licenseNumber)
        {
            var practitioner = new Practitioner(id, familyName, givenName);

            // �K�[��v�����ѧO�X
            practitioner.Identifier = new List<Identifier>
            {
                new Identifier
                {
                    System = new FhirUri("http://www.mohw.gov.tw/doctor-license"),
                    Value = new FhirString(licenseNumber),
                    Type = new CodeableConcept
                    {
                        Text = new FhirString("��v���Ӹ��X")
                    }
                }
            };

            // �K�[��v���
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
                    Text = new FhirString("��v")
                })
            };

            return practitioner;
        }

        #endregion

        #region Medication Factory Methods

        /// <summary>
        /// �Ыطs�� Medication �귽
        /// </summary>
        /// <returns>�s�� Medication ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӪŪ� Medication �귽�A�Ҧ��ݩʳ���l�Ƭ� null�C
        /// ��ĳ�b�Ыث�ߧY�]�w���n���ݩʡC
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
        /// �Ыب㦳���w ID �� Medication �귽
        /// </summary>
        /// <param name="id">�Ī����ߤ@�ѧO�X</param>
        /// <returns>�s�� Medication ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�Ө㦳���w ID �� Medication �귽�C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var medication = R5Factory.CreateMedication("medication-001");
        /// // medication.Id �w�]�� "medication-001"
        /// </code>
        /// </example>
        public static Medication CreateMedication(string id) => new(id);

        /// <summary>
        /// �Ыب㦳�N�X�� Medication �귽
        /// </summary>
        /// <param name="id">�Ī����ߤ@�ѧO�X</param>
        /// <param name="code">�Ī��N�X</param>
        /// <returns>�s�� Medication ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�Ө㦳���w ID �M�N�X�� Medication �귽�C
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
        /// // medication.Id �w�]�� "medication-001"
        /// // medication.Code �w�]�����w�� CodeableConcept
        /// </code>
        /// </example>
        public static Medication CreateMedication(string id, CodeableConcept code)
        {
            return new Medication(id, code);
        }

        /// <summary>
        /// �Ы�²�檺 Medication �귽
        /// </summary>
        /// <param name="id">�Ī����ߤ@�ѧO�X</param>
        /// <param name="medicationName">�Ī��W��</param>
        /// <param name="rxNormCode">RxNorm �N�X�]���^</param>
        /// <returns>�s�� Medication ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@��²�檺 Medication �귽�A�ȥ]�t�W�١C
        /// �i��ܩʦa�K�[ RxNorm �N�X�A�H�K�P�~���t�ξ�X�C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var medication = R5Factory.CreateSimpleMedication("medication-001", "��A�Q�����", "24620");
        /// // medication.Id �w�]�� "medication-001"
        /// // medication.Code.Text �w�]�� "��A�Q�����"
        /// // medication.Code.Coding �w�]�t���w�� RxNorm �N�X
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
        /// �Ыب㦳������ Medication �귽
        /// </summary>
        /// <param name="id">�Ī����ߤ@�ѧO�X</param>
        /// <param name="medicationName">�Ī��W��</param>
        /// <param name="doseForm">�����y�z</param>
        /// <returns>�s�� Medication ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӥ]�t�Ī��W�٩M������ Medication �귽�C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var medication = R5Factory.CreateMedicationWithDoseForm("medication-001", "��A�Q�����", "Tablet");
        /// // medication.Id �w�]�� "medication-001"
        /// // medication.Code.Text �w�]�� "��A�Q�����"
        /// // medication.DoseForm.Text �w�]�� "Tablet"
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
        /// �Ыب㦳�妸��T�� Medication �귽
        /// </summary>
        /// <param name="id">�Ī����ߤ@�ѧO�X</param>
        /// <param name="medicationName">�Ī��W��</param>
        /// <param name="lotNumber">�帹</param>
        /// <param name="expirationDate">���Ĥ���]���^</param>
        /// <returns>�s�� Medication ���</returns>
        /// <remarks>
        /// <para>
        /// �Ыؤ@�ӥ]�t�Ī��W�٩M�妸��T�� Medication �귽�C
        /// �i��ܩʦa�K�[���Ĥ���C
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var medication = R5Factory.CreateMedicationWithBatch("medication-001", "��A�Q�����", "BATCH123", new DateTime(2023, 12, 31));
        /// // medication.Id �w�]�� "medication-001"
        /// // medication.Code.Text �w�]�� "��A�Q�����"
        /// // medication.Batch.LotNumber �w�]�� "BATCH123"
        /// // medication.Batch.ExpirationDate �w�]�� 2023-12-31
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
        /// �Ыطs�� Observation �귽
        /// </summary>
        public static Observation CreateObservation() => new();

        /// <summary>
        /// �Ыب㦳���w ID �� Observation �귽
        /// </summary>
        public static Observation CreateObservation(string id) => new(id);

        /// <summary>
        /// �Ыب㦳�򥻸�T�� Observation �귽
        /// </summary>
        public static Observation CreateObservation(string id, string status, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            return new Observation(id, status, code, subject);
        }

        /// <summary>
        /// �Ы�²�檺�ƭȫ� Observation �귽
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
        /// �ЫإͩR��x Observation �귽
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
                throw new ArgumentException($"���䴩���ͩR��x����: {vitalSignType}", nameof(vitalSignType));
            }

            var (loincCode, display) = vitalSignCodes[vitalSignType];
            var observation = CreateQuantityObservation(id, loincCode, display, value, unit, subjectReference);

            // �K�[�ͩR��x����
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
        /// �Ыع�������� Observation �귽
        /// </summary>
        public static Observation CreateLabObservation(string id, string loincCode, string display, 
            decimal value, string unit, string subjectReference)
        {
            var observation = CreateQuantityObservation(id, loincCode, display, value, unit, subjectReference);

            // �K�[����Ǥ���
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
        /// �ЫإN�X�� Observation �귽
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
        /// �Ыرa�Ѧҽd�� Observation �귽
        /// </summary>
        public static Observation CreateObservationWithReferenceRange(string id, string loincCode, string display,
            decimal value, string unit, string subjectReference, decimal lowLimit, decimal highLimit)
        {
            var observation = CreateQuantityObservation(id, loincCode, display, value, unit, subjectReference);

            // �K�[�Ѧҽd��
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
        /// �Ыطs�� Encounter �귽
        /// </summary>
        public static Encounter CreateEncounter() => new();

        /// <summary>
        /// �Ыب㦳���w ID �� Encounter �귽
        /// </summary>
        public static Encounter CreateEncounter(string id) => new(id);

        /// <summary>
        /// �Ыب㦳�򥻸�T�� Encounter �귽
        /// </summary>
        public static Encounter CreateEncounter(string id, string status, CodeableConcept encounterClass, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            return new Encounter(id, status, encounterClass, subject);
        }

        /// <summary>
        /// �Ыت��E Encounter �귽
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

            // �K�[�D�v��v
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

            // �]�w�N�E�ɶ�
            encounter.ActualPeriod = new Period
            {
                Start = new FhirDateTime(DateTime.Now)
            };

            return encounter;
        }

        /// <summary>
        /// �Ыئ�| Encounter �귽
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

            // �]�w�A�ȴ��Ѫ�
            encounter.ServiceProvider = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(organizationReference)
            };

            // �K�[�D�v��v
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

            // �]�w�J�|��T
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
        /// �Ыث�E Encounter �귽
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

            // �]�w�u����
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

            // �]�w�N�E�ɶ�
            encounter.ActualPeriod = new Period
            {
                Start = new FhirDateTime(DateTime.Now)
            };

            return encounter;
        }

        /// <summary>
        /// �Ыص����N�E Encounter �귽
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

            // �K�[��v�ѻP��
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
        /// �Ыرa�E?�� Encounter �귽
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
        /// �Ыطs�� Condition �귽
        /// </summary>
        public static Condition CreateCondition() => new();

        /// <summary>
        /// �Ыب㦳���w ID �� Condition �귽
        /// </summary>
        public static Condition CreateCondition(string id) => new(id);

        /// <summary>
        /// �Ыب㦳�򥻸�T�� Condition �귽
        /// </summary>
        public static Condition CreateCondition(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            return new Condition(id, code, subject);
        }

        /// <summary>
        /// �ЫؽT�E�� Condition �귽
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
        /// �ЫإD�n�E�_ Condition �귽
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

            // �]�w���D�n�E�_
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

            // �]�w���p�N�E
            condition.Encounter = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
            {
                Reference = new FhirString(encounterReference)
            };

            return condition;
        }

        /// <summary>
        /// �Ыذ��D�C�� Condition �귽
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

            // �]�w�����D�C��
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

            // �]�w�Y���{��
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
        /// �ЫغC�ʯf Condition �귽
        /// </summary>
        public static Condition CreateChronicCondition(string id, string snomedCode, string displayName, string subjectReference, DateTime onsetDate)
        {
            var condition = CreateConfirmedCondition(id, snomedCode, displayName, subjectReference);

            // �]�w�o�f�ɶ�
            condition.Onset = new ConditionOnsetChoice(new FhirDateTime(onsetDate));

            // �]�w���C�ʯf
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
        /// �Ыؤw�ѨM�� Condition �귽
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

            // �]�w�w�Ѯɶ�
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
                _ => "6736007" // �w�]������
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
        /// �Ыش��եΪ� Organization �귽
        /// </summary>
        /// <param name="suffix">ID ���A�Ω�Ϥ����P�����ղ�´</param>
        /// <returns>�s�� Organization ���</returns>
        /// <remarks>
        /// <para>
        /// ����k�M���Ω���թM�}�o���ҡA�Ыب㦳�w�]���ո�ƪ���´�O���C
        /// ����ĳ�b�Ͳ����Ҥ��ϥΡC
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
            return CreateOrganization(id, $"������|{suffix}", "prov");
        }

        /// <summary>
        /// �Ыش��եΪ� Practitioner �귽
        /// </summary>
        /// <param name="suffix">ID ���A�Ω�Ϥ����P�����ձq�~�H��</param>
        /// <returns>�s�� Practitioner ���</returns>
        /// <remarks>
        /// <para>
        /// ����k�M���Ω���թM�}�o���ҡA�Ыب㦳�w�]���ո�ƪ��q�~�H���O���C
        /// ����ĳ�b�Ͳ����Ҥ��ϥΡC
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
            return CreatePractitioner(id, "����", $"��v{suffix}", "unknown");
        }

        /// <summary>
        /// �Ыش��եΪ� Medication �귽
        /// </summary>
        /// <param name="suffix">ID ���A�Ω�Ϥ����P�������Ī�</param>
        /// <returns>�s�� Medication ���</returns>
        /// <remarks>
        /// <para>
        /// ����k�M���Ω���թM�}�o���ҡA�Ыب㦳�w�]���ո�ƪ��Ī��O���C
        /// ����ĳ�b�Ͳ����Ҥ��ϥΡC
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
            return CreateSimpleMedication(id, $"�����Ī�{suffix}");
        }

        /// <summary>
        /// �Ыش��եΪ� Observation �귽
        /// </summary>
        public static Observation CreateTestObservation(string suffix = "001")
        {
            var id = $"test-observation-{suffix}";
            return CreateVitalSignsObservation(id, "body-height", 175, "cm", $"Patient/test-patient-{suffix}");
        }

        /// <summary>
        /// �Ыش��եΪ� Encounter �귽
        /// </summary>
        public static Encounter CreateTestEncounter(string suffix = "001")
        {
            var id = $"test-encounter-{suffix}";
            return CreateOutpatientEncounter(id, $"Patient/test-patient-{suffix}", $"Practitioner/test-practitioner-{suffix}");
        }

        /// <summary>
        /// �Ыش��եΪ� Condition �귽
        /// </summary>
        public static Condition CreateTestCondition(string suffix = "001")
        {
            var id = $"test-condition-{suffix}";
            return CreateConfirmedCondition(id, "73211009", $"���նE�_{suffix}", $"Patient/test-patient-{suffix}");
        }

        #endregion

        #region Validation Helper Methods

        /// <summary>
        /// ���ҨóЫ� Patient �귽
        /// </summary>
        public static Patient CreateValidatedPatient(string id, string familyName, string givenName, string gender, string birthDate)
        {
            var patient = CreatePatient(id, familyName, givenName, gender, birthDate);
            
            var validationResult = patient.Validate();
            if (validationResult != System.ComponentModel.DataAnnotations.ValidationResult.Success)
            {
                throw new InvalidOperationException($"�w�̸귽���ҥ���");
            }

            return patient;
        }

        /// <summary>
        /// ���ҨóЫ� Organization �귽
        /// </summary>
        public static Organization CreateValidatedOrganization(string id, string name)
        {
            var organization = CreateOrganization(id, name);
            
            var validationResult = organization.Validate();
            if (validationResult != System.ComponentModel.DataAnnotations.ValidationResult.Success)
            {
                throw new InvalidOperationException($"��´�귽���ҥ���");
            }

            return organization;
        }

        /// <summary>
        /// ���ҨóЫ� Observation �귽
        /// </summary>
        public static Observation CreateValidatedObservation(string id, string status, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            var observation = CreateObservation(id, status, code, subject);
            
            var validationResult = observation.Validate();
            if (validationResult != System.ComponentModel.DataAnnotations.ValidationResult.Success)
            {
                throw new InvalidOperationException($"�[��ȸ귽���ҥ���");
            }

            return observation;
        }

        /// <summary>
        /// ���ҨóЫ� Encounter �귽
        /// </summary>
        public static Encounter CreateValidatedEncounter(string id, string status, CodeableConcept encounterClass, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            var encounter = CreateEncounter(id, status, encounterClass, subject);
            
            var validationResult = encounter.Validate();
            if (validationResult != System.ComponentModel.DataAnnotations.ValidationResult.Success)
            {
                throw new InvalidOperationException($"�N�E�귽���ҥ���");
            }

            return encounter;
        }

        /// <summary>
        /// ���ҨóЫ� Condition �귽
        /// </summary>
        public static Condition CreateValidatedCondition(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            var condition = CreateCondition(id, code, subject);
            
            var validationResult = condition.Validate();
            if (validationResult != System.ComponentModel.DataAnnotations.ValidationResult.Success)
            {
                throw new InvalidOperationException($"����귽���ҥ���");
            }

            return condition;
        }

        #endregion
    }
}