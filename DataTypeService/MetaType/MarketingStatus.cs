using Core.Extension;
using DataTypeService.Based;
using DataTypeService.Choice;
using DataTypeService.Complex;
using System.Text.Json.Nodes;

namespace DataTypeService.Meta
{
    public class MarketingStatus : ComplexType
    {

        #region Property
        public CodeableConcept? Country { get; set; }
        public CodeableConcept? Jurisdiction { get; set; }
        public CodeableConcept? Status { get; set; }
        public Period? DateRange { get; set; }
        public Primitive.FhirDateTime? RestoreDate { get; set; }


        #endregion
        #region Constructor
        public MarketingStatus() { }
        public MarketingStatus(string? value) : this(value.Parse()) { }
        public MarketingStatus(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "country": Country = new(cv); break;
                        case "jurisdiction": Jurisdiction = new(cv); break;
                        case "status": Status = new(cv); break;
                        case "dateRange": DateRange = new(cv); break;
                        case "restoreDate": RestoreDate = new(cv); break;



                    }
                }
            }

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "MarketingStatus ";
        #endregion

        #region Public Method
        public override void SetProperties(string? tagName = null)
        {
            List<KeyValuePair<string, JsonNode?>> result = new();
            if (Country is CodeableConcept countryValue) { result.Add(ForComplexType("country", countryValue)); }
            if (Jurisdiction is CodeableConcept jurisdictionValue) { result.Add(ForComplexType("jurisdiction", jurisdictionValue)); }
            if (Status is CodeableConcept statusValue) { result.Add(ForComplexType("status", statusValue)); }
            if (DateRange is Period dateRangeValue) { result.Add(ForComplexType("dateRange", dateRangeValue)); }
            if (RestoreDate is Primitive.FhirDateTime restoreDateValue) { result.Add(ForPrimitiveType("restoreDate", restoreDateValue)); }

            _Properties = result;
        }
        #endregion
    }
}
