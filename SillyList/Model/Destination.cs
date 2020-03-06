using System;

using Xamarin.Forms;
using SillyList.ViewModel;
using SillyList.View;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace SillyList.Model
{
    public class Destination
    {

        public string Locations { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public List<Destination> GetDestinations()
        {
            List<Destination> places = new List<Destination>()
            {


            };
            return places;

        }
    }
}
