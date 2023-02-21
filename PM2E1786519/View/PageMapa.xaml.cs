using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace PM2E1786519.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageMapa : ContentPage
	{
		public PageMapa ()
		{
			InitializeComponent ();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            Pin pin = new Pin
            {
                Label = ubicacion.Text,
                Address = ubicacion_corta.Text,
                Type = PinType.Generic,
                Position = new Position(Convert.ToDouble(latitud.Text), Convert.ToDouble(longitud.Text))
            };

            mapa.Pins.Add(pin);
            mapa.MoveToRegion(mapSpan: MapSpan.FromCenterAndRadius(new Position(Convert.ToDouble(latitud.Text), Convert.ToDouble(longitud.Text)), Distance.FromKilometers(1)));

        }
        }
    }