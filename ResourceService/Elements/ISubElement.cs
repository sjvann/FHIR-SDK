using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    internal interface ISubElement
    {
        string ElementName { get; }
        bool CheckElement(FHIRDefinedType checker);

        T GetResourc<T>() where T : Resource;
        T GetDataType<T>() where T : DataType;
    }
}