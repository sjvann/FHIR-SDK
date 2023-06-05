


using DataTypeHelper.Special;


namespace DataTypeHelper.Complex
{
    public class SignatureHelper
    {
        #region Property
        public CodingHelper[]? Type { get; set; }
        public System.DateTime? When { get; set; }
        public ReferenceHelper? Who { get; set; }
        public ReferenceHelper? OnBehalfOf { get; set; }
        public string? TargetFormat { get; set; }
        public string? SigFormat { get; set; }
        public string? Data { get; set; }
        #endregion
      
    }
}
