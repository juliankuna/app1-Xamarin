using App1.Dependencies;
using App1.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace App1.Repository
{
   public class RepositoryFormularios
    {
        private SQLiteConnection cn;

        public RepositoryFormularios() => this.cn = DependencyService.Get<IDataBase>().GetConnection();



        //------------------MÉTODOS:
        public void CrearBBDD()
        {
            try
            {
                this.cn.DropTable<Formulario>();

            this.cn.CreateTable<Formulario>();

        }
            catch (Exception e) { }
        }

        public List<Formulario> GetFormularios()
        {
     
        var consulta = from datos in cn.Table<Formulario>()
                           select datos;
            return consulta.ToList();
        }
       
        public Formulario BuscarFormulario(int id)
        {
            
                var consulta = from datos in cn.Table<Formulario>()
                           where datos.Id == id
                           select datos;
            return consulta.FirstOrDefault();
           
        }
        public void InsertarFormulario(int id, DateTime fecha, string titulo, string descripcion)
        {
            try
            {
                Formulario formulario = new Formulario();
                formulario.Id = id;
                formulario.Fecha = fecha;
                formulario.Titulo = titulo;
                formulario.Descripcion = descripcion;
                this.cn.Insert(formulario);
            }
            catch (Exception e) { }
            
        }

        public void ModificarFormulario(int id, DateTime fecha, string titulo, string descripcion)
        {
            try
            {
            Formulario formulario = this.BuscarFormulario(id);
            formulario.Fecha = fecha;
            formulario.Titulo = titulo;
            formulario.Descripcion = descripcion;
            this.cn.Update(formulario);
        }
            catch (Exception e) { }
}
        public void EliminarFormulario(int id)
        {
            try
            {
                Formulario formulario = this.BuscarFormulario(id);
            this.cn.Delete<Formulario>(id);
}
            catch (Exception e) { }
        }
    }
}
