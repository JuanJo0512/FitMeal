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
                {
                    //Verificar si ya existe un usuario con esa cédula o email
                    string verificarQuery = "select count(*) from USUARIOS where Cedula = @Cedula or email = @Email";
                    using (SqlCommand cmdVerificar = new SqlCommand(verificarQuery, cn.AbrirConexion()))
                    {
                        cmdVerificar.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                        cmdVerificar.Parameters.AddWithValue("@Email", txtEmail.Text);

                        int existe = (int)cmdVerificar.ExecuteScalar();

                        if (existe > 0)
                        {
                            MessageBox.Show("El usuario ya está registrado con esa cédula o correo.");
                            return;
                        }
                    }

                    // 2. Insertar el nuevo usuario
                    string insertarQuery = @"insert into USUARIOS 
                                    (Cedula, Nombre, Apellido, Edad, Sexo, Altura, Peso, Meta, email, Contrasena)
                                    values (@Cedula, @Nombre, @Apellido, @Edad, @Sexo, @Altura, @Peso, @Meta, @Email, @Contrasena)";

                    using (SqlCommand cmdInsertar = new SqlCommand(insertarQuery, cn.AbrirConexion()))
                    {
                        // Validar Edad, Altura y Peso
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
                            


                            cmdInsertar.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                        cmdInsertar.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmdInsertar.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                        cmdInsertar.Parameters.AddWithValue("@Edad", edad);
                        cmdInsertar.Parameters.AddWithValue("@Sexo", sexo);
                        cmdInsertar.Parameters.AddWithValue("@Altura", altura);
                        cmdInsertar.Parameters.AddWithValue("@Peso", peso);
                        cmdInsertar.Parameters.AddWithValue("@Meta", cmbMeta.Text);
                        cmdInsertar.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmdInsertar.Parameters.AddWithValue("@Contrasena", txtContraseña.Text);

                        cmdInsertar.ExecuteNonQuery();
                        MessageBox.Show("Usuario registrado correctamente.");
                        FrmLoggin.AbrirForm(new FrmLoggin(),this);
                        
                    }
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
