using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CdsHooks
{
    public interface IPrefetchService
    {
        HookServiceModel? GetHook(string id);
        ServicesModel? GetHooks();
    }
}
