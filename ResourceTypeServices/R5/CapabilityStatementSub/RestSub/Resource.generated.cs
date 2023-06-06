
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.CapabilityStatementSub.RestSub.ResourceSub;

namespace ResourceTypeServices.R5.CapabilityStatementSub.RestSub
{
    public class Resource : BackboneElement<Resource>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("profile", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Profile {get; set;}
[Element("supportedProfile", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> SupportedProfile {get; set;}
[Element("documentation", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Documentation {get; set;}
[Element("interaction", typeof(Interaction), false, true, false, true)]
public IEnumerable<Interaction> Interaction {get; set;}
[Element("versioning", typeof(FhirCode), true, false, false, false)]
public FhirCode Versioning {get; set;}
[Element("readHistory", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean ReadHistory {get; set;}
[Element("updateCreate", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean UpdateCreate {get; set;}
[Element("conditionalCreate", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean ConditionalCreate {get; set;}
[Element("conditionalRead", typeof(FhirCode), true, false, false, false)]
public FhirCode ConditionalRead {get; set;}
[Element("conditionalUpdate", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean ConditionalUpdate {get; set;}
[Element("conditionalPatch", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean ConditionalPatch {get; set;}
[Element("conditionalDelete", typeof(FhirCode), true, false, false, false)]
public FhirCode ConditionalDelete {get; set;}
[Element("referencePolicy", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> ReferencePolicy {get; set;}
[Element("searchInclude", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> SearchInclude {get; set;}
[Element("searchRevInclude", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> SearchRevInclude {get; set;}
[Element("searchParam", typeof(SearchParam), false, true, false, true)]
public IEnumerable<SearchParam> SearchParam {get; set;}
[Element("operation", typeof(Operation), false, true, false, true)]
public IEnumerable<Operation> Operation {get; set;}

        #endregion
        #region Constructor
        public  Resource() { }
        public  Resource(string value) : base(value) { }
        public  Resource(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Resource";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
