using DataTypeHelper.Choice;
using DataTypeService.Choice;

namespace DataTypeService.Helper
{
    public static partial class DataTypeHelper
    {
        #region For Choice Type
        public static ChoiceAuthor? ToFhirChoiceAuthor(this AuthorChoiceHelper? v)
        {
            if (v != null)
            {
                if (v.AuthorReference != null)
                {
                    return new ChoiceAuthor("Author", v.AuthorReference.ToFhirReference());
                }
                else if (v.AuthorString != null)
                {
                    return new ChoiceAuthor("Author", v.AuthorString.ToFhirString());
                }
            }
            return null;

        }
        public static ChoiceBounds? ToFhirChoiceBounds(this BoundsChoiceHelper? v)
        {
            if (v != null)
            {
                if (v.BoundsDuration != null)
                {
                    return new ChoiceBounds("Author", v.BoundsDuration.ToFhirDuration());
                }
                else if (v.BoundsRange != null)
                {
                    return new ChoiceBounds("Author", v.BoundsRange.ToFhirRange());
                }
                else if( v.BoundsPeriod != null)
                {
                     return new ChoiceBounds("Author", v.BoundsPeriod.ToFhirPeriod());
                }
            }
            return null;

        }
        #endregion
    }
}
