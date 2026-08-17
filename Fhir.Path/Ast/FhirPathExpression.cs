namespace Fhir.Path.Ast;

public abstract record FhirPathExpression;

public sealed record LiteralExpression(object? Value) : FhirPathExpression;

public sealed record IdentifierExpression(string Name) : FhirPathExpression;

public sealed record MemberInvocationExpression(FhirPathExpression Left, string Member) : FhirPathExpression;

public sealed record IndexerExpression(FhirPathExpression Left, FhirPathExpression Index) : FhirPathExpression;

public sealed record FunctionInvocationExpression(FhirPathExpression? Left, string FunctionName, IReadOnlyList<FhirPathExpression> Arguments) : FhirPathExpression;

public sealed record UnaryExpression(string Operator, FhirPathExpression Operand) : FhirPathExpression;

public sealed record BinaryExpression(string Operator, FhirPathExpression Left, FhirPathExpression Right) : FhirPathExpression;

public sealed record TypeExpression(FhirPathExpression Left, string TypeSpecifier, bool IsTypeCheck) : FhirPathExpression;

public sealed record UnionExpression(FhirPathExpression Left, FhirPathExpression Right) : FhirPathExpression;
