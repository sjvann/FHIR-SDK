

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.OperationDefinitionSub
{
    public class OperationDefinition : DomainResource<OperationDefinition>
    {
        #region Property
        [Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}
[Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("versionAlgorithm", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased VersionAlgorithm {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("kind", typeof(FhirCode), true, false, false, false)]
public FhirCode Kind {get; set;}
[Element("experimental", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Experimental {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("publisher", typeof(FhirString), true, false, false, false)]
public FhirString Publisher {get; set;}
[Element("contact", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Contact {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("useContext", typeof(UsageContext), false, true, false, false)]
public IEnumerable<UsageContext> UseContext {get; set;}
[Element("jurisdiction", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Jurisdiction {get; set;}
[Element("purpose", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Purpose {get; set;}
[Element("copyright", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Copyright {get; set;}
[Element("copyrightLabel", typeof(FhirString), true, false, false, false)]
public FhirString CopyrightLabel {get; set;}
[Element("affectsState", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean AffectsState {get; set;}
[Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("comment", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Comment {get; set;}
[Element("base", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Base {get; set;}
[Element("resource", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Resource {get; set;}
[Element("system", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean System {get; set;}
[Element("type", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Type {get; set;}
[Element("instance", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Instance {get; set;}
[Element("inputProfile", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical InputProfile {get; set;}
[Element("outputProfile", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical OutputProfile {get; set;}
[Element("parameter", typeof(Parameter), false, true, false, true)]
public IEnumerable<Parameter> Parameter {get; set;}
[Element("overload", typeof(Overload), false, true, false, true)]
public IEnumerable<Overload> Overload {get; set;}

        #endregion
        #region Constructor
        public  OperationDefinition() { }

        public  OperationDefinition(string value) : base(value) { }
        public  OperationDefinition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "OperationDefinition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
