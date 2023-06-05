using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class MarketingStatus : ComplexType<MarketingStatus>
    {

        #region Property
        [Element("country", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Country { get; set; }
        [Element("jurisdiction", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Jurisdiction { get; set; }
        [Element("status", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Status { get; set; }
        [Element("dateRange", typeof(Period), false, false, false, false)]
        public Period? DateRange { get; set; }
        [Element("restoreDate", typeof(FhirDateTime), true, false, false, false)]
        public FhirDateTime? RestoreDate { get; set; }


        #endregion
        #region Constructor
        public MarketingStatus() { }
        public MarketingStatus(string? value) : base(value) { }
        public MarketingStatus(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "MarketingStatus ";
        #endregion

        #region Public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
