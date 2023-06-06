
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceDefinitionSub
{
    public class Guideline : BackboneElement<Guideline>
    {

        #region Property
        [Element("useContext", typeof(UsageContext), false, true, false, false)]
public IEnumerable<UsageContext> UseContext {get; set;}
[Element("usageInstruction", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown UsageInstruction {get; set;}
[Element("relatedArtifact", typeof(RelatedArtifact), false, true, false, false)]
public IEnumerable<RelatedArtifact> RelatedArtifact {get; set;}
[Element("indication", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Indication {get; set;}
[Element("contraindication", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Contraindication {get; set;}
[Element("warning", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Warning {get; set;}
[Element("intendedUse", typeof(FhirString), true, false, false, false)]
public FhirString IntendedUse {get; set;}

        #endregion
        #region Constructor
        public  Guideline() { }
        public  Guideline(string value) : base(value) { }
        public  Guideline(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Guideline";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
