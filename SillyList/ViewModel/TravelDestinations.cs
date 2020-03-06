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
                    Image = "Taiwan.jpg",
                    Description= "Famed for centuries as Ilha Formosa (Beautiful Isle; 美麗島; Měilìdǎo), " +
                    "this is a land with more sides than the 11-headed Guanyin. Towering sea cliffs, marble-walled gorges and " +
                    "tropical forests are just the start of your journey, which could take you as far as Yushan, Taiwan's 3952m alpine roof." +
                    "In Taiwan you can criss - cross mountains on colonial - era hiking trails or cycle a lone highway with the blue Pacific on one side and green volcanic arcs on the other." +
                    "And if you simply want classic landscapes to enjoy, you'll find them around every corner."

                });

                Destinations.Add(new Destination
                {
                    Locations = "Japan",
                    Image = "Japan.jpg",
                    Description= "Wherever you are in Japan, it seems, you're never far from a great meal. Restaurants often specialise in just one dish – perhaps having spent generations perfecting it – and pay close attention to every stage, from sourcing the freshest, local ingredients to assembling the dish attractively. And as you'll quickly discover, Japanese cuisine has great regional variations. " +
                    "The hearty hotpots of the mountains are, for example, dramatically different from the delicate sushi for which the coast is famous. It's also intensely seasonal, meaning you can visit at a different time of year and experience totally new tastes."
                });

                Destinations.Add(new Destination
                {
                    Locations = "South Korea",
                    Image = "SouthKorea.jpg",
                    Description= "South Korea’s compact size and superb transport infrastructure mean that tranquillity is always within easy reach of urban sprawl. Hike to the summits of craggy mountains – some of which transform into ski slopes come winter – enveloped within densely forested national parks. " +
                    "Get further off the beaten path than you thought possible by sailing to remote islands, where farming and fishing folk welcome you into their homes or simple seafood cafes. " +
                    "Gaze up at the distant stars from serene villages surrounded by rice fields, sleeping in rustic hanok (traditional wooden house) guesthouses."
                });

            }




        }
    }

}
