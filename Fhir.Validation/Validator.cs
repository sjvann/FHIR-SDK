using Fhir.Support.Versioning;
using Fhir.Support.Interfaces;
using Fhir.Support.Models;
using System.Collections.Generic;

namespace Fhir.Validation;

/// <summary>
/// 提供 FHIR 资源对象的验证功能。
/// 此验证器是版本无关的，它依赖于 <see cref="FhirContext"/> 来取得特定版本的模型和 Profile 约束信息。
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
    /// 验证一个 FHIR 资源对象是否符合其 Profile 中定义的约束。
    /// </summary>
    /// <param name="resource">要验证的 FHIR 资源对象。</param>
    /// <returns>一个包含所有验证问题的列表。如果列表为空，表示验证通过。</returns>
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