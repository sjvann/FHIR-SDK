using DataTypeService.Complex;

namespace DataTypeService.Based
{
    public interface IElement
    {
        string? Id { get; set; }
        List<Extension>? Extension { get; set; }

    }
}
