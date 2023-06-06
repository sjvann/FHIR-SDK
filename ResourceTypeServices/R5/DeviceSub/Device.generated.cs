

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceSub
{
    public class Device : DomainResource<Device>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("displayName", typeof(FhirString), true, false, false, false)]
public FhirString DisplayName {get; set;}
[Element("definition", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Definition {get; set;}
[Element("udiCarrier", typeof(UdiCarrier), false, true, false, true)]
public IEnumerable<UdiCarrier> UdiCarrier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("availabilityStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AvailabilityStatus {get; set;}
[Element("biologicalSourceEvent", typeof(Identifier), false, false, false, false)]
public Identifier BiologicalSourceEvent {get; set;}
[Element("manufacturer", typeof(FhirString), true, false, false, false)]
public FhirString Manufacturer {get; set;}
[Element("manufactureDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime ManufactureDate {get; set;}
[Element("expirationDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime ExpirationDate {get; set;}
[Element("lotNumber", typeof(FhirString), true, false, false, false)]
public FhirString LotNumber {get; set;}
[Element("serialNumber", typeof(FhirString), true, false, false, false)]
public FhirString SerialNumber {get; set;}
[Element("name", typeof(Name), false, true, false, true)]
public IEnumerable<Name> Name {get; set;}
[Element("modelNumber", typeof(FhirString), true, false, false, false)]
public FhirString ModelNumber {get; set;}
[Element("partNumber", typeof(FhirString), true, false, false, false)]
public FhirString PartNumber {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("version", typeof(ResourceTypeServices.R5.DeviceSub.Version), false, true, false, true)]
public IEnumerable<ResourceTypeServices.R5.DeviceSub.Version> Version {get; set;}
[Element("conformsTo", typeof(ConformsTo), false, true, false, true)]
public IEnumerable<ConformsTo> ConformsTo {get; set;}
[Element("property", typeof(Property), false, true, false, true)]
public IEnumerable<Property> Property {get; set;}
[Element("mode", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Mode {get; set;}
[Element("cycle", typeof(Count), false, false, false, false)]
public Count Cycle {get; set;}
[Element("duration", typeof(Duration), false, false, false, false)]
public Duration Duration {get; set;}
[Element("owner", typeof(Reference), false, false, false, false)]
public Reference Owner {get; set;}
[Element("contact", typeof(ContactPoint), false, true, false, false)]
public IEnumerable<ContactPoint> Contact {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}
[Element("endpoint", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Endpoint {get; set;}
[Element("gateway", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Gateway {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("safety", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Safety {get; set;}
[Element("parent", typeof(Reference), false, false, false, false)]
public Reference Parent {get; set;}

        #endregion
        #region Constructor
        public  Device() { }

        public  Device(string value) : base(value) { }
        public  Device(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Device";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
