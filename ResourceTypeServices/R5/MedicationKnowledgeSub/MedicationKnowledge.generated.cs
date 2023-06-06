

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub
{
    public class MedicationKnowledge : DomainResource<MedicationKnowledge>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("author", typeof(Reference), false, false, false, false)]
public Reference Author {get; set;}
[Element("intendedJurisdiction", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> IntendedJurisdiction {get; set;}
[Element("name", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Name {get; set;}
[Element("relatedMedicationKnowledge", typeof(RelatedMedicationKnowledge), false, true, false, true)]
public IEnumerable<RelatedMedicationKnowledge> RelatedMedicationKnowledge {get; set;}
[Element("associatedMedication", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> AssociatedMedication {get; set;}
[Element("productType", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ProductType {get; set;}
[Element("monograph", typeof(Monograph), false, true, false, true)]
public IEnumerable<Monograph> Monograph {get; set;}
[Element("preparationInstruction", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown PreparationInstruction {get; set;}
[Element("cost", typeof(Cost), false, true, false, true)]
public IEnumerable<Cost> Cost {get; set;}
[Element("monitoringProgram", typeof(MonitoringProgram), false, true, false, true)]
public IEnumerable<MonitoringProgram> MonitoringProgram {get; set;}
[Element("indicationGuideline", typeof(IndicationGuideline), false, true, false, true)]
public IEnumerable<IndicationGuideline> IndicationGuideline {get; set;}
[Element("medicineClassification", typeof(MedicineClassification), false, true, false, true)]
public IEnumerable<MedicineClassification> MedicineClassification {get; set;}
[Element("packaging", typeof(Packaging), false, true, false, true)]
public IEnumerable<Packaging> Packaging {get; set;}
[Element("clinicalUseIssue", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> ClinicalUseIssue {get; set;}
[Element("storageGuideline", typeof(StorageGuideline), false, true, false, true)]
public IEnumerable<StorageGuideline> StorageGuideline {get; set;}
[Element("regulatory", typeof(Regulatory), false, true, false, true)]
public IEnumerable<Regulatory> Regulatory {get; set;}
[Element("definitional", typeof(Definitional), false, false, false, true)]
public Definitional Definitional {get; set;}

        #endregion
        #region Constructor
        public  MedicationKnowledge() { }

        public  MedicationKnowledge(string value) : base(value) { }
        public  MedicationKnowledge(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "MedicationKnowledge";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
