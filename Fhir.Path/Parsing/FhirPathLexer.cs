using Fhir.Path.Exceptions;

namespace Fhir.Path.Parsing;

internal enum FhirPathTokenKind
{
    End, Identifier, Number, String, Boolean, Null,
    Dot, LParen, RParen, LBracket, RBracket, Comma, Pipe,
    Plus, Minus, Star, Slash, Ampersand,
    Eq, Ne, Tilde, NotEquivalent, Lt, Gt, Le, Ge,
    Percent, Dollar, Colon,
    And, Or, Xor, Implies, In, Is, As, Not, Div, Mod,
    EOF
}

internal readonly record struct FhirPathToken(FhirPathTokenKind Kind, string Text, int Position);

internal sealed class FhirPathLexer(string input)
{
    private int _pos;

    public FhirPathToken Read()
    {
        SkipWhitespace();
        if (_pos >= input.Length) return new(FhirPathTokenKind.EOF, "", _pos);

        var start = _pos;
        var c = input[_pos];

        if (char.IsLetter(c) || c == '_')
            return ReadIdentifier(start);

        if (char.IsDigit(c))
            return ReadNumber(start);

        if (c is '\'' or '"')
            return ReadString(start, c);

        if (c == '`')
            return ReadBacktickIdentifier(start);

        _pos++;
        return c switch
        {
            '.' => new(FhirPathTokenKind.Dot, ".", start),
            '(' => new(FhirPathTokenKind.LParen, "(", start),
            ')' => new(FhirPathTokenKind.RParen, ")", start),
            '[' => new(FhirPathTokenKind.LBracket, "[", start),
            ']' => new(FhirPathTokenKind.RBracket, "]", start),
            ',' => new(FhirPathTokenKind.Comma, ",", start),
            '|' => new(FhirPathTokenKind.Pipe, "|", start),
            '+' => new(FhirPathTokenKind.Plus, "+", start),
            '-' => new(FhirPathTokenKind.Minus, "-", start),
            '*' => new(FhirPathTokenKind.Star, "*", start),
            '/' => new(FhirPathTokenKind.Slash, "/", start),
            '&' => new(FhirPathTokenKind.Ampersand, "&", start),
            '%' => new(FhirPathTokenKind.Percent, "%", start),
            '$' => new(FhirPathTokenKind.Dollar, "$", start),
            ':' => new(FhirPathTokenKind.Colon, ":", start),
            '~' => new(FhirPathTokenKind.Tilde, "~", start),
            '=' => ReadEquals(start),
            '!' => ReadBang(start),
            '<' => ReadLess(start),
            '>' => ReadTwoChar(start, '=', FhirPathTokenKind.Ge, FhirPathTokenKind.Gt),
            _ => throw FhirPathException.Syntax($"Unexpected character '{c}'", start)
        };
    }

    private FhirPathToken ReadIdentifier(int start)
    {
        while (_pos < input.Length && (char.IsLetterOrDigit(input[_pos]) || input[_pos] is '_' or '-'))
            _pos++;

        var text = input[start.._pos];
        var kind = text switch
        {
            "true" => FhirPathTokenKind.Boolean,
            "false" => FhirPathTokenKind.Boolean,
            "null" => FhirPathTokenKind.Null,
            "and" => FhirPathTokenKind.And,
            "or" => FhirPathTokenKind.Or,
            "xor" => FhirPathTokenKind.Xor,
            "implies" => FhirPathTokenKind.Implies,
            "in" => FhirPathTokenKind.In,
            "is" => FhirPathTokenKind.Is,
            "as" => FhirPathTokenKind.As,
            "not" => FhirPathTokenKind.Not,
            "div" => FhirPathTokenKind.Div,
            "mod" => FhirPathTokenKind.Mod,
            _ => FhirPathTokenKind.Identifier
        };
        return new(kind, text, start);
    }

    private FhirPathToken ReadNumber(int start)
    {
        while (_pos < input.Length && (char.IsDigit(input[_pos]) || input[_pos] is '.'))
            _pos++;
        return new(FhirPathTokenKind.Number, input[start.._pos], start);
    }

    private FhirPathToken ReadString(int start, char quote)
    {
        _pos++;
        var sb = new System.Text.StringBuilder();
        while (_pos < input.Length)
        {
            if (input[_pos] == quote)
            {
                _pos++;
                return new(FhirPathTokenKind.String, sb.ToString(), start);
            }
            if (input[_pos] == '\\' && _pos + 1 < input.Length)
            {
                _pos++;
                sb.Append(input[_pos]);
                _pos++;
                continue;
            }
            sb.Append(input[_pos++]);
        }
        throw FhirPathException.Syntax("Unterminated string literal", start);
    }

    private FhirPathToken ReadBacktickIdentifier(int start)
    {
        _pos++;
        var sb = new System.Text.StringBuilder();
        while (_pos < input.Length)
        {
            if (input[_pos] == '`')
            {
                _pos++;
                return new(FhirPathTokenKind.Identifier, sb.ToString(), start);
            }
            sb.Append(input[_pos++]);
        }
        throw FhirPathException.Syntax("Unterminated delimited identifier", start);
    }

    private FhirPathToken ReadBang(int start)
    {
        if (_pos < input.Length && input[_pos] == '=')
        {
            _pos++;
            return new(FhirPathTokenKind.Ne, "!=", start);
        }
        if (_pos < input.Length && input[_pos] == '~')
        {
            _pos++;
            return new(FhirPathTokenKind.NotEquivalent, "!~", start);
        }
        throw FhirPathException.Syntax("Expected '=' or '~' after '!'", start);
    }

    private FhirPathToken ReadEquals(int start)
    {
        if (_pos < input.Length && input[_pos] == '=')
        {
            _pos++;
            return new(FhirPathTokenKind.Eq, "==", start);
        }
        return new(FhirPathTokenKind.Eq, "=", start);
    }

    private FhirPathToken ReadTwoChar(int start, char second, FhirPathTokenKind twoCharKind, FhirPathTokenKind? singleKind = null)
    {
        if (_pos < input.Length && input[_pos] == second)
        {
            _pos++;
            return new(twoCharKind, input[start.._pos], start);
        }
        if (singleKind is not null)
            return new(singleKind.Value, input[start.._pos], start);
        throw FhirPathException.Syntax($"Expected '{second}' after '{input[start]}'", start);
    }

    private FhirPathToken ReadLess(int start)
    {
        if (_pos < input.Length && input[_pos] == '=')
        {
            _pos++;
            return new(FhirPathTokenKind.Le, input[start.._pos], start);
        }
        if (_pos < input.Length && input[_pos] == '<')
        {
            _pos++;
            return new(FhirPathTokenKind.Lt, "<<", start);
        }
        return new(FhirPathTokenKind.Lt, "<", start);
    }

    private void SkipWhitespace()
    {
        while (_pos < input.Length && char.IsWhiteSpace(input[_pos]))
            _pos++;
    }
}
