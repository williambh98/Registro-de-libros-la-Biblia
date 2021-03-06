﻿using Registro.BLL;
using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro.UI.Consultas
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDLibronumericUpDown.Value = 0;
            string.IsNullOrWhiteSpace(textBoxDescripcion.Text);
            textBoxSiglas.Text = string.Empty;
            textBoxTiposLibro.Text = string.Empty;
            errorProvider.Clear();
        }
        //Evento del boton nuevo en el que limpiamos los componentes del registro
        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Libros LlenarClase()
        {
            Libros libros = new Libros();
            libros.LibroId = Convert.ToInt32(IDLibronumericUpDown.Value);
            libros.Descripcion = textBoxDescripcion.Text;
            libros.Siglas = textBoxSiglas.Text;
            libros.Tipolb = textBoxTiposLibro.Text;

            return libros;
        }

        //Llenar campo
        private void LlenarCampo(Libros libros)
        {
            IDLibronumericUpDown.Value = libros.LibroId;
            textBoxDescripcion.Text = libros.Descripcion;
            textBoxSiglas.Text = libros.Siglas;
            textBoxTiposLibro.Text = libros.Tipolb;

        }
   

        private bool GuardarValidar()
        {
            errorProvider.Clear();
            bool paso = true;

            //if( string.IsNullOrWhiteSpace(textBoxDescripcion.Text) || string.IsNullOrWhiteSpace(textBoxSiglas.Text) || string.IsNullOrWhiteSpace(textBoxTiposLibro.Text))
           // {
                if (string.IsNullOrWhiteSpace(textBoxDescripcion.Text))
                  {
                    errorProvider.SetError(textBoxDescripcion, "Ingrese Descricion");
                    paso = false;

                  }
                if (string.IsNullOrWhiteSpace(textBoxSiglas.Text))
                  {
                     errorProvider.SetError(textBoxSiglas, "Ingrese Siglas");
                     paso = false;
                  }
                if (string.IsNullOrWhiteSpace(textBoxTiposLibro.Text))
                 {
                     errorProvider.SetError(textBoxTiposLibro, "Ingrese Tipos de libros");
                   
                   paso = false;
                  }  
             
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Libros libros = LibrosBLL.Buscar((int)IDLibronumericUpDown.Value);
            return (libros != null);
        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            
            errorProvider.Clear();
        
            Libros libros;
            bool paso = false;

            if (!GuardarValidar())
                return;

            libros = LlenarClase();

            //Determinar si es guardar o modificar
            if (IDLibronumericUpDown.Value == 0)
                paso = LibrosBLL.Guardar(libros);
            else
                 {
                 if(!ExisteEnLaBaseDeDatos())
                 {
                MessageBox.Show("No se puede modificar No existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                 }
                paso = LibrosBLL.Modificar(libros);
             }

           
            if (paso)
            {
               
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se puede guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
                
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            Libros libros = new Libros();
            int.TryParse(IDLibronumericUpDown.Text, out id);

            libros = LibrosBLL.Buscar(id);

            if (libros != null)
            {
                
                MessageBox.Show("Libros Encotrado","Existo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LlenarCampo(libros);
            }

            else
            {
                MessageBox.Show("Libros no Encontrada", "Fallo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Limpiar();
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            int.TryParse(IDLibronumericUpDown.Text, out id);

            if (!ExisteEnLaBaseDeDatos())
            {
                errorProvider.SetError(IDLibronumericUpDown, "No se puede eliminar una persona que no existe");
                return;
            }
            if(LibrosBLL.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Eliminado");
            }

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }  
   
}

