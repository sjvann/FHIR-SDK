using DataTypeServices.TypeFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using DataTypeServices.FhirParser.ExtensionMethods;
using FhirCore.Interfaces;

namespace DataTypeServices.FhirParser
{
    public static class FhirParser
    {
        public static T? ParseDataType<T>(string value) where T : IDataType, new()
        {
            if (JsonNode.Parse(value) is JsonObject jsonObject)
            {
                return ParseDataType<T>(jsonObject);
            }
            else
            {
                return default;
            }
        }
        public static T? ParseDataType<T>(JsonNode value) where T : IDataType, new()
        {
            return value.ParseForFhirDataType<T>();
        }




    }
}
