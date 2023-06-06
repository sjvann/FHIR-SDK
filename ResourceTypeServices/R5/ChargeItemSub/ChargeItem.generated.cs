

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ChargeItemSub
{
    public class ChargeItem : DomainResource<ChargeItem>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("definitionUri", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> DefinitionUri {get; set;}
[Element("definitionCanonical", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> DefinitionCanonical {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("partOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PartOf {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("occurrence", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Occurrence {get; set;}
[Element("performer", typeof(Performer), false, true, false, true)]
public IEnumerable<Performer> Performer {get; set;}
[Element("performingOrganization", typeof(Reference), false, false, false, false)]
public Reference PerformingOrganization {get; set;}
[Element("requestingOrganization", typeof(Reference), false, false, false, false)]
public Reference RequestingOrganization {get; set;}
[Element("costCenter", typeof(Reference), false, false, false, false)]
public Reference CostCenter {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("bodysite", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Bodysite {get; set;}
[Element("unitPriceComponent", typeof(MonetaryComponent), false, false, false, false)]
public MonetaryComponent UnitPriceComponent {get; set;}
[Element("totalPriceComponent", typeof(MonetaryComponent), false, false, false, false)]
public MonetaryComponent TotalPriceComponent {get; set;}
[Element("overrideReason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept OverrideReason {get; set;}
[Element("enterer", typeof(Reference), false, false, false, false)]
public Reference Enterer {get; set;}
[Element("enteredDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime EnteredDate {get; set;}
[Element("reason", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Reason {get; set;}
[Element("service", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Service {get; set;}
[Element("product", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Product {get; set;}
[Element("account", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Account {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("supportingInformation", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingInformation {get; set;}

        #endregion
        #region Constructor
        public  ChargeItem() { }

        public  ChargeItem(string value) : base(value) { }
        public  ChargeItem(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ChargeItem";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
