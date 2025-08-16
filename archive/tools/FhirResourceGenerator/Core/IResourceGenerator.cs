namespace FhirResourceGenerator.Core;

/// <summary>
/// �귽�ͦ�������
/// 
/// <para>
/// �t�d�ھڸ귽�w�q�ͦ� C# �귽���O�{���X�C
/// </para>
/// </summary>
public interface IResourceGenerator
{
    /// <summary>
    /// �ͦ���@�귽
    /// </summary>
    /// <param name="definition">�귽�w�q</param>
    /// <param name="context">�ͦ��W�U��</param>
    /// <returns>�ͦ����G</returns>
    Task<GenerationResult> GenerateResourceAsync(ResourceDefinition definition, GeneratorContext context);

    /// <summary>
    /// �ͦ��h�Ӹ귽
    /// </summary>
    /// <param name="definitions">�귽�w�q���X</param>
    /// <param name="context">�ͦ��W�U��</param>
    /// <returns>�ͦ����G</returns>
    Task<GenerationResult> GenerateResourcesAsync(IEnumerable<ResourceDefinition> definitions, GeneratorContext context);
}

/// <summary>
/// �M�ץͦ�������
/// 
/// <para>
/// �t�d�ͦ����㪺 FHIR �귽�M�סA�]�A�M���ɡB�u�t���O�M���աC
/// </para>
/// </summary>
public interface IProjectGenerator
{
    /// <summary>
    /// �ͦ�����M��
    /// </summary>
    /// <param name="context">�ͦ��W�U��</param>
    /// <returns>�ͦ����G</returns>
    Task<GenerationResult> GenerateProjectAsync(GeneratorContext context);
}