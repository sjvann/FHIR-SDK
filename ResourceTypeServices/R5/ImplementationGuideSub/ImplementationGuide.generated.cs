

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImplementationGuideSub
{
    public class ImplementationGuide : DomainResource<ImplementationGuide>
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
[Element("packageId", typeof(FhirId), true, false, false, false)]
public FhirId PackageId {get; set;}
[Element("license", typeof(FhirCode), true, false, false, false)]
public FhirCode License {get; set;}
[Element("fhirVersion", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> FhirVersion {get; set;}
[Element("dependsOn", typeof(DependsOn), false, true, false, true)]
public IEnumerable<DependsOn> DependsOn {get; set;}
[Element("global", typeof(Global), false, true, false, true)]
public IEnumerable<Global> Global {get; set;}
[Element("definition", typeof(Definition), false, false, false, true)]
public Definition Definition {get; set;}
[Element("manifest", typeof(Manifest), false, false, false, true)]
public Manifest Manifest {get; set;}

        #endregion
        #region Constructor
        public  ImplementationGuide() { }

        public  ImplementationGuide(string value) : base(value) { }
        public  ImplementationGuide(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ImplementationGuide";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
