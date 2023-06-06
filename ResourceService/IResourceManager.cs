using Hl7.Fhir.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResourceMgr
{
    interface IResourceManager
    {
        System.Threading.Tasks.Task DeleteResouceAsync<T>(int id) where T : Resource;
        Task<T> SaveResourceAsync<T>(Resource resource) where T : Resource;
        Task<T> UpdateResource<T>(Resource resource) where T : Resource;

    }
}
