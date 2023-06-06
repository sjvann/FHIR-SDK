

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CareTeamSub
{
    public class CareTeam : DomainResource<CareTeam>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("participant", typeof(Participant), false, true, false, true)]
public IEnumerable<Participant> Participant {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("managingOrganization", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> ManagingOrganization {get; set;}
[Element("telecom", typeof(ContactPoint), false, true, false, false)]
public IEnumerable<ContactPoint> Telecom {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  CareTeam() { }

        public  CareTeam(string value) : base(value) { }
        public  CareTeam(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "CareTeam";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
