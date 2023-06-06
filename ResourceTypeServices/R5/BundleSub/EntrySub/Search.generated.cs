
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.BundleSub.EntrySub
{
    public class Search : BackboneElement<Search>
    {

        #region Property
        [Element("mode", typeof(FhirCode), true, false, false, false)]
public FhirCode Mode {get; set;}
[Element("score", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Score {get; set;}

        #endregion
        #region Constructor
        public  Search() { }
        public  Search(string value) : base(value) { }
        public  Search(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Search";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
