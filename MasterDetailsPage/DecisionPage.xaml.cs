using System;
using System.Collections.Generic;
using MasterDetailsPage.Models;
using MasterDetailsPage.Services;
using Xamarin.Forms;

namespace MasterDetailsPage
{
    public partial class DecisionPage : ContentPage
    {

        FirebaseService service;
        int decisionId;
       
         public DecisionPage(int id)
        {
            InitializeComponent();
            service = new FirebaseService();
            decisionId = id;

        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();

            //await service.AddDecision(1, "Buying a car", 4, 6);
            List<Case> allCases = await service.GetAllCases();
            List<Case> casesFiltered = new List<Case>();
            foreach (Case c in allCases)
            {
                if(c.decisionId == decisionId)
                {
                    casesFiltered.Add(c);
                }
            }
            //casesList.ItemsSource = casesFiltered;
        }

        void AllPros(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AllPros(decisionId));
        }

        void AllCons(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AllCons(decisionId));
        }

        void AddArgumentPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ArgumentPage(decisionId));
        }

       




    }
}
