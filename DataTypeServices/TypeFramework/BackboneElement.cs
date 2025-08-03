using System.Collections.ObjectModel;
using DataTypeServices.DataTypes.SpecialTypes;

namespace DataTypeServices.TypeFramework
{
    /// <summary>
    /// FHIR Backbone Element 基礎類別
    ///
    /// <para>
    /// 提供所有 FHIR Backbone Element 的基本功能，包括修飾符擴展。
    /// </para>
    /// </summary>
    /// <typeparam name="T">繼承的類別類型</typeparam>
    public abstract class BackboneElement<T> : Element
        where T : BackboneElement<T>
    {
        /// <summary>
        /// 修飾符擴展集合
        /// </summary>
        /// <remarks>
        /// <para>
        /// 修飾符擴展可能會改變其他元素的含義。
        /// </para>
        /// </remarks>
        public ObservableCollection<DataTypeServices.DataTypes.SpecialTypes.Extension> ModifierExtension { get; } = new();

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
        /// 初始化 BackboneElement 的新執行個體
        /// </summary>
        protected BackboneElement() : base() { }
    }
}
