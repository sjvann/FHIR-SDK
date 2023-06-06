
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TestReportSub
{
    public class Participant : BackboneElement<Participant>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("uri", typeof(FhirUri), true, false, false, false)]
public FhirUri Uri {get; set;}
[Element("display", typeof(FhirString), true, false, false, false)]
public FhirString Display {get; set;}

        #endregion
        #region Constructor
        public  Participant() { }
        public  Participant(string value) : base(value) { }
        public  Participant(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Participant";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
