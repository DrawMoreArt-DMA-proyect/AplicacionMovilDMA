using mx.edu.uttt.dma.appmovil.Entitades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mx.edu.uttt.dma.appmovil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario : ContentPage
    {
        private string url = "https://drawmoreart.somee.com/WebApi/webapi/usuarios/registro";
        public Formulario()
        {
            InitializeComponent();
        }


        void NavigateButtonClicked(System.Object sender, System.EventArgs e)
        {   
            Navigation.PushAsync(new MainPage());
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            if (!contrasenaEntry.Text.Equals(repetirEntry.Text))
            {
                labelContrasena.IsVisible = true;
                labelContrasena.Text = "Las Contraseñas no Coinciden";
            }
            else { 
            Usuario user = new Usuario
            {
                UsuarioNombre = usuarioEntry.Text,
                CorreoElectronico = correoEntry.Text,
                Contrasena = contrasenaEntry.Text
            };
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(user);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await client.PostAsync(url, httpContent);

            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode) {
                await DisplayAlert("Mensaje: ", result.ToString(), "Ok");
                await Navigation.PushAsync(new MainPage());
            }
            
            
            }
        }
    }
}