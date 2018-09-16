using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Creamos la Entidades
namespace Registro.Entidades
{
   public class Libros
    {
        [Key]
        public int LibroId { get; set; }
        public string Descripcion { get; set; }
        public string Siglas { get; set; }
        public string Tipolb { get; set; }
       // public DateTime FechaCreacion { get; set; }
       

        public Libros()
        {
            LibroId = 0;
            Descripcion = string.Empty;
            Siglas = string.Empty;
            Tipolb = string.Empty;
           // FechaCreacion = DateTime.Now;
        }

        public Libros(int libroid, string descripcion, string siglas, string tipolb)
        {
            LibroId = libroid;
            Descripcion = descripcion;
            Siglas = siglas;
            Tipolb = tipolb;
        }
    }
}
