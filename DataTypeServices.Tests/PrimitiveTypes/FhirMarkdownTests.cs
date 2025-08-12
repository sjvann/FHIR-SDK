using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    public class FhirMarkdownTests : PrimitiveTypeTestBase<FhirMarkdown>
    {
        public override string[] GetValidValues()
        {
            return new[]
            {
                "# Heading",
                "**Bold text**",
                "*Italic text*",
                "`code`",
                "```\ncode block\n```",
                "Link: [text](url)",
                "Simple text content"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                ""
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Markdown";
        }

        public override FhirMarkdown CreateInstance(string value)
        {
            return new FhirMarkdown(value);
        }

        public override FhirMarkdown CreateNullInstance()
        {
            return new FhirMarkdown((string?)null);
        }

        protected override object? GetValueFromInstance(FhirMarkdown instance)
        {
            return instance.Value;
        }
    }
} 