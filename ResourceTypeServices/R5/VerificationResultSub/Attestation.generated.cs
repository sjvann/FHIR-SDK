
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.VerificationResultSub
{
    public class Attestation : BackboneElement<Attestation>
    {

        #region Property
        [Element("who", typeof(Reference), false, false, false, false)]
public Reference Who {get; set;}
[Element("onBehalfOf", typeof(Reference), false, false, false, false)]
public Reference OnBehalfOf {get; set;}
[Element("communicationMethod", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept CommunicationMethod {get; set;}
[Element("date", typeof(FhirDate), true, false, false, false)]
public FhirDate Date {get; set;}
[Element("sourceIdentityCertificate", typeof(FhirString), true, false, false, false)]
public FhirString SourceIdentityCertificate {get; set;}
[Element("proxyIdentityCertificate", typeof(FhirString), true, false, false, false)]
public FhirString ProxyIdentityCertificate {get; set;}
[Element("proxySignature", typeof(Signature), false, false, false, false)]
public Signature ProxySignature {get; set;}
[Element("sourceSignature", typeof(Signature), false, false, false, false)]
public Signature SourceSignature {get; set;}

        #endregion
        #region Constructor
        public  Attestation() { }
        public  Attestation(string value) : base(value) { }
        public  Attestation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Attestation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
