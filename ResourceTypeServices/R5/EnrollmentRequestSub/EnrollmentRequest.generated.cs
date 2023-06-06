

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EnrollmentRequestSub
{
    public class EnrollmentRequest : DomainResource<EnrollmentRequest>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("created", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Created {get; set;}
[Element("insurer", typeof(Reference), false, false, false, false)]
public Reference Insurer {get; set;}
[Element("provider", typeof(Reference), false, false, false, false)]
public Reference Provider {get; set;}
[Element("candidate", typeof(Reference), false, false, false, false)]
public Reference Candidate {get; set;}
[Element("coverage", typeof(Reference), false, false, false, false)]
public Reference Coverage {get; set;}

        #endregion
        #region Constructor
        public  EnrollmentRequest() { }

        public  EnrollmentRequest(string value) : base(value) { }
        public  EnrollmentRequest(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "EnrollmentRequest";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
