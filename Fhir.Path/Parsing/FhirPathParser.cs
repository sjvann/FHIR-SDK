using Fhir.Path.Ast;
using Fhir.Path.Exceptions;

namespace Fhir.Path.Parsing;

/// <summary>FHIRPath 表達式解析器（recursive descent）。</summary>
public sealed class FhirPathParser
{
    private readonly FhirPathLexer _lexer;
    private FhirPathToken _current;

    public FhirPathParser(string expression)
    {
        _lexer = new FhirPathLexer(expression);
        _current = _lexer.Read();
    }

    public static FhirPathExpression Parse(string expression)
        => new FhirPathParser(expression).ParseExpression();

    private FhirPathExpression ParseExpression() => ParseImplies();

    private FhirPathExpression ParseImplies()
    {
        var left = ParseOr();
        while (_current.Kind == FhirPathTokenKind.Implies)
        {
            Next();
            left = new BinaryExpression("implies", left, ParseOr());
        }
        return left;
    }

    private FhirPathExpression ParseOr()
    {
        var left = ParseXor();
        while (_current.Kind == FhirPathTokenKind.Or)
        {
            Next();
            left = new BinaryExpression("or", left, ParseXor());
        }
        return left;
    }

    private FhirPathExpression ParseXor()
    {
        var left = ParseAnd();
        while (_current.Kind == FhirPathTokenKind.Xor)
        {
            Next();
            left = new BinaryExpression("xor", left, ParseAnd());
        }
        return left;
    }

    private FhirPathExpression ParseAnd()
    {
        var left = ParseUnion();
        while (_current.Kind == FhirPathTokenKind.And)
        {
            Next();
            left = new BinaryExpression("and", left, ParseUnion());
        }
        return left;
    }

    private FhirPathExpression ParseUnion()
    {
        var left = ParseIn();
        while (_current.Kind == FhirPathTokenKind.Pipe)
        {
            Next();
            left = new UnionExpression(left, ParseIn());
        }
        return left;
    }

    private FhirPathExpression ParseIn()
    {
        var left = ParseEquality();
        if (_current.Kind == FhirPathTokenKind.In)
        {
            Next();
            return new BinaryExpression("in", left, ParseEquality());
        }
        return left;
    }

    private FhirPathExpression ParseEquality()
    {
        var left = ParseComparison();
        while (_current.Kind is FhirPathTokenKind.Eq or FhirPathTokenKind.Ne)
        {
            var op = _current.Text;
            Next();
            left = new BinaryExpression(op, left, ParseComparison());
        }
        return left;
    }

    private FhirPathExpression ParseComparison()
    {
        var left = ParseAdditive();
        while (_current.Kind is FhirPathTokenKind.Lt or FhirPathTokenKind.Gt or FhirPathTokenKind.Le or FhirPathTokenKind.Ge)
        {
            var op = _current.Text;
            Next();
            left = new BinaryExpression(op, left, ParseAdditive());
        }
        return left;
    }

    private FhirPathExpression ParseAdditive()
    {
        var left = ParseMultiplicative();
        while (_current.Kind is FhirPathTokenKind.Plus or FhirPathTokenKind.Minus)
        {
            var op = _current.Text;
            Next();
            left = new BinaryExpression(op, left, ParseMultiplicative());
        }
        return left;
    }

    private FhirPathExpression ParseMultiplicative()
    {
        var left = ParseUnary();
        while (_current.Kind is FhirPathTokenKind.Star or FhirPathTokenKind.Slash)
        {
            var op = _current.Text;
            Next();
            left = new BinaryExpression(op, left, ParseUnary());
        }
        return left;
    }

    private FhirPathExpression ParseUnary()
    {
        if (_current.Kind == FhirPathTokenKind.Minus)
        {
            Next();
            return new UnaryExpression("-", ParseUnary());
        }
        if (_current.Kind == FhirPathTokenKind.Not)
        {
            Next();
            return new UnaryExpression("not", ParseUnary());
        }
        return ParseType();
    }

    private FhirPathExpression ParseType()
    {
        var left = ParseInvocation();
        if (_current.Kind == FhirPathTokenKind.Is)
        {
            Next();
            var type = ExpectIdentifier();
            return new TypeExpression(left, type, IsTypeCheck: true);
        }
        if (_current.Kind == FhirPathTokenKind.As)
        {
            Next();
            var type = ExpectIdentifier();
            return new TypeExpression(left, type, IsTypeCheck: false);
        }
        return left;
    }

    private FhirPathExpression ParseInvocation()
    {
        var expr = ParsePrimary();
        while (true)
        {
            if (_current.Kind == FhirPathTokenKind.Dot)
            {
                Next();
                var member = ExpectIdentifier();
                if (_current.Kind == FhirPathTokenKind.LParen)
                    expr = ParseFunctionAfterDot(expr, member);
                else
                    expr = new MemberInvocationExpression(expr, member);
            }
            else if (_current.Kind == FhirPathTokenKind.LBracket)
            {
                Next();
                var indexExpr = ParseExpression();
                Expect(FhirPathTokenKind.RBracket);
                expr = new IndexerExpression(expr, indexExpr);
            }
            else break;
        }
        return expr;
    }

    private FhirPathExpression ParseFunctionAfterDot(FhirPathExpression left, string name)
    {
        Next(); // (
        var args = ParseArgumentList();
        Expect(FhirPathTokenKind.RParen);
        return new FunctionInvocationExpression(left, name, args);
    }

    private FhirPathExpression ParsePrimary()
    {
        if (_current.Kind == FhirPathTokenKind.Percent)
        {
            Next();
            return new IdentifierExpression("%" + ExpectIdentifier());
        }

        if (_current.Kind == FhirPathTokenKind.Identifier)
        {
            var name = _current.Text;
            Next();
            if (_current.Kind == FhirPathTokenKind.LParen)
            {
                Next();
                var args = ParseArgumentList();
                Expect(FhirPathTokenKind.RParen);
                return new FunctionInvocationExpression(null, name, args);
            }
            return new IdentifierExpression(name);
        }

        if (_current.Kind == FhirPathTokenKind.String)
        {
            var v = _current.Text;
            Next();
            return new LiteralExpression(v);
        }

        if (_current.Kind == FhirPathTokenKind.Number)
        {
            var text = _current.Text;
            Next();
            object? val = text.Contains('.') ? decimal.Parse(text, System.Globalization.CultureInfo.InvariantCulture)
                : int.Parse(text, System.Globalization.CultureInfo.InvariantCulture);
            return new LiteralExpression(val);
        }

        if (_current.Kind == FhirPathTokenKind.Boolean)
        {
            var v = _current.Text == "true";
            Next();
            return new LiteralExpression(v);
        }

        if (_current.Kind == FhirPathTokenKind.Null)
        {
            Next();
            return new LiteralExpression(null);
        }

        if (_current.Kind == FhirPathTokenKind.LParen)
        {
            Next();
            var inner = ParseExpression();
            Expect(FhirPathTokenKind.RParen);
            return inner;
        }

        throw FhirPathException.Syntax($"Unexpected token {_current.Kind}", _current.Position);
    }

    private List<FhirPathExpression> ParseArgumentList()
    {
        var args = new List<FhirPathExpression>();
        if (_current.Kind == FhirPathTokenKind.RParen) return args;
        args.Add(ParseExpression());
        while (_current.Kind == FhirPathTokenKind.Comma)
        {
            Next();
            args.Add(ParseExpression());
        }
        return args;
    }

    private string ExpectIdentifier()
    {
        if (_current.Kind != FhirPathTokenKind.Identifier)
            throw FhirPathException.Syntax("Expected identifier", _current.Position);
        var text = _current.Text;
        Next();
        return text;
    }

    private void Expect(FhirPathTokenKind kind)
    {
        if (_current.Kind != kind)
            throw FhirPathException.Syntax($"Expected {kind}", _current.Position);
        Next();
    }

    private void Next() => _current = _lexer.Read();
}
