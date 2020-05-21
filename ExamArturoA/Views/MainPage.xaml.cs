using System;
using ExamArturoA.ViewModels;
using Xamarin.Forms;

namespace ExamArturoA.Views
{
    /// <summary>
    /// Main page
    /// </summary>
    public partial class MainPage : ContentPage
    {
        private MainViewModel viewModel;

        /// <summary>
        /// Const
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new MainViewModel();

            UsersListView.ItemsSource = viewModel.Users;

        }

        /// <summary>
        /// New record click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnItemClicked(object sender, EventArgs e)
        {
            var page = new AddRecordPage();
            page.DidFinishPoping += (parameter) =>
            {
                viewModel.AppendNewUser(parameter);
            };
            await Navigation.PushAsync(page);

        }
    }
}
