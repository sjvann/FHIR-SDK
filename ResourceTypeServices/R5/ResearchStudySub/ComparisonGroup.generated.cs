
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ResearchStudySub
{
    public class ComparisonGroup : BackboneElement<ComparisonGroup>
    {

        #region Property
        [Element("linkId", typeof(FhirId), true, false, false, false)]
public FhirId LinkId {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("intendedExposure", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> IntendedExposure {get; set;}
[Element("observedGroup", typeof(Reference), false, false, false, false)]
public Reference ObservedGroup {get; set;}

        #endregion
        #region Constructor
        public  ComparisonGroup() { }
        public  ComparisonGroup(string value) : base(value) { }
        public  ComparisonGroup(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ComparisonGroup";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
