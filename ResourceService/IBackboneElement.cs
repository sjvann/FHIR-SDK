using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceMgr
{
    public interface IBackboneElement<out T> where T : BackboneElement
    {
        public T GetComponent();
    }
}
