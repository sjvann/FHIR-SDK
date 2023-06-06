

using Hl7.Fhir.Model;

namespace ResourceMgr
{
    public interface IFhirProfile
    {
        string GetFhirId();
        abstract string GetText();
        string GetFullUri();
        ResourceReference GetReference();
        int Count();
        abstract string GetResourceJson();

    }
}
