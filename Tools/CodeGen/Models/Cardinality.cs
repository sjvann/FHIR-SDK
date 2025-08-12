namespace CodeGen.Models;

/// <summary>
/// Represents FHIR element cardinality (min/max occurrence)
/// </summary>
/// <param name="Min">Minimum occurrences (0 or 1+)</param>
/// <param name="Max">Maximum occurrences ("1", "*", or numeric string)</param>
public record Cardinality(int Min, string Max)
{
    /// <summary>
    /// Determines if this cardinality represents a list/collection (max > 1 or "*")
    /// </summary>
    public bool IsList => string.Equals(Max, "*", StringComparison.OrdinalIgnoreCase) || 
                         (int.TryParse(Max, out var mx) && mx > 1);

    /// <summary>
    /// Determines if this element is required (min >= 1)
    /// </summary>
    public bool IsRequired => Min >= 1;

    /// <summary>
    /// Default cardinality for optional single elements [0..1]
    /// </summary>
    public static Cardinality Optional => new(0, "1");

    /// <summary>
    /// Default cardinality for required single elements [1..1]
    /// </summary>
    public static Cardinality Required => new(1, "1");

    /// <summary>
    /// Default cardinality for optional collections [0..*]
    /// </summary>
    public static Cardinality OptionalList => new(0, "*");

    /// <summary>
    /// Default cardinality for required collections [1..*]
    /// </summary>
    public static Cardinality RequiredList => new(1, "*");
}
