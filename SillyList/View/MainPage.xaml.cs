using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SillyList.Model;
using SillyList.ViewModel;
using System.Collections.ObjectModel;


namespace SillyList.View
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
       // List<string> listThings = new List<string>();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new TravelDestinationsViewModel();
           /*Referenced https://dzone.com/articles/xamarinforms-listview-with-pull-to-refresh/8 for Pull to Refresh */

        }

       
   
        public void RefreshView(object sender, EventArgs e)
        {
            DisplayAlert("Uh Oh", "There are no new destinations.", "OK");
            listDestinations.EndRefresh();
        }

        public async void OnClicked(object sender, EventArgs e)
        {
            var stuff = sender as MenuItem;
            var item = stuff.BindingContext as Destination;
            await Navigation.PushAsync(new ContextInfo(item.Locations, item.Image, item.Description));

        }

        public void MenuDelete(object sender, EventArgs e)
        {
            var stuff = sender as MenuItem;
            var item = stuff.BindingContext as Destination;
            var List = BindingContext as TravelDestinationsViewModel;
            List.Remove.Execute(item);

        }
        /*public void doUpdate()
        {
            listThings.Add("Bali");
            List.ItemsSource = null;
            List.ItemsSource = listThings;

        }*/



    }
}
