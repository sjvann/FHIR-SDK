
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.BundleSub.EntrySub
{
    public class Request : BackboneElement<Request>
    {

        #region Property
        [Element("method", typeof(FhirCode), true, false, false, false)]
public FhirCode Method {get; set;}
[Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}
[Element("ifNoneMatch", typeof(FhirString), true, false, false, false)]
public FhirString IfNoneMatch {get; set;}
[Element("ifModifiedSince", typeof(FhirInstant), true, false, false, false)]
public FhirInstant IfModifiedSince {get; set;}
[Element("ifMatch", typeof(FhirString), true, false, false, false)]
public FhirString IfMatch {get; set;}
[Element("ifNoneExist", typeof(FhirString), true, false, false, false)]
public FhirString IfNoneExist {get; set;}

        #endregion
        #region Constructor
        public  Request() { }
        public  Request(string value) : base(value) { }
        public  Request(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Request";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
