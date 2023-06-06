

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceDispenseSub
{
    public class DeviceDispense : DomainResource<DeviceDispense>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("partOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PartOf {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("statusReason", typeof(CodeableReference), false, false, false, false)]
public CodeableReference StatusReason {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("device", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Device {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("receiver", typeof(Reference), false, false, false, false)]
public Reference Receiver {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("supportingInformation", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingInformation {get; set;}
[Element("performer", typeof(Performer), false, true, false, true)]
public IEnumerable<Performer> Performer {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("preparedDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime PreparedDate {get; set;}
[Element("whenHandedOver", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime WhenHandedOver {get; set;}
[Element("destination", typeof(Reference), false, false, false, false)]
public Reference Destination {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("usageInstruction", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown UsageInstruction {get; set;}
[Element("eventHistory", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> EventHistory {get; set;}

        #endregion
        #region Constructor
        public  DeviceDispense() { }

        public  DeviceDispense(string value) : base(value) { }
        public  DeviceDispense(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "DeviceDispense";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
