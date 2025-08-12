using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace FhirCore.Interfaces
{
    public interface IBase
    {

        string GetFhirTypeName(bool withCapital = true);
        JsonNode? GetJsonNode();
        List<KeyValuePair<string, JsonNode?>>? GetPropertyValues();
        string ToJsonString();
    }
}
