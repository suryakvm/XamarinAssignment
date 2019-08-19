using System;
using System.Collections.Generic;
using MasterDetailsPage.Services;
using Xamarin.Forms;

namespace MasterDetailsPage
{
    public partial class ArgumentPage : ContentPage
    {
        int decisionId;
        FirebaseService service = new FirebaseService();
        public ArgumentPage(int id)
        {
            InitializeComponent();
            decisionId = id;
        }




        async void saveCase(object sender, System.EventArgs e)
        {
            //throw new NotImplementedExcept
            var selectedItem = picker.SelectedItem;

            await service.AddCase(1, decisionId, argumentName.Text, (int)slider.Value, (string)selectedItem);
            await Navigation.PushAsync(new DecisionPage(decisionId));

        }
    }
}
