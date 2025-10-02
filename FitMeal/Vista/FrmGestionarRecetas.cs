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
    public partial class FrmGestionarRecetas : Form
    {
        public FrmGestionarRecetas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmLoggin.AbrirForm(new FrmAdmin(),this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

    }
}
