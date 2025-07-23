namespace Fhir.Support.Attributes;

/// <summary>
/// 表示 FHIR 元素基数（Cardinality）的约束。
/// </summary>
[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class CardinalityAttribute : Attribute
{
    /// <summary>
    /// 最小出现次数。
    /// </summary>
    public int Min { get; }

    /// <summary>
    /// 最大出现次数。'*' 被表示为 int.MaxValue。
    /// </summary>
    public int Max { get; }

    /// <summary>
    /// 初始化 <see cref="CardinalityAttribute"/> 的新实例。
    /// </summary>
    /// <param name="min">最小出现次数。</param>
    /// <param name="max">最大出现次数。</param>
    public CardinalityAttribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
} 