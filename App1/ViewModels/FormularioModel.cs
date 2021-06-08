using App1.Base;
using App1.Models;
using App1.Repository;

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class FormularioModel : ViewModelBase
    {
        RepositoryFormularios repo;
        public FormularioModel()
        {
            this.repo = new RepositoryFormularios();
            this.Formulario = new Formulario();
        }

        public Command InsertarFormulario
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.InsertarFormulario(this.Formulario.Id,
                        Formulario.Fecha, Formulario.Titulo, Formulario.Descripcion
                        );
                });
            }
             
        }

        public Command ModificarFormulario
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.ModificarFormulario(this.Formulario.Id,
                        Formulario.Fecha, Formulario.Titulo, Formulario.Descripcion
                        );
                });
            }
        }

        public Command EliminarFormulario
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.EliminarFormulario(this.Formulario.Id
                        );
                });
            }
        }

        private Formulario _Formulario;
        public Formulario Formulario
        {
            get { return this._Formulario; }
            set
            {
                this._Formulario = value;
                onPropertyChanged("Formulario");
            }
        }
    }
}