namespace FhirResourceGenerator.Core;

/// <summary>
/// �ͦ����G
/// 
/// <para>
/// �]�t�귽�ͦ��L�{�����G�M�έp��T�C
/// </para>
/// </summary>
public class GenerationResult
{
    /// <summary>
    /// �O�_���\
    /// </summary>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// ���~�T��
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// �ͦ����ɮצC��
    /// </summary>
    public List<GeneratedFile> GeneratedFiles { get; set; } = new();

    /// <summary>
    /// �ͦ����귽�ƶq
    /// </summary>
    public int GeneratedResourceCount { get; set; }

    /// <summary>
    /// �ͦ����u�t��k�ƶq
    /// </summary>
    public int GeneratedFactoryCount { get; set; }

    /// <summary>
    /// �ͦ��������ɮ׼ƶq
    /// </summary>
    public int GeneratedTestCount { get; set; }

    /// <summary>
    /// �}�l�ɶ�
    /// </summary>
    public DateTime StartTime { get; set; }

    /// <summary>
    /// �����ɶ�
    /// </summary>
    public DateTime EndTime { get; set; }

    /// <summary>
    /// �`�Ӯ�
    /// </summary>
    public TimeSpan Duration => EndTime - StartTime;

    /// <summary>
    /// ĵ�i�T��
    /// </summary>
    public List<string> Warnings { get; set; } = new();

    /// <summary>
    /// �إߦ��\���G
    /// </summary>
    public static GenerationResult Success()
    {
        return new GenerationResult { IsSuccess = true };
    }

    /// <summary>
    /// �إߥ��ѵ��G
    /// </summary>
    public static GenerationResult Failure(string errorMessage)
    {
        return new GenerationResult 
        { 
            IsSuccess = false, 
            ErrorMessage = errorMessage 
        };
    }

    /// <summary>
    /// �s�W�ͦ����ɮ�
    /// </summary>
    public void AddGeneratedFile(string filePath, string content, GeneratedFileType type)
    {
        GeneratedFiles.Add(new GeneratedFile
        {
            FilePath = filePath,
            Content = content,
            Type = type,
            GeneratedAt = DateTime.UtcNow
        });

        // ��s�έp
        switch (type)
        {
            case GeneratedFileType.Resource:
                GeneratedResourceCount++;
                break;
            case GeneratedFileType.Factory:
                GeneratedFactoryCount++;
                break;
            case GeneratedFileType.Test:
                GeneratedTestCount++;
                break;
        }
    }
}

/// <summary>
/// �ͦ����ɮ�
/// </summary>
public class GeneratedFile
{
    /// <summary>
    /// �ɮ׸��|
    /// </summary>
    public string FilePath { get; set; } = string.Empty;

    /// <summary>
    /// �ɮפ��e
    /// </summary>
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// �ɮ�����
    /// </summary>
    public GeneratedFileType Type { get; set; }

    /// <summary>
    /// �ͦ��ɶ�
    /// </summary>
    public DateTime GeneratedAt { get; set; }

    /// <summary>
    /// �ɮפj�p�]�줸�ա^
    /// </summary>
    public int Size => System.Text.Encoding.UTF8.GetByteCount(Content);
}

/// <summary>
/// �ͦ��ɮ�����
/// </summary>
public enum GeneratedFileType
{
    /// <summary>
    /// �귽���O
    /// </summary>
    Resource,

    /// <summary>
    /// �u�t���O
    /// </summary>
    Factory,

    /// <summary>
    /// �������O
    /// </summary>
    Test,

    /// <summary>
    /// �M����
    /// </summary>
    Project,

    /// <summary>
    /// �t�m��
    /// </summary>
    Configuration,

    /// <summary>
    /// �����ɮ�
    /// </summary>
    Documentation
}