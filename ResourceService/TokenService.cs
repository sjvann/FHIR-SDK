using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Web;
using ResourceMgr.Token;

namespace ResourceMgr
{
    public class TokenService
    {
        private readonly string _clientId;
        private readonly string _iss;
        private readonly string _launch;
        private readonly string _redirectUrl;
        private string _authorizeUrl;
        private string _tokenUrl;
        private string _code;
        private string _state;

        private const string OAUTHURI = @"http://fhir-registry.smarthealthit.org/StructureDefinition/oauth-uris";

        public TokenService(string clientId, string iss, string launch, string redirectUrl)
        {
            _clientId = clientId;
            _iss = iss;
            _launch = launch;
            _redirectUrl = redirectUrl;
          
        }
        public TokenService(string clientId, string iss, string launch, string redirectUrl, string tokenUrl)
        {
            _clientId = clientId;
            _iss = iss;
            _launch = launch;
            _redirectUrl = redirectUrl;
            _tokenUrl = tokenUrl;

        }
        #region Public Method
        public Dictionary<string, object> TokenResult { get; set; }
        public void GetOAuthInformation()
        {
            FhirClient client = new FhirClient(new Uri(_iss));
            var cp = client.CapabilityStatement();
            var ex = cp.Rest[0].Security.GetExtension(OAUTHURI);
            _authorizeUrl = ex?.GetExtension("authorize").Value.ToString();
            _tokenUrl = ex?.GetExtension("token").Value.ToString();
        }
        public LaunchResponse GetAuthorize()
        {
            string uri = GetAuthorizationUri();
            return new LaunchResponse(uri, _authorizeUrl, _tokenUrl);
        }
        
        public Dictionary<string, object> InitToken()
        {
            Dictionary<string, object> tmp = new();
            _code = GetAuthorizationCodeByGet();
            if (string.IsNullOrEmpty(_code))
            {
                var result = GetAuthorizationCodeByPost().Result;
                _code = result.ContainsKey("code") ? result["code"] : string.Empty;
                if (!string.IsNullOrEmpty(_code))
                {
                    tmp = GetAccessTokenByPost();
                }
            }
            TokenResult = tmp;
            return tmp;

        }

        public AccessTokenResponse GetToken(string code, string state)
        {
            _code = code;
            _state = state;
            var result = GetAccessTokenByPost();
            return MapToAccessTokenResponse(result);
        }
        public AccessTokenResponse GetToken()
        {
            AccessTokenResponse token = new();
            if(TokenResult != null)
            {
                token.AccessToken = TokenResult.ContainsKey("access_token") ? (string)TokenResult["_tokenResult"] : string.Empty;
                token.AppointmentID = TokenResult.ContainsKey("appointment") ? (string)TokenResult["appointment"] : string.Empty;
                token.DepartmentID = TokenResult.ContainsKey("appointment") ? (string)TokenResult["appointment"] : string.Empty;
                token.Dob = TokenResult.ContainsKey("dob") ? (string)TokenResult["dob"] : string.Empty;
                token.EncounterID = TokenResult.ContainsKey("encounter") ? (string)TokenResult["encounter"] : string.Empty;
                token.ExpiresIn = TokenResult.ContainsKey("expires_in") ? (decimal)TokenResult["expires_in"] : 0;
                token.IDToken = TokenResult.ContainsKey("id_token") ? (string)TokenResult["id_token"] : string.Empty;
                token.Location = TokenResult.ContainsKey("location") ? (string)TokenResult["location"] : string.Empty;
                token.NeedPatientBanner = TokenResult.ContainsKey("need_patient_banner") && (bool)TokenResult["location"];
                token.PatientID = TokenResult.ContainsKey("patient") ? (string)TokenResult["patient"] : string.Empty;
                token.Scope = TokenResult.ContainsKey("scope") ? (string)TokenResult["scope"] : string.Empty;
                token.SmartStyleUrl = TokenResult.ContainsKey("smart_style_url") ? (string)TokenResult["smart_style_url"] : string.Empty;
                token.State = TokenResult.ContainsKey("state") ? (string)TokenResult["state"] : string.Empty;
                token.TokenType = TokenResult.ContainsKey("token_type") ? (string)TokenResult["token_type"] : string.Empty;
                token.UserID = TokenResult.ContainsKey("user") ? (string)TokenResult["user"] : string.Empty;
            }
          
           
            return token;

        }

        #endregion



        #region Private Method
        
        private Dictionary<string, object> GetAccessTokenByPost()
        {
            Dictionary<string, object> dicResult = new();
            using HttpClient client = new();
            HttpRequestMessage rq = new(HttpMethod.Post, _tokenUrl);
            rq.Content = new FormUrlEncodedContent(MapAccessToken());
            HttpResponseMessage rp = client.SendAsync(rq).GetAwaiter().GetResult();
            if (rp != null && rp.IsSuccessStatusCode)
            {
                string strResult = rp.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                dicResult = JsonConvert.DeserializeObject<Dictionary<string, object>>(strResult);
            }
            return dicResult;
        }

        private string GetAuthorizationUri()
        {

            string state = Guid.NewGuid().ToString();
            Dictionary<string, string> source = MapAuthorization(state);
            StringBuilder sb = new();
            string last = source.Values.Last();
            foreach (var key in source.Keys)
            {
                sb.Append(key).Append('=').Append(source[key]);
                if (source[key] != last)
                { sb.Append('&'); }
            }
            UriBuilder ub = new(_authorizeUrl) { Query = sb.ToString() };

            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpRequestMessage rq = new(HttpMethod.Get, ub.Uri);
            var rp = client.SendAsync(rq).GetAwaiter().GetResult();
            rp.EnsureSuccessStatusCode();
            return rp.RequestMessage.RequestUri.ToString();
        }

        private string GetAuthorizationCodeByGet()
        {

            string state = Guid.NewGuid().ToString();
            Dictionary<string, string> source = MapAuthorization(state);
            StringBuilder sb = new();
            string last = source.Values.Last();
            foreach (var item in source)
            {
                sb.Append(item.Key).Append('=').Append(item.Value);
                if (item.Value != last) { sb.Append('&'); }
            }
            UriBuilder ub = new(_authorizeUrl) { Query = sb.ToString() };

            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage rpm = client.GetAsync(ub.Uri).GetAwaiter().GetResult();
            if (rpm != null && rpm.IsSuccessStatusCode)
            {
                var newUri = rpm.RequestMessage.RequestUri;
                string stateBack = HttpUtility.ParseQueryString(newUri.Query).Get("state");
                if (state == stateBack)
                {
                    return HttpUtility.ParseQueryString(newUri.Query).Get("code");
                }
                else
                {
                    Console.WriteLine("並非原始訊息");
                }
            }
            return string.Empty;

        }

        private async Task<Dictionary<string, string>> GetAuthorizationCodeByPost()
        {
            Dictionary<string, string> r = new();
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var state = Guid.NewGuid().ToString();
            HttpContent content = new FormUrlEncodedContent(MapAuthorization(state));
            HttpResponseMessage rp = await client.PostAsync(_authorizeUrl, content);
            if (rp != null && rp.IsSuccessStatusCode)
            {
                string result = await rp.Content.ReadAsStringAsync();
                try
                {
                    r = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                    if (r.ContainsKey("state") && r["state"] != _state)
                    {
                        Console.WriteLine("非原始訊息");
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
            return r;
        }

        #endregion


        #region Map Reqeust/Response
        private AccessTokenResponse MapToAccessTokenResponse(Dictionary<string, object> source)
        {
            AccessTokenResponse result = new();
            result.AccessToken = source.ContainsKey("access_token") ?(string)source["access_token"] : string.Empty;
            result.AppointmentID = source.ContainsKey("appointment") ? (string)source["appointment"] : string.Empty;
            result.EncounterID = source.ContainsKey("encounter") ?(string)source["encounter"] : string.Empty;
            result.ExpiresIn = source.ContainsKey("expires_in") ? Convert.ToInt32(source["expires_in"]) : 0;
            result.IDToken = source.ContainsKey("id_token") ? (string)source["id_token"] : string.Empty;
            result.Location = source.ContainsKey("location") ? (string)source["location"] : string.Empty;
            result.DepartmentID = source.ContainsKey("loginDepartment") ? (string)source["loginDepartment"] : string.Empty;
            result.PatientID = source.ContainsKey("patient") ? (string)source["patient"] : string.Empty;
            result.Scope = source.ContainsKey("scope") ? (string)source["scope"] : string.Empty;
            result.State = source.ContainsKey("state") ? (string)source["state"] : string.Empty;
            result.TokenType = source.ContainsKey("token_type") ? (string)source["token_type"] : string.Empty;
            return result;
        }
        private Dictionary<string, string> MapAuthorization(string status)
        {

            var dict = new Dictionary<string, string>
            {
                {"client_id", _clientId },
                {"launch", _launch },
                {"aud",_iss },
                {"redirect_uri", _redirectUrl },
                {"response_type", "code" },
                {"scope", "launch profile openid fhirUser" },
                {"state",status}

            };
            return dict;
        }
        private Dictionary<string, string> MapAccessToken()
        {
            var dict = new Dictionary<string, string>
            {
                {"grant_type", "authorization_code" },
                {"client_id", _clientId },
                {"redirect_uri", _redirectUrl },
                {"code", _code }
            };
            return dict;
        }
        #endregion

    }
}
