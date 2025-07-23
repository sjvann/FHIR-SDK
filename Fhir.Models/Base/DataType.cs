using Fhir.Support.Interfaces;

namespace Fhir.Support.Base;

/// <summary>
/// 所有 FHIR 資料型態的基礎抽象類別，繼承自 <see cref="Element"/> 並實作 <see cref="IDataType"/>。
/// </summary>
public abstract class DataType : Element, IDataType
{
    // 此類別為階層結構的一部分，目前不需要額外的實作。
} 