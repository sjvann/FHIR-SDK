
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ImplementationGuideSub.ManifestSub;

namespace ResourceTypeServices.R5.ImplementationGuideSub
{
    public class Manifest : BackboneElement<Manifest>
    {

        #region Property
        [Element("rendering", typeof(FhirUrl), true, false, false, false)]
public FhirUrl Rendering {get; set;}
[Element("resource", typeof(Resource), false, true, false, true)]
public IEnumerable<Resource> Resource {get; set;}
[Element("page", typeof(Page), false, true, false, true)]
public IEnumerable<Page> Page {get; set;}
[Element("image", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Image {get; set;}
[Element("other", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Other {get; set;}

        #endregion
        #region Constructor
        public  Manifest() { }
        public  Manifest(string value) : base(value) { }
        public  Manifest(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Manifest";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
