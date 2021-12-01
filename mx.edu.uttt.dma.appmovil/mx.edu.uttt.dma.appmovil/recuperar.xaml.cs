using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mx.edu.uttt.dma.appmovil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class recuperar : ContentPage
    {
        public recuperar()
        {
            InitializeComponent();
        }

        void regresarclicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

    }
}