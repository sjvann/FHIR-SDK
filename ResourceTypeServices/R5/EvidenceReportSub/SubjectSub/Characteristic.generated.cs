
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EvidenceReportSub.SubjectSub
{
    public class Characteristic : BackboneElement<Characteristic>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}
[Element("exclude", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Exclude {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}

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
