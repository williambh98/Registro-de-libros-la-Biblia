using Registro.BLL;
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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            var Listado = new List<Libros>();
            if (textBoxCristerio.Text.Trim().Length > 0)
            {
                switch (comboBoxFiltro.SelectedIndex)
                {
                    case 0://Todo
                        Listado = LibrosBLL.GetList(progressBar1 => true);
                        break;
                    case 1://id
                        int id = Convert.ToInt32(textBoxCristerio.Text);
                        Listado = LibrosBLL.GetList(p => p.LibroId == id);
                        break;
                    case 2:// Descricion
                        Listado = LibrosBLL.GetList(p => p.Descripcion.Contains(textBoxCristerio.Text));
                        break;
                    case 3://Siglas
                        Listado = LibrosBLL.GetList(p => p.Siglas.Contains(textBoxCristerio.Text));
                        break;
                    case 4://Tipo de libro
                        Listado = LibrosBLL.GetList(p => p.Tipolb.Contains(textBoxCristerio.Text));
                        break;
                }

            }
            else
            {
                Listado = LibrosBLL.GetList(p => true);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Listado;
        }
    }
}
