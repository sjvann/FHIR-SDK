using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.MetaTypes
{

    /// <summary>
    /// 虛擬服務詳細資訊
    /// 
    /// <para>
    /// 描述虛擬服務連接的詳細資訊，包括頻道類型、地址、參與者限制等。
    /// </para>
    /// </summary>
    public class VirtualServiceDetail : ComplexType<VirtualServiceDetail>
    {
        private DataTypeServices.DataTypes.ComplexTypes.Coding? _channelType;
        private VirtualServiceDetailAddressChoice? _address;
        private List<FhirUrl>? _additionalInfo;
        private FhirPositiveInt? _maxParticipants;
        private FhirString? _sessionKey;

        /// <summary>
        /// 頻道類型
        /// </summary>
        public DataTypeServices.DataTypes.ComplexTypes.Coding? ChannelType
        {
            get { return _channelType; }
            set
            {
                _channelType = value;
                OnPropertyChanged("channelType", value);
            }
        }
        
        /// <summary>
        /// 地址
        /// </summary>
        public VirtualServiceDetailAddressChoice? Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("address", value);
            }
        }
        
        /// <summary>
        /// 額外資訊
        /// </summary>
        public List<FhirUrl>? AdditionalInfo
        {
            get { return _additionalInfo; }
            set
            {
                _additionalInfo = value;
                OnPropertyChanged("additionalInfo", value);
            }
        }
        
        /// <summary>
        /// 最大參與者數量
        /// </summary>
        public FhirPositiveInt? MaxParticipants
        {
            get { return _maxParticipants; }
            set
            {
                _maxParticipants = value;
                OnPropertyChanged("maxParticipants", value);
            }
        }
        
        /// <summary>
        /// 會話金鑰
        /// </summary>
        public FhirString? SessionKey
        {
            get { return _sessionKey; }
            set
            {
                _sessionKey = value;
                OnPropertyChanged("sessionKey", value);
            }
        }

        /// <summary>
        /// 初始化 VirtualServiceDetail 的新執行個體
        /// </summary>
        public VirtualServiceDetail() : base() { }
        
        /// <summary>
        /// 從 JSON 物件初始化 VirtualServiceDetail 的新執行個體
        /// </summary>
        /// <param name="value">JSON 物件</param>
        public VirtualServiceDetail(JsonObject? value) : base(value) { }
        
        /// <summary>
        /// 從字串初始化 VirtualServiceDetail 的新執行個體
        /// </summary>
        /// <param name="value">JSON 字串</param>
        public VirtualServiceDetail(string value) : base(value) { }
    }

    /// <summary>
    /// 虛擬服務詳細資訊地址選擇類型
    /// </summary>
    public class VirtualServiceDetailAddressChoice: ChoiceType
    {
        private static readonly List<string> _supportType = [
        "url","string","ContactPoint","ExtendedContactDetail"
        ];

        /// <summary>
        /// 從 JSON 物件初始化
        /// </summary>
        /// <param name="value">JSON 物件</param>
        public VirtualServiceDetailAddressChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        
        /// <summary>
        /// 從複雜類型初始化
        /// </summary>
        /// <param name="value">複雜類型</param>
        public VirtualServiceDetailAddressChoice(FhirCore.Interfaces.IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        
        /// <summary>
        /// 從原始類型初始化
        /// </summary>
        /// <param name="value">原始類型</param>
        public VirtualServiceDetailAddressChoice(FhirCore.Interfaces.IPrimitiveType? value) : base("versionAlgorithm", value) { }

        /// <summary>
        /// 取得前綴名稱
        /// </summary>
        /// <param name="withCapital">是否首字母大寫</param>
        /// <returns>前綴名稱</returns>
        public override string GetPrefixName(bool withCapital = true) => "versionAlgorithm".ToTitleCase(withCapital);

        /// <summary>
        /// 設定支援的資料類型
        /// </summary>
        /// <returns>支援的資料類型列表</returns>
        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }
}
