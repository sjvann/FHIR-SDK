namespace FhirResourceGenerator.Core;

/// <summary>
/// �ͦ��W�U��
/// </summary>
/// <remarks>
/// �]�t�ͦ��L�{���ݭn���Ҧ��t�m�M���A��T
/// </remarks>
public class GeneratorContext
{
    /// <summary>
    /// FHIR ���� (R4, R5, R6)
    /// </summary>
    public string Version { get; set; } = string.Empty;

    /// <summary>
    /// �w�q�ɸ��|
    /// </summary>
    public string DefinitionsPath { get; set; } = string.Empty;

    /// <summary>
    /// ��X���|
    /// </summary>
    public string OutputPath { get; set; } = string.Empty;

    /// <summary>
    /// �ؼи귽 (null ��ܥ���)
    /// </summary>
    public List<string>? TargetResources { get; set; }

    /// <summary>
    /// �O�_�j���л\
    /// </summary>
    public bool ForceOverwrite { get; set; }

    /// <summary>
    /// �O�_�]�t����
    /// </summary>
    public bool IncludeTests { get; set; }

    /// <summary>
    /// �B�~�]�w
    /// </summary>
    public Dictionary<string, object> AdditionalSettings { get; set; } = new();

    /// <summary>
    /// ���ҤW�U��
    /// </summary>
    public bool IsValid()
    {
        return !string.IsNullOrEmpty(Version) &&
               !string.IsNullOrEmpty(DefinitionsPath) &&
               !string.IsNullOrEmpty(OutputPath);
    }
}

/// <summary>
/// �ͦ����G
/// </summary>
/// <remarks>
/// �]�t�ͦ��L�{�����G�M�έp��T
/// </remarks>
public class GenerationResult
{
    /// <summary>
    /// �O�_���\
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// ���~�T��
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// �ͦ����귽�ƶq
    /// </summary>
    public int ResourcesGenerated { get; set; }

    /// <summary>
    /// �ͦ����ɮ׼ƶq
    /// </summary>
    public int FilesGenerated { get; set; }

    /// <summary>
    /// �ͦ����ɮצC��
    /// </summary>
    public List<string> GeneratedFiles { get; set; } = new();

    /// <summary>
    /// ĵ�i�T��
    /// </summary>
    public List<string> Warnings { get; set; } = new();

    /// <summary>
    /// �ԲӸ�T
    /// </summary>
    public Dictionary<string, object> Details { get; set; } = new();

    /// <summary>
    /// �ͦ��}�l�ɶ�
    /// </summary>
    public DateTime StartTime { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// �ͦ������ɶ�
    /// </summary>
    public DateTime EndTime { get; set; }

    /// <summary>
    /// �ͦ��Ӯ�
    /// </summary>
    public TimeSpan Duration => EndTime - StartTime;

    /// <summary>
    /// �Ыئ��\���G
    /// </summary>
    public static GenerationResult CreateSuccess(int resourcesGenerated, int filesGenerated)
    {
        return new GenerationResult
        {
            Success = true,
            ResourcesGenerated = resourcesGenerated,
            FilesGenerated = filesGenerated,
            EndTime = DateTime.UtcNow
        };
    }

    /// <summary>
    /// �Ыإ��ѵ��G
    /// </summary>
    public static GenerationResult CreateFailure(string errorMessage)
    {
        return new GenerationResult
        {
            Success = false,
            ErrorMessage = errorMessage,
            EndTime = DateTime.UtcNow
        };
    }
}

/// <summary>
/// �ҪO�W�U��
/// </summary>
/// <remarks>
/// �ҪO�����ϥΪ��W�U���T
/// </remarks>
public class TemplateContext
{
    /// <summary>
    /// FHIR ����
    /// </summary>
    public string FhirVersion { get; set; } = string.Empty;

    /// <summary>
    /// �R�W�Ŷ�
    /// </summary>
    public string Namespace { get; set; } = string.Empty;

    /// <summary>
    /// �ϥΪ��ޥ�
    /// </summary>
    public List<string> Usings { get; set; } = new();

    /// <summary>
    /// �����M�g
    /// </summary>
    public Dictionary<string, string> TypeMappings { get; set; } = new();

    /// <summary>
    /// �����S�w�]�w
    /// </summary>
    public Dictionary<string, object> VersionSettings { get; set; } = new();

    /// <summary>
    /// �ҪO�ܼ�
    /// </summary>
    public Dictionary<string, object> Variables { get; set; } = new();
}