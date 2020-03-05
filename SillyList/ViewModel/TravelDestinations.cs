using System;

using Xamarin.Forms;
using SillyList.Model;
using SillyList.View;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace SillyList.ViewModel
{
    public class TravelDestinationsViewModel
    {
        public ObservableCollection<Destination> Destinations { get; set; }

        public TravelDestinationsViewModel()
        {
            Destinations = new ObservableCollection<Destination>();
            {

                Destinations.Add(new Destination
                {
                    Locations = "Taiwan",
                    Image = "Taiwan.jpg"


                });

                Destinations.Add(new Destination
                {
                    Locations = "Japan",
                    Image = "Japan.jpg"
                });

                Destinations.Add(new Destination
                {
                    Locations = "South Korea",
                    Image = "SouthKorea.jpg"
                });

            }




        }
    }

}
