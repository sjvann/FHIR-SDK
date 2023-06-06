
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.CitationSub.CitedArtifactSub.ContributorshipSub;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub
{
    public class Contributorship : BackboneElement<Contributorship>
    {

        #region Property
        [Element("complete", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Complete {get; set;}
[Element("entry", typeof(Entry), false, true, false, true)]
public IEnumerable<Entry> Entry {get; set;}
[Element("summary", typeof(Summary), false, true, false, true)]
public IEnumerable<Summary> Summary {get; set;}

        #endregion
        #region Constructor
        public  Contributorship() { }
        public  Contributorship(string value) : base(value) { }
        public  Contributorship(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Contributorship";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
