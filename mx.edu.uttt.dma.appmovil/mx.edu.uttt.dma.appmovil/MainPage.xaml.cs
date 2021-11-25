using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mx.edu.uttt.dma.appmovil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnNavigateButtonClicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Formulario());
        }
    }
}
