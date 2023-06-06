

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.StructureDefinitionSub
{
    public class StructureDefinition : DomainResource<StructureDefinition>
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
[Element("keyword", typeof(Coding), false, true, false, false)]
public IEnumerable<Coding> Keyword {get; set;}
[Element("fhirVersion", typeof(FhirCode), true, false, false, false)]
public FhirCode FhirVersion {get; set;}
[Element("mapping", typeof(Mapping), false, true, false, true)]
public IEnumerable<Mapping> Mapping {get; set;}
[Element("kind", typeof(FhirCode), true, false, false, false)]
public FhirCode Kind {get; set;}
[Element("abstract", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Abstract {get; set;}
[Element("context", typeof(Context), false, true, false, true)]
public IEnumerable<Context> Context {get; set;}
[Element("contextInvariant", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> ContextInvariant {get; set;}
[Element("type", typeof(FhirUri), true, false, false, false)]
public FhirUri Type {get; set;}
[Element("baseDefinition", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical BaseDefinition {get; set;}
[Element("derivation", typeof(FhirCode), true, false, false, false)]
public FhirCode Derivation {get; set;}
[Element("snapshot", typeof(Snapshot), false, false, false, true)]
public Snapshot Snapshot {get; set;}
[Element("differential", typeof(Differential), false, false, false, true)]
public Differential Differential {get; set;}

        #endregion
        #region Constructor
        public  StructureDefinition() { }

        public  StructureDefinition(string value) : base(value) { }
        public  StructureDefinition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "StructureDefinition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
