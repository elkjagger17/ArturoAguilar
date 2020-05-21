using System;
using Newtonsoft.Json;

namespace ExamArturoA.Models.Objetcs
{
    /// <summary>
    /// LocationDTO
    /// </summary>
    public class LocationDTO
    {
        [JsonProperty("street")]
        public StreetDTO Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postcode")]
        public object Postcode { get; set; }

    }
}
