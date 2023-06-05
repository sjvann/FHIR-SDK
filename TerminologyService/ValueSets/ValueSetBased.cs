using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminologyService.ValueSets
{
    public abstract class ValueSetBased
    {
        public string? OfficalUrl { get; init; }
        public string? ComputableName { get; init; }
        public string? Oid { get; init;  }
        public Dictionary<string, string[]>? ValueSet { get; init; }

    }
}
