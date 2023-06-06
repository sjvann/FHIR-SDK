
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceDefinitionSub
{
    public class Code : BackboneElement<Code>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept CodeProp {get; set;}
[Element("status", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Status {get; set;}
[Element("statusDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime StatusDate {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("source", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Source {get; set;}

        #endregion
        #region Constructor
        public  Code() { }
        public  Code(string value) : base(value) { }
        public  Code(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Code";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
