using App1.Base;
using App1.Models;
using App1.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App1.ViewModels
{
    public class FormulariosViewModel : ViewModelBase
    {

        public FormulariosViewModel()
        {
            RepositoryFormularios repo = new RepositoryFormularios();
            List<Formulario> lista = repo.GetFormularios();
            this.Formularios = new ObservableCollection<Formulario>(lista);

        }

        private ObservableCollection<Formulario> _Formularios;
        public ObservableCollection<Formulario> Formularios
        {
            get { return this._Formularios; }
            set
            {
                this._Formularios = value;
                onPropertyChanged("Formularios");
            }
        }

    }
}
