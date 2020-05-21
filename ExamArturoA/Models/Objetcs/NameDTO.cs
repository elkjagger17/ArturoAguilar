using System;
using Newtonsoft.Json;

namespace ExamArturoA.Models.Objetcs
{
    /// <summary>
    /// NameDTO
    /// </summary>
    public class NameDTO
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }
    }
}
