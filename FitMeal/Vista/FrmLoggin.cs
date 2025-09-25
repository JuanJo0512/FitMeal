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
    public partial class FrmLoggin : Form
    {
        public FrmLoggin()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmLlenarDatos());
        }

        Form activeForm = null;

        private void AbrirForm(Form frmHijo)
        {
            if (activeForm != null && !activeForm.IsDisposed)
            {
                activeForm.Close();
            }

            activeForm = frmHijo;
            frmHijo.StartPosition = FormStartPosition.CenterScreen;
            frmHijo.Show();
            this.Hide();
        }

    }
}
