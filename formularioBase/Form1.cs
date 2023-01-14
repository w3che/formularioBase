using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularioBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludo(object sender, EventArgs e)
        {
            labelSaludo.Text = "Buenas tardes";
        }

        private void btnCargo(object sender, EventArgs e)
        {
            labelCargo.Text = "ingeniero";
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            labelNombre.Text = "Juan Carlos";
        }

        private void btnPaterno_Click(object sender, EventArgs e)
        {
            labelPaterno.Text = "Chuc";
        }

        private void btnMaterno_Click(object sender, EventArgs e)
        {
            labelMaterno.Text = "Uh";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            labelSaludo.Text = "saludo";
            labelCargo.Text = "cargo";
            labelNombre.Text = "nombre";
            labelPaterno.Text = "paterno";
            labelMaterno.Text = "materno";

        }
    }
}
