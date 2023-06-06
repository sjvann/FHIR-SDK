
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CapabilityStatementSub.RestSub.ResourceSub
{
    public class SearchParam : BackboneElement<SearchParam>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("definition", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Definition {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("documentation", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Documentation {get; set;}

        #endregion
        #region Constructor
        public  SearchParam() { }
        public  SearchParam(string value) : base(value) { }
        public  SearchParam(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SearchParam";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
