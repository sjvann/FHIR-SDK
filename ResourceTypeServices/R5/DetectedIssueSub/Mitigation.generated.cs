
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DetectedIssueSub
{
    public class Mitigation : BackboneElement<Mitigation>
    {

        #region Property
        [Element("action", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Action {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("author", typeof(Reference), false, false, false, false)]
public Reference Author {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  Mitigation() { }
        public  Mitigation(string value) : base(value) { }
        public  Mitigation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Mitigation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
