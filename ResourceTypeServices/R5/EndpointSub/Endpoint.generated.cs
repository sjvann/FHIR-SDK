

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EndpointSub
{
    public class Endpoint : DomainResource<Endpoint>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("connectionType", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ConnectionType {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("environmentType", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> EnvironmentType {get; set;}
[Element("managingOrganization", typeof(Reference), false, false, false, false)]
public Reference ManagingOrganization {get; set;}
[Element("contact", typeof(ContactPoint), false, true, false, false)]
public IEnumerable<ContactPoint> Contact {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("payload", typeof(Payload), false, true, false, true)]
public IEnumerable<Payload> Payload {get; set;}
[Element("address", typeof(FhirUrl), true, false, false, false)]
public FhirUrl Address {get; set;}
[Element("header", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Header {get; set;}

        #endregion
        #region Constructor
        public  Endpoint() { }

        public  Endpoint(string value) : base(value) { }
        public  Endpoint(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Endpoint";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
