using Registro.DAL;
using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Registro.BLL
{
    //En esta calse se programa la logica del negocios
    public class LibrosBLL
    {     
        //Guardar Entidad en la base de Datos
        public static bool Guardar(Libros libro)
        {
            bool paso = false;
            //Instancia de contexto para conecyar con la BD
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Librosbl.Add(libro) != null)
                {
                    contexto.SaveChanges();//Guadar los cambios
                    paso = true;
                }
               
                contexto.Dispose();//Cerrar la conexion
              }catch(Exception)
            {
                throw;
            }
            return paso;
            

        }
        //Perimite editar una entidad en la base de datos
        public static bool Modificar(Libros Libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Libro).State = System.Data.Entity.EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }
        //Permite eliminar una entidad de la base de datos
        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.Librosbl.Find(id);
                contexto.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;
                paso = (contexto.SaveChanges() > 0);
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return paso;

        }

        //Metodo para buscar en la base de datos
        public static Libros Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Libros libro = new Libros();

            try
            {
                libro = contexto.Librosbl.Find(id);
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return libro;
        }

       //metodo para listar o consultar lo que tenemos en la base de datos
        public static List <Libros> GetList(Expression<Func<Libros, bool>> expression)
        {
            List<Libros> Libros = new List<Libros>();
            Contexto contexto = new Contexto();
            try
            {
                Libros = contexto.Librosbl.Where(expression).ToList();
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return Libros;


        }

    }
}
