using System;
using System.Collections.Generic;
using MasterDetailsPage.Models;
using MasterDetailsPage.Services;
using Xamarin.Forms;

namespace MasterDetailsPage
{
    public partial class AddDecisionPage : ContentPage
    {
        FirebaseService service = new FirebaseService();
        public AddDecisionPage()
        {
            InitializeComponent();
        }


        async void navigateToDecisionPage(object sender, System.EventArgs e)
        {

            if(titleText.Text == "")
            {
                await DisplayAlert("Empty Name", "Please enter decision name", "OK");
            }
            else
            {
                List<Decision> allDecisions = await service.GetAllDecisions();
                int id = allDecisions.Count + 1;
                Decision d = new Decision(id, titleText.Text, 50, 50);
                await service.AddDecision(id, titleText.Text, 50, 50);
                titleText.Text = "";
                await Navigation.PushAsync(new DecisionPage(id));

            }
        }
    }
}
