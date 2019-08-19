using System;
using System.Collections.Generic;
using MasterDetailsPage.Models;
using MasterDetailsPage.Services;
using Xamarin.Forms;

namespace MasterDetailsPage
{
    public partial class LoginPage : ContentPage
    {
        FirebaseService service;
        public LoginPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
            service = new FirebaseService();
        
        }




        void navigateToSignup(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignupPage());
        }

        async void navigateToMainPage(object sender, System.EventArgs e)
        {


            List<User> allUsers = await service.GetAllUsers();
            bool userFound = false;
            foreach(User user in allUsers)
            {
                if(username.Text == user.username && password.Text == user.password)
                {
                    Console.WriteLine("Found User");
                    User loggedUser = user;
                    userFound = true;
                    await Navigation.PushAsync(new MainPage(loggedUser.id));
                    break;
                }
            }
            if (!userFound)
            {
                await DisplayAlert("Invalid Credentials", "Please enter valid credentials","OK" );
            }
           


        }

    }
}
