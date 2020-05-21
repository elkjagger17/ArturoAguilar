using System;
using Newtonsoft.Json;

namespace ExamArturoA.Models.Objetcs
{
    /// <summary>
    /// ResultDTO
    /// </summary>
    public class ResultDTO
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("picture")]
        public PictureDTO Picture { get; set; }

        [JsonProperty("name")]
        public NameDTO Name { get; set; }

        [JsonProperty("location")]
        public LocationDTO Location { get; set; }

    }
}
