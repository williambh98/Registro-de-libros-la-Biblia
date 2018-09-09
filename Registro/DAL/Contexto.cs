using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.DAL
{
    //Agregamos public para que la clase pueda ser encontrada y Heredamos de DbContext
   public  class Contexto : DbContext
    {
   
        public DbSet<Libros> Librosbl  { get; set; }
  
        public Contexto() : base("ConStr")//para pasar la Conexion a la clase EntityFramework
        {

        }

    }
}
