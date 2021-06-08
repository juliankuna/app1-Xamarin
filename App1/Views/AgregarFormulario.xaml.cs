using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarFormulario : ContentPage
    {
        public AgregarFormulario()
        {
            InitializeComponent();
        }

        async void btnInsertar(object sender, System.EventArgs e)
        {
            await DisplayAlert("Aviso", "Se inserto con exito el formulario", "OK");

        }
    }
}