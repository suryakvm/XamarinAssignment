using System;
using System.Collections.Generic;
using MasterDetailsPage.Models;
using MasterDetailsPage.Services;
using Xamarin.Forms;

namespace MasterDetailsPage
{
    public partial class AllCons : ContentPage
    {
        FirebaseService service;
        int decisionId;
        public AllCons(int id)
        {
            InitializeComponent();
            service = new FirebaseService();
            decisionId = id;
        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allCases = await service.GetAllCases();
            List<Case> casesFiltered = new List<Case>();
            foreach (Case c in allCases)
            {
                if (c.type == "Con" && c.decisionId == decisionId)
                {
                    casesFiltered.Add(c);
                }
            }

            conList.ItemsSource = casesFiltered;

        }
    }
}
