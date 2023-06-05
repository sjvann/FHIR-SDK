using DataTypeHelper.Complex;
using DataTypeHelper.Meta;

namespace DataTypeHelper.Choice
{
    public class AddressChoiceHelper
    {
        #region Property
        public string? AddressUrl { get; set; }
        public string? AddressStrint { get; set; }
        public ContactPointHelper? AddressContactPoint { get; set; }
        public ExtendedContactDetailHelper? AddressExtendedContactDetail { get; set; }
        #endregion

    }
}
