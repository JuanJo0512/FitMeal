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
    public partial class FrmLlenarDatos : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        String sexo;
        public FrmLlenarDatos()
        {
            InitializeComponent();
            cn = new cConexion();
        }

        private void btnCrearPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                    string verificarQuery = "select count(*) from USUARIOS where Cedula = @Cedula or email = @Email";

                    SqlCommand cmdVerificar = new SqlCommand(verificarQuery, cn.AbrirConexion());
                    cmdVerificar.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                    cmdVerificar.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmdVerificar.ExecuteNonQuery();

                    int existe = (int)cmdVerificar.ExecuteScalar();

                if (existe > 0)
                {
                    MessageBox.Show("El usuario ya está registrado con esa cédula o correo.");
                    return;
                }
                else
                {
                    string insertarQuery = @"insert into USUARIOS 
                                    (Cedula, Nombre, Apellido, Edad, Sexo, Altura, Peso, Meta, email, Contrasena)
                                    values (@Cedula, @Nombre, @Apellido, @Edad, @Sexo, @Altura, @Peso, @Meta, @Email, @Contrasena)";


                    cmd = new SqlCommand(insertarQuery, cn.AbrirConexion());

                    int edad;
                    if (!int.TryParse(txtEdad.Text, out edad) || edad <= 0)
                    {
                        MessageBox.Show("Ingrese una edad válida.");
                        return;
                    }
                    decimal altura;
                    if (!decimal.TryParse(txtAltura.Text, out altura) || altura <= 0)
                    {
                        MessageBox.Show("Ingrese una altura válida en metros.");
                        return;
                    }
                    decimal peso;
                    if (!decimal.TryParse(txtPeso.Text, out peso) || peso <= 0)
                    {
                        MessageBox.Show("Ingrese un peso válido en kilogramos.");
                        return;
                    }

                    if (cmbSexo.SelectedItem.ToString() == "Masculino")
                    {
                        sexo = "M";
                    }

                    else
                    {
                        sexo = "F";
                    }



                    cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@Edad", edad);
                    cmd.Parameters.AddWithValue("@Sexo", sexo);
                    cmd.Parameters.AddWithValue("@Altura", altura);
                    cmd.Parameters.AddWithValue("@Peso", peso);
                    cmd.Parameters.AddWithValue("@Meta", cmbMeta.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Contrasena", txtContraseña.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado correctamente.");
                    FrmLoggin.AbrirForm(new FrmLoggin(), this);

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmLoggin.AbrirForm(new FrmLoggin(), this);
        }
    }
}
