using DataTypeHelper.Complex;
using DataTypeHelper.Special;

namespace DataTypeHelper.Meta
{
    public class ExtendedContactDetailHelper 
    {

        #region Property
        public CodeableConceptHelper? Purpose { get; set; }
        public List<HumanNameHelper>? Name { get; set; }
        public List<ContactPointHelper>? Telecom { get; set; }
        public AddressHelper? Address { get; set; }
        public ReferenceHelper? Organization { get; set; }
        public PeriodHelper? Period { get;set; }

        #endregion
      
    }
}
