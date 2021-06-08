using App1.Models;
using App1.Repository;
using App1.Views;

using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        RepositoryFormularios repo;
        public MainPage()
        {
            InitializeComponent();
            this.repo = new RepositoryFormularios();
            this.repo.CrearBBDD();
            
            this.btnABM.Clicked += BtnABM_Clicked;
            
            this.btnnuevo.Clicked += Btnnuevo_Clicked;
        }

        private async void Btnnuevo_Clicked(object sender, EventArgs e)
        {
            AgregarFormulario view = new AgregarFormulario();
            await Navigation.PushModalAsync(view);
          
        }

      
        private async void BtnABM_Clicked(object sender, EventArgs e)
        {
            FormularioABM view = new FormularioABM();
            FormularioModel viewmodel = new FormularioModel();

            //buscar el número de departamento que hay en la caja
            try{
                int num = int.Parse(this.cajacodigo.Text);
                //asociarlo con viewmodel
                Formulario form = this.repo.BuscarFormulario(num);
                viewmodel.Formulario = form;
                view.BindingContext = viewmodel;
                await Navigation.PushModalAsync(view);
            }catch (Exception ex){ }
            
            
        }

       




    }
}
