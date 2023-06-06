using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminologyService
{
    public static class BindingChecker
    {
        public static bool CheckForFhirCode<TEnum>(string source) where TEnum: struct, Enum
        {
            return Enum.TryParse<TEnum>(source, out var _);
        }

    }
}
