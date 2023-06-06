
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.VerificationResultSub
{
    public class PrimarySource : BackboneElement<PrimarySource>
    {

        #region Property
        [Element("who", typeof(Reference), false, false, false, false)]
public Reference Who {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("communicationMethod", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> CommunicationMethod {get; set;}
[Element("validationStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ValidationStatus {get; set;}
[Element("validationDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime ValidationDate {get; set;}
[Element("canPushUpdates", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept CanPushUpdates {get; set;}
[Element("pushTypeAvailable", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> PushTypeAvailable {get; set;}

        #endregion
        #region Constructor
        public  PrimarySource() { }
        public  PrimarySource(string value) : base(value) { }
        public  PrimarySource(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "PrimarySource";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
