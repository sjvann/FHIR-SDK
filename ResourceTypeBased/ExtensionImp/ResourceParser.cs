using Core.ExtensionImp;
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
    }
}
