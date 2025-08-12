namespace FhirResourceGenerator.Configuration;

/// <summary>
/// R4 �M�g�t�m
/// </summary>
/// <remarks>
/// �]�t FHIR R4 �����S�w���M�g�M�]�w
/// </remarks>
public class R4MappingConfig
{
    /// <summary>
    /// R4 �S���������M�g
    /// </summary>
    public Dictionary<string, R4TypeMapping> R4TypeMappings { get; } = new()
    {
        // R4 �S��������
        ["canonical"] = new R4TypeMapping("FhirCanonical", "DataTypeServices.DataTypes.PrimitiveTypes", true),
        ["url"] = new R4TypeMapping("FhirUrl", "DataTypeServices.DataTypes.PrimitiveTypes", true),
        ["uuid"] = new R4TypeMapping("FhirUuid", "DataTypeServices.DataTypes.PrimitiveTypes", true),
        
        // R4 ������������
        ["CodeableReference"] = new R4TypeMapping("CodeableReference", "DataTypeServices.DataTypes.ComplexTypes", false),
        ["RatioRange"] = new R4TypeMapping("RatioRange", "DataTypeServices.DataTypes.ComplexTypes", false),
        
        // R4 �S�w���귽�ޥ�
        ["Reference(Patient)"] = new R4TypeMapping("ReferenceType", "DataTypeServices.DataTypes.SpecialTypes", true),
        ["Reference(Practitioner)"] = new R4TypeMapping("ReferenceType", "DataTypeServices.DataTypes.SpecialTypes", true),
        ["Reference(Organization)"] = new R4TypeMapping("ReferenceType", "DataTypeServices.DataTypes.SpecialTypes", true),
    };

    /// <summary>
    /// R4 �w���������� (�q R5 �������b R4 ���s�b)
    /// </summary>
    public HashSet<string> R4RemovedTypes { get; } = new()
    {
        // �b R5 �������� R4 ���s�b������
    };

    /// <summary>
    /// R4 �s�W������ (R4 ���s�W�� R5 �����s�b)
    /// </summary>
    public HashSet<string> R4AddedTypes { get; } = new()
    {
        // R4 ���s�W������
    };

    /// <summary>
    /// R4 �S������������
    /// </summary>
    public Dictionary<string, List<string>> R4Constraints { get; } = new()
    {
        ["Patient"] = new List<string>
        {
            "pat-1: SHALL have a contact's details or a reference to an organization",
            "pat-2: A patient SHALL have at least a family name or a given name or both"
        },
        ["Observation"] = new List<string>
        {
            "obs-1: Must have a code if you have a value",
            "obs-2: Must have either a value or data absent reason"
        }
    };

    /// <summary>
    /// R4 �S�����R�W�Ŷ�
    /// </summary>
    public Dictionary<string, string> R4Namespaces { get; } = new()
    {
        ["Resources"] = "FhirCore.R4.Resources",
        ["Factory"] = "FhirCore.R4.Factory",
        ["Extensions"] = "FhirCore.R4.Extensions",
        ["Validation"] = "FhirCore.R4.Validation"
    };

    /// <summary>
    /// R4 �����S�w�]�w
    /// </summary>
    public R4VersionSettings VersionSettings { get; } = new();
}

/// <summary>
/// R4 �����M�g
/// </summary>
public class R4TypeMapping
{
    /// <summary>
    /// C# �����W��
    /// </summary>
    public string CSharpType { get; }

    /// <summary>
    /// �R�W�Ŷ�
    /// </summary>
    public string Namespace { get; }

    /// <summary>
    /// �O�_����l����
    /// </summary>
    public bool IsPrimitive { get; }

    /// <summary>
    /// �O�_�i�� null
    /// </summary>
    public bool IsNullable { get; }

    /// <summary>
    /// R4 �S�w����
    /// </summary>
    public string? R4SpecificNote { get; set; }

    public R4TypeMapping(string csharpType, string @namespace, bool isPrimitive, bool isNullable = true)
    {
        CSharpType = csharpType;
        Namespace = @namespace;
        IsPrimitive = isPrimitive;
        IsNullable = isNullable;
    }
}

/// <summary>
/// R4 �����S�w�]�w
/// </summary>
public class R4VersionSettings
{
    /// <summary>
    /// FHIR �����r��
    /// </summary>
    public string FhirVersion { get; } = "4.0.1";

    /// <summary>
    /// �����o�����
    /// </summary>
    public DateTime ReleaseDate { get; } = new DateTime(2019, 10, 30);

    /// <summary>
    /// �䴩���귽�`��
    /// </summary>
    public int SupportedResourceCount { get; } = 130; // �j���ƶq

    /// <summary>
    /// R4 �S���\��
    /// </summary>
    public List<string> R4SpecificFeatures { get; } = new()
    {
        "CodeableReference �����䴩",
        "�W�j�� Reference ����",
        "��i�� Quantity ����",
        "�s�� url �M canonical ��l����"
    };

    /// <summary>
    /// �P R5 ���D�n�t��
    /// </summary>
    public List<string> DifferencesFromR5 { get; } = new()
    {
        "�Y�Ǹ귽���ݩʩR�W���P",
        "�������󪺪�F���y�k�t��",
        "�Y�ǿ���������ﶵ���P",
        "�X�i����t��"
    };

    /// <summary>
    /// R4 �S�w���w�]��
    /// </summary>
    public Dictionary<string, object> DefaultValues { get; } = new()
    {
        ["MaxStringLength"] = 1024 * 1024, // 1MB
        ["DefaultCurrency"] = "USD",
        ["DefaultLanguage"] = "en-US"
    };

    /// <summary>
    /// R4 �S�w�����ҳW�h
    /// </summary>
    public Dictionary<string, string> ValidationRules { get; } = new()
    {
        ["id"] = "^[A-Za-z0-9\\-\\.]{1,64}$",
        ["uri"] = "^\\S*$",
        ["code"] = "^[^\\s]+( [^\\s]+)*$"
    };
}

/// <summary>
/// R4 �u�t�]�w
/// </summary>
public class R4FactorySettings
{
    /// <summary>
    /// �w�] ID �e��
    /// </summary>
    public Dictionary<string, string> DefaultIdPrefixes { get; } = new()
    {
        ["Patient"] = "pat-",
        ["Practitioner"] = "prac-",
        ["Organization"] = "org-",
        ["Observation"] = "obs-",
        ["Condition"] = "cond-",
        ["Procedure"] = "proc-",
        ["Medication"] = "med-",
        ["MedicationRequest"] = "medreq-"
    };

    /// <summary>
    /// ���ո�ƼҪO
    /// </summary>
    public Dictionary<string, object> TestDataTemplates { get; } = new()
    {
        ["Patient"] = new
        {
            family = "Doe",
            given = new[] { "John" },
            gender = "male",
            birthDate = "1990-01-01"
        },
        ["Observation"] = new
        {
            status = "final",
            category = new[]
            {
                new
                {
                    coding = new[]
                    {
                        new
                        {
                            system = "http://terminology.hl7.org/CodeSystem/observation-category",
                            code = "vital-signs"
                        }
                    }
                }
            }
        }
    };
}

/// <summary>
/// R4 ���ɳ]�w
/// </summary>
public class R4DocumentationSettings
{
    /// <summary>
    /// �зǰѦ� URL
    /// </summary>
    public string StandardReferenceUrl { get; } = "http://hl7.org/fhir/R4/";

    /// <summary>
    /// �귽�Ѧ� URL �ҪO
    /// </summary>
    public string ResourceReferenceUrlTemplate { get; } = "http://hl7.org/fhir/R4/{resourceType}.html";

    /// <summary>
    /// ��������Ѧ� URL �ҪO
    /// </summary>
    public string DataTypeReferenceUrlTemplate { get; } = "http://hl7.org/fhir/R4/datatypes.html#{dataType}";

    /// <summary>
    /// R4 �S�w���ɽd��
    /// </summary>
    public Dictionary<string, string> DocumentationTemplates { get; } = new()
    {
        ["ResourceSummary"] = "FHIR R4 {ResourceName} �귽����@",
        ["PropertySummary"] = "{PropertyName} - {Description}",
        ["ConstraintNote"] = "R4 �����G{ConstraintDescription}",
        ["UsageExample"] = "// �إ� {ResourceName} �귽\nvar {variableName} = new {ResourceName}(\"{resourceId}\");"
    };
}