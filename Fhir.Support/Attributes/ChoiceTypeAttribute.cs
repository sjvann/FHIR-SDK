using System;

namespace Fhir.Support.Attributes;

/// <summary>
/// 標記屬性為 FHIR Choice Type (value[x]) 的一部分
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class ChoiceTypeAttribute : Attribute
{
    /// <summary>
    /// Choice Type 的基礎名稱 (例如 "value" 對應 value[x])
    /// </summary>
    public string? BaseName { get; set; }
    
    /// <summary>
    /// 此屬性對應的 FHIR 型別代碼
    /// </summary>
    public string? TypeCode { get; set; }
    
    public ChoiceTypeAttribute()
    {
    }
    
    public ChoiceTypeAttribute(string baseName, string typeCode)
    {
        BaseName = baseName;
        TypeCode = typeCode;
    }
}
