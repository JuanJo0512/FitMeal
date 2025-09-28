using FitMeal.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitMeal
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            Hide();
            FrmLoggin pagina = new FrmLoggin();
            pagina.Show();
            timerSplash.Stop();
        }
    }
}
