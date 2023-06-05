using Core.Attribute;

using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class VirtualServiceDetail : ComplexType<VirtualServiceDetail>
    {

        #region Property
        [Element("channelType", typeof(Coding), false, false, false, false)]
        public Coding? ChannelType { get; set; }
        [Element("address", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Address { get; set; }
        [Element("additionalInfo", typeof(FhirUrl), true, true, false, false)]
        public IEnumerable<FhirUrl>? AdditionalInfo { get; set; }
        [Element("maxParticipants", typeof(FhirPositiveInt), true, false, false, false)]
        public FhirPositiveInt? MaxParticipants { get; set; }
        [Element("sessionKey", typeof(FhirString), true, false, false, false)]
        public FhirString? SessionKey { get; set; }

        #endregion
        #region Constructor
        public VirtualServiceDetail() { }
        public VirtualServiceDetail(string? value) : base(value) { }
        public VirtualServiceDetail(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "VirtualServiceDetail";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
