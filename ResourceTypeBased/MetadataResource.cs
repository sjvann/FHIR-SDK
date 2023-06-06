using ResourceTypeBased;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace ResourceTypeBased
{
    public abstract class MetadataResource<T>: CanonicalResource<T>   where T : ResourceAbstract, new()
    {
        protected MetadataResource() { }
        protected MetadataResource(string? value) : base(value) { }
        protected MetadataResource(JsonNode source) : base(source)
        {
        }
    }
}
