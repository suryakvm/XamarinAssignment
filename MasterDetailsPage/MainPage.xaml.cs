using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailsPage
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : MasterDetailPage
    {
       

        public MainPage(int id)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
            Detail = new NavigationPage(new HomePage()); 
            //Master.Icon = "menu.png";
        }

        void navigateToProfile(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new ProfilePage());
        }

        void navigateToHome(object sender, System.EventArgs e) 
        {
            Detail = new NavigationPage(new HomePage());
        }

        void navigateToSettings(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new SettingsPage());
        }

        void navigateToLogin(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
        void navigateToLogout(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }


    }
}
