using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Drop
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void SignInButton(object sender, EventArgs e)
        {
           bool isEmailEmpty = String.IsNullOrEmpty(EmailEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(PasswordEntry.Text);

            if (isEmailEmpty || isPasswordEmpty) {

            }
            else {
                Navigation.PushAsync(new HomePage());
            }

        }

        void SignUpButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

    }
}
