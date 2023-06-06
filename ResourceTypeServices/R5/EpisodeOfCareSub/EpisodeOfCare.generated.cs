

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EpisodeOfCareSub
{
    public class EpisodeOfCare : DomainResource<EpisodeOfCare>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("statusHistory", typeof(StatusHistory), false, true, false, true)]
public IEnumerable<StatusHistory> StatusHistory {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("reason", typeof(Reason), false, true, false, true)]
public IEnumerable<Reason> Reason {get; set;}
[Element("diagnosis", typeof(Diagnosis), false, true, false, true)]
public IEnumerable<Diagnosis> Diagnosis {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("managingOrganization", typeof(Reference), false, false, false, false)]
public Reference ManagingOrganization {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("referralRequest", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> ReferralRequest {get; set;}
[Element("careManager", typeof(Reference), false, false, false, false)]
public Reference CareManager {get; set;}
[Element("careTeam", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> CareTeam {get; set;}
[Element("account", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Account {get; set;}

        #endregion
        #region Constructor
        public  EpisodeOfCare() { }

        public  EpisodeOfCare(string value) : base(value) { }
        public  EpisodeOfCare(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "EpisodeOfCare";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
