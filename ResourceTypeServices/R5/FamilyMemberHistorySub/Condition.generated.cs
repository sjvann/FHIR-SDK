
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.FamilyMemberHistorySub
{
    public class Condition : BackboneElement<Condition>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("outcome", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Outcome {get; set;}
[Element("contributedToDeath", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean ContributedToDeath {get; set;}
[Element("onset", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Onset {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  Condition() { }
        public  Condition(string value) : base(value) { }
        public  Condition(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Condition";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
