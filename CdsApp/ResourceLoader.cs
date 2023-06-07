using ResourceTypeBased;
using ResourceTypeBased.ExtensionImp;
using System.Text.Json.Nodes;

namespace CdsApp
{
    public class ResourceLoader
    {
        private readonly JsonNode? _dataSource;

        public ResourceLoader(JsonNode? context)
        {
            _dataSource = context;
        }
        public IEnumerable<T> GetReSource<T>() where T : ResourceAbstract
        {
            List<T> result = new();
            if (_dataSource != null && _dataSource["entry"] is JsonArray entry)
            {
                foreach (var item in entry)
                {

                    JsonNode? resource = item?["resource"];
                    if (resource != null)
                    {
                        var target = resource.ParseToResource<T>();
                        if (target != null)
                        {
                            result.Add(target);
                        }
                    }
                }
            }
            return result;
        }
    }
}
