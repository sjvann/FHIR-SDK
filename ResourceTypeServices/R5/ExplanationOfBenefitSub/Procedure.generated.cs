
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub
{
    public class Procedure : BackboneElement<Procedure>
    {

        #region Property
        [Element("sequence", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt Sequence {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("procedure", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased ProcedureProp {get; set;}
[Element("udi", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Udi {get; set;}

        #endregion
        #region Constructor
        public  Procedure() { }
        public  Procedure(string value) : base(value) { }
        public  Procedure(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Procedure";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
