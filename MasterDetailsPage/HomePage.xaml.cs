using System;
using System.Collections.Generic;
using MasterDetailsPage.Models;
using MasterDetailsPage.Services;
using Xamarin.Forms;

namespace MasterDetailsPage
{
    public partial class HomePage : ContentPage
    {
    
        FirebaseService service = new FirebaseService();
        int userId;

        public HomePage()
        {
            InitializeComponent();
            //userId = id;

        }

        void decisionListItemClick(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var listView = (ListView)sender;
            Decision decision = (MasterDetailsPage.Models.Decision)listView.SelectedItem;
            Navigation.PushAsync(new DecisionPage(decision.id));
        }

        void navigateToAddDecisionPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddDecisionPage());
        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allDecisions = await service.GetAllDecisions();
            //List<Decision> decisionsFiltered = new List<Decision>();
            // foreach (Decision d in allDecisions){
            //    if(d.userId == userId)
            //    {
            //        decisionsFiltered.Add(d);
            //    }
            //}
            decisionList.ItemsSource = allDecisions;
        }

    }
}
