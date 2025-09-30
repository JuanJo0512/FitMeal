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
    public partial class frmLogginAdmin : Form
    {
        public frmLogginAdmin()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmLoggin.AbrirForm(new FrmLoggin(), this);
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            String codigo = txtcodigo.Text;

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Debe ingresarse el codigo de administrador");
                return;
            }

            else
            {
                if (codigo == "1040572195" || codigo == "1020110100")
                {
                    FrmLoggin.AbrirForm(new frmAdmin(), this);
                }
            }
        }
    }
}
