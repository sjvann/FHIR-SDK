using Core.Extension;

using DataTypeService.BaseTypes;
using DataTypeService.Choice;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Text;
using System.Text.Json.Nodes;

namespace DataTypeService.MetaType
{
    public class VirtualServiceDetail : ComplexType
    {

        #region Property
        public Coding? ChannelType { get; set; }
        public ChoiceBased? Address { get; set; }
        public IEnumerable<FhirUrl>? AdditionalInfo { get; set; }
        public FhirPositiveInt? MaxParticipants{ get; set; }
        public FhirString? SessionKey { get; set; }

        #endregion
        #region Constructor
        public VirtualServiceDetail() { }
        public VirtualServiceDetail(string? value) : this(value.Parse()) { }
        public VirtualServiceDetail(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "channelType":
                            ChannelType = new Coding(cv);
                            break;
                        case "addressUrl":
                        case "addressString":
                        case "addressContactPoint":
                        case "addressExtendedContactDetail":
                            Address = new ChoiceBased(ck, cv);
                            break;
                        case "additionalInfo":
                            AdditionalInfo = cv?.AsArray().Select(x => new FhirUrl(x));
                            break;
                        case "maxParticipants":
                            MaxParticipants = new FhirPositiveInt(cv);
                            break;
                        case "sessionKey":
                            SessionKey = new FhirString(cv);
                            break;
                    }
                }
            }

        }

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
