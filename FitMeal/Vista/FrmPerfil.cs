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
        int contador;
        public FrmPerfil()
        {
            InitializeComponent();

            cn = new cConexion();


            string idUsuarioActivo = FrmLoggin.UsuarioActivoCedula;
            string consultaSql = "SELECT * FROM tblUsuario WHERE Cedula = @ID";
            SqlCommand cmd = new SqlCommand(consultaSql, cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@ID", idUsuarioActivo);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            // llenar tiene 2 parametros, el dt que es toda la tabla y la i que es el subindice
            llenar(dt, i);
        }

        private void llenar(DataTable dt, int i)
        {

            // Verificamos si hay datos
            if (dt.Rows.Count > 0)
            {
                // Siempre usamos la fila 0, ya que la consulta SQL la filtró
                DataRow fila = dt.Rows[0];

                txtEdad.Text = fila[4].ToString();
                txtSexo.Text = fila[5].ToString();
                txtAltura.Text = fila[6].ToString();
                txtPeso.Text = fila[7].ToString();

                // El índice [8] es la columna 'Meta'
                string metaUsuario = fila[8].ToString();

                txtEmail.Text = fila[9].ToString();
                txtContraseña.Text = fila[10].ToString();


                // Manejo del ComboBox 
                for (int j = 0; j < cmbMeta.Items.Count; j++)
                {
                    if (cmbMeta.Items[j].ToString().Equals(metaUsuario, StringComparison.OrdinalIgnoreCase))
                    {
                        cmbMeta.SelectedIndex = j;
                        break;
                    }
                }

                // Si el contador es 1 hay datos, si es cero no hay
                contador = dt.Rows.Count;
            }

        }


        void habilita()
        {
            // Aca habilita los campos para llenar
            // El focus lo que hace es que ubica el cursor autometicamente en la txtCedula

            txtEdad.Enabled = true;
            txtSexo.Enabled = true;
            txtAltura.Enabled = true;
            txtPeso.Enabled = true;
            cmbMeta.Enabled = true;
            txtEmail.Enabled = true;
            txtContraseña.Enabled = true;
        }

        void desabiilita()
        {
            // Aca habilita los campos para llenar

            txtEdad.Enabled = false;
            txtSexo.Enabled = false;
            txtAltura.Enabled = false;
            txtPeso.Enabled = false;
            cmbMeta.Enabled = false;
            txtEmail.Enabled = false;
            txtContraseña.Enabled = false;
        }

        void limpiar()
        {
            // Este limpia las celdas

            txtEdad.Clear();
            txtSexo.Clear();
            txtAltura.Clear();
            txtPeso.Clear();
            txtEmail.Clear();
            txtContraseña.Clear();
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

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            habilita();
            limpiar();
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string idUsuarioActivo = FrmLoggin.UsuarioActivoCedula;

            SqlCommand cmd = new SqlCommand("Update Usuario set Edad='" + txtEdad.Text + "', Sexo'" + txtSexo.Text + "', Altura'" + txtAltura.Text + "', Peso'" + txtPeso.Text + "', Meta'" + cmbMeta + "', email'" + txtEmail.Text + "', Contraseña'" + txtContraseña.Text + "'where Cedula='" + idUsuarioActivo + "'", cn.AbrirConexion());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tu perfil ha sido modificado!");
        }



        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar con este paso?", "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Tu perfil ha sido eliminado. Gracias por usar FitMeal");
                FrmLoggin nuevoFormulario = new FrmLoggin();
                nuevoFormulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Eliminacion Cancelada!");
            }
        }




        // ---------------------------------------------------------------------------
        //                      BOTONES DE NAVEGACION
        // ---------------------------------------------------------------------------

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

        private void btnPreferencias_Click(object sender, EventArgs e)
        {
            frmVerPreferencias nuevoFormulario = new frmVerPreferencias();
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
