using System.Text.RegularExpressions;
using Fhir.TypeFramework.Abstractions;

namespace Fhir.TypeFramework.Query;

/// <summary>
/// FHIR Path 查詢器
/// 提供 FHIR Path 語法的查詢功能
/// </summary>
public class FhirPathQuery
{
    private static readonly Dictionary<string, Func<object, object?, bool>> _operators = new();
    private static readonly object _lock = new();
    
    /// <summary>
    /// 靜態建構函式，註冊預設運算子
    /// </summary>
    static FhirPathQuery()
    {
        RegisterDefaultOperators();
    }
    
    /// <summary>
    /// 執行 FHIR Path 查詢
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="path">FHIR Path 表達式</param>
    /// <returns>查詢結果</returns>
    public static IEnumerable<T> Query<T>(IEnumerable<T> resources, string path) 
        where T : ITypeFramework
    {
        if (string.IsNullOrEmpty(path))
            return resources;
        
        try
        {
            var parsedPath = ParsePath(path);
            return resources.Where(resource => EvaluatePath(resource, parsedPath));
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"FHIR Path query failed: {ex.Message}", ex);
        }
    }
    
    /// <summary>
    /// 執行複雜查詢
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resources">資源集合</param>
    /// <param name="query">查詢條件</param>
    /// <returns>查詢結果</returns>
    public static IEnumerable<T> Query<T>(IEnumerable<T> resources, FhirPathQueryCondition query) 
        where T : ITypeFramework
    {
        return resources.Where(resource => EvaluateCondition(resource, query));
    }
    
    /// <summary>
    /// 解析 FHIR Path
    /// </summary>
    /// <param name="path">FHIR Path 表達式</param>
    /// <returns>解析後的查詢條件</returns>
    private static FhirPathQueryCondition ParsePath(string path)
    {
        // 簡單的 FHIR Path 解析器
        // 支援基本語法：resourceType.property[condition]
        
        var condition = new FhirPathQueryCondition();
        
        // 解析基本路徑
        var pathParts = path.Split('.');
        if (pathParts.Length >= 2)
        {
            condition.ResourceType = pathParts[0];
            condition.Property = pathParts[1];
        }
        
        // 解析條件
        var conditionMatch = Regex.Match(path, @"\[(.*?)\]");
        if (conditionMatch.Success)
        {
            var conditionText = conditionMatch.Groups[1].Value;
            ParseCondition(conditionText, condition);
        }
        
        return condition;
    }
    
    /// <summary>
    /// 解析條件
    /// </summary>
    /// <param name="conditionText">條件文字</param>
    /// <param name="condition">查詢條件</param>
    private static void ParseCondition(string conditionText, FhirPathQueryCondition condition)
    {
        // 支援基本運算子：=, !=, >, <, >=, <=
        var operators = new[] { "!=", ">=", "<=", "=", ">", "<" };
        
        foreach (var op in operators)
        {
            if (conditionText.Contains(op))
            {
                var parts = conditionText.Split(new[] { op }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    condition.Operator = op;
                    condition.Property = parts[0].Trim();
                    condition.Value = parts[1].Trim().Trim('"', '\'');
                    break;
                }
            }
        }
    }
    
    /// <summary>
    /// 評估路徑
    /// </summary>
    /// <param name="resource">資源</param>
    /// <param name="condition">查詢條件</param>
    /// <returns>是否匹配</returns>
    private static bool EvaluatePath(ITypeFramework resource, FhirPathQueryCondition condition)
    {
        // 檢查資源型別
        if (!string.IsNullOrEmpty(condition.ResourceType) && 
            resource.GetType().Name != condition.ResourceType)
        {
            return false;
        }
        
        // 如果沒有條件，直接返回 true
        if (string.IsNullOrEmpty(condition.Operator))
        {
            return true;
        }
        
        // 評估條件
        return EvaluateCondition(resource, condition);
    }
    
    /// <summary>
    /// 評估條件
    /// </summary>
    /// <param name="resource">資源</param>
    /// <param name="condition">查詢條件</param>
    /// <returns>是否匹配</returns>
    private static bool EvaluateCondition(ITypeFramework resource, FhirPathQueryCondition condition)
    {
        try
        {
            // 取得屬性值
            var propertyValue = GetPropertyValue(resource, condition.Property);
            
            // 執行運算子
            if (_operators.TryGetValue(condition.Operator, out var operatorFunc))
            {
                return operatorFunc(propertyValue, condition.Value);
            }
            
            return false;
        }
        catch
        {
            return false;
        }
    }
    
    /// <summary>
    /// 取得屬性值
    /// </summary>
    /// <param name="resource">資源</param>
    /// <param name="propertyName">屬性名稱</param>
    /// <returns>屬性值</returns>
    private static object? GetPropertyValue(ITypeFramework resource, string propertyName)
    {
        var property = resource.GetType().GetProperty(propertyName);
        if (property != null)
        {
            return property.GetValue(resource);
        }
        
        // 處理特殊屬性
        return propertyName.ToLower() switch
        {
            "id" => resource is IIdentifiableTypeFramework identifiable ? identifiable.Id : null,
            "extension" => resource is IExtensibleTypeFramework extensible ? extensible.Extension : null,
            _ => null
        };
    }
    
    /// <summary>
    /// 註冊預設運算子
    /// </summary>
    private static void RegisterDefaultOperators()
    {
        lock (_lock)
        {
            // 等於運算子
            _operators["="] = (value, expected) => 
                value?.ToString()?.Equals(expected?.ToString(), StringComparison.OrdinalIgnoreCase) == true;
            
            // 不等於運算子
            _operators["!="] = (value, expected) => 
                !value?.ToString()?.Equals(expected?.ToString(), StringComparison.OrdinalIgnoreCase) == true;
            
            // 大於運算子
            _operators[">"] = (value, expected) => 
                value is IComparable comparable && 
                expected != null && 
                comparable.CompareTo(Convert.ChangeType(expected, value.GetType())) > 0;
            
            // 小於運算子
            _operators["<"] = (value, expected) => 
                value is IComparable comparable && 
                expected != null && 
                comparable.CompareTo(Convert.ChangeType(expected, value.GetType())) < 0;
            
            // 大於等於運算子
            _operators[">="] = (value, expected) => 
                value is IComparable comparable && 
                expected != null && 
                comparable.CompareTo(Convert.ChangeType(expected, value.GetType())) >= 0;
            
            // 小於等於運算子
            _operators["<="] = (value, expected) => 
                value is IComparable comparable && 
                expected != null && 
                comparable.CompareTo(Convert.ChangeType(expected, value.GetType())) <= 0;
        }
    }
    
    /// <summary>
    /// 註冊自訂運算子
    /// </summary>
    /// <param name="operatorSymbol">運算子符號</param>
    /// <param name="operatorFunc">運算子函數</param>
    public static void RegisterOperator(string operatorSymbol, Func<object, object?, bool> operatorFunc)
    {
        lock (_lock)
        {
            _operators[operatorSymbol] = operatorFunc;
        }
    }
}

/// <summary>
/// FHIR Path 查詢條件
/// </summary>
public class FhirPathQueryCondition
{
    /// <summary>
    /// 資源型別
    /// </summary>
    public string? ResourceType { get; set; }
    
    /// <summary>
    /// 屬性名稱
    /// </summary>
    public string? Property { get; set; }
    
    /// <summary>
    /// 運算子
    /// </summary>
    public string? Operator { get; set; }
    
    /// <summary>
    /// 比較值
    /// </summary>
    public string? Value { get; set; }
    
    /// <summary>
    /// 子條件
    /// </summary>
    public List<FhirPathQueryCondition> SubConditions { get; set; } = new();
    
    /// <summary>
    /// 邏輯運算子 (AND, OR)
    /// </summary>
    public string? LogicalOperator { get; set; }
} 