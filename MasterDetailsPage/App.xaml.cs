﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailsPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new LoginPage());



            MainPage = new NavigationPage(new LoginPage())
            {
                BarBackgroundColor = Color.FromHex("#00649B"),
                BarTextColor = Color.White,

            };
            //MainPage = new LoginPage();
           
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
