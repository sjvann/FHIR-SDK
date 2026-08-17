using Fhir.TypeFramework.Bases;

namespace Fhir.Path.Abstractions;

/// <summary>FHIRPath 邏輯模型節點（對應 tree model 中的一個節點）。</summary>
public interface IFhirNode
{
    /// <summary>節點名稱（元素名；primitive 為型別名或屬性語意名）。</summary>
    string Name { get; }

    /// <summary>底層 POCO 物件（primitive 為 <see cref="PrimitiveType"/> 實例）。</summary>
    object? Native { get; }

    /// <summary>父節點。</summary>
    IFhirNode? Parent { get; }

    /// <summary>是否為 FHIR primitive 邏輯節點（不可再導覽 .value）。</summary>
    bool IsPrimitive { get; }

    /// <summary>取得子元素（依 FHIR 元素名）。</summary>
    IReadOnlyList<IFhirNode> Children(string elementName);

    /// <summary>取得此節點下所有具名子節點（展開 list）。</summary>
    IReadOnlyList<IFhirNode> AllChildren();

    /// <summary>以 0-based 索引存取重複元素中的單一項。</summary>
    IFhirNode? AtIndex(int index);

    /// <summary>重複元素數量（非 list 為 0 或 1）。</summary>
    int Count { get; }

    /// <summary>取得用於 FHIRPath 比較/輸出的值（primitive 為 lexical 或強型別投影）。</summary>
    object? GetValue();

    /// <summary>型別名稱（資源或 datatype）。</summary>
    string? TypeName { get; }
}
