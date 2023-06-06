
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using ResourceTypeServices.R5.AdverseEventSub.SuspectEntitySub;

namespace ResourceTypeServices.R5.AdverseEventSub
{
    public class SuspectEntity : BackboneElement<SuspectEntity>
    {

        #region Property
        [Element("instance", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Instance {get; set;}
[Element("causality", typeof(Causality), false, false, false, true)]
public Causality Causality {get; set;}

        #endregion
        #region Constructor
        public  SuspectEntity() { }
        public  SuspectEntity(string value) : base(value) { }
        public  SuspectEntity(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SuspectEntity";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
