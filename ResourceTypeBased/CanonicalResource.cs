

using System.Text.Json.Nodes;

namespace ResourceTypeBased
{
    public abstract class CanonicalResource<T> : DomainResource<T>  where T : ResourceAbstract, new()
    {
        protected CanonicalResource() { }
        protected CanonicalResource(string? value) : base(value) { }
        protected CanonicalResource(JsonNode source) : base(source)
        {
        }
    }
}
