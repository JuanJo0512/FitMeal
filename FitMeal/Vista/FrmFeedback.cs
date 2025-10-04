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
    public partial class FrmFeedback : Form
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

        public FrmFeedback()
        {
            InitializeComponent();


            cn = new cConexion();

            //Se inicializa el subindice y el boton en cero

            // Aqui comenzamos a usar el lenguaje de sql, por eso usamos el SqlCommand y como vamos a usar la base de datos llamamos el metodo de abrir conexion
            cmd = new SqlCommand("Select * from FEEDBACK", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

        }

        private void FrmFeedback_Load(object sender, EventArgs e)
        {
            // Llama a la variable estática directamente desde la clase FrmLoggin
            // y asigna su valor al texto del Label.
            if (!string.IsNullOrEmpty(FrmLoggin.UsuarioActivoNombre))
            {
                lblNombre.Text = FrmLoggin.UsuarioActivoNombre;
            }
            else
            {
                lblNombre.Text = "Usuario Invitado";
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

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil nuevoFormulario = new FrmPerfil();
            nuevoFormulario.Show();
            this.Hide();
        }


        private int ObtenerPuntuacion()
        {
            Control contenedor = this.grpPuntuacion; 

            // Recorremos todos los controles dentro del contenedor
            foreach (Control control in contenedor.Controls)
            {
                // Verificamos si el control es un RadioButton
                if (control is RadioButton radioButton)
                {
                    // Verificamos si este RadioButton específico está seleccionado
                    if (radioButton.Checked)
                    {
                        // Intentamos convertir el texto del RadioButton a un entero (1, 2, 3, 4, o 5)
                        if (int.TryParse(radioButton.Text, out int valor))
                        {
                            // Devolvemos el valor entero encontrado
                            return valor;
                        }
                    }
                }
            }

            // Si no se encontró ningún RadioButton seleccionado, devolvemos 0 o -1
            return 0;
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            int puntuacion = ObtenerPuntuacion();
            string textoDestacar = txtDestacado.Text.Trim();
            string textoMejorar = txtMejoras.Text.Trim();
            string cedula = FrmLoggin.UsuarioActivoCedula;

            // Valos a ver si me lo guardo
            MessageBox.Show($"Puntuación seleccionada: {puntuacion}");

            if (puntuacion > 0 && !string.IsNullOrEmpty(textoDestacar) && !string.IsNullOrEmpty(textoMejorar))
            {
                try
                {
                    // Especificar las columnas a insertar y usar parámetros
                    
                    string sqlInsert = "INSERT INTO FEEDBACK (Cedula, Destacado, Mejoras, Puntuacion) VALUES (@Cedula, @Destacar, @Mejorar, @Puntuacion)";

                    SqlCommand cmd = new SqlCommand(sqlInsert, cn.AbrirConexion());

                    // Agrego los parámetros de a unito
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    cmd.Parameters.AddWithValue("@Destacar", textoDestacar);
                    cmd.Parameters.AddWithValue("@Mejorar", textoMejorar);
                    cmd.Parameters.AddWithValue("@Puntuacion", puntuacion);

                    //Ejecutar y cerrar
                    cmd.ExecuteNonQuery();
                    cn.CerrarConexion(); // cerrar la conexión

                    MessageBox.Show("Gracias por tu aporte! ❤️");
                }
                catch (Exception ex)
                {
                    // Manejo del error
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Por favor, llena todos los campos antes de enviar");
            }
        }
    }
}
