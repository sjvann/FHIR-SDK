
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ConsentSub
{
    public class Verification : BackboneElement<Verification>
    {

        #region Property
        [Element("verified", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Verified {get; set;}
[Element("verificationType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept VerificationType {get; set;}
[Element("verifiedBy", typeof(Reference), false, false, false, false)]
public Reference VerifiedBy {get; set;}
[Element("verifiedWith", typeof(Reference), false, false, false, false)]
public Reference VerifiedWith {get; set;}
[Element("verificationDate", typeof(FhirDateTime), true, true, false, false)]
public IEnumerable<FhirDateTime> VerificationDate {get; set;}

        #endregion
        #region Constructor
        public  Verification() { }
        public  Verification(string value) : base(value) { }
        public  Verification(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Verification";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
