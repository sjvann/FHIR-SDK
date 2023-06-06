
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub.ContributorshipSub.EntrySub
{
    public class ContributionInstance : BackboneElement<ContributionInstance>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("time", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Time {get; set;}

        #endregion
        #region Constructor
        public  ContributionInstance() { }
        public  ContributionInstance(string value) : base(value) { }
        public  ContributionInstance(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ContributionInstance";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
