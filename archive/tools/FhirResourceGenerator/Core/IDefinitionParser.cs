namespace FhirResourceGenerator.Core;

/// <summary>
/// �w�q�ɸѪR������
/// 
/// <para>
/// �t�d�ѪR FHIR StructureDefinition JSON �ɮסA�����귽�w�q�B��������M��������ơC
/// </para>
/// </summary>
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