
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.EncounterSub
{
    public class Admission : BackboneElement<Admission>
    {

        #region Property
        [Element("preAdmissionIdentifier", typeof(Identifier), false, false, false, false)]
public Identifier PreAdmissionIdentifier {get; set;}
[Element("origin", typeof(Reference), false, false, false, false)]
public Reference Origin {get; set;}
[Element("admitSource", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AdmitSource {get; set;}
[Element("reAdmission", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ReAdmission {get; set;}
[Element("destination", typeof(Reference), false, false, false, false)]
public Reference Destination {get; set;}
[Element("dischargeDisposition", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept DischargeDisposition {get; set;}

        #endregion
        #region Constructor
        public  Admission() { }
        public  Admission(string value) : base(value) { }
        public  Admission(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Admission";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
