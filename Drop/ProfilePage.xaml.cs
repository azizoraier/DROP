using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Drop
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }
        void UpdateButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UpdatePage());
        }
    }
}
