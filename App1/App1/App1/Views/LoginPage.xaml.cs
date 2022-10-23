using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Model;
using NuGet.Protocol.Plugins;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            Entry_Username.TextColor = Constants.placeholdercolor;
            Entry_Password.TextColor = Constants.placeholdercolor;
            AppIcon.HeightRequest = Constants.AppIconHeight;
            //Entry_Username.Completed += (Sender, e)->Entry_Password.forcus();

        }
        public void SigInProcedure(object sender,EventArgs e)
        {
            User user = new User(Entry_Username.Text,Entry_Password.Text);
            if(user.CheckInformation())
            {
                DisplayAlert("Login", "Successfully Login!", "Ok");
                App.UserDatabase.SaveUser(user);
            }
            else
            {
                DisplayAlert("Login", "Login In Correct, Empty Username or Password", "Ok");
            }
            Entry_Username.Text = string.Empty;
            Entry_Password.Text = string.Empty;

        }

    }
}