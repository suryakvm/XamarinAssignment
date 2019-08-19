using System;
using System.Collections.Generic;
using MasterDetailsPage.Models;
using MasterDetailsPage.Services;
using Xamarin.Forms;

namespace MasterDetailsPage
{
    public partial class SignupPage : ContentPage
    {

        FirebaseService service = new FirebaseService();
        public SignupPage()
        {
            InitializeComponent();

        }


        async void signUp(object sender, System.EventArgs e)
        {
            if (name.Text == "" || username.Text == "" || password.Text == "" || cPassword.Text == "") {

                await DisplayAlert("Error", "Please fill the empty fields", "OK");
            }
            else
            {
                if (password.Text == cPassword.Text)
                {
                    List<User> users = new List<User>();
                    int id = users.Count+1;
                    await service.AddUser(id, name.Text, username.Text, email.Text, password.Text);
                    await DisplayAlert("Success", "User Added", "OK");
                    await Navigation.PushAsync(new LoginPage());

                }
                else
                {
                    await DisplayAlert("Error", "Passwords do not match", "OK");
                }
            }

           


        }
    }
}
