using System;
using Xamarin.Forms;

namespace CustomTransitionExample
{
    public partial class CardPage : ContentPage
    {
        public CardPage ()
        {
            InitializeComponent ();
        }

        private void OnClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}

