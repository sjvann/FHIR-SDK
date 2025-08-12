

namespace TerminologyService.Models
{
    [AttributeUsage(AttributeTargets.Enum)]
    public class ValueSetAttribute : Attribute
    {
        public ValueSetAttribute(string computableName, string version, string officialUrl)
        {
            ComputableName = computableName;
            Version = version;
            OfficialUrl = officialUrl;
        }

        public string? ComputableName { get; init; }
        public string? Version { get; init; }
        public string? OfficialUrl { get; init; }

    }
}
