

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceUsageSub
{
    public class DeviceUsage : DomainResource<DeviceUsage>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("derivedFrom", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> DerivedFrom {get; set;}
[Element("context", typeof(Reference), false, false, false, false)]
public Reference Context {get; set;}
[Element("timing", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Timing {get; set;}
[Element("dateAsserted", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime DateAsserted {get; set;}
[Element("usageStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept UsageStatus {get; set;}
[Element("usageReason", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> UsageReason {get; set;}
[Element("adherence", typeof(Adherence), false, false, false, true)]
public Adherence Adherence {get; set;}
[Element("informationSource", typeof(Reference), false, false, false, false)]
public Reference InformationSource {get; set;}
[Element("device", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Device {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("bodySite", typeof(CodeableReference), false, false, false, false)]
public CodeableReference BodySite {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  DeviceUsage() { }

        public  DeviceUsage(string value) : base(value) { }
        public  DeviceUsage(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "DeviceUsage";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
