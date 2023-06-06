using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TerminologyService.EnumValueSet
{

    public enum AccountStatus
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive,
        [EnumMember(Value = " entered-in-error")]
        EnteredInError,
        [EnumMember(Value = " on-hold")]
        OnHold,
        [EnumMember(Value = " unknown")]
        Unknown,
    }
}
