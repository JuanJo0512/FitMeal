using FitMeal.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitMeal.Vista
{
    public partial class FrmPerfil : Form
    {

        // Creando un Objeto de cada una de las clases
        // cn para conexion
        // cmd para los comandos
        // da para la adaptacion de datos
        // dt para sacar las tablas de la database
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int i, contador, boton;
        public FrmPerfil()
        {
            InitializeComponent();

            cn = new cConexion();

            //Se inicializa el subindice y el boton en cero
            i = 0;
            boton = 0;

            // Aqui comenzamos a usar el lenguaje de sql, por eso usamos el SqlCommand y como vamos a usar la base de datos llamamos el metodo de abrir conexion
            cmd = new SqlCommand("Select * from tblEmpleado", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            // llenar tiene 2 parametros, el dt que es toda la tabla y la i que es el subindice
            llenar(dt, i);
        }

        private void llenar(DataTable dt, int i)
        {
            
            txtEdad.Text = dt.Rows[i][4].ToString();
            txtSexo.Text = dt.Rows[i][5].ToString();
            txtAltura.Text = dt.Rows[i][6].ToString();
            txtPeso.Text = dt.Rows[i][7].ToString();
            // Aqui iria el meta que es un combo box pero no se como ponerlo
            txtEmail.Text = dt.Rows[i][9].ToString();
            txtContraseña.Text = dt.Rows[i][10].ToString();

            contador = dt.Rows.Count;

        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            // Llama a la variable estática directamente desde la clase FrmLoggin
            // y asigna su valor al texto del Label.
            if (!string.IsNullOrEmpty(FrmLoggin.UsuarioActivoNombre))
            {
                lblNombre.Text = FrmLoggin.UsuarioActivoNombre;
                lblCedula.Text = FrmLoggin.UsuarioActivoCedula;
            }
            else
            {
                lblNombre.Text = "Usuario Invitado";
                lblCedula.Text = "Cedula no encontrada";
            }
        }

        private void btnIrRegistrarAlimento_Click(object sender, EventArgs e)
        {
            FrmRegistrarAlimentos nuevoFormulario = new FrmRegistrarAlimentos();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnIrRegistrarActividad_Click(object sender, EventArgs e)
        {
            FrmRegistrarActividad nuevoFormulario = new FrmRegistrarActividad();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnIrRegistrarPlan_Click(object sender, EventArgs e)
        {
            FrmMiPlan nuevoFormulario = new FrmMiPlan();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnIrRegistrarProgreso_Click(object sender, EventArgs e)
        {
            FrmMiProgreso nuevoFormulario = new FrmMiProgreso();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnIrFeedback_Click(object sender, EventArgs e)
        {
            FrmFeedback nuevoFormulario = new FrmFeedback();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil nuevoFormulario = new FrmPerfil();
            nuevoFormulario.Show();
            this.Hide();
        }
    }
}
