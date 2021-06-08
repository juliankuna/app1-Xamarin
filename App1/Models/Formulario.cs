using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    [Table("Formularios")]
    public class Formulario
    {

        [PrimaryKey]
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }
    }
}
