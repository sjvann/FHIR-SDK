

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.InventoryReportSub
{
    public class InventoryReport : DomainResource<InventoryReport>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("countType", typeof(FhirCode), true, false, false, false)]
public FhirCode CountType {get; set;}
[Element("operationType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept OperationType {get; set;}
[Element("operationTypeReason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept OperationTypeReason {get; set;}
[Element("reportedDateTime", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime ReportedDateTime {get; set;}
[Element("reporter", typeof(Reference), false, false, false, false)]
public Reference Reporter {get; set;}
[Element("reportingPeriod", typeof(Period), false, false, false, false)]
public Period ReportingPeriod {get; set;}
[Element("inventoryListing", typeof(InventoryListing), false, true, false, true)]
public IEnumerable<InventoryListing> InventoryListing {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  InventoryReport() { }

        public  InventoryReport(string value) : base(value) { }
        public  InventoryReport(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "InventoryReport";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
