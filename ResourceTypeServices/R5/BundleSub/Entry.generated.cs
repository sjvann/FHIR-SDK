
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

using DataTypeService.Primitive;
using ResourceTypeServices.R5.BundleSub.EntrySub;
using ResourceTypeBased;

namespace ResourceTypeServices.R5.BundleSub
{
    public class Entry : BackboneElement<Entry>
    {

        #region Property
        [Element("fullUrl", typeof(FhirUri), true, false, false, false)]
public FhirUri FullUrl {get; set;}
[Element("resource", typeof(Resource), false, false, false, false)]
public Resource Resource {get; set;}
[Element("search", typeof(Search), false, false, false, true)]
public Search Search {get; set;}
[Element("request", typeof(Request), false, false, false, true)]
public Request Request {get; set;}
[Element("response", typeof(Response), false, false, false, true)]
public Response Response {get; set;}

        #endregion
        #region Constructor
        public  Entry() { }
        public  Entry(string value) : base(value) { }
        public  Entry(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Entry";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
