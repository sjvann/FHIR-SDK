using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace FhirCore.ExtensionMethods
{
    public static class StringExtension
    {
        #region Based64
        public static string Based64Encode(this string source)
        {
            if (string.IsNullOrEmpty(source)) { return string.Empty; }
            var ptextbyte = Encoding.UTF8.GetBytes(source);
            return Convert.ToBase64String(ptextbyte);
        }
        public static string Based64Decode(this string source)
        {
            if (string.IsNullOrEmpty(source)) { return string.Empty; }
            var base64EncodedBytes = Convert.FromBase64String(source);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        #endregion
        public static string ToTitleCase(this string source, bool setUpperCase = true)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;
            if (setUpperCase)
                return source.First().ToString().ToUpper() + source.Substring(1);
            else
                return source.First().ToString().ToLower() + source.Substring(1);

        }
    }

    public static class DeserializeExtensions
    {
        private static JsonSerializerOptions defaultSerializerSettings = new();

        // set this up how you need to!
        private static JsonSerializerOptions featureCustomerSettings = new JsonSerializerOptions()
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = true
        };
        public static string SerializeCustom(this JsonObject json)
        {
            return JsonSerializer.Serialize(json, featureCustomerSettings);
        }
        public static string SerializeDefault(this JsonObject json)
        {
            return JsonSerializer.Serialize(json, defaultSerializerSettings);
        }
        public static T? Deserializer<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json, defaultSerializerSettings);
        }

        public static T? DeserializerCustom<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json, featureCustomerSettings);
        }
    }



}
