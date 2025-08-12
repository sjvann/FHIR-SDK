namespace FhirResourceGenerator.Core;

/// <summary>
/// �귽�w�q
/// </summary>
/// <remarks>
/// ��ܱq StructureDefinition �ѪR�X���귽�w�q��T
/// </remarks>
public class ResourceDefinition
{
    /// <summary>
    /// �귽�W��
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// �귽���� (resource, complex-type, primitive-type)
    /// </summary>
    public string Kind { get; set; } = string.Empty;

    /// <summary>
    /// �O�_����H���O
    /// </summary>
    public bool Abstract { get; set; }

    /// <summary>
    /// ��¦�w�q URL
    /// </summary>
    public string? BaseDefinition { get; set; }

    /// <summary>
    /// �����w�q�C��
    /// </summary>
    public List<ElementDefinition> Elements { get; set; } = new();

    /// <summary>
    /// ���ɸ�T
    /// </summary>
    public DocumentationData Documentation { get; set; } = new();

    /// <summary>
    /// ��������
    /// </summary>
    public List<ConstraintDefinition> Constraints { get; set; } = new();

    /// <summary>
    /// �ݩʩw�q (�q�����ѪR�Ө�)
    /// </summary>
    public List<PropertyDefinition> Properties { get; set; } = new();

    /// <summary>
    /// �I�������w�q
    /// </summary>
    public List<BackboneElementDefinition> BackboneElements { get; set; } = new();

    /// <summary>
    /// ��������w�q
    /// </summary>
    public List<ChoiceTypeDefinition> ChoiceTypes { get; set; } = new();

    /// <summary>
    /// URL
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    public string? Version { get; set; }

    /// <summary>
    /// ���A
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// ����ʽ�
    /// </summary>
    public bool Experimental { get; set; }

    /// <summary>
    /// ���
    /// </summary>
    public string? Date { get; set; }

    /// <summary>
    /// �o����
    /// </summary>
    public string? Publisher { get; set; }

    /// <summary>
    /// �y�z
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// �γ~
    /// </summary>
    public string? Purpose { get; set; }

    /// <summary>
    /// �ۧ@�v
    /// </summary>
    public string? Copyright { get; set; }
}

/// <summary>
/// �����w�q
/// </summary>
/// <remarks>
/// ��� StructureDefinition ������@�����w�q
/// </remarks>
public class ElementDefinition
{
    /// <summary>
    /// ���� ID
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// ���|
    /// </summary>
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// ��ܦC��
    /// </summary>
    public List<string> Representation { get; set; } = new();

    /// <summary>
    /// �����W��
    /// </summary>
    public string? SliceName { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// ²�u�y�z
    /// </summary>
    public string? Short { get; set; }

    /// <summary>
    /// �w�q
    /// </summary>
    public string? Definition { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// �ݨD
    /// </summary>
    public string? Requirements { get; set; }

    /// <summary>
    /// �O�W
    /// </summary>
    public List<string> Alias { get; set; } = new();

    /// <summary>
    /// �̤p�X�{����
    /// </summary>
    public int Min { get; set; }

    /// <summary>
    /// �̤j�X�{����
    /// </summary>
    public string Max { get; set; } = string.Empty;

    /// <summary>
    /// ��¦��T
    /// </summary>
    public ElementBase? Base { get; set; }

    /// <summary>
    /// ���e�Ѧ�
    /// </summary>
    public string? ContentReference { get; set; }

    /// <summary>
    /// �����C��
    /// </summary>
    public List<ElementType> Type { get; set; } = new();

    /// <summary>
    /// �w�]��
    /// </summary>
    public object? DefaultValue { get; set; }

    /// <summary>
    /// �N�q��ʤ�
    /// </summary>
    public string? MeaningWhenMissing { get; set; }

    /// <summary>
    /// ���ǷN�q
    /// </summary>
    public string? OrderMeaning { get; set; }

    /// <summary>
    /// �T�w��
    /// </summary>
    public object? Fixed { get; set; }

    /// <summary>
    /// �Ҧ���
    /// </summary>
    public object? Pattern { get; set; }

    /// <summary>
    /// �d��
    /// </summary>
    public List<ElementExample> Example { get; set; } = new();

    /// <summary>
    /// �̤p��
    /// </summary>
    public object? MinValue { get; set; }

    /// <summary>
    /// �̤j��
    /// </summary>
    public object? MaxValue { get; set; }

    /// <summary>
    /// �̤j����
    /// </summary>
    public int? MaxLength { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    public List<string> Condition { get; set; } = new();

    /// <summary>
    /// ����
    /// </summary>
    public List<ElementConstraint> Constraint { get; set; } = new();

    /// <summary>
    /// �������
    /// </summary>
    public bool? MustSupport { get; set; }

    /// <summary>
    /// �O�_�׹���
    /// </summary>
    public bool? IsModifier { get; set; }

    /// <summary>
    /// �׹��ŭ�]
    /// </summary>
    public string? IsModifierReason { get; set; }

    /// <summary>
    /// �O�_�K�n
    /// </summary>
    public bool? IsSummary { get; set; }

    /// <summary>
    /// �j�w
    /// </summary>
    public ElementBinding? Binding { get; set; }

    /// <summary>
    /// �M�g
    /// </summary>
    public List<ElementMapping> Mapping { get; set; } = new();
}

/// <summary>
/// �ݩʩw�q
/// </summary>
/// <remarks>
/// �q�����w�q�ഫ�ӨӪ� C# �ݩʩw�q
/// </remarks>
public class PropertyDefinition
{
    /// <summary>
    /// �ݩʦW��
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// C# ����
    /// </summary>
    public string CSharpType { get; set; } = string.Empty;

    /// <summary>
    /// FHIR ����
    /// </summary>
    public string FhirType { get; set; } = string.Empty;

    /// <summary>
    /// �O�_���}�C
    /// </summary>
    public bool IsArray { get; set; }

    /// <summary>
    /// �O�_�i�� null
    /// </summary>
    public bool IsNullable { get; set; }

    /// <summary>
    /// �̤p�X�{����
    /// </summary>
    public int MinOccurs { get; set; }

    /// <summary>
    /// �̤j�X�{����
    /// </summary>
    public string MaxOccurs { get; set; } = string.Empty;

    /// <summary>
    /// ²�u�y�z
    /// </summary>
    public string? Summary { get; set; }

    /// <summary>
    /// �ԲӴy�z
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// �d��
    /// </summary>
    public string? Example { get; set; }

    /// <summary>
    /// ��������
    /// </summary>
    public List<string> Constraints { get; set; } = new();

    /// <summary>
    /// �����ݩ�
    /// </summary>
    public List<string> ValidationAttributes { get; set; } = new();

    /// <summary>
    /// �O�_���������
    /// </summary>
    public bool IsChoiceType { get; set; }

    /// <summary>
    /// ��������ﶵ
    /// </summary>
    public List<string> ChoiceTypeOptions { get; set; } = new();

    /// <summary>
    /// �O�_���I������
    /// </summary>
    public bool IsBackboneElement { get; set; }

    /// <summary>
    /// �I�������W��
    /// </summary>
    public string? BackboneElementName { get; set; }

    /// <summary>
    /// �w�]��
    /// </summary>
    public string? DefaultValue { get; set; }
}

/// <summary>
/// ���ɸ��
/// </summary>
/// <remarks>
/// �]�t�ͦ� XML ���ɵ��ѩһݪ���T
/// </remarks>
public class DocumentationData
{
    /// <summary>
    /// �K�n
    /// </summary>
    public string Summary { get; set; } = string.Empty;

    /// <summary>
    /// �ԲӴy�z
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// �Ƶ�
    /// </summary>
    public string Remarks { get; set; } = string.Empty;

    /// <summary>
    /// �d��
    /// </summary>
    public string Example { get; set; } = string.Empty;

    /// <summary>
    /// �����S�I
    /// </summary>
    public List<string> VersionFeatures { get; set; } = new();

    /// <summary>
    /// ��������
    /// </summary>
    public List<string> ConstraintDescriptions { get; set; } = new();

    /// <summary>
    /// �Ѧҳs��
    /// </summary>
    public List<string> References { get; set; } = new();
}

/// <summary>
/// �����w�q
/// </summary>
/// <remarks>
/// ��� FHIR �귽����������
/// </remarks>
public class ConstraintDefinition
{
    /// <summary>
    /// ���� ID
    /// </summary>
    public string Key { get; set; } = string.Empty;

    /// <summary>
    /// �Y���{��
    /// </summary>
    public string Severity { get; set; } = string.Empty;

    /// <summary>
    /// �H���iŪ�y�z
    /// </summary>
    public string Human { get; set; } = string.Empty;

    /// <summary>
    /// ��F��
    /// </summary>
    public string Expression { get; set; } = string.Empty;

    /// <summary>
    /// XPath ��F��
    /// </summary>
    public string? Xpath { get; set; }

    /// <summary>
    /// �ӷ�
    /// </summary>
    public string? Source { get; set; }
}

/// <summary>
/// �I�������w�q
/// </summary>
/// <remarks>
/// ��ܻݭn�ͦ����I���������O
/// </remarks>
public class BackboneElementDefinition
{
    /// <summary>
    /// ���O�W��
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// ���|
    /// </summary>
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// �ݩʦC��
    /// </summary>
    public List<PropertyDefinition> Properties { get; set; } = new();

    /// <summary>
    /// ����
    /// </summary>
    public DocumentationData Documentation { get; set; } = new();

    /// <summary>
    /// ����
    /// </summary>
    public List<ConstraintDefinition> Constraints { get; set; } = new();
}

/// <summary>
/// ��������w�q
/// </summary>
/// <remarks>
/// ��ܻݭn�ͦ�������������O
/// </remarks>
public class ChoiceTypeDefinition
{
    /// <summary>
    /// ���O�W��
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// �e��W��
    /// </summary>
    public string PrefixName { get; set; } = string.Empty;

    /// <summary>
    /// �䴩������
    /// </summary>
    public List<string> SupportedTypes { get; set; } = new();

    /// <summary>
    /// ����
    /// </summary>
    public DocumentationData Documentation { get; set; } = new();
}

/// <summary>
/// ��������w�q
/// </summary>
/// <remarks>
/// ��� FHIR ��������w�q
/// </remarks>
public class DataTypeDefinition
{
    /// <summary>
    /// �����W��
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// ��������
    /// </summary>
    public string Kind { get; set; } = string.Empty;

    /// <summary>
    /// ��¦����
    /// </summary>
    public string? BaseType { get; set; }

    /// <summary>
    /// �����w�q
    /// </summary>
    public List<ElementDefinition> Elements { get; set; } = new();

    /// <summary>
    /// ����
    /// </summary>
    public DocumentationData Documentation { get; set; } = new();
}

/// <summary>
/// ���������
/// </summary>
/// <remarks>
/// �]�t FHIR ���������������
/// </remarks>
public class VersionMetadata
{
    /// <summary>
    /// ������
    /// </summary>
    public string Version { get; set; } = string.Empty;

    /// <summary>
    /// �����W��
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// �o�����
    /// </summary>
    public string? Date { get; set; }

    /// <summary>
    /// ���A
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// �귽�`��
    /// </summary>
    public int ResourceCount { get; set; }

    /// <summary>
    /// �䴩���귽�C��
    /// </summary>
    public List<string> SupportedResources { get; set; } = new();
}

// ���U���O�w�q
public class ElementBase
{
    public string Path { get; set; } = string.Empty;
    public int Min { get; set; }
    public string Max { get; set; } = string.Empty;
}

public class ElementType
{
    public string Code { get; set; } = string.Empty;
    public List<string> Profile { get; set; } = new();
    public List<string> TargetProfile { get; set; } = new();
    public List<string> Aggregation { get; set; } = new();
    public string? Versioning { get; set; }
}

public class ElementExample
{
    public string Label { get; set; } = string.Empty;
    public object? Value { get; set; }
}

public class ElementConstraint
{
    public string Key { get; set; } = string.Empty;
    public string Requirements { get; set; } = string.Empty;
    public string Severity { get; set; } = string.Empty;
    public string Human { get; set; } = string.Empty;
    public string Expression { get; set; } = string.Empty;
    public string? Xpath { get; set; }
    public string? Source { get; set; }
}

public class ElementBinding
{
    public string Strength { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? ValueSet { get; set; }
}

public class ElementMapping
{
    public string Identity { get; set; } = string.Empty;
    public string? Language { get; set; }
    public string Map { get; set; } = string.Empty;
    public string? Comment { get; set; }
}