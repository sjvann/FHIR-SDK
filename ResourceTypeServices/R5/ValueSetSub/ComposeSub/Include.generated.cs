
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ValueSetSub.ComposeSub.IncludeSub;

namespace ResourceTypeServices.R5.ValueSetSub.ComposeSub
{
    public class Include : BackboneElement<Include>
    {

        #region Property
        [Element("system", typeof(FhirUri), true, false, false, false)]
public FhirUri System {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("concept", typeof(Concept), false, true, false, true)]
public IEnumerable<Concept> Concept {get; set;}
[Element("filter", typeof(Filter), false, true, false, true)]
public IEnumerable<Filter> Filter {get; set;}
[Element("valueSet", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> ValueSet {get; set;}
[Element("copyright", typeof(FhirString), true, false, false, false)]
public FhirString Copyright {get; set;}

        #endregion
        #region Constructor
        public  Include() { }
        public  Include(string value) : base(value) { }
        public  Include(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Include";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
