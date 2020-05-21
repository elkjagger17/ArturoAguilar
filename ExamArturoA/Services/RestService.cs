using System;
using System.Net.Http;
using System.Threading.Tasks;
using ExamArturoA.Models.Request;
using ExamArturoA.Models.Response;

namespace ExamArturoA.Services
{
    /// <summary>
    /// HTTP Class for get Api Services
    /// </summary>
    public class RestService
    {
        private HttpClient httpClient = new HttpClient();

        /// <summary>
        /// Small Get implementation 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Task<string> Get (string url)
        {
            return httpClient.GetStringAsync(url);
        }
    }
}
