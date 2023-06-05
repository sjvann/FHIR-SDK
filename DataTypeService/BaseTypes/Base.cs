using Core.Attribute;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace DataTypeService.BaseTypes
{
    public abstract class Base
    {
        /// <summary>
        /// 類別名稱
        /// </summary>
        protected virtual string? _TypeName { get; }
        /// <summary>
        /// 存放JsonNode結構
        /// </summary>
        protected JsonNode? _JsonNode;

        /// <summary>
        /// 取得FHIR型態名稱
        /// </summary>
        /// <returns>FHIR型態名稱</returns>
        public string ResourceTypeName => _TypeName ?? "Base";
        public string GetTypeName() => _TypeName ?? "Base";

        protected static JsonSerializerOptions JsonSerializerOptions
        {
            get
            {
                return new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true,
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
            }
        }
        /// <summary>
        /// 將多筆資料轉成JsonArray格式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        protected static JsonArray GetJsonArray<T>(IEnumerable<T>? source) where T : Base
        {
            JsonArray target = new();
            if (source != null)
            {
                foreach (var item in source)
                {
                    if (item is IPrimitiveType pt)
                    {
                        target.Add(pt.GetJsonValue());
                    }
                    else if (item is IComplexType ct)
                    {
                        var result = ct.GetJsonNode();
                        target.Add(result);
                    }
                }
            }
            return target;
        }
        protected static JsonArray GetJsonArray(IEnumerable<JsonNode?> source)
        {
            JsonArray target = new();
            if (source != null)
            {
                foreach (var item in source)
                {
                    target.Add(item);
                }
            }
            return target;
        }

    }
}
