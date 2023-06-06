
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub
{
    public class ProcessNote : BackboneElement<ProcessNote>
    {

        #region Property
        [Element("number", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt Number {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("language", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Language {get; set;}

        #endregion
        #region Constructor
        public  ProcessNote() { }
        public  ProcessNote(string value) : base(value) { }
        public  ProcessNote(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ProcessNote";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
