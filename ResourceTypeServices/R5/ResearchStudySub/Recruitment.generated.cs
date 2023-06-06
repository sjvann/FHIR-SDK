
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ResearchStudySub
{
    public class Recruitment : BackboneElement<Recruitment>
    {

        #region Property
        [Element("targetNumber", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt TargetNumber {get; set;}
[Element("actualNumber", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt ActualNumber {get; set;}
[Element("eligibility", typeof(Reference), false, false, false, false)]
public Reference Eligibility {get; set;}
[Element("actualGroup", typeof(Reference), false, false, false, false)]
public Reference ActualGroup {get; set;}

        #endregion
        #region Constructor
        public  Recruitment() { }
        public  Recruitment(string value) : base(value) { }
        public  Recruitment(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Recruitment";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
