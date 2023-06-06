
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.TerminologyCapabilitiesSub.ExpansionSub;

namespace ResourceTypeServices.R5.TerminologyCapabilitiesSub
{
    public class Expansion : BackboneElement<Expansion>
    {

        #region Property
        [Element("hierarchical", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Hierarchical {get; set;}
[Element("paging", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Paging {get; set;}
[Element("incomplete", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Incomplete {get; set;}
[Element("parameter", typeof(Parameter), false, true, false, true)]
public IEnumerable<Parameter> Parameter {get; set;}
[Element("textFilter", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown TextFilter {get; set;}

        #endregion
        #region Constructor
        public  Expansion() { }
        public  Expansion(string value) : base(value) { }
        public  Expansion(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Expansion";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
