using System;
using System.Collections.Generic;
using ExamArturoA.Models.Objetcs;
using Newtonsoft.Json;

namespace ExamArturoA.Models.Response
{
    /// <summary>
    /// Response class for user list
    /// </summary>
    public class UserResponseDTO : ReponseBaseDTO
    {
        [JsonProperty("results")]
        public List<ResultDTO> Results { get; set; }
    }
}
