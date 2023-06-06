
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.TestScriptSub.SetupSub.ActionSub.AssertSub;

namespace ResourceTypeServices.R5.TestScriptSub.SetupSub.ActionSub
{
    public class Assert : BackboneElement<Assert>
    {

        #region Property
        [Element("label", typeof(FhirString), true, false, false, false)]
public FhirString Label {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("direction", typeof(FhirCode), true, false, false, false)]
public FhirCode Direction {get; set;}
[Element("compareToSourceId", typeof(FhirString), true, false, false, false)]
public FhirString CompareToSourceId {get; set;}
[Element("compareToSourceExpression", typeof(FhirString), true, false, false, false)]
public FhirString CompareToSourceExpression {get; set;}
[Element("compareToSourcePath", typeof(FhirString), true, false, false, false)]
public FhirString CompareToSourcePath {get; set;}
[Element("contentType", typeof(FhirCode), true, false, false, false)]
public FhirCode ContentType {get; set;}
[Element("defaultManualCompletion", typeof(FhirCode), true, false, false, false)]
public FhirCode DefaultManualCompletion {get; set;}
[Element("expression", typeof(FhirString), true, false, false, false)]
public FhirString Expression {get; set;}
[Element("headerField", typeof(FhirString), true, false, false, false)]
public FhirString HeaderField {get; set;}
[Element("minimumId", typeof(FhirString), true, false, false, false)]
public FhirString MinimumId {get; set;}
[Element("navigationLinks", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean NavigationLinks {get; set;}
[Element("operator", typeof(FhirCode), true, false, false, false)]
public FhirCode Operator {get; set;}
[Element("path", typeof(FhirString), true, false, false, false)]
public FhirString Path {get; set;}
[Element("requestMethod", typeof(FhirCode), true, false, false, false)]
public FhirCode RequestMethod {get; set;}
[Element("requestURL", typeof(FhirString), true, false, false, false)]
public FhirString RequestURL {get; set;}
[Element("resource", typeof(FhirUri), true, false, false, false)]
public FhirUri Resource {get; set;}
[Element("response", typeof(FhirCode), true, false, false, false)]
public FhirCode Response {get; set;}
[Element("responseCode", typeof(FhirString), true, false, false, false)]
public FhirString ResponseCode {get; set;}
[Element("sourceId", typeof(FhirId), true, false, false, false)]
public FhirId SourceId {get; set;}
[Element("stopTestOnFail", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean StopTestOnFail {get; set;}
[Element("validateProfileId", typeof(FhirId), true, false, false, false)]
public FhirId ValidateProfileId {get; set;}
[Element("value", typeof(FhirString), true, false, false, false)]
public FhirString Value {get; set;}
[Element("warningOnly", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean WarningOnly {get; set;}
[Element("requirement", typeof(Requirement), false, true, false, true)]
public IEnumerable<Requirement> Requirement {get; set;}

        #endregion
        #region Constructor
        public  Assert() { }
        public  Assert(string value) : base(value) { }
        public  Assert(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Assert";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
