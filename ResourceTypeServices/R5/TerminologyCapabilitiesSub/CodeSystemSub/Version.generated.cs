
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.TerminologyCapabilitiesSub.CodeSystemSub.VersionSub;

namespace ResourceTypeServices.R5.TerminologyCapabilitiesSub.CodeSystemSub
{
    public class Version : BackboneElement<Version>
    {

        #region Property
        [Element("code", typeof(FhirString), true, false, false, false)]
public FhirString Code {get; set;}
[Element("isDefault", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean IsDefault {get; set;}
[Element("compositional", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Compositional {get; set;}
[Element("language", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Language {get; set;}
[Element("filter", typeof(Filter), false, true, false, true)]
public IEnumerable<Filter> Filter {get; set;}
[Element("property", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Property {get; set;}

        #endregion
        #region Constructor
        public  Version() { }
        public  Version(string value) : base(value) { }
        public  Version(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Version";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
