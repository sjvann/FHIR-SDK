namespace FhirResourceGenerator.Core;

/// <summary>
/// �ҪO��������
/// 
/// <para>
/// �t�d�ھڼҪO�M��ƥͦ��{���X���q�C
/// </para>
/// </summary>
public interface ITemplateEngine
{
    /// <summary>
    /// �ͦ��귽���O�{���X
    /// </summary>
    /// <param name="definition">�귽�w�q</param>
    /// <param name="context">�ҪO�W�U��</param>
    /// <returns>�ͦ����{���X</returns>
    string GenerateResourceClass(ResourceDefinition definition, TemplateContext context);

    /// <summary>
    /// �ͦ��ݩʵ{���X
    /// </summary>
    /// <param name="property">�ݩʩw�q</param>
    /// <param name="context">�ҪO�W�U��</param>
    /// <returns>�ͦ����{���X</returns>
    string GenerateProperty(PropertyDefinition property, TemplateContext context);

    /// <summary>
    /// �ͦ����ɵ���
    /// </summary>
    /// <param name="docs">���ɸ��</param>
    /// <param name="context">�ҪO�W�U��</param>
    /// <returns>�ͦ����{���X</returns>
    string GenerateDocumentation(DocumentationData docs, TemplateContext context);

    /// <summary>
    /// �ͦ��u�t��k�{���X
    /// </summary>
    /// <param name="definition">�귽�w�q</param>
    /// <param name="context">�ҪO�W�U��</param>
    /// <returns>�ͦ����{���X</returns>
    string GenerateFactoryMethods(ResourceDefinition definition, TemplateContext context);

    /// <summary>
    /// �ͦ��M���ɮ�
    /// </summary>
    /// <param name="projectInfo">�M�׸�T</param>
    /// <param name="context">�ҪO�W�U��</param>
    /// <returns>�ͦ����M���ɤ��e</returns>
    string GenerateProjectFile(ProjectInfo projectInfo, TemplateContext context);
}