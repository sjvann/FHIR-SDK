

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EnrollmentResponseSub
{
    public class EnrollmentResponse : DomainResource<EnrollmentResponse>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("request", typeof(Reference), false, false, false, false)]
public Reference Request {get; set;}
[Element("outcome", typeof(FhirCode), true, false, false, false)]
public FhirCode Outcome {get; set;}
[Element("disposition", typeof(FhirString), true, false, false, false)]
public FhirString Disposition {get; set;}
[Element("created", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Created {get; set;}
[Element("organization", typeof(Reference), false, false, false, false)]
public Reference Organization {get; set;}
[Element("requestProvider", typeof(Reference), false, false, false, false)]
public Reference RequestProvider {get; set;}

        #endregion
        #region Constructor
        public  EnrollmentResponse() { }

        public  EnrollmentResponse(string value) : base(value) { }
        public  EnrollmentResponse(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "EnrollmentResponse";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
