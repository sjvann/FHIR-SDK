
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.SpecimenDefinitionSub.TypeTestedSub;

namespace ResourceTypeServices.R5.SpecimenDefinitionSub
{
    public class TypeTested : BackboneElement<TypeTested>
    {

        #region Property
        [Element("isDerived", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean IsDerived {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("preference", typeof(FhirCode), true, false, false, false)]
public FhirCode Preference {get; set;}
[Element("container", typeof(Container), false, false, false, true)]
public Container Container {get; set;}
[Element("requirement", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Requirement {get; set;}
[Element("retentionTime", typeof(Duration), false, false, false, false)]
public Duration RetentionTime {get; set;}
[Element("singleUse", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean SingleUse {get; set;}
[Element("rejectionCriterion", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> RejectionCriterion {get; set;}
[Element("handling", typeof(Handling), false, true, false, true)]
public IEnumerable<Handling> Handling {get; set;}
[Element("testingDestination", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> TestingDestination {get; set;}

        #endregion
        #region Constructor
        public  TypeTested() { }
        public  TypeTested(string value) : base(value) { }
        public  TypeTested(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "TypeTested";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
