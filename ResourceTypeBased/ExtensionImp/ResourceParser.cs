using System.Text.Json.Nodes;

namespace ResourceTypeBased.ExtensionImp
{
    public static class ResourceParser
    {

        public static T? ParseToResource<T>(this JsonNode source) where T : ResourceAbstract
        {
            if (source == null) return null;
            return (T?)Activator.CreateInstance(typeof(T), source);

        }

        public static T? ParseToResource<T>(this string source) where T : ResourceAbstract
        {
            if (source == null) return null;
            return (T?)Activator.CreateInstance(typeof(T), source);
        }
        public static IEnumerable<T>? ParseToResourceFromBundle<T>(this JsonNode source) where T : ResourceAbstract
        {
            List<T> result = new();
             JsonObject bundle = source.AsObject();

            if (ResourceTypeHelper.CheckResourceType(source, "Bundle"))
            {
               
                var entry = bundle["entry"]?.AsArray();
                if (entry != null && entry.Any())
                {
                    foreach (var r in entry)
                    {
                        if (r != null)
                        {
                            var resource = (T?)Activator.CreateInstance(typeof(T), r);
                            if (resource != null)
                            {
                                result.Add(resource);
                            }
                        }
                    }
                }
            }

            return result;
        }

    }
}
