using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormularioABM : ContentPage
    {
        public FormularioABM()
        {
            InitializeComponent();
        }

        async void btnModificar(object sender, System.EventArgs e)
        {
            await DisplayAlert("Aviso", "Se modifico con exito el formulario", "OK");

        }

        async void btnEliminar(object sender, System.EventArgs e)
        {
            await DisplayAlert("Aviso", "Se elimino con exito el formulario", "OK");

        }
    }
}