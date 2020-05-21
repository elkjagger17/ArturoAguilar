using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ExamArturoA.Models.Objetcs;
using ExamArturoA.Models.Response;
using ExamArturoA.Services;
using Newtonsoft.Json;

namespace ExamArturoA.ViewModels
{
    /// <summary>
    /// Main VM get the list and others
    /// </summary>
	public class MainViewModel : BaseViewModel
    {

        public ObservableCollection<ResultDTO> Users;

        /// <summary>
        /// Const
        /// </summary>
        public MainViewModel()
        {
            Title = "Usuarios";
            var responseGet = GetData();
        }

        /// <summary>
        /// Get Data thats gonna show in the front page
        /// </summary>
        /// <returns></returns>
        public async Task<bool> GetData()
        {
            Users = new ObservableCollection<ResultDTO>();

            var service = new RestService();
            var ApiResponse = await service.Get("https://randomuser.me/api/?results=50");
            var data = JsonConvert.DeserializeObject<UserResponseDTO>(ApiResponse);

            foreach(var user in data.Results)
            {
                Users.Add(user);
            }

            return true;
        }

        /// <summary>
        /// Catch the nre register and append it
        /// </summary>
        /// <param name="parameter"></param>
        public void AppendNewUser(string parameter)
        {
            var newUser = JsonConvert.DeserializeObject<ResultDTO>(parameter);
            Users.Add(newUser);
        }
    }
}
