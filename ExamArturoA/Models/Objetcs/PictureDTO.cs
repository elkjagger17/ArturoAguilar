using System;
using Newtonsoft.Json;

namespace ExamArturoA.Models.Objetcs
{
    /// <summary>
    /// PictureDTO
    /// </summary>
    public class PictureDTO
    {
        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }
}
