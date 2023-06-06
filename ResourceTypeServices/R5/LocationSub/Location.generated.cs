

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.LocationSub
{
    public class Location : DomainResource<Location>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("operationalStatus", typeof(Coding), false, false, false, false)]
public Coding OperationalStatus {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("alias", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Alias {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("mode", typeof(FhirCode), true, false, false, false)]
public FhirCode Mode {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("contact", typeof(ExtendedContactDetail), false, true, false, false)]
public IEnumerable<ExtendedContactDetail> Contact {get; set;}
[Element("address", typeof(Address), false, false, false, false)]
public Address Address {get; set;}
[Element("form", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Form {get; set;}
[Element("position", typeof(Position), false, false, false, true)]
public Position Position {get; set;}
[Element("managingOrganization", typeof(Reference), false, false, false, false)]
public Reference ManagingOrganization {get; set;}
[Element("partOf", typeof(Reference), false, false, false, false)]
public Reference PartOf {get; set;}
[Element("characteristic", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Characteristic {get; set;}
[Element("hoursOfOperation", typeof(Availability), false, true, false, false)]
public IEnumerable<Availability> HoursOfOperation {get; set;}
[Element("virtualService", typeof(VirtualServiceDetail), false, true, false, false)]
public IEnumerable<VirtualServiceDetail> VirtualService {get; set;}
[Element("endpoint", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Endpoint {get; set;}

        #endregion
        #region Constructor
        public  Location() { }

        public  Location(string value) : base(value) { }
        public  Location(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Location";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
