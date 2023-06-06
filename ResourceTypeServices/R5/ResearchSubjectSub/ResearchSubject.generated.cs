

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ResearchSubjectSub
{
    public class ResearchSubject : DomainResource<ResearchSubject>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("progress", typeof(Progress), false, true, false, true)]
public IEnumerable<Progress> Progress {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("study", typeof(Reference), false, false, false, false)]
public Reference Study {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("assignedComparisonGroup", typeof(FhirId), true, false, false, false)]
public FhirId AssignedComparisonGroup {get; set;}
[Element("actualComparisonGroup", typeof(FhirId), true, false, false, false)]
public FhirId ActualComparisonGroup {get; set;}
[Element("consent", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Consent {get; set;}

        #endregion
        #region Constructor
        public  ResearchSubject() { }

        public  ResearchSubject(string value) : base(value) { }
        public  ResearchSubject(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ResearchSubject";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
