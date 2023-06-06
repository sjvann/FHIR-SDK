
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TerminologyCapabilitiesSub.CodeSystemSub.VersionSub
{
    public class Filter : BackboneElement<Filter>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("op", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Op {get; set;}

        #endregion
        #region Constructor
        public  Filter() { }
        public  Filter(string value) : base(value) { }
        public  Filter(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Filter";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
