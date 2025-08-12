namespace FhirResourceGenerator.Configuration;

/// <summary>
/// �ͦ����t�m
/// </summary>
/// <remarks>
/// �]�t�ͦ���������t�m�ﶵ
/// </remarks>
public class GeneratorConfig
{
    /// <summary>
    /// �w�]��X�ؿ�
    /// </summary>
    public string DefaultOutputDirectory { get; set; } = "Generated";

    /// <summary>
    /// �w�]�w�q�ɥؿ�
    /// </summary>
    public string DefaultDefinitionsDirectory { get; set; } = "Definitions";

    /// <summary>
    /// �w�]�R�W�Ŷ��e��
    /// </summary>
    public string DefaultNamespacePrefix { get; set; } = "FhirCore";

    /// <summary>
    /// �O�_�ͦ����ɵ���
    /// </summary>
    public bool GenerateDocumentation { get; set; } = true;

    /// <summary>
    /// �O�_�ͦ������ݩ�
    /// </summary>
    public bool GenerateValidationAttributes { get; set; } = true;

    /// <summary>
    /// �O�_�ͦ��u�t��k
    /// </summary>
    public bool GenerateFactoryMethods { get; set; } = true;

    /// <summary>
    /// �O�_�ͦ������ɮ�
    /// </summary>
    public bool GenerateTests { get; set; } = false;

    /// <summary>
    /// �{���X�Y�Ʀr��
    /// </summary>
    public string IndentationCharacter { get; set; } = "    "; // 4 �ӪŮ�

    /// <summary>
    /// �浲���r��
    /// </summary>
    public string LineEnding { get; set; } = Environment.NewLine;

    /// <summary>
    /// �̤j�ɮפj�p (�줸��)
    /// </summary>
    public long MaxFileSize { get; set; } = 1024 * 1024; // 1MB

    /// <summary>
    /// �䴩�� FHIR ����
    /// </summary>
    public List<string> SupportedVersions { get; set; } = new() { "R4", "R5", "R6" };

    /// <summary>
    /// �ư����귽����
    /// </summary>
    public List<string> ExcludedResourceTypes { get; set; } = new();

    /// <summary>
    /// �ۭq�����M�g
    /// </summary>
    public Dictionary<string, string> CustomTypeMappings { get; set; } = new();

    /// <summary>
    /// �ҪO�]�w
    /// </summary>
    public TemplateSettings Templates { get; set; } = new();

    /// <summary>
    /// ���ҳ]�w
    /// </summary>
    public ValidationSettings Validation { get; set; } = new();

    /// <summary>
    /// �O���]�w
    /// </summary>
    public LoggingSettings Logging { get; set; } = new();
}

/// <summary>
/// �ҪO�]�w
/// </summary>
public class TemplateSettings
{
    /// <summary>
    /// �ϥΦۭq�ҪO
    /// </summary>
    public bool UseCustomTemplates { get; set; } = false;

    /// <summary>
    /// �ۭq�ҪO�ؿ�
    /// </summary>
    public string? CustomTemplateDirectory { get; set; }

    /// <summary>
    /// �ҪO�֨��ҥ�
    /// </summary>
    public bool EnableTemplateCache { get; set; } = true;

    /// <summary>
    /// �ҪO�ܼ�
    /// </summary>
    public Dictionary<string, object> Variables { get; set; } = new();
}

/// <summary>
/// ���ҳ]�w
/// </summary>
public class ValidationSettings
{
    /// <summary>
    /// �ҥθ귽����
    /// </summary>
    public bool EnableResourceValidation { get; set; } = true;

    /// <summary>
    /// �ҥε{���X����
    /// </summary>
    public bool EnableCodeValidation { get; set; } = true;

    /// <summary>
    /// ���ҳW�h�ɮ�
    /// </summary>
    public string? ValidationRulesFile { get; set; }

    /// <summary>
    /// ���������ҿ��~
    /// </summary>
    public List<string> IgnoredValidationErrors { get; set; } = new();
}

/// <summary>
/// �O���]�w
/// </summary>
public class LoggingSettings
{
    /// <summary>
    /// �O���h��
    /// </summary>
    public string LogLevel { get; set; } = "Information";

    /// <summary>
    /// �O���ɸ��|
    /// </summary>
    public string? LogFilePath { get; set; }

    /// <summary>
    /// �ҥα���x�O��
    /// </summary>
    public bool EnableConsoleLogging { get; set; } = true;

    /// <summary>
    /// �ҥθԲӰO��
    /// </summary>
    public bool EnableVerboseLogging { get; set; } = false;
}