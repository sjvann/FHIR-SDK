
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImplementationGuideSub.ManifestSub
{
    public class Resource : BackboneElement<Resource>
    {

        #region Property
        [Element("reference", typeof(Reference), false, false, false, false)]
public Reference Reference {get; set;}
[Element("isExample", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean IsExample {get; set;}
[Element("profile", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> Profile {get; set;}
[Element("relativePath", typeof(FhirUrl), true, false, false, false)]
public FhirUrl RelativePath {get; set;}

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
