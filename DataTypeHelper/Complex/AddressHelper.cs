namespace DataTypeHelper.Complex
{
    public  class AddressHelper
    {
        #region Property      
        public  string? Use { get; set; }
        public string? Type { get; set; }
        public string? Text { get; set; }
        public string[]? Line { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public PeriodHelper? Period { get; set; }
        #endregion
    }
}