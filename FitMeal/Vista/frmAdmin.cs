using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitMeal.Vista
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            FrmLoggin.AbrirForm(new frmGestionAlimentos(), this);
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            FrmLoggin.AbrirForm(new FrmGestionarRecetas(), this);
        }

        private void brnSalir_Click(object sender, EventArgs e)
        {
            FrmLoggin.AbrirForm(new FrmLoggin(), this);
        }
    }
}
