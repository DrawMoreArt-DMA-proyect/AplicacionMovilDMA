using mx.edu.uttt.dma.appmovil.Entitades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mx.edu.uttt.dma.appmovil
{
    public partial class MainPage : ContentPage
    {
        private string url = "https://drawmoreart.somee.com/WebApi/webapi/usuarios/login";
        public MainPage()
        {
            InitializeComponent();
        }

        void OnNavigateButtonClicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Formulario());
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            Usuario user = new Usuario
            {
                UsuarioNombre = usuarioEntry.Text,
                Contrasena = contrasenaEntry.Text
            };
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(user);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await client.PostAsync(url, httpContent);

            var result = await response.Content.ReadAsStringAsync();
            Mensaje.IsVisible = true;
            Mensaje.Text = result.ToString();
        }
    }
}
