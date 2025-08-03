namespace FhirResourceGenerator.Utilities;

/// <summary>
/// �R�W�u����
/// </summary>
/// <remarks>
/// ���ѲΤ@���R�W�ഫ�M�榡�ƥ\��
/// </remarks>
public static class NamingUtils
{
    /// <summary>
    /// �ഫ�� Pascal �R�W�k (���r���j�g)
    /// </summary>
    public static string ToPascalCase(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        // �����S��r�Ũä��γ��
        var words = SplitIntoWords(input);
        
        // �N�C�ӳ�������r���j�g
        var result = string.Join("", words.Select(word => 
            char.ToUpper(word[0]) + word.Substring(1).ToLower()));

        return result;
    }

    /// <summary>
    /// �ഫ�� Camel �R�W�k (���r���p�g)
    /// </summary>
    public static string ToCamelCase(string input)
    {
        var pascalCase = ToPascalCase(input);
        
        if (string.IsNullOrEmpty(pascalCase))
            return pascalCase;

        return char.ToLower(pascalCase[0]) + pascalCase.Substring(1);
    }

    /// <summary>
    /// �ഫ�����Ī� C# �ѧO��
    /// </summary>
    public static string ToValidCSharpIdentifier(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "Unknown";

        // �����L�Ħr��
        var identifier = new string(input.Where(c => 
            char.IsLetterOrDigit(c) || c == '_').ToArray());

        // �T�O�H�r���Ω��u�}�Y
        if (!char.IsLetter(identifier[0]) && identifier[0] != '_')
        {
            identifier = "_" + identifier;
        }

        // �ˬd�O�_�� C# ����r
        if (IsCSharpKeyword(identifier))
        {
            identifier = "@" + identifier;
        }

        return identifier;
    }

    /// <summary>
    /// �ഫ���ƼƧΦ�
    /// </summary>
    public static string ToPlural(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        // ²�檺�Ƽ��ഫ�W�h
        if (input.EndsWith("y", StringComparison.OrdinalIgnoreCase))
        {
            return input.Substring(0, input.Length - 1) + "ies";
        }
        
        if (input.EndsWith("s", StringComparison.OrdinalIgnoreCase) ||
            input.EndsWith("x", StringComparison.OrdinalIgnoreCase) ||
            input.EndsWith("z", StringComparison.OrdinalIgnoreCase) ||
            input.EndsWith("ch", StringComparison.OrdinalIgnoreCase) ||
            input.EndsWith("sh", StringComparison.OrdinalIgnoreCase))
        {
            return input + "es";
        }

        return input + "s";
    }

    /// <summary>
    /// �ഫ����ƧΦ�
    /// </summary>
    public static string ToSingular(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        // ²�檺����ഫ�W�h
        if (input.EndsWith("ies", StringComparison.OrdinalIgnoreCase))
        {
            return input.Substring(0, input.Length - 3) + "y";
        }
        
        if (input.EndsWith("es", StringComparison.OrdinalIgnoreCase))
        {
            return input.Substring(0, input.Length - 2);
        }
        
        if (input.EndsWith("s", StringComparison.OrdinalIgnoreCase))
        {
            return input.Substring(0, input.Length - 1);
        }

        return input;
    }

    /// <summary>
    /// �ͦ����O�W��
    /// </summary>
    public static string GenerateClassName(string resourceName, string? suffix = null)
    {
        var className = ToPascalCase(resourceName);
        
        if (!string.IsNullOrEmpty(suffix))
        {
            className += ToPascalCase(suffix);
        }

        return ToValidCSharpIdentifier(className);
    }

    /// <summary>
    /// �ͦ��ݩʦW��
    /// </summary>
    public static string GeneratePropertyName(string elementPath, string resourceName)
    {
        // �����귽�W�٫e��
        var propertyPath = elementPath;
        if (elementPath.StartsWith($"{resourceName}.", StringComparison.OrdinalIgnoreCase))
        {
            propertyPath = elementPath.Substring(resourceName.Length + 1);
        }

        // �B�z�������
        if (propertyPath.Contains("[x]"))
        {
            propertyPath = propertyPath.Replace("[x]", "");
        }

        // �B�z�O�M���| (�u���̫�@�q)
        var segments = propertyPath.Split('.');
        var propertyName = segments.Last();

        return ToPascalCase(propertyName);
    }

    /// <summary>
    /// �ͦ��R�W�Ŷ�
    /// </summary>
    public static string GenerateNamespace(string baseNamespace, string version, string? subNamespace = null)
    {
        var ns = $"{baseNamespace}.{version}";
        
        if (!string.IsNullOrEmpty(subNamespace))
        {
            ns += $".{subNamespace}";
        }

        return ns;
    }

    /// <summary>
    /// �ͦ��ɮצW��
    /// </summary>
    public static string GenerateFileName(string className, string? suffix = null)
    {
        var fileName = className;
        
        if (!string.IsNullOrEmpty(suffix))
        {
            fileName += suffix;
        }

        return fileName + ".cs";
    }

    /// <summary>
    /// ���ά����
    /// </summary>
    private static List<string> SplitIntoWords(string input)
    {
        var words = new List<string>();
        var currentWord = new List<char>();

        for (int i = 0; i < input.Length; i++)
        {
            var currentChar = input[i];

            // �ˬd���j��
            if (char.IsWhiteSpace(currentChar) || 
                currentChar == '-' || 
                currentChar == '_' || 
                currentChar == '.')
            {
                if (currentWord.Count > 0)
                {
                    words.Add(new string(currentWord.ToArray()));
                    currentWord.Clear();
                }
                continue;
            }

            // �ˬd�j�g�r�� (�m�p�R�W)
            if (char.IsUpper(currentChar) && currentWord.Count > 0)
            {
                // �p�G���O�s��j�g�r���A�h����
                if (i > 0 && !char.IsUpper(input[i - 1]))
                {
                    words.Add(new string(currentWord.ToArray()));
                    currentWord.Clear();
                }
            }

            currentWord.Add(currentChar);
        }

        if (currentWord.Count > 0)
        {
            words.Add(new string(currentWord.ToArray()));
        }

        return words.Where(w => !string.IsNullOrEmpty(w)).ToList();
    }

    /// <summary>
    /// �ˬd�O�_�� C# ����r
    /// </summary>
    private static bool IsCSharpKeyword(string identifier)
    {
        var keywords = new HashSet<string>
        {
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch",
            "char", "checked", "class", "const", "continue", "decimal", "default",
            "delegate", "do", "double", "else", "enum", "event", "explicit",
            "extern", "false", "finally", "fixed", "float", "for", "foreach",
            "goto", "if", "implicit", "in", "int", "interface", "internal",
            "is", "lock", "long", "namespace", "new", "null", "object",
            "operator", "out", "override", "params", "private", "protected",
            "public", "readonly", "ref", "return", "sbyte", "sealed", "short",
            "sizeof", "stackalloc", "static", "string", "struct", "switch",
            "this", "throw", "true", "try", "typeof", "uint", "ulong",
            "unchecked", "unsafe", "ushort", "using", "virtual", "void",
            "volatile", "while"
        };

        return keywords.Contains(identifier.ToLower());
    }
}