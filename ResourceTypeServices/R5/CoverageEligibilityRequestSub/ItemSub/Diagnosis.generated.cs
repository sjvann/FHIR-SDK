
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.CoverageEligibilityRequestSub.ItemSub
{
    public class Diagnosis : BackboneElement<Diagnosis>
    {

        #region Property
        [Element("diagnosis", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased DiagnosisProp {get; set;}

        #endregion
        #region Constructor
        public  Diagnosis() { }
        public  Diagnosis(string value) : base(value) { }
        public  Diagnosis(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Diagnosis";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
