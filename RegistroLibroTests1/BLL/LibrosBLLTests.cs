using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registro.BLL;
using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.BLL.Tests
{
    [TestClass()]
    public class LibrosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Libros libros = new Libros();
            libros.LibroId = 0;
            libros.Descripcion = "PUeba";
            libros.Siglas = "LBD";
            libros.Tipolb = "Nuevo";
            paso = LibrosBLL.Guardar(libros);
            Assert.AreEqual(paso, true);
           
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Libros libros = new Libros();
            libros.LibroId = 0;
            libros.Descripcion = "PUeba";
            libros.Siglas = "LBD";
            libros.Tipolb = "Nuevo";
            paso = LibrosBLL.Guardar(libros);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Libros libros = new Libros();
            libros.LibroId = 0;
            libros.Descripcion = "PUeba";
            libros.Siglas = "LBD";
            libros.Tipolb = "Nuevo";
            paso = LibrosBLL.Guardar(libros);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            Libros libros = new Libros();
            libros.LibroId = 0;
            libros.Descripcion = "PUeba";
            libros.Siglas = "LBD";
            libros.Tipolb = "Nuevo";
            paso = LibrosBLL.Guardar(libros);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}