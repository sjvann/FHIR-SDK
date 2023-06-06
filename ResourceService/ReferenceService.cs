using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace ResourceMgr
{
    public static class ReferenceService<T> where T : Resource
    {
        public static List<T> GetReference(Uri uri, string token = "")
        {
            List<T> result = new();
            HttpClient client = new();
            FhirJsonParser parser = new();
            client.DefaultRequestHeaders.Add("Accept", "application/json+fhir");
            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            }
            HttpResponseMessage rm = client.GetAsync(uri).Result;
            if (rm.IsSuccessStatusCode)
            {
                var target = rm.Content.ReadAsStringAsync().Result;
                if (target != null)
                {
                    Resource r = parser.Parse<Resource>(target);
                    if (r.TypeName == "Bundle")
                    {
                        Bundle bundle = (Bundle)r;
                        if (bundle.Total > 0)
                        {
                            foreach (var m in bundle.Entry)
                            {
                                var resource = m.Resource;
                                result.Add((T)resource);
                            }
                        }
                    }
                    else
                    {
                        result.Add((T)r);
                    }
                }
            }
            return result;
        }
    }
}

