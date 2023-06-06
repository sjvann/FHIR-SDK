using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceMgr.Token
{
    public class AuthorizeResponse
    {
        public AuthorizeResponse(string code, string state)
        {
            Code = code;
            State = state;
        }
        public string Code { get; set; }
        public string State { get; set; }
    }
}
