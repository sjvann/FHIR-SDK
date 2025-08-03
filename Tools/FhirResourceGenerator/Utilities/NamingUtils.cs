namespace FhirResourceGenerator.Utilities;

/// <summary>
/// 命名工具類
/// </summary>
/// <remarks>
/// 提供統一的命名轉換和格式化功能
/// </remarks>
public static class NamingUtils
{
    /// <summary>
    /// 轉換為 Pascal 命名法 (首字母大寫)
    /// </summary>
    public static string ToPascalCase(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        // 移除特殊字符並分割單詞
        var words = SplitIntoWords(input);
        
        // 將每個單詞的首字母大寫
        var result = string.Join("", words.Select(word => 
            char.ToUpper(word[0]) + word.Substring(1).ToLower()));

        return result;
    }

    /// <summary>
    /// 轉換為 Camel 命名法 (首字母小寫)
    /// </summary>
    public static string ToCamelCase(string input)
    {
        var pascalCase = ToPascalCase(input);
        
        if (string.IsNullOrEmpty(pascalCase))
            return pascalCase;

        return char.ToLower(pascalCase[0]) + pascalCase.Substring(1);
    }

    /// <summary>
    /// 轉換為有效的 C# 識別符
    /// </summary>
    public static string ToValidCSharpIdentifier(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "Unknown";

        // 移除無效字符
        var identifier = new string(input.Where(c => 
            char.IsLetterOrDigit(c) || c == '_').ToArray());

        // 確保以字母或底線開頭
        if (!char.IsLetter(identifier[0]) && identifier[0] != '_')
        {
            identifier = "_" + identifier;
        }

        // 檢查是否為 C# 關鍵字
        if (IsCSharpKeyword(identifier))
        {
            identifier = "@" + identifier;
        }

        return identifier;
    }

    /// <summary>
    /// 轉換為複數形式
    /// </summary>
    public static string ToPlural(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        // 簡單的複數轉換規則
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
    /// 轉換為單數形式
    /// </summary>
    public static string ToSingular(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        // 簡單的單數轉換規則
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
    /// 生成類別名稱
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
    /// 生成屬性名稱
    /// </summary>
    public static string GeneratePropertyName(string elementPath, string resourceName)
    {
        // 移除資源名稱前綴
        var propertyPath = elementPath;
        if (elementPath.StartsWith($"{resourceName}.", StringComparison.OrdinalIgnoreCase))
        {
            propertyPath = elementPath.Substring(resourceName.Length + 1);
        }

        // 處理選擇類型
        if (propertyPath.Contains("[x]"))
        {
            propertyPath = propertyPath.Replace("[x]", "");
        }

        // 處理嵌套路徑 (只取最後一段)
        var segments = propertyPath.Split('.');
        var propertyName = segments.Last();

        return ToPascalCase(propertyName);
    }

    /// <summary>
    /// 生成命名空間
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
    /// 生成檔案名稱
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
    /// 分割為單詞
    /// </summary>
    private static List<string> SplitIntoWords(string input)
    {
        var words = new List<string>();
        var currentWord = new List<char>();

        for (int i = 0; i < input.Length; i++)
        {
            var currentChar = input[i];

            // 檢查分隔符
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

            // 檢查大寫字母 (駝峰命名)
            if (char.IsUpper(currentChar) && currentWord.Count > 0)
            {
                // 如果不是連續大寫字母，則分割
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
    /// 檢查是否為 C# 關鍵字
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