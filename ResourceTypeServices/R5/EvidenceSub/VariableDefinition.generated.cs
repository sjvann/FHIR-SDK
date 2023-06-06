
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EvidenceSub
{
    public class VariableDefinition : BackboneElement<VariableDefinition>
    {

        #region Property
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("variableRole", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept VariableRole {get; set;}
[Element("observed", typeof(Reference), false, false, false, false)]
public Reference Observed {get; set;}
[Element("intended", typeof(Reference), false, false, false, false)]
public Reference Intended {get; set;}
[Element("directnessMatch", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept DirectnessMatch {get; set;}

        #endregion
        #region Constructor
        public  VariableDefinition() { }
        public  VariableDefinition(string value) : base(value) { }
        public  VariableDefinition(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "VariableDefinition";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
