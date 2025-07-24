using Fhir.Support.Versioning;
using Fhir.Support.Interfaces;
using Fhir.Support.Models;
using System.Collections.Generic;

namespace Fhir.Validation;

/// <summary>
/// Provides functionality to validate FHIR resource objects against their definitional constraints.
/// This validator is version-aware and relies on an <see cref="IFhirContext"/>
/// to access version-specific model information and profile constraints.
/// </summary>
public class Validator : IFhirValidator
{
    private readonly IFhirContext _context;

    /// <summary>
    /// 初始化 <see cref="Validator"/> 的新实例。
    /// </summary>
    /// <param name="context">要使用的 FHIR 上下文。</param>
    public Validator(IFhirContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Validates a FHIR resource object against its base specification and any associated profiles.
    /// </summary>
    /// <param name="resource">The FHIR resource instance to validate.</param>
    /// <returns>
    /// A list of <see cref="ValidationIssue"/> objects.
    /// If the list is empty, the validation was successful.
    /// </returns>
    public List<ValidationIssue> Validate(IResource resource)
    {
        var issues = new List<ValidationIssue>();
        if (resource == null)
        {
            issues.Add(new ValidationIssue(IssueSeverity.Fatal, "资源实例不能为 null。", "Resource"));
            return issues;
        }

        // 递归验证逻辑将从这里开始
        ValidateObject(resource, resource.GetType().Name, issues);

        return issues;
    }

    private void ValidateObject(object obj, string path, List<ValidationIssue> issues)
    {
        // TODO: 使用反射读取 obj 的属性和 Attribute，并根据规则进行验证
        // 1. 验证 Cardinality (基数)
        // 2. 验证 MustSupport
        // 3. 验证 ValueSet 绑定
        // 4. 递归调用 ValidateObject 处理 Complex Type
    }
} 