using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Parsers;

/// <summary>
/// FHIR �����ѪR��
/// </summary>
/// <remarks>
/// �t�d�N FHIR �����M�g�� C# ����
/// </remarks>
public class FhirTypeResolver
{
    private readonly ILogger<FhirTypeResolver> _logger;
    private readonly Dictionary<string, TypeMapping> _typeMappings;

    public FhirTypeResolver(ILogger<FhirTypeResolver> logger)
    {
        _logger = logger;
        _typeMappings = InitializeTypeMappings();
    }

    /// <summary>
    /// �ѪR C# ����
    /// </summary>
    public async Task<string> ResolveCSharpTypeAsync(string fhirType, bool isArray = false)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

        if (_typeMappings.TryGetValue(fhirType, out var mapping))
        {
            var csharpType = mapping.CSharpType;
            
            if (isArray)
            {
                csharpType = $"List<{csharpType}>";
            }
            
            if (mapping.IsNullable && !isArray)
            {
                csharpType += "?";
            }

            return csharpType;
        }

        _logger.LogWarning("������ FHIR �����G{FhirType}", fhirType);
        
        // �w�]�B�z
        var defaultType = isArray ? $"List<{fhirType}>" : fhirType;
        return defaultType;
    }

    /// <summary>
    /// ���o�������R�W�Ŷ�
    /// </summary>
    public string GetTypeNamespace(string fhirType)
    {
        if (_typeMappings.TryGetValue(fhirType, out var mapping))
        {
            return mapping.Namespace;
        }

        return "System"; // �w�]�R�W�Ŷ�
    }

    /// <summary>
    /// �O�_����l����
    /// </summary>
    public bool IsPrimitiveType(string fhirType)
    {
        if (_typeMappings.TryGetValue(fhirType, out var mapping))
        {
            return mapping.IsPrimitive;
        }

        return false;
    }

    /// <summary>
    /// �O�_����������
    /// </summary>
    public bool IsComplexType(string fhirType)
    {
        if (_typeMappings.TryGetValue(fhirType, out var mapping))
        {
            return mapping.IsComplex;
        }

        return false;
    }

    /// <summary>
    /// ��l�������M�g
    /// </summary>
    private Dictionary<string, TypeMapping> InitializeTypeMappings()
    {
        return new Dictionary<string, TypeMapping>
        {
            // ��l����
            ["string"] = new("FhirString", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["boolean"] = new("FhirBoolean", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["integer"] = new("FhirInteger", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["positiveInt"] = new("FhirPositiveInt", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["unsignedInt"] = new("FhirUnsignedInt", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["decimal"] = new("FhirDecimal", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["uri"] = new("FhirUri", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["url"] = new("FhirUrl", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["canonical"] = new("FhirCanonical", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["base64Binary"] = new("FhirBase64Binary", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["instant"] = new("FhirInstant", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["date"] = new("FhirDate", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["dateTime"] = new("FhirDateTime", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["time"] = new("FhirTime", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["code"] = new("FhirCode", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["oid"] = new("FhirOid", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["id"] = new("FhirId", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["markdown"] = new("FhirMarkdown", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["uuid"] = new("FhirUuid", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["xhtml"] = new("FhirXhtml", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),

            // ��������
            ["Address"] = new("Address", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Age"] = new("Age", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Annotation"] = new("Annotation", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Attachment"] = new("Attachment", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["CodeableConcept"] = new("CodeableConcept", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["CodeableReference"] = new("CodeableReference", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Coding"] = new("Coding", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["ContactPoint"] = new("ContactPoint", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Count"] = new("Count", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Distance"] = new("Distance", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Duration"] = new("Duration", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["HumanName"] = new("HumanName", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Identifier"] = new("Identifier", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Money"] = new("Money", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Period"] = new("Period", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Quantity"] = new("Quantity", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Range"] = new("Range", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Ratio"] = new("Ratio", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["RatioRange"] = new("RatioRange", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["SampledData"] = new("SampledData", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Signature"] = new("Signature", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Timing"] = new("Timing", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),

            // �S������
            ["Reference"] = new("ReferenceType", "DataTypeServices.DataTypes.SpecialTypes", true, false, true),
            ["Extension"] = new("Extension", "DataTypeServices.DataTypes.SpecialTypes", true, false, true),
            ["Narrative"] = new("Narrative", "DataTypeServices.DataTypes.SpecialTypes", true, false, true),
            ["Meta"] = new("Meta", "DataTypeServices.DataTypes.SpecialTypes", true, false, true),

            // ��]����
            ["Element"] = new("Element", "DataTypeServices.DataTypes.MetaTypes", true, false, true),
            ["BackboneElement"] = new("BackboneElement", "DataTypeServices.DataTypes.MetaTypes", true, false, true),
            ["DomainResource"] = new("DomainResource", "FhirCore.Base", true, false, true),
            ["Resource"] = new("ResourceBase", "FhirCore.Base", true, false, true),

            // ��������M�����������w�]�B�z
            ["ChoiceType"] = new("ChoiceType", "DataTypeServices.DataTypes.ChoiceTypes", true, false, true),
            ["BackboneElement"] = new("BackboneElement", "DataTypeServices.DataTypes.MetaTypes", true, false, true)
        };
    }
}

/// <summary>
/// �����M�g��T
/// </summary>
/// <remarks>
/// �]�t FHIR ������ C# �������M�g��T
/// </remarks>
public class TypeMapping
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
    /// �O�_�i�� null
    /// </summary>
    public bool IsNullable { get; }

    /// <summary>
    /// �O�_����l����
    /// </summary>
    public bool IsPrimitive { get; }

    /// <summary>
    /// �O�_����������
    /// </summary>
    public bool IsComplex { get; }

    public TypeMapping(string csharpType, string @namespace, bool isNullable = true, 
        bool isPrimitive = false, bool isComplex = false)
    {
        CSharpType = csharpType;
        Namespace = @namespace;
        IsNullable = isNullable;
        IsPrimitive = isPrimitive;
        IsComplex = isComplex;
    }

    /// <summary>
    /// ���o���������W��
    /// </summary>
    public string GetFullTypeName()
    {
        return $"{Namespace}.{CSharpType}";
    }

    /// <summary>
    /// �ഫ���}�C����
    /// </summary>
    public TypeMapping AsArray()
    {
        return new TypeMapping($"List<{CSharpType}>", "System.Collections.Generic", 
            IsNullable, false, IsComplex);
    }
}