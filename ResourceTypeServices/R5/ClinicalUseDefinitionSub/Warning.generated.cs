
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ClinicalUseDefinitionSub
{
    public class Warning : BackboneElement<Warning>
    {

        #region Property
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}

        #endregion
        #region Constructor
        public  Warning() { }
        public  Warning(string value) : base(value) { }
        public  Warning(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Warning";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
