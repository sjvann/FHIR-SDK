
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.TerminologyCapabilitiesSub.CodeSystemSub;

namespace ResourceTypeServices.R5.TerminologyCapabilitiesSub
{
    public class CodeSystem : BackboneElement<CodeSystem>
    {

        #region Property
        [Element("uri", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Uri {get; set;}
[Element("version", typeof(ResourceTypeServices.R5.TerminologyCapabilitiesSub.CodeSystemSub.Version), false, true, false, true)]
public IEnumerable<ResourceTypeServices.R5.TerminologyCapabilitiesSub.CodeSystemSub.Version> Version {get; set;}
[Element("content", typeof(FhirCode), true, false, false, false)]
public FhirCode Content {get; set;}
[Element("subsumption", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Subsumption {get; set;}

        #endregion
        #region Constructor
        public  CodeSystem() { }
        public  CodeSystem(string value) : base(value) { }
        public  CodeSystem(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "CodeSystem";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
