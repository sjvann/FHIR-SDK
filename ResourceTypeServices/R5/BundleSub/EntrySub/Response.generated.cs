
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeBased;

namespace ResourceTypeServices.R5.BundleSub.EntrySub
{
    public class Response : BackboneElement<Response>
    {

        #region Property
        [Element("status", typeof(FhirString), true, false, false, false)]
public FhirString Status {get; set;}
[Element("location", typeof(FhirUri), true, false, false, false)]
public FhirUri Location {get; set;}
[Element("etag", typeof(FhirString), true, false, false, false)]
public FhirString Etag {get; set;}
[Element("lastModified", typeof(FhirInstant), true, false, false, false)]
public FhirInstant LastModified {get; set;}
[Element("outcome", typeof(Resource), false, false, false, false)]
public Resource Outcome {get; set;}

        #endregion
        #region Constructor
        public  Response() { }
        public  Response(string value) : base(value) { }
        public  Response(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Response";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
