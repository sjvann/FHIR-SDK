using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceMgr
{
    interface IResourceType<T> where T:Resource
    {
        T GetResource(int id);
        List<T> GetResources();
        T SaveResource(T source);
        T UpdateResource(T source);
        bool DeleteResource(int id);


    }
}
