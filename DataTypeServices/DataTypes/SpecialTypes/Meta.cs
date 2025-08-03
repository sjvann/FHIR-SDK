using FhirCore.Interfaces;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.SpecialTypes
{
    /// <summary>
    /// DataTypeServices 版本的 Meta 類別（已棄用）
    /// 
    /// <para>
    /// 此類別已被 FhirCore.Interfaces.Meta 取代。
    /// 建議使用新的統一架構中的 Meta 類別。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 為了向後相容性暫時保留，但建議遷移到新架構。
    /// </para>
    /// </remarks>
    [Obsolete("使用 FhirCore.Interfaces.Meta 替代")]
    public class Meta : ComplexType<Meta>
    {
        private FhirId? _VersionId;
        private FhirInstant? _LastUpdated;
        private FhirUri? _Source;
        private List<FhirCanonical>? _Profile;
        private List<DataTypeServices.DataTypes.ComplexTypes.Coding>? _Security;
        private List<DataTypeServices.DataTypes.ComplexTypes.Coding>? _Tag;

        public FhirId? VersionId
        {
            get { return _VersionId; }
            set
            {
                _VersionId = value;
                OnPropertyChanged("versionId", value);
            }
        }
        public FhirInstant? LastUpdated
        {
            get { return _LastUpdated; }
            set
            {
                _LastUpdated = value;
                OnPropertyChanged("lastUpdated", value);
            }
        }
        public FhirUri? Source
        {
            get { return _Source; }
            set
            {
                _Source = value;
                OnPropertyChanged("source", value);
            }
        }
        public List<FhirCanonical>? Profile
        {
            get { return _Profile; }
            set
            {
                _Profile = value;
                OnPropertyChanged("profile", value);
            }
        }
        public List<DataTypeServices.DataTypes.ComplexTypes.Coding>? Security
        {
            get { return _Security; }
            set
            {
                _Security = value;
                OnPropertyChanged("security", value);
            }
        }
        public List<DataTypeServices.DataTypes.ComplexTypes.Coding>? Tag
        {
            get { return _Tag; }
            set
            {
                _Tag = value;
                OnPropertyChanged("tag", value);
            }
        }
        public Meta() : base() { }
        public Meta(JsonObject? value) : base(value) { }
        public Meta(string value) : base(value) { }

        public override bool IsChoiceType() => false;

        public override bool IsPrimitive() => false;

        public override bool IsComplex() => true;
    }
}
