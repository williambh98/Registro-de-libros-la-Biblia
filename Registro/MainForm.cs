using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro.UI.Consultas;

namespace Registro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Registro.UI.Consultas.Registro().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Registro.UI.Consultas.Consultas().Show();

        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
