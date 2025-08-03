using DataTypeServices.Serialization;
using FhirCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeServices.TypeFramework
{
    /// <summary>
    /// FHIR 資料類型基礎抽象類別
    ///
    /// <para>
    /// 提供所有 FHIR 資料類型的基本功能實作，包括序列化、反序列化、
    /// JSON 處理和類型識別。此類別繼承自 Element 並實作 IDataType 介面。
    /// </para>
    ///
    /// <example>
    /// <code>
    /// public class MyCustomType : DataType
    /// {
    ///     public override bool IsPrimitive() => false;
    ///     public override bool IsComplex() => true;
    ///     public override bool IsChoiceType() => false;
    ///     public override string GetFhirTypeName(bool withCapital = true) => "MyCustomType";
    /// }
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 此抽象類別提供了現代化的序列化方法，支援多種格式的資料轉換，
    /// 並提供了靜態方法用於從各種格式創建實例。
    /// </para>
    /// </remarks>
    public abstract class DataType : Element, IDataType
    {
        #region Constructors

        /// <summary>
        /// 預設建構函數
        /// </summary>
        protected DataType() { }

        /// <summary>
        /// 從 JsonNode 建構實例
        /// </summary>
        /// <param name="value">JSON 節點值</param>
        protected DataType(JsonNode? value) { }

        /// <summary>
        /// 從 JSON 字串建構實例
        /// </summary>
        /// <param name="value">JSON 字串</param>
        protected DataType(string value) : this(JsonNode.Parse(value)) { }

        /// <summary>
        /// 獲取此資料類型的 JSON 物件表示
        /// </summary>
        /// <returns>JSON 物件，如果沒有屬性則返回 null</returns>
        public virtual JsonNode? GetJsonObject()
        {
            return (_Properties != null && _Properties.Count > 0) ? new JsonObject(_Properties) : null;
        }

        #endregion

        #region Implement Interface

        /// <summary>
        /// 判斷此資料類型是否為選擇類型
        /// </summary>
        /// <returns>如果是選擇類型則返回 true</returns>
        public abstract bool IsChoiceType();

        /// <summary>
        /// 判斷此資料類型是否為複雜類型
        /// </summary>
        /// <returns>如果是複雜類型則返回 true</returns>
        public abstract bool IsComplex();

        /// <summary>
        /// 判斷此資料類型是否為原始類型
        /// </summary>
        /// <returns>如果是原始類型則返回 true</returns>
        public abstract bool IsPrimitive();

        #endregion
        protected static List<KeyValuePair<string, JsonNode?>> InitProperty(JsonObject? dataSource)
        {
            List<KeyValuePair<string, JsonNode?>> properties = [];
            if (dataSource == null) return properties;
            foreach (var item in dataSource)
            {
                properties.Add(new KeyValuePair<string, JsonNode?>(item.Key, item.Value));
            }
            return properties;
        }

        #region Modern Serialization Methods

        /// <summary>
        /// 使用現代化序列化器序列化為 JSON
        /// </summary>
        /// <param name="writeIndented">是否格式化輸出</param>
        /// <returns>JSON 字符串</returns>
        public virtual string ToJson(bool writeIndented = false)
        {
            return FhirJsonSerializer.Serialize(this, writeIndented);
        }

        /// <summary>
        /// 使用現代化序列化器序列化為指定格式
        /// </summary>
        /// <param name="format">序列化格式</param>
        /// <returns>序列化後的字符串</returns>
        public virtual string Serialize(FhirSerializationFormat format = FhirSerializationFormat.Json)
        {
            return FhirSerializer.Serialize(this, format);
        }

        /// <summary>
        /// 從 JSON 字符串創建實例（靜態方法）
        /// </summary>
        /// <typeparam name="T">目標類型</typeparam>
        /// <param name="json">JSON 字符串</param>
        /// <returns>反序列化的實例</returns>
        public static T? FromJson<T>(string json) where T : IDataType
        {
            return FhirJsonSerializer.Deserialize<T>(json);
        }

        /// <summary>
        /// 從指定格式的字符串創建實例（靜態方法）
        /// </summary>
        /// <typeparam name="T">目標類型</typeparam>
        /// <param name="data">序列化的資料</param>
        /// <param name="format">資料格式</param>
        /// <returns>反序列化的實例</returns>
        public static T? Deserialize<T>(string data, FhirSerializationFormat format = FhirSerializationFormat.Json) where T : IDataType
        {
            return FhirSerializer.Deserialize<T>(data, format);
        }

        /// <summary>
        /// 自動檢測格式並反序列化（靜態方法）
        /// </summary>
        /// <typeparam name="T">目標類型</typeparam>
        /// <param name="data">序列化的資料</param>
        /// <returns>反序列化的實例</returns>
        public static T? DeserializeAuto<T>(string data) where T : IDataType
        {
            return FhirSerializer.DeserializeAuto<T>(data);
        }

        #endregion
    }
}
