
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ConceptMapSub.GroupSub;

namespace ResourceTypeServices.R5.ConceptMapSub
{
    public class Group : BackboneElement<Group>
    {

        #region Property
        [Element("source", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Source {get; set;}
[Element("target", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Target {get; set;}
[Element("element", typeof(ResourceTypeServices.R5.ConceptMapSub.GroupSub.Element), false, true, false, true)]
public IEnumerable<ResourceTypeServices.R5.ConceptMapSub.GroupSub.Element> Element {get; set;}
[Element("unmapped", typeof(Unmapped), false, false, false, true)]
public Unmapped Unmapped {get; set;}

        #endregion
        #region Constructor
        public  Group() { }
        public  Group(string value) : base(value) { }
        public  Group(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Group";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
