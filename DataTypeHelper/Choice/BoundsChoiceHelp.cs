using DataTypeHelper.Complex;

namespace DataTypeHelper.Choice
{
    public class BoundsChoiceHelper
    {
        #region Property
        public DurationHelper? BoundsDuration { get; set; }
        public RangeHelper? BoundsRange { get; set; }
        public PeriodHelper? BoundsPeriod { get; set; }
        #endregion

    }
}
