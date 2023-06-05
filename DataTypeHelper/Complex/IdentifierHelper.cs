using DataTypeHelper.Special;

namespace DataTypeHelper.Complex
{
    public class IdentifierHelper
    {
        #region Property
        public string? Use { get; set; }
        public CodeableConceptHelper? Type { get; set; }
        public string? System { get; set; }
        public string? Value { get; set; }
        public PeriodHelper? Period { get; set; }
        public ReferenceHelper? Assigner { get; set; }

        #endregion
    }
}