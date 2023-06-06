
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.CitationSub.CitedArtifactSub.ContributorshipSub.EntrySub;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub.ContributorshipSub
{
    public class Entry : BackboneElement<Entry>
    {

        #region Property
        [Element("contributor", typeof(Reference), false, false, false, false)]
public Reference Contributor {get; set;}
[Element("forenameInitials", typeof(FhirString), true, false, false, false)]
public FhirString ForenameInitials {get; set;}
[Element("affiliation", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Affiliation {get; set;}
[Element("contributionType", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ContributionType {get; set;}
[Element("role", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Role {get; set;}
[Element("contributionInstance", typeof(ContributionInstance), false, true, false, true)]
public IEnumerable<ContributionInstance> ContributionInstance {get; set;}
[Element("correspondingContact", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean CorrespondingContact {get; set;}
[Element("rankingOrder", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt RankingOrder {get; set;}

        #endregion
        #region Constructor
        public  Entry() { }
        public  Entry(string value) : base(value) { }
        public  Entry(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Entry";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
