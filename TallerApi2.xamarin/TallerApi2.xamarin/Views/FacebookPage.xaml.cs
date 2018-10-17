using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TallerApi.Dominio;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerApi2.xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FacebookPage : ContentPage
	{
		public FacebookPage ()
		{
			InitializeComponent ();
            CargarPublicacion();

		}

        private async void CargarPublicacion()
        {
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri("http://172.16.21.7");

            var request = await cliente.GetAsync("/TallerApi/api/publicacion");
            
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var listado = JsonConvert.DeserializeObject<List<Publicacion>>(responseJson);
                listPublicaciones.ItemsSource = listado;            }
        }

	}
}