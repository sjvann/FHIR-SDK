namespace Fhir.Support.Attributes;

/// <summary>
/// 用於標記 FHIR 資料模型屬性的自訂 Attribute，以儲存來自 StructureDefinition 的元數據。
/// </summary>
[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class FhirElementAttribute : Attribute
{
    /// <summary>
    /// 初始化 <see cref="FhirElementAttribute"/> 的新實例。
    /// </summary>
    public FhirElementAttribute()
    {
        Name = string.Empty;
    }

    /// <summary>
    /// 初始化 <see cref="FhirElementAttribute"/> 的新實例。
    /// </summary>
    /// <param name="name">FHIR 元素的名稱。</param>
    /// <param name="order">FHIR 元素的順序。</param>
    public FhirElementAttribute(string name, int order)
    {
        Name = name;
        Order = order;
    }

    /// <summary>
    /// 初始化 <see cref="FhirElementAttribute"/> 的新實例。
    /// </summary>
    /// <param name="name">FHIR 元素的名稱。</param>
    public FhirElementAttribute(string name)
    {
        Name = name;
    }

    /// <summary>
    /// 取得 FHIR 元素的名稱 (例如 "birthDate")。
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 取得 FHIR 元素在資源中的順序。
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// 取得或設定一個值，表示此元素是否為列表（基數 > 1）。
    /// </summary>
    public bool IsList { get; set; }

    /// <summary>
    /// 取得或設定 FHIR 元素的資料型態。
    /// 對於 choice 型態的元素，此屬性將會是 `typeof(ChoiceType)`。
    /// </summary>
    public Type? ElementType { get; set; }

    /// <summary>
    /// 取得或設定一個值，表示此元素是否為 Choice 型態 (例如 "value[x]")。
    /// </summary>
    public bool IsChoice { get; set; }
} 