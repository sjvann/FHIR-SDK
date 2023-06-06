

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CoverageEligibilityRequestSub
{
    public class CoverageEligibilityRequest : DomainResource<CoverageEligibilityRequest>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("priority", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Priority {get; set;}
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
[Element("enterer", typeof(Reference), false, false, false, false)]
public Reference Enterer {get; set;}
[Element("provider", typeof(Reference), false, false, false, false)]
public Reference Provider {get; set;}
[Element("insurer", typeof(Reference), false, false, false, false)]
public Reference Insurer {get; set;}
[Element("facility", typeof(Reference), false, false, false, false)]
public Reference Facility {get; set;}
[Element("supportingInfo", typeof(SupportingInfo), false, true, false, true)]
public IEnumerable<SupportingInfo> SupportingInfo {get; set;}
[Element("insurance", typeof(Insurance), false, true, false, true)]
public IEnumerable<Insurance> Insurance {get; set;}
[Element("item", typeof(Item), false, true, false, true)]
public IEnumerable<Item> Item {get; set;}

        #endregion
        #region Constructor
        public  CoverageEligibilityRequest() { }

        public  CoverageEligibilityRequest(string value) : base(value) { }
        public  CoverageEligibilityRequest(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "CoverageEligibilityRequest";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
