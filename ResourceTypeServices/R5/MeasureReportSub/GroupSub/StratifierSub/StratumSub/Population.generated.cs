
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MeasureReportSub.GroupSub.StratifierSub.StratumSub
{
    public class Population : BackboneElement<Population>
    {

        #region Property
        [Element("linkId", typeof(FhirString), true, false, false, false)]
public FhirString LinkId {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("count", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Count {get; set;}
[Element("subjectResults", typeof(Reference), false, false, false, false)]
public Reference SubjectResults {get; set;}
[Element("subjectReport", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SubjectReport {get; set;}
[Element("subjects", typeof(Reference), false, false, false, false)]
public Reference Subjects {get; set;}

        #endregion
        #region Constructor
        public  Population() { }
        public  Population(string value) : base(value) { }
        public  Population(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Population";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
