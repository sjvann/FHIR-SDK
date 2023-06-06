using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceMgr.Token
{
   public class LaunchResponse
    {
        public LaunchResponse(string pageUrl, string authorizeUrl,  string tokenUrl)
        {
            PageUrl = pageUrl;
            AuthorizeUrl = authorizeUrl;
            TokenUrl = tokenUrl;
        }
        public string PageUrl { get; set; }
        public string AuthorizeUrl { get; set; }
        public string TokenUrl { get; set; }
    }
}
