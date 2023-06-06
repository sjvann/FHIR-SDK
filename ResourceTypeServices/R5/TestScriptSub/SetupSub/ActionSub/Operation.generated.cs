
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.TestScriptSub.SetupSub.ActionSub.OperationSub;

namespace ResourceTypeServices.R5.TestScriptSub.SetupSub.ActionSub
{
    public class Operation : BackboneElement<Operation>
    {

        #region Property
        [Element("type", typeof(Coding), false, false, false, false)]
public Coding Type {get; set;}
[Element("resource", typeof(FhirUri), true, false, false, false)]
public FhirUri Resource {get; set;}
[Element("label", typeof(FhirString), true, false, false, false)]
public FhirString Label {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("accept", typeof(FhirCode), true, false, false, false)]
public FhirCode Accept {get; set;}
[Element("contentType", typeof(FhirCode), true, false, false, false)]
public FhirCode ContentType {get; set;}
[Element("destination", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Destination {get; set;}
[Element("encodeRequestUrl", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean EncodeRequestUrl {get; set;}
[Element("method", typeof(FhirCode), true, false, false, false)]
public FhirCode Method {get; set;}
[Element("origin", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Origin {get; set;}
[Element("params", typeof(FhirString), true, false, false, false)]
public FhirString Params {get; set;}
[Element("requestHeader", typeof(RequestHeader), false, true, false, true)]
public IEnumerable<RequestHeader> RequestHeader {get; set;}
[Element("requestId", typeof(FhirId), true, false, false, false)]
public FhirId RequestId {get; set;}
[Element("responseId", typeof(FhirId), true, false, false, false)]
public FhirId ResponseId {get; set;}
[Element("sourceId", typeof(FhirId), true, false, false, false)]
public FhirId SourceId {get; set;}
[Element("targetId", typeof(FhirId), true, false, false, false)]
public FhirId TargetId {get; set;}
[Element("url", typeof(FhirString), true, false, false, false)]
public FhirString Url {get; set;}

        #endregion
        #region Constructor
        public  Operation() { }
        public  Operation(string value) : base(value) { }
        public  Operation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Operation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
