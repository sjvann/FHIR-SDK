

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CoverageEligibilityResponseSub
{
    public class CoverageEligibilityResponse : DomainResource<CoverageEligibilityResponse>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("purpose", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Purpose {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("event", typeof(Event), false, true, false, true)]
public IEnumerable<Event> Event {get; set;}
[Element("serviced", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Serviced {get; set;}
[Element("created", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Created {get; set;}
[Element("requestor", typeof(Reference), false, false, false, false)]
public Reference Requestor {get; set;}
[Element("request", typeof(Reference), false, false, false, false)]
public Reference Request {get; set;}
[Element("outcome", typeof(FhirCode), true, false, false, false)]
public FhirCode Outcome {get; set;}
[Element("disposition", typeof(FhirString), true, false, false, false)]
public FhirString Disposition {get; set;}
[Element("insurer", typeof(Reference), false, false, false, false)]
public Reference Insurer {get; set;}
[Element("insurance", typeof(Insurance), false, true, false, true)]
public IEnumerable<Insurance> Insurance {get; set;}
[Element("preAuthRef", typeof(FhirString), true, false, false, false)]
public FhirString PreAuthRef {get; set;}
[Element("form", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Form {get; set;}
[Element("error", typeof(Error), false, true, false, true)]
public IEnumerable<Error> Error {get; set;}

        #endregion
        #region Constructor
        public  CoverageEligibilityResponse() { }

        public  CoverageEligibilityResponse(string value) : base(value) { }
        public  CoverageEligibilityResponse(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "CoverageEligibilityResponse";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
