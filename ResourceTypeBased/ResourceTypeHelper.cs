using System.Text.Json.Nodes;

namespace ResourceTypeBased
{
    public static class ResourceTypeHelper
    {
        public static bool CheckResourceType(JsonNode? source, string name)
        {

            return CheckResourceType(source?.AsObject(), name);

        }

        public static bool CheckResourceType(JsonObject? source, string name)
        {
            bool result = false;
            if (source != null)
            {
                var type = source["resourceType"];
                if (type != null)
                {
                    result = type.ToString() == name;
                }
            }
            return result;
        }
    }
}
