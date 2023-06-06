
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImplementationGuideSub.ManifestSub
{
    public class Page : BackboneElement<Page>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("anchor", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Anchor {get; set;}

        #endregion
        #region Constructor
        public  Page() { }
        public  Page(string value) : base(value) { }
        public  Page(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Page";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
