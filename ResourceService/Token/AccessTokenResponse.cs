using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ResourceMgr.Token
{
    public class AccessTokenResponse
    {
        [JsonProperty("aud")]
        public string FhirServerUrl { get; set; }
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        [JsonProperty("expires_in")]
        public decimal ExpiresIn { get; set; }
        [JsonProperty("scope")]
        public string Scope { get; set; }
        [JsonProperty("id_token")]
        public string IDToken { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }
        [JsonProperty("patient")]
        public string PatientID { get; set; }
        [JsonProperty("__epic.dstu2.patient")]
        public string PatientIDDstu2 { get; set; }
        [JsonProperty("encounter")]
        public string EncounterID { get; set; }
        [JsonProperty("user")]
        public string UserID { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
        [JsonProperty("loginDepartment")]
        public string DepartmentID { get; set; }
        [JsonProperty("appointment")]
        public string AppointmentID { get; set; }
        [JsonProperty("need_patient_banner")]
        public bool NeedPatientBanner { get; set; }
        [JsonProperty("smart_style_url")]
        public string SmartStyleUrl { get; set; }

    }
}
