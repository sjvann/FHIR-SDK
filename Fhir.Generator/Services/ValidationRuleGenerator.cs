using System.Text;
using System.Text.Json;
using Fhir.Generator.Models;

namespace Fhir.Generator.Services;

/// <summary>
/// 生成 FHIR 驗證規則的程式碼
/// </summary>
public class ValidationRuleGenerator
{
    /// <summary>
    /// 從 StructureDefinition 提取並生成驗證規則
    /// </summary>
    public List<ValidationRule> ExtractValidationRules(JsonElement structDef)
    {
        var rules = new List<ValidationRule>();
        
        if (!structDef.TryGetProperty("snapshot", out var snapshot) ||
            !snapshot.TryGetProperty("element", out var elements))
            return rules;
            
        foreach (var element in elements.EnumerateArray())
        {
            var elementRules = ProcessElementValidation(element);
            rules.AddRange(elementRules);
        }
        
        return rules;
    }
    
    /// <summary>
    /// 處理單個元素的驗證規則
    /// </summary>
    private List<ValidationRule> ProcessElementValidation(JsonElement element)
    {
        var rules = new List<ValidationRule>();
        var path = element.GetProperty("path").GetString()!;
        
        // 1. Cardinality 驗證
        var cardinalityRule = ExtractCardinalityRule(element, path);
        if (cardinalityRule != null)
            rules.Add(cardinalityRule);
            
        // 2. ValueSet 綁定驗證
        var valueSetRule = ExtractValueSetBindingRule(element, path);
        if (valueSetRule != null)
            rules.Add(valueSetRule);
            
        // 3. Constraint 規則
        var constraintRules = ExtractConstraintRules(element, path);
        rules.AddRange(constraintRules);
        
        // 4. 型別驗證
        var typeRule = ExtractTypeValidationRule(element, path);
        if (typeRule != null)
            rules.Add(typeRule);
            
        return rules;
    }
    
    /// <summary>
    /// 提取基數驗證規則
    /// </summary>
    private ValidationRule? ExtractCardinalityRule(JsonElement element, string path)
    {
        if (!element.TryGetProperty("min", out var minElement) ||
            !element.TryGetProperty("max", out var maxElement))
            return null;
            
        var min = minElement.GetInt32();
        var max = maxElement.GetString();
        
        if (min == 0 && max == "1")
            return null; // 預設基數，不需要特殊驗證
            
        return new ValidationRule
        {
            Type = ValidationRuleType.Cardinality,
            ElementPath = path,
            MinCardinality = min,
            MaxCardinality = max,
            ErrorMessage = $"Element '{path}' cardinality must be {min}..{max}"
        };
    }
    
    /// <summary>
    /// 提取 ValueSet 綁定驗證規則
    /// </summary>
    private ValidationRule? ExtractValueSetBindingRule(JsonElement element, string path)
    {
        if (!element.TryGetProperty("binding", out var binding))
            return null;
            
        if (!binding.TryGetProperty("valueSet", out var valueSetElement) ||
            !binding.TryGetProperty("strength", out var strengthElement))
            return null;
            
        var valueSet = valueSetElement.GetString();
        var strength = strengthElement.GetString();
        
        // 檢查 null 值
        if (valueSet == null || strength == null)
            return null;
        
        // 只對 required 和 extensible 綁定生成驗證
        if (strength != "required" && strength != "extensible")
            return null;
            
        return new ValidationRule
        {
            Type = ValidationRuleType.ValueSetBinding,
            ElementPath = path,
            ValueSetUrl = valueSet,
            BindingStrength = strength,
            ErrorMessage = $"Element '{path}' must be bound to ValueSet '{valueSet}' with {strength} strength"
        };
    }
    
    /// <summary>
    /// 提取約束規則
    /// </summary>
    private List<ValidationRule> ExtractConstraintRules(JsonElement element, string path)
    {
        var rules = new List<ValidationRule>();
        
        if (!element.TryGetProperty("constraint", out var constraints))
            return rules;
            
        foreach (var constraint in constraints.EnumerateArray())
        {
            if (!constraint.TryGetProperty("key", out var keyElement) ||
                !constraint.TryGetProperty("severity", out var severityElement) ||
                !constraint.TryGetProperty("expression", out var expressionElement))
                continue;
                
            var key = keyElement.GetString()!;
            var severity = severityElement.GetString()!;
            var expression = expressionElement.GetString()!;
            var human = constraint.TryGetProperty("human", out var humanElement) 
                ? humanElement.GetString() 
                : $"Constraint {key} failed";
                
            rules.Add(new ValidationRule
            {
                Type = ValidationRuleType.Constraint,
                ElementPath = path,
                ConstraintKey = key,
                ConstraintExpression = expression,
                Severity = severity,
                ErrorMessage = human ?? $"Constraint {key} failed"
            });
        }
        
        return rules;
    }
    
    /// <summary>
    /// 提取型別驗證規則
    /// </summary>
    private ValidationRule? ExtractTypeValidationRule(JsonElement element, string path)
    {
        if (!element.TryGetProperty("type", out var types))
            return null;
            
        var typeList = new List<string>();
        foreach (var type in types.EnumerateArray())
        {
            if (type.TryGetProperty("code", out var codeElement))
            {
                typeList.Add(codeElement.GetString()!);
            }
        }
        
        if (typeList.Count <= 1)
            return null; // 單一型別不需要特殊驗證
            
        return new ValidationRule
        {
            Type = ValidationRuleType.TypeValidation,
            ElementPath = path,
            AllowedTypes = typeList,
            ErrorMessage = $"Element '{path}' must be one of types: {string.Join(", ", typeList)}"
        };
    }
    
    /// <summary>
    /// 生成驗證方法的程式碼
    /// </summary>
    public string GenerateValidationCode(List<ValidationRule> rules, string className)
    {
        if (!rules.Any())
            return string.Empty;
            
        var sb = new StringBuilder();
        
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// Validates this instance according to FHIR rules");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)");
        sb.AppendLine("    {");
        sb.AppendLine("        foreach (var result in base.Validate(validationContext))");
        sb.AppendLine("            yield return result;");
        sb.AppendLine();
        
        // 按類型分組生成驗證規則
        var cardinalityRules = rules.Where(r => r.Type == ValidationRuleType.Cardinality).ToList();
        var valueSetRules = rules.Where(r => r.Type == ValidationRuleType.ValueSetBinding).ToList();
        var constraintRules = rules.Where(r => r.Type == ValidationRuleType.Constraint).ToList();
        
        if (cardinalityRules.Any())
        {
            sb.AppendLine("        // Cardinality validation");
            foreach (var rule in cardinalityRules)
            {
                GenerateCardinalityValidation(sb, rule);
            }
            sb.AppendLine();
        }
        
        if (valueSetRules.Any())
        {
            sb.AppendLine("        // ValueSet binding validation");
            foreach (var rule in valueSetRules)
            {
                GenerateValueSetValidation(sb, rule);
            }
            sb.AppendLine();
        }
        
        if (constraintRules.Any())
        {
            sb.AppendLine("        // Constraint validation");
            foreach (var rule in constraintRules)
            {
                GenerateConstraintValidation(sb, rule);
            }
        }
        
        sb.AppendLine("    }");
        
        return sb.ToString();
    }
    
    private void GenerateCardinalityValidation(StringBuilder sb, ValidationRule rule)
    {
        var propertyName = GetPropertyNameFromPath(rule.ElementPath);
        var isArray = rule.MaxCardinality == "*" || (int.TryParse(rule.MaxCardinality, out var max) && max > 1);
        
        if (isArray)
        {
            sb.AppendLine($"        // Validate {propertyName} cardinality");
            sb.AppendLine($"        var {propertyName.ToLower()}Count = {propertyName}?.Count ?? 0;");
            sb.AppendLine($"        if ({propertyName.ToLower()}Count < {rule.MinCardinality})");
            sb.AppendLine("        {");
            sb.AppendLine($"            yield return new ValidationResult(\"{rule.ErrorMessage}\", new[] {{ nameof({propertyName}) }});");
            sb.AppendLine("        }");
            
            if (rule.MaxCardinality != "*")
            {
                sb.AppendLine($"        if ({propertyName.ToLower()}Count > {rule.MaxCardinality})");
                sb.AppendLine("        {");
                sb.AppendLine($"            yield return new ValidationResult(\"{rule.ErrorMessage}\", new[] {{ nameof({propertyName}) }});");
                sb.AppendLine("        }");
            }
        }
        else
        {
            if (rule.MinCardinality > 0)
            {
                sb.AppendLine($"        if ({propertyName} == null)");
                sb.AppendLine("        {");
                sb.AppendLine($"            yield return new ValidationResult(\"{rule.ErrorMessage}\", new[] {{ nameof({propertyName}) }});");
                sb.AppendLine("        }");
            }
        }
    }
    
    private void GenerateValueSetValidation(StringBuilder sb, ValidationRule rule)
    {
        var propertyName = GetPropertyNameFromPath(rule.ElementPath);
        
        sb.AppendLine($"        // Validate {propertyName} ValueSet binding");
        sb.AppendLine($"        if ({propertyName} != null)");
        sb.AppendLine("        {");
        sb.AppendLine($"            // TODO: Implement ValueSet validation for {rule.ValueSetUrl}");
        sb.AppendLine("            // This requires a terminology service or local ValueSet cache");
        sb.AppendLine("        }");
    }
    
    private void GenerateConstraintValidation(StringBuilder sb, ValidationRule rule)
    {
        var propertyName = GetPropertyNameFromPath(rule.ElementPath);
        
        sb.AppendLine($"        // Constraint: {rule.ConstraintKey}");
        sb.AppendLine($"        // Expression: {rule.ConstraintExpression}");
        sb.AppendLine($"        // TODO: Implement FHIRPath expression evaluation");
        sb.AppendLine($"        // if (!EvaluateFHIRPath(\"{rule.ConstraintExpression}\"))");
        sb.AppendLine("        // {");
        sb.AppendLine($"        //     yield return new ValidationResult(\"{rule.ErrorMessage}\", new[] {{ nameof({propertyName}) }});");
        sb.AppendLine("        // }");
    }
    
    private string GetPropertyNameFromPath(string path)
    {
        var parts = path.Split('.');
        var elementName = parts.Last();
        
        // 移除 [x] 後綴
        if (elementName.EndsWith("[x]"))
            elementName = elementName[..^3];
            
        // 轉換為 PascalCase
        return char.ToUpper(elementName[0]) + elementName[1..];
    }
}
