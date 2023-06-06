using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceMgr
{
    public class FhirServer : IFhirServer
    {
        private readonly string _basedUrl;
        private readonly string _accessToken;
        private readonly DateTime _expiredTime;
        
        private const int ALLOWANCE = 3;
        #region Constructure
        public FhirServer(string basedUrl)
        {
            _basedUrl = basedUrl;
        }
        public FhirServer(string basedUrl, string accessToken, int? expiredIn)
        {
            _basedUrl = basedUrl;
            _accessToken = accessToken;
            _expiredTime =  DateTime.Now.AddSeconds(expiredIn??3*24*60*760);
        }

        #endregion

        #region Public Method
        public string GetAccessToken()
        {
            return _accessToken;
        }

        public string GetBasedUrl()
        {
            return _basedUrl;
        }

        public bool IsExpired()
        {

            return DateTime.Now.AddMinutes(ALLOWANCE) >= _expiredTime;
        }
        #endregion
    }
}
