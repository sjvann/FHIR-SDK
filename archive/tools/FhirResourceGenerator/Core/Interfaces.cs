namespace FhirResourceGenerator.Core;

/// <summary>
/// �w�q�ɸѪR������
/// </summary>
/// <remarks>
/// �t�d�ѪR FHIR StructureDefinition JSON �ɮסA�����귽�w�q��T
/// </remarks>
public interface IDefinitionParser
{
    /// <summary>
    /// �ѪR�귽�w�q��
    /// </summary>
    /// <param name="definitionPath">�w�q�ɸ��|</param>
    /// <returns>�귽�w�q���X</returns>
    Task<IEnumerable<ResourceDefinition>> ParseResourceDefinitionsAsync(string definitionPath);

    /// <summary>
    /// �ѪR��������w�q��
    /// </summary>
    /// <param name="definitionPath">�w�q�ɸ��|</param>
    /// <returns>��������w�q���X</returns>
    Task<IEnumerable<DataTypeDefinition>> ParseDataTypeDefinitionsAsync(string definitionPath);

    /// <summary>
    /// �������������
    /// </summary>
    /// <param name="definitionPath">�w�q�ɸ��|</param>
    /// <returns>���������</returns>
    Task<VersionMetadata> ExtractVersionMetadataAsync(string definitionPath);
}

/// <summary>
/// �귽�ͦ�������
/// </summary>
/// <remarks>
/// �t�d�ھڸ귽�w�q�ͦ� C# �귽���O
/// </remarks>
public interface IResourceGenerator
{
    /// <summary>
    /// �ͦ���@�귽
    /// </summary>
    /// <param name="context">�ͦ��W�U��</param>
    /// <returns>�ͦ����G</returns>
    Task<GenerationResult> GenerateProjectAsync(GeneratorContext context);

    /// <summary>
    /// �ͦ��M��
    /// </summary>
    /// <param name="definitions">�귽�w�q���X</param>
    /// <param name="context">�ͦ��W�U��</param>
    /// <returns>�ͦ����G</returns>
    Task<GenerationResult> GenerateResourceAsync(ResourceDefinition definition, GeneratorContext context);
}

/// <summary>
/// �ҪO��������
/// </summary>
/// <remarks>
/// �t�d�ھڼҪO�ͦ��{���X
/// </remarks>
public interface ITemplateEngine
{
    /// <summary>
    /// �ͦ��귽���O
    /// </summary>
    /// <param name="definition">�귽�w�q</param>
    /// <param name="context">�ҪO�W�U��</param>
    /// <returns>�ͦ��� C# �{���X</returns>
    string GenerateResourceClass(ResourceDefinition definition, TemplateContext context);

    /// <summary>
    /// �ͦ��ݩ�
    /// </summary>
    /// <param name="property">�ݩʩw�q</param>
    /// <param name="context">�ҪO�W�U��</param>
    /// <returns>�ͦ����ݩʵ{���X</returns>
    string GenerateProperty(PropertyDefinition property, TemplateContext context);

    /// <summary>
    /// �ͦ����ɵ���
    /// </summary>
    /// <param name="docs">���ɸ��</param>
    /// <param name="context">�ҪO�W�U��</param>
    /// <returns>�ͦ������ɵ���</returns>
    string GenerateDocumentation(DocumentationData docs, TemplateContext context);

    /// <summary>
    /// �ͦ��u�t��k
    /// </summary>
    /// <param name="definition">�귽�w�q</param>
    /// <param name="context">�ҪO�W�U��</param>
    /// <returns>�ͦ����u�t��k�{���X</returns>
    string GenerateFactoryMethod(ResourceDefinition definition, TemplateContext context);
}