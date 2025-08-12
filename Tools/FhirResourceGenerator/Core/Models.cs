namespace FhirResourceGenerator.Core;

/// <summary>
/// �귽�w�q
/// 
/// <para>
/// ��ܱq FHIR StructureDefinition �ѪR�X���귽�w�q��T�C
/// </para>
/// </summary>
public class ResourceDefinition
{
    /// <summary>
    /// �귽�W��
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// �귽����
    /// </summary>
    public string Kind { get; set; } = string.Empty;

    /// <summary>
    /// �O�_����H�귽
    /// </summary>
    public bool Abstract { get; set; }

    /// <summary>
    /// ��¦�w�q URL
    /// </summary>
    public string? BaseDefinition { get; set; }

    /// <summary>
    /// �귽 URL
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    public string? Version { get; set; }

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
    /// �O�_�� BackboneElement
    /// </summary>
    public bool IsBackboneElement => Kind.Equals("complex-type", StringComparison.OrdinalIgnoreCase) 
                                    && BaseDefinition?.EndsWith("BackboneElement") == true;

    /// <summary>
    /// �O�_�� DataType
    /// </summary>
    public bool IsDataType => Kind.Equals("primitive-type", StringComparison.OrdinalIgnoreCase) 
                             || Kind.Equals("complex-type", StringComparison.OrdinalIgnoreCase);

    /// <summary>
    /// ���o�ڤ����]�귽�������w�q�^
    /// </summary>
    public ElementDefinition? RootElement => Elements.FirstOrDefault(e => e.Path == Name);

    /// <summary>
    /// ���o�ݩʤ����]�D�ڤ����^
    /// </summary>
    public IEnumerable<ElementDefinition> PropertyElements => Elements.Where(e => e.Path != Name && !e.Path.Contains('['));
}

/// <summary>
/// �����w�q
/// 
/// <para>
/// ��� FHIR ElementDefinition ����T�C
/// </para>
/// </summary>
public class ElementDefinition
{
    /// <summary>
    /// �������|
    /// </summary>
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// �����W�١]���|���̫�@�����^
    /// </summary>
    public string Name => Path.Split('.').Last();

    /// <summary>
    /// �̤p�X�{����
    /// </summary>
    public int Min { get; set; }

    /// <summary>
    /// �̤j�X�{���ơ]*��ܵL����^
    /// </summary>
    public string Max { get; set; } = "1";

    /// <summary>
    /// �O�_���}�C
    /// </summary>
    public bool IsArray => Max != "1";

    /// <summary>
    /// �O�_������
    /// </summary>
    public bool IsRequired => Min > 0;

    /// <summary>
    /// ���O�w�q
    /// </summary>
    public List<TypeRef> Types { get; set; } = new();

    /// <summary>
    /// ²�u�y�z
    /// </summary>
    public string? Short { get; set; }

    /// <summary>
    /// �Բөw�q
    /// </summary>
    public string? Definition { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// �O�_�� ChoiceType
    /// </summary>
    public bool IsChoiceType => Types.Count > 1 || Name.EndsWith("[x]");

    /// <summary>
    /// ���o C# �ݩʦW��
    /// </summary>
    public string PropertyName
    {
        get
        {
            var name = Name;
            if (name.EndsWith("[x]"))
            {
                name = name[..^3]; // ���� [x]
            }
            return char.ToUpper(name[0]) + name[1..];
        }
    }
}

/// <summary>
/// ���O�Ѧ�
/// </summary>
public class TypeRef
{
    /// <summary>
    /// ���O�N�X
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// Profile URL
    /// </summary>
    public string? Profile { get; set; }

    /// <summary>
    /// �ؼ� Profile
    /// </summary>
    public List<string> TargetProfile { get; set; } = new();
}

/// <summary>
/// ��������w�q
/// </summary>
public class DataTypeDefinition
{
    /// <summary>
    /// ���O�W��
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// ��¦���O
    /// </summary>
    public string? BaseType { get; set; }

    /// <summary>
    /// �O�_�� primitive type
    /// </summary>
    public bool IsPrimitive { get; set; }

    /// <summary>
    /// �����w�q
    /// </summary>
    public List<ElementDefinition> Elements { get; set; } = new();
}

/// <summary>
/// ���������
/// </summary>
public class VersionMetadata
{
    /// <summary>
    /// FHIR ����
    /// </summary>
    public string Version { get; set; } = string.Empty;

    /// <summary>
    /// �o�����
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// �䴩���귽�C��
    /// </summary>
    public List<string> SupportedResources { get; set; } = new();

    /// <summary>
    /// �䴩����������C��
    /// </summary>
    public List<string> SupportedDataTypes { get; set; } = new();
}

/// <summary>
/// ���ɸ��
/// </summary>
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
    /// �ϥνd��
    /// </summary>
    public string? Example { get; set; }

    /// <summary>
    /// �Ƶ�
    /// </summary>
    public string? Remarks { get; set; }

    /// <summary>
    /// �����s��
    /// </summary>
    public List<string> SeeAlso { get; set; } = new();
}

/// <summary>
/// �����w�q
/// </summary>
public class ConstraintDefinition
{
    /// <summary>
    /// �������
    /// </summary>
    public string Key { get; set; } = string.Empty;

    /// <summary>
    /// �Y���{��
    /// </summary>
    public string Severity { get; set; } = string.Empty;

    /// <summary>
    /// �H���iŪ���y�z
    /// </summary>
    public string Human { get; set; } = string.Empty;

    /// <summary>
    /// XPath ��F��
    /// </summary>
    public string? Expression { get; set; }
}

/// <summary>
/// �M�׸�T
/// </summary>
public class ProjectInfo
{
    /// <summary>
    /// �M�צW��
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// �ؼЮج[
    /// </summary>
    public string TargetFramework { get; set; } = "net9.0";

    /// <summary>
    /// �M�״y�z
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// ����
    /// </summary>
    public string Version { get; set; } = "1.0.0";

    /// <summary>
    /// �̩ۨʮM��
    /// </summary>
    public List<PackageReference> PackageReferences { get; set; } = new();

    /// <summary>
    /// �M�װѦ�
    /// </summary>
    public List<string> ProjectReferences { get; set; } = new();
}

/// <summary>
/// �M��Ѧ�
/// </summary>
public class PackageReference
{
    /// <summary>
    /// �M��W��
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// ����
    /// </summary>
    public string Version { get; set; } = string.Empty;
}