using System;
using Newtonsoft.Json;

namespace ExamArturoA.Models.Objetcs
{
    /// <summary>
    /// StreetDTO
    /// </summary>
    public class StreetDTO
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
