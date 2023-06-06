
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.MeasureReportSub.GroupSub;

namespace ResourceTypeServices.R5.MeasureReportSub
{
    public class Group : BackboneElement<Group>
    {

        #region Property
        [Element("linkId", typeof(FhirString), true, false, false, false)]
public FhirString LinkId {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("population", typeof(Population), false, true, false, true)]
public IEnumerable<Population> Population {get; set;}
[Element("measureScore", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased MeasureScore {get; set;}
[Element("stratifier", typeof(Stratifier), false, true, false, true)]
public IEnumerable<Stratifier> Stratifier {get; set;}

        #endregion
        #region Constructor
        public  Group() { }
        public  Group(string value) : base(value) { }
        public  Group(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Group";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
