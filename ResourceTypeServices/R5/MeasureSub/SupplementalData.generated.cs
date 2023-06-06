
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MeasureSub
{
    public class SupplementalData : BackboneElement<SupplementalData>
    {

        #region Property
        [Element("linkId", typeof(FhirString), true, false, false, false)]
public FhirString LinkId {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("usage", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Usage {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("criteria", typeof(Expression), false, false, false, false)]
public Expression Criteria {get; set;}

        #endregion
        #region Constructor
        public  SupplementalData() { }
        public  SupplementalData(string value) : base(value) { }
        public  SupplementalData(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SupplementalData";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
