using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailsPage
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            var imageSource = ImageSource.FromResource("MasterDetailsPage.images.splash.png");
            image.Source = imageSource;
        }
            
    }
}
