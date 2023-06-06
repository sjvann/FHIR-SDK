
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.EvidenceVariableSub.CharacteristicSub;

namespace ResourceTypeServices.R5.EvidenceVariableSub
{
    public class Characteristic : BackboneElement<Characteristic>
    {

        #region Property
        [Element("linkId", typeof(FhirId), true, false, false, false)]
public FhirId LinkId {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("exclude", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Exclude {get; set;}
[Element("definitionReference", typeof(Reference), false, false, false, false)]
public Reference DefinitionReference {get; set;}
[Element("definitionCanonical", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical DefinitionCanonical {get; set;}
[Element("definitionCodeableConcept", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept DefinitionCodeableConcept {get; set;}
[Element("definitionExpression", typeof(Expression), false, false, false, false)]
public Expression DefinitionExpression {get; set;}
[Element("definitionId", typeof(FhirId), true, false, false, false)]
public FhirId DefinitionId {get; set;}
[Element("definitionByTypeAndValue", typeof(DefinitionByTypeAndValue), false, false, false, true)]
public DefinitionByTypeAndValue DefinitionByTypeAndValue {get; set;}
[Element("definitionByCombination", typeof(DefinitionByCombination), false, false, false, true)]
public DefinitionByCombination DefinitionByCombination {get; set;}
[Element("instances", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Instances {get; set;}
[Element("duration", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Duration {get; set;}
[Element("timeFromEvent", typeof(TimeFromEvent), false, true, false, true)]
public IEnumerable<TimeFromEvent> TimeFromEvent {get; set;}

        #endregion
        #region Constructor
        public  Characteristic() { }
        public  Characteristic(string value) : base(value) { }
        public  Characteristic(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Characteristic";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
