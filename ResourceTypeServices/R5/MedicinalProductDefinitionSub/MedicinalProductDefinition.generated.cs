

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MedicinalProductDefinitionSub
{
    public class MedicinalProductDefinition : DomainResource<MedicinalProductDefinition>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("domain", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Domain {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("status", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Status {get; set;}
[Element("statusDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime StatusDate {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("combinedPharmaceuticalDoseForm", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept CombinedPharmaceuticalDoseForm {get; set;}
[Element("route", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Route {get; set;}
[Element("indication", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Indication {get; set;}
[Element("legalStatusOfSupply", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept LegalStatusOfSupply {get; set;}
[Element("additionalMonitoringIndicator", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AdditionalMonitoringIndicator {get; set;}
[Element("specialMeasures", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> SpecialMeasures {get; set;}
[Element("pediatricUseIndicator", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept PediatricUseIndicator {get; set;}
[Element("classification", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Classification {get; set;}
[Element("marketingStatus", typeof(MarketingStatus), false, true, false, false)]
public IEnumerable<MarketingStatus> MarketingStatus {get; set;}
[Element("packagedMedicinalProduct", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> PackagedMedicinalProduct {get; set;}
[Element("comprisedOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> ComprisedOf {get; set;}
[Element("ingredient", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Ingredient {get; set;}
[Element("impurity", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Impurity {get; set;}
[Element("attachedDocument", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> AttachedDocument {get; set;}
[Element("masterFile", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> MasterFile {get; set;}
[Element("contact", typeof(Contact), false, true, false, true)]
public IEnumerable<Contact> Contact {get; set;}
[Element("clinicalTrial", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> ClinicalTrial {get; set;}
[Element("code", typeof(Coding), false, true, false, false)]
public IEnumerable<Coding> Code {get; set;}
[Element("name", typeof(Name), false, true, false, true)]
public IEnumerable<Name> Name {get; set;}
[Element("crossReference", typeof(CrossReference), false, true, false, true)]
public IEnumerable<CrossReference> CrossReference {get; set;}
[Element("operation", typeof(Operation), false, true, false, true)]
public IEnumerable<Operation> Operation {get; set;}
[Element("characteristic", typeof(Characteristic), false, true, false, true)]
public IEnumerable<Characteristic> Characteristic {get; set;}

        #endregion
        #region Constructor
        public  MedicinalProductDefinition() { }

        public  MedicinalProductDefinition(string value) : base(value) { }
        public  MedicinalProductDefinition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "MedicinalProductDefinition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
