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
    public partial class FrmLoggin : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //mantiene los datos del usuario que ingresara
        public static string UsuarioActivoCedula;
        public static string UsuarioActivoNombre;
        public FrmLoggin()
        {
            InitializeComponent();
            cn = new cConexion();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmLlenarDatos(),this);
        }

        //Metodo para pasar entre formularios que se usara en todo el codigo
        private static Form activeForm = null;
        public static void AbrirForm(Form frmHijo, Form frmactual)
        {
            if (activeForm != null && !activeForm.IsDisposed)
            {
                activeForm.Close();
            }

            activeForm = frmHijo;
            frmHijo.StartPosition = FormStartPosition.CenterScreen;
            frmHijo.Show();
            frmactual.Hide();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                
                string cedula = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                string query = "select Nombre from usuarios where Cedula = @cedula and contrasena = @contraseña";

                SqlCommand cmd = new SqlCommand(query, cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@cedula", cedula);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    UsuarioActivoCedula = cedula;
                    UsuarioActivoNombre = resultado.ToString();

                    MessageBox.Show($"Biemvenido {UsuarioActivoNombre}");

                    AbrirForm(new frmVerPreferencias(), this);
                }
                else
                {
                    if (string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(contraseña))
                    {
                        MessageBox.Show("Debe ingresarse la cedula y contraseña");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrectos");
                    }
                    cn.CerrarConexion();
                }
                cn.CerrarConexion();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmLogginAdmin(), this);
        }
    }
}
