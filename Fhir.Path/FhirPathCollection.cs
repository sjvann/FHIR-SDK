namespace Fhir.Path;

/// <summary>FHIRPath 評估結果集合。</summary>
public sealed class FhirPathCollection : IReadOnlyList<object?>
{
    private readonly List<object?> _items;

    public static FhirPathCollection Empty { get; } = new([]);

    public FhirPathCollection(IEnumerable<object?> items)
        => _items = items.ToList();

    public int Count => _items.Count;
    public object? this[int index] => _items[index];
    public IEnumerator<object?> GetEnumerator() => _items.GetEnumerator();
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();

    public bool IsEmpty => _items.Count == 0;
    public bool IsSingleton => _items.Count == 1;

    public object? SingleOrDefault()
        => _items.Count switch
        {
            0 => null,
            1 => _items[0],
            _ => throw new InvalidOperationException("FHIRPath collection expected a single item.")
        };

    public FhirPathCollection SelectMany(Func<object?, IEnumerable<object?>> selector)
        => new(_items.SelectMany(i => selector(i)));
}
