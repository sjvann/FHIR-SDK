

using DataTypeService.Complex;

namespace DataTypeService.Based
{
    public interface IExtenable
    {
        List<Extension>? Extension { get; set; }
    }
    public interface IModifierExtenable : IExtenable
    {
        List<Extension>? ModifierExtension { get; set; }
    }

    public static class ExtonsionExtension
    {
        public static IEnumerable<Extension> AllExtensions(this IExtenable extension)
        {
            if (extension is IModifierExtenable target && target.ModifierExtension != null && target.ModifierExtension.Any() && target.Extension != null)
            {
                return target.ModifierExtension.Concat(target.Extension);
            }
            else
            {
                return extension.Extension ?? new List<Extension>();
            }
        }

    }
}
