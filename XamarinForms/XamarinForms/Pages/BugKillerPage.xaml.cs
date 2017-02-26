﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BugKillerPage : ContentPage
    {
        public BugKillerPage()
        {
            InitializeComponent();
        }

        async void OnClick(object sender, EventArgs e)
        {
            await DisplayAlert("Clicked!", "The button labeled has been clicked", "OK");
            App.KeglerList.Add(new Kegler { _imageUri = "bug_six.png", _vorname = "Katze 9", _nachname = "sjdksjd" });
        }
    }
}
