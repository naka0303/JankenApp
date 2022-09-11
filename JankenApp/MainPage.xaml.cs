using System;
using Xamarin.Forms;

namespace JankenApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new NavigationPage(new StartPage() { Title = "StartPage" }));
        }
    }
}
