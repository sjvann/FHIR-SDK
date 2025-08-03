using System.Text.Json.Nodes;

namespace FhirCore.Interfaces
{
    /// <summary>
    /// FHIR 資料類型基礎介面
    ///
    /// <para>
    /// 定義所有 FHIR 資料類型的基本行為和屬性。此介面提供了資料類型的核心功能，
    /// 包括類型識別、JSON 序列化支援和類型名稱獲取。
    /// </para>
    ///
    /// <example>
    /// <code>
    /// public class MyDataType : IDataType
    /// {
    ///     public bool IsPrimitive() => false;
    ///     public bool IsComplex() => true;
    ///     public bool IsChoiceType() => false;
    ///     public string GetFhirTypeName(bool withCapital = true) => withCapital ? "MyDataType" : "myDataType";
    ///     public JsonNode? GetJsonObject() => new JsonObject();
    /// }
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 所有 FHIR 資料類型都必須實作此介面，確保基本功能的一致性。
    /// 介面定義了資料類型的最小必要行為集合。
    /// </para>
    /// </remarks>
    public interface IDataType
    {
        /// <summary>
        /// 判斷此資料類型是否為原始類型
        ///
        /// <para>
        /// 原始類型是 FHIR 中最基本的資料類型，如 string、integer、boolean 等。
        /// 這些類型通常直接對應到 JSON 的基本值類型。
        /// </para>
        /// </summary>
        /// <returns>如果是原始類型則返回 true，否則返回 false</returns>
        /// <example>
        /// <code>
        /// var stringType = new FhirString("test");
        /// bool isPrimitive = stringType.IsPrimitive(); // 返回 true
        ///
        /// var address = new Address();
        /// bool isPrimitive2 = address.IsPrimitive(); // 返回 false
        /// </code>
        /// </example>
        public bool IsPrimitive();

        /// <summary>
        /// 判斷此資料類型是否為複雜類型
        ///
        /// <para>
        /// 複雜類型是由多個屬性組成的資料類型，如 Address、HumanName、Period 等。
        /// 這些類型在 JSON 中表示為物件。
        /// </para>
        /// </summary>
        /// <returns>如果是複雜類型則返回 true，否則返回 false</returns>
        /// <example>
        /// <code>
        /// var address = new Address();
        /// bool isComplex = address.IsComplex(); // 返回 true
        ///
        /// var stringType = new FhirString("test");
        /// bool isComplex2 = stringType.IsComplex(); // 返回 false
        /// </code>
        /// </example>
        public bool IsComplex();

        /// <summary>
        /// 判斷此資料類型是否為選擇類型
        ///
        /// <para>
        /// 選擇類型允許在多種不同的資料類型中選擇一種，通常用於 FHIR 中的 choice 元素。
        /// 例如，value[x] 可以是 valueString、valueInteger、valueBoolean 等。
        /// </para>
        /// </summary>
        /// <returns>如果是選擇類型則返回 true，否則返回 false</returns>
        /// <example>
        /// <code>
        /// var choiceType = new ChoiceType&lt;FhirString, FhirInteger&gt;();
        /// bool isChoice = choiceType.IsChoiceType(); // 返回 true
        ///
        /// var stringType = new FhirString("test");
        /// bool isChoice2 = stringType.IsChoiceType(); // 返回 false
        /// </code>
        /// </example>
        public bool IsChoiceType();

        /// <summary>
        /// 獲取 FHIR 類型名稱
        ///
        /// <para>
        /// 返回此資料類型在 FHIR 規範中的正式名稱。這個名稱用於序列化、
        /// 驗證和與其他 FHIR 系統的互操作性。
        /// </para>
        /// </summary>
        /// <param name="withCapital">是否首字母大寫，預設為 true</param>
        /// <returns>FHIR 類型名稱</returns>
        /// <example>
        /// <code>
        /// var stringType = new FhirString("test");
        /// string typeName1 = stringType.GetFhirTypeName(); // 返回 "String"
        /// string typeName2 = stringType.GetFhirTypeName(false); // 返回 "string"
        ///
        /// var address = new Address();
        /// string typeName3 = address.GetFhirTypeName(); // 返回 "Address"
        /// </code>
        /// </example>
        public string GetFhirTypeName(bool withCapital = true);

        /// <summary>
        /// 獲取此資料類型的 JSON 物件表示
        ///
        /// <para>
        /// 將此資料類型轉換為 JsonNode 物件，用於序列化和與其他系統的資料交換。
        /// 如果資料類型沒有值或為空，可能返回 null。
        /// </para>
        /// </summary>
        /// <returns>表示此資料類型的 JsonNode，如果沒有值則返回 null</returns>
        /// <example>
        /// <code>
        /// var stringType = new FhirString("test");
        /// JsonNode? jsonNode = stringType.GetJsonObject();
        /// // jsonNode 包含 "test" 的 JSON 表示
        ///
        /// var emptyType = new FhirString();
        /// JsonNode? jsonNode2 = emptyType.GetJsonObject(); // 可能返回 null
        /// </code>
        /// </example>
        public JsonNode? GetJsonObject();
    }
}
