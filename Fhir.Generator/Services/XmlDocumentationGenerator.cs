using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Fhir.Generator.Services;

/// <summary>
/// XML 文件註解生成器
/// 處理 FHIR 文件中的各種特殊情況，確保生成的 XML 註解符合 C# 規範
/// </summary>
public class XmlDocumentationGenerator
{
    private const int MaxLineLength = 120;
    private const int MaxSummaryLength = 500;
    
    /// <summary>
    /// 生成類別的 XML 註解
    /// </summary>
    public string GenerateClassDocumentation(string summary, string? remarks = null, string? example = null)
    {
        var sb = new StringBuilder();
        sb.AppendLine("/// <summary>");
        
        var cleanSummary = CleanDocumentationText(summary);
        var summaryLines = WrapText(cleanSummary, MaxLineLength - 4); // 減去 "/// " 的長度
        
        foreach (var line in summaryLines)
        {
            sb.AppendLine($"/// {line}");
        }
        
        sb.AppendLine("/// </summary>");
        
        if (!string.IsNullOrEmpty(remarks))
        {
            sb.AppendLine("/// <remarks>");
            var cleanRemarks = CleanDocumentationText(remarks);
            var remarksLines = WrapText(cleanRemarks, MaxLineLength - 4);
            
            foreach (var line in remarksLines)
            {
                sb.AppendLine($"/// {line}");
            }
            sb.AppendLine("/// </remarks>");
        }
        
        if (!string.IsNullOrEmpty(example))
        {
            sb.AppendLine("/// <example>");
            var cleanExample = CleanDocumentationText(example);
            var exampleLines = WrapText(cleanExample, MaxLineLength - 4);
            
            foreach (var line in exampleLines)
            {
                sb.AppendLine($"/// {line}");
            }
            sb.AppendLine("/// </example>");
        }
        
        return sb.ToString().TrimEnd();
    }
    
    /// <summary>
    /// 生成屬性的 XML 註解
    /// </summary>
    public string GeneratePropertyDocumentation(string summary, string? fhirPath = null, 
        string? cardinality = null, string[]? allowedTypes = null, bool isRequired = false)
    {
        var sb = new StringBuilder();
        sb.AppendLine("/// <summary>");
        
        var cleanSummary = CleanDocumentationText(summary);
        
        // 限制 summary 長度，避免過長
        if (cleanSummary.Length > MaxSummaryLength)
        {
            cleanSummary = cleanSummary.Substring(0, MaxSummaryLength - 3) + "...";
        }
        
        var summaryLines = WrapText(cleanSummary, MaxLineLength - 4);
        
        foreach (var line in summaryLines)
        {
            sb.AppendLine($"/// {line}");
        }
        
        // 添加額外的 FHIR 資訊
        if (!string.IsNullOrEmpty(fhirPath))
        {
            sb.AppendLine($"/// FHIR Path: {CleanDocumentationText(fhirPath)}");
        }
        
        if (!string.IsNullOrEmpty(cardinality))
        {
            sb.AppendLine($"/// Cardinality: {CleanDocumentationText(cardinality)}");
        }
        
        if (isRequired)
        {
            sb.AppendLine("/// Required: Yes");
        }
        
        if (allowedTypes != null && allowedTypes.Length > 0)
        {
            var typesText = string.Join(", ", allowedTypes.Select(CleanDocumentationText));
            if (typesText.Length > 80)
            {
                sb.AppendLine("/// Allowed types:");
                foreach (var type in allowedTypes)
                {
                    sb.AppendLine($"///   - {CleanDocumentationText(type)}");
                }
            }
            else
            {
                sb.AppendLine($"/// Allowed types: {typesText}");
            }
        }
        
        sb.AppendLine("/// </summary>");
        
        return sb.ToString().TrimEnd();
    }
    
    /// <summary>
    /// 生成方法的 XML 註解
    /// </summary>
    public string GenerateMethodDocumentation(string summary, 
        Dictionary<string, string>? parameters = null, 
        string? returns = null, 
        string[]? exceptions = null)
    {
        var sb = new StringBuilder();
        sb.AppendLine("/// <summary>");
        
        var cleanSummary = CleanDocumentationText(summary);
        var summaryLines = WrapText(cleanSummary, MaxLineLength - 4);
        
        foreach (var line in summaryLines)
        {
            sb.AppendLine($"/// {line}");
        }
        
        sb.AppendLine("/// </summary>");
        
        // 參數註解
        if (parameters != null && parameters.Any())
        {
            foreach (var param in parameters)
            {
                var cleanParamDesc = CleanDocumentationText(param.Value);
                var paramLines = WrapText(cleanParamDesc, MaxLineLength - 20); // 減去參數標籤的長度
                
                if (paramLines.Length == 1)
                {
                    sb.AppendLine($"/// <param name=\"{param.Key}\">{paramLines[0]}</param>");
                }
                else
                {
                    sb.AppendLine($"/// <param name=\"{param.Key}\">");
                    foreach (var line in paramLines)
                    {
                        sb.AppendLine($"/// {line}");
                    }
                    sb.AppendLine("/// </param>");
                }
            }
        }
        
        // 返回值註解
        if (!string.IsNullOrEmpty(returns))
        {
            var cleanReturns = CleanDocumentationText(returns);
            var returnLines = WrapText(cleanReturns, MaxLineLength - 15); // 減去 returns 標籤的長度
            
            if (returnLines.Length == 1)
            {
                sb.AppendLine($"/// <returns>{returnLines[0]}</returns>");
            }
            else
            {
                sb.AppendLine("/// <returns>");
                foreach (var line in returnLines)
                {
                    sb.AppendLine($"/// {line}");
                }
                sb.AppendLine("/// </returns>");
            }
        }
        
        // 異常註解
        if (exceptions != null && exceptions.Length > 0)
        {
            foreach (var exception in exceptions)
            {
                var cleanException = CleanDocumentationText(exception);
                sb.AppendLine($"/// <exception cref=\"{cleanException}\"></exception>");
            }
        }
        
        return sb.ToString().TrimEnd();
    }
    
    /// <summary>
    /// 清理文件文字，處理特殊字元和格式問題
    /// </summary>
    private string CleanDocumentationText(string text)
    {
        if (string.IsNullOrEmpty(text))
            return string.Empty;
        
        // 1. 移除多餘的空白和換行
        text = Regex.Replace(text, @"\s+", " ").Trim();
        
        // 2. 處理 HTML 標籤 - 移除或轉換為純文字
        text = RemoveHtmlTags(text);
        
        // 3. 轉義 XML 特殊字元
        text = EscapeXmlCharacters(text);
        
        // 4. 處理 Unicode 控制字元
        text = RemoveControlCharacters(text);
        
        // 5. 處理引號
        text = text.Replace(""", "\"").Replace(""", "\"");
        text = text.Replace("'", "'").Replace("'", "'");
        
        // 6. 移除多餘的標點符號
        text = Regex.Replace(text, @"\.{2,}", ".");
        
        return text;
    }
    
    /// <summary>
    /// 移除 HTML 標籤
    /// </summary>
    private string RemoveHtmlTags(string text)
    {
        if (string.IsNullOrEmpty(text))
            return string.Empty;
        
        // 保留一些有用的 HTML 標籤，轉換為文字
        var replacements = new Dictionary<string, string>
        {
            { "<br>", " " },
            { "<br/>", " " },
            { "<br />", " " },
            { "<p>", "" },
            { "</p>", ". " },
            { "<li>", "- " },
            { "</li>", " " },
            { "<ul>", "" },
            { "</ul>", "" },
            { "<ol>", "" },
            { "</ol>", "" },
            { "<strong>", "" },
            { "</strong>", "" },
            { "<b>", "" },
            { "</b>", "" },
            { "<em>", "" },
            { "</em>", "" },
            { "<i>", "" },
            { "</i>", "" }
        };
        
        foreach (var replacement in replacements)
        {
            text = text.Replace(replacement.Key, replacement.Value);
        }
        
        // 移除其他所有 HTML 標籤
        text = Regex.Replace(text, @"<[^>]+>", "");
        
        return text;
    }
    
    /// <summary>
    /// 轉義 XML 特殊字元
    /// </summary>
    private string EscapeXmlCharacters(string text)
    {
        if (string.IsNullOrEmpty(text))
            return string.Empty;
        
        return text
            .Replace("&", "&amp;")   // 必須先處理 &
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("\"", "&quot;")
            .Replace("'", "&apos;");
    }
    
    /// <summary>
    /// 移除控制字元
    /// </summary>
    private string RemoveControlCharacters(string text)
    {
        if (string.IsNullOrEmpty(text))
            return string.Empty;
        
        // 移除控制字元，但保留常用的空白字元
        return Regex.Replace(text, @"[\x00-\x08\x0B\x0C\x0E-\x1F\x7F]", "");
    }
    
    /// <summary>
    /// 將文字包裝到指定長度的行
    /// </summary>
    private string[] WrapText(string text, int maxLength)
    {
        if (string.IsNullOrEmpty(text))
            return Array.Empty<string>();
        
        if (text.Length <= maxLength)
            return new[] { text };
        
        var lines = new List<string>();
        var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var currentLine = new StringBuilder();
        
        foreach (var word in words)
        {
            // 如果單個詞太長，強制分割
            if (word.Length > maxLength)
            {
                if (currentLine.Length > 0)
                {
                    lines.Add(currentLine.ToString());
                    currentLine.Clear();
                }
                
                // 分割長詞
                for (int i = 0; i < word.Length; i += maxLength)
                {
                    var chunk = word.Substring(i, Math.Min(maxLength, word.Length - i));
                    lines.Add(chunk);
                }
                continue;
            }
            
            // 檢查是否需要換行
            if (currentLine.Length + word.Length + 1 > maxLength)
            {
                if (currentLine.Length > 0)
                {
                    lines.Add(currentLine.ToString());
                    currentLine.Clear();
                }
            }
            
            if (currentLine.Length > 0)
                currentLine.Append(" ");
            
            currentLine.Append(word);
        }
        
        if (currentLine.Length > 0)
        {
            lines.Add(currentLine.ToString());
        }
        
        return lines.ToArray();
    }
    
    /// <summary>
    /// 生成 Choice Type 屬性的特殊註解
    /// </summary>
    public string GenerateChoiceTypeDocumentation(string baseName, string[] allowedTypes, string? summary = null)
    {
        var sb = new StringBuilder();
        sb.AppendLine("/// <summary>");
        
        if (!string.IsNullOrEmpty(summary))
        {
            var cleanSummary = CleanDocumentationText(summary);
            var summaryLines = WrapText(cleanSummary, MaxLineLength - 4);
            
            foreach (var line in summaryLines)
            {
                sb.AppendLine($"/// {line}");
            }
            sb.AppendLine("///");
        }
        
        sb.AppendLine($"/// Choice Type: {baseName}[x]");
        sb.AppendLine("/// This is a choice element - only one of the following types may be present:");
        
        foreach (var type in allowedTypes)
        {
            sb.AppendLine($"///   - {CleanDocumentationText(type)}");
        }
        
        sb.AppendLine("/// </summary>");
        
        return sb.ToString().TrimEnd();
    }
    
    /// <summary>
    /// 生成 Reference 屬性的特殊註解
    /// </summary>
    public string GenerateReferenceDocumentation(string[] allowedTargets, string? summary = null)
    {
        var sb = new StringBuilder();
        sb.AppendLine("/// <summary>");
        
        if (!string.IsNullOrEmpty(summary))
        {
            var cleanSummary = CleanDocumentationText(summary);
            var summaryLines = WrapText(cleanSummary, MaxLineLength - 4);
            
            foreach (var line in summaryLines)
            {
                sb.AppendLine($"/// {line}");
            }
            sb.AppendLine("///");
        }
        
        sb.AppendLine("/// Reference to:");
        foreach (var target in allowedTargets)
        {
            sb.AppendLine($"///   - {CleanDocumentationText(target)}");
        }
        
        sb.AppendLine("/// </summary>");
        
        return sb.ToString().TrimEnd();
    }
    
    /// <summary>
    /// 生成 BackboneElement 的特殊註解
    /// </summary>
    public string GenerateBackboneElementDocumentation(string resourceName, string elementName, string? summary = null)
    {
        var sb = new StringBuilder();
        sb.AppendLine("/// <summary>");
        
        if (!string.IsNullOrEmpty(summary))
        {
            var cleanSummary = CleanDocumentationText(summary);
            var summaryLines = WrapText(cleanSummary, MaxLineLength - 4);
            
            foreach (var line in summaryLines)
            {
                sb.AppendLine($"/// {line}");
            }
            sb.AppendLine("///");
        }
        
        sb.AppendLine($"/// BackboneElement for {resourceName}.{elementName}");
        sb.AppendLine("/// This element is defined within the resource and contains additional");
        sb.AppendLine("/// structured information that is part of the resource definition.");
        sb.AppendLine("/// </summary>");
        
        return sb.ToString().TrimEnd();
    }
    
    /// <summary>
    /// 驗證生成的 XML 註解是否有效
    /// </summary>
    public bool ValidateXmlDocumentation(string xmlDoc)
    {
        try
        {
            // 簡單的 XML 驗證
            var testXml = $"<root>{xmlDoc.Replace("///", "").Replace("/// ", "")}</root>";
            var doc = System.Xml.Linq.XDocument.Parse(testXml);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
