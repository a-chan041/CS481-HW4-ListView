using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SillyList.Model;
using SillyList.View;
using SillyList.ViewModel;
using Xamarin.Forms;

namespace SillyList.View
{
    public partial class ContextInfo : ContentPage
    {
        public ContextInfo()
        {
            InitializeComponent();
        }

        public ContextInfo(string Locations, string Image, string Description)
        {
            InitializeComponent();
            Pic.Source = Image;
            Descriptions.Text = Description;

        }

        
    }
}
