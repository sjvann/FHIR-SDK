

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.PackagedProductDefinitionSub
{
    public class PackagedProductDefinition : DomainResource<PackagedProductDefinition>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("packageFor", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PackageFor {get; set;}
[Element("status", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Status {get; set;}
[Element("statusDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime StatusDate {get; set;}
[Element("containedItemQuantity", typeof(Quantity), false, true, false, false)]
public IEnumerable<Quantity> ContainedItemQuantity {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("legalStatusOfSupply", typeof(LegalStatusOfSupply), false, true, false, true)]
public IEnumerable<LegalStatusOfSupply> LegalStatusOfSupply {get; set;}
[Element("marketingStatus", typeof(MarketingStatus), false, true, false, false)]
public IEnumerable<MarketingStatus> MarketingStatus {get; set;}
[Element("copackagedIndicator", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean CopackagedIndicator {get; set;}
[Element("manufacturer", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Manufacturer {get; set;}
[Element("attachedDocument", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> AttachedDocument {get; set;}
[Element("packaging", typeof(Packaging), false, false, false, true)]
public Packaging Packaging {get; set;}

        #endregion
        #region Constructor
        public  PackagedProductDefinition() { }

        public  PackagedProductDefinition(string value) : base(value) { }
        public  PackagedProductDefinition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "PackagedProductDefinition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
