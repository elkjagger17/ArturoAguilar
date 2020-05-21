using System;
using System.Collections.Generic;
using ExamArturoA.ViewModels;

using Xamarin.Forms;

namespace ExamArturoA.Views
{
    /// <summary>
    /// Add Record Page
    /// </summary>
    public partial class AddRecordPage : ContentPage
    {
        public delegate void HandlePopDelegate(string parameter);
        public event HandlePopDelegate DidFinishPoping;

		private AddRecordViewModel viewModel;

        /// <summary>
        /// Const
        /// </summary>
        public AddRecordPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new AddRecordViewModel();

            var ent = new Entry();

            Entry_One.ReturnCommand = new Command(() => Entry_Two.Focus());
            Entry_Two.ReturnCommand = new Command(() => Entry_Three.Focus());
            Entry_Three.ReturnCommand = new Command(() => Entry_Four.Focus());
            Entry_Four.ReturnCommand = new Command(() => Entry_Five.Focus());
            Entry_Five.ReturnCommand = new Command(() => Entry_Six.Focus());
            Entry_Six.ReturnCommand = new Command(() => Entry_Seven.Focus());

        }

        /// <summary>
        /// Click save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Save_Clicked(object sender, EventArgs e)
        {
            if(viewModel.ValidateField())
            {
                var data = viewModel.SaveRecord();
                await Navigation.PopAsync();
                DidFinishPoping(data);
                await DisplayAlert("Ëxito", "Se ha guardado correctamente", "OK");
            }
            else
            {
                await DisplayAlert("Advertencia", "No puedes dejar ningún campo vacio", "OK");
            }
        }

        /// <summary>
        /// Click Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Cancel_Clicked(object sender, EventArgs e)
        { 
            await Navigation.PopAsync();
        }
    }
}
