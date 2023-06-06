
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using ResourceTypeServices.R5.MeasureReportSub.GroupSub.StratifierSub.StratumSub;

namespace ResourceTypeServices.R5.MeasureReportSub.GroupSub.StratifierSub
{
    public class Stratum : BackboneElement<Stratum>
    {

        #region Property
        [Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}
[Element("component", typeof(Component), false, true, false, true)]
public IEnumerable<Component> Component {get; set;}
[Element("population", typeof(Population), false, true, false, true)]
public IEnumerable<Population> Population {get; set;}
[Element("measureScore", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased MeasureScore {get; set;}

        #endregion
        #region Constructor
        public  Stratum() { }
        public  Stratum(string value) : base(value) { }
        public  Stratum(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Stratum";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
