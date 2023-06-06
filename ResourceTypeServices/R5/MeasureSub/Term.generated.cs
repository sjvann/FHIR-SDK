
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MeasureSub
{
    public class Term : BackboneElement<Term>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("definition", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Definition {get; set;}

        #endregion
        #region Constructor
        public  Term() { }
        public  Term(string value) : base(value) { }
        public  Term(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Term";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
