
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.SubstancePolymerSub.RepeatSub;

namespace ResourceTypeServices.R5.SubstancePolymerSub
{
    public class Repeat : BackboneElement<Repeat>
    {

        #region Property
        [Element("averageMolecularFormula", typeof(FhirString), true, false, false, false)]
public FhirString AverageMolecularFormula {get; set;}
[Element("repeatUnitAmountType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept RepeatUnitAmountType {get; set;}
[Element("repeatUnit", typeof(RepeatUnit), false, true, false, true)]
public IEnumerable<RepeatUnit> RepeatUnit {get; set;}

        #endregion
        #region Constructor
        public  Repeat() { }
        public  Repeat(string value) : base(value) { }
        public  Repeat(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Repeat";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
