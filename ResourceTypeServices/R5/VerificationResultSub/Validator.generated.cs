
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.VerificationResultSub
{
    public class Validator : BackboneElement<Validator>
    {

        #region Property
        [Element("organization", typeof(Reference), false, false, false, false)]
public Reference Organization {get; set;}
[Element("identityCertificate", typeof(FhirString), true, false, false, false)]
public FhirString IdentityCertificate {get; set;}
[Element("attestationSignature", typeof(Signature), false, false, false, false)]
public Signature AttestationSignature {get; set;}

        #endregion
        #region Constructor
        public  Validator() { }
        public  Validator(string value) : base(value) { }
        public  Validator(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Validator";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
