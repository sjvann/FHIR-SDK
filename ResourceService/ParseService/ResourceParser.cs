using Core.ExtensionImp;
using ResourceTypeBased;
using ResourceTypeServices.R5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace ResourceService.ParseService
{
    public static class ResourceParser
    {
        
        public static T? ParseToResource<T>(this JsonNode source) where T : Resource
        {
            if (source == null) return null;
            return (T?)Activator.CreateInstance(typeof(T), source);
        }

        public static T? ParseToResource<T>(this string source) where T : Resource
        {
            if (source == null) return null;
            return (T?)Activator.CreateInstance(typeof(T), source.Parse());
        }
    }
}
