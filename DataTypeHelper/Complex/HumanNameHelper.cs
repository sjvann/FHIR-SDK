namespace DataTypeHelper.Complex
{
    public class HumanNameHelper
    {
        #region Property      
        public string? Use { get; init; }
        public string? Text { get; init; }
        public string? Family { get; init; }
        public string[]? Given { get; init; }
        public string[]? Prefix { get; init; }
        public string[]? Suffix { get; init; }
        public PeriodHelper? Period { get; init; }
        #endregion
    }
}