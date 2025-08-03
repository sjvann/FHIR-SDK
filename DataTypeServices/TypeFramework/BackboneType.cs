using System.Collections.ObjectModel;
using DataTypeServices.DataTypes.SpecialTypes;
using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;

namespace DataTypeServices.TypeFramework
{
    /// <summary>
    /// FHIR Backbone Type 基礎類別
    ///
    /// <para>
    /// 提供所有 FHIR Backbone Type 的基本功能，包括修飾符擴展。
    /// </para>
    /// </summary>
    /// <typeparam name="T">繼承的類別類型</typeparam>
    public abstract class BackboneType<T> : BackboneElement<T>
        where T : BackboneType<T>
    {
        /// <summary>
        /// 修飾符擴展集合
        /// </summary>
        /// <remarks>
        /// <para>
        /// 修飾符擴展可能會改變其他元素的含義。
        /// </para>
        /// </remarks>
        public new ObservableCollection<DataTypeServices.DataTypes.SpecialTypes.Extension> ModifierExtension { get; } = new();

        /// <summary>
        /// 擴展集合
        /// </summary>
        /// <remarks>
        /// <para>
        /// 標準擴展，不會改變其他元素的含義。
        /// </para>
        /// </remarks>
        public new ObservableCollection<DataTypeServices.DataTypes.SpecialTypes.Extension> Extension { get; } = new();

        /// <summary>
        /// 初始化 BackboneType 的新執行個體
        /// </summary>
        protected BackboneType() : base() { }

        /// <summary>
        /// 從 JsonNode 初始化 BackboneType 的新執行個體
        /// </summary>
        /// <param name="value">JSON 節點值</param>
        protected BackboneType(JsonNode? value) : base() { }

        /// <summary>
        /// 獲取 FHIR 類型名稱
        /// </summary>
        /// <param name="withCapital">是否首字母大寫</param>
        /// <returns>FHIR 類型名稱</returns>
        public override string GetFhirTypeName(bool withCapital = true) => typeof(T).Name.ToTitleCase(withCapital);
    }
}
