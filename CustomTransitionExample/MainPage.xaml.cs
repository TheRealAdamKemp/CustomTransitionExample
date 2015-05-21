using System;
using Xamarin.Forms;

namespace CustomTransitionExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage ()
        {
            InitializeComponent ();
        }

        private void OnClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CardPage());
        }
    }
}

