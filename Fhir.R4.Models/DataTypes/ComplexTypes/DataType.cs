using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// Base definition for all re-usable types defined as part of the FHIR Specification.
/// 現在可以安全地繼承 Element
/// </summary>
/// <remarks>
/// FHIR R4 DataType (Abstract)
/// The base class for all re-usable types defined as part of the FHIR Specification.
/// </remarks>
public abstract class DataType : Element
{
    // 所有可重用型別的基礎
    // 繼承了 Element 的 id 和 extension 屬性
}
