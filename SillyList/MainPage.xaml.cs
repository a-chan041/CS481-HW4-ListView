using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SillyList
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<string> listThings = new List<string>();
        public MainPage()
        {
            InitializeComponent();

            listThings.Add("Taiwan"); /*Referenced https://dzone.com/articles/xamarinforms-listview-with-pull-to-refresh/8 for Pull to Refresh */
            listThings.Add("Japan");
            listThings.Add("South Korea");
            List.ItemsSource = listThings;

        }

        public object BindingIcon { get; set; }

        public void RefreshView(object sender, EventArgs e)
        {
            doUpdate();
            List.EndRefresh();
        }

        public void doUpdate()
        {
            listThings.Add("Bali");
            List.ItemsSource = null;
            List.ItemsSource = listThings;

        }

       /* private void OnClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Taiwan();
            
        }
                
     */   

        
    }
}
