
using System.Text.Json.Serialization;


namespace Core.CdsHooks
{
    public class HookModel
    {
        /// <summary>
        /// The hook this service should be invoked on.
        /// </summary>
        [JsonPropertyName("hook")]

        public string? Hook { get; set; }
        /// <summary>
        /// The {id} portion of the URL to this service which is available at {baseUrl}/cds-services/{id}
        /// </summary>
        [JsonPropertyName("id")]

        public string? Id { get; set; }

        /// <summary>
        /// The human-friendly name of this service.
        /// </summary>
        [JsonPropertyName("title")]

        public string? Title { get; set; }

        /// <summary>
        /// The description of this service.
        /// </summary>

        [JsonPropertyName("description")]

        public string? Description { get; set; }

        /// <summary>
        /// An object containing key/value pairs of FHIR queries that this service is requesting that the CDS Client prefetch and provide on each service call. The key is a string that describes the type of data being requested and the value is a string representing the FHIR query.
        /// </summary>
        [JsonPropertyName("prefetch")]

        public Dictionary<string, string>? Prefetch { get; set; }
    }
}
