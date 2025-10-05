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
// Se usa esta para las conversiones decimales que necesito en el UPDATE
using System.Globalization;

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
            string consultaSql = "SELECT * FROM USUARIOS WHERE Cedula = @ID";
            SqlCommand cmd = new SqlCommand(consultaSql, cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@ID", idUsuarioActivo);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            // llenar tiene 2 parametros, el dt que es toda la tabla y la i que es el subindice
            llenar(dt, 0);
        }

        private void llenar(DataTable dt, int i)
        {

            // Verificamos si hay datos
            if (dt.Rows.Count > 0)
            {
                // Siempre usamos la fila 0, ya que la consulta SQL la filtró
                DataRow fila = dt.Rows[0];

                txtEdad.Text = fila[3].ToString();
                txtSexo.Text = fila[4].ToString();
                txtAltura.Text = fila[5].ToString();
                txtPeso.Text = fila[6].ToString();

                // El índice [8] es la columna 'Meta'
                string metaUsuario = fila[7].ToString();

                txtEmail.Text = fila[8].ToString();
                txtContraseña.Text = fila[9].ToString();


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
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string idUsuarioActivo = FrmLoggin.UsuarioActivoCedula;


            // Validación de campos vacíos (El .SelectedIndex == -1 es para confirmar que si haya elegido algo)

            if (string.IsNullOrEmpty(txtEdad.Text) || string.IsNullOrEmpty(txtSexo.Text) || string.IsNullOrEmpty(txtAltura.Text) || string.IsNullOrEmpty(txtPeso.Text) || cmbMeta.SelectedIndex == -1 || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, rellena todos los campos antes de guardar.", "Campos Requeridos");
                return;
            }

            // Validacion de que ingrese un numero y que sea mayor de edad
            if (!int.TryParse(txtEdad.Text, out int edad) || edad < 18)
            {
                MessageBox.Show("La edad debe ser un número válido y mayor o igual a 18.", "Error de Validación");
                return;
            }

            // Usamos CultureInfo.InvariantCulture para asegurar que el punto (.) sea reconocido como decimal.
            if (!decimal.TryParse(txtAltura.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal altura) || altura <= 0)
            {
                MessageBox.Show("La altura debe ser un número válido mayor a 0 (ej: 1.75).", "Error de Validación");
                return;
            }

            // el decimal.TryParse convierte el txt a decimal, por esto lo que importe arriba. Pero si la conversion falla pq el usuario ingreso letras me regresa en booleano
            //Si TryParse devuelve un false (pq falló) entonces la negacion hace que sea un true, por lo que si no pudo convertir a decimal hay un error
            // NumerStyles.Any hace que se acepten decimales tanto con  comas como con puntos
            if (!decimal.TryParse(txtPeso.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal peso) || peso <= 0)
            {
                MessageBox.Show("El peso debe ser un número válido mayor a 0 (ej: 75.5).", "Error de Validación");
                return;
            }

            // Si la validación pasa, continuamos con la actualización

            // UPDATE 

            string updateQuery = @"
        UPDATE USUARIOS SET 
            Edad = @Edad, 
            Sexo = @Sexo, 
            Altura = @Altura, 
            Peso = @Peso, 
            Meta = @Meta, 
            email = @Email, 
            Contrasena = @Contrasena
        WHERE Cedula = @Cedula";

            try
            {
                SqlCommand cmd = new SqlCommand(updateQuery, cn.AbrirConexion());

                // Asignación de Parámetros SQL: Asegura la seguridad y el tipo de dato correcto
                // Usamos los valores convertidos (edad, altura, peso)
                cmd.Parameters.AddWithValue("@Edad", edad);       // INT
                cmd.Parameters.AddWithValue("@Altura", altura);   // DECIMAL
                cmd.Parameters.AddWithValue("@Peso", peso);       // DECIMAL

                // El resto son VARCHAR/CHAR y se pasan directamente
                cmd.Parameters.AddWithValue("@Sexo", txtSexo.Text.Trim());
                cmd.Parameters.AddWithValue("@Meta", cmbMeta.Text); // Usamos el texto seleccionado
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Contrasena", txtContraseña.Text.Trim());
                cmd.Parameters.AddWithValue("@Cedula", idUsuarioActivo);

                cmd.ExecuteNonQuery();
                cn.CerrarConexion();

                MessageBox.Show("Tu perfil ha sido modificado!");
                // Deshabilitamos los campos tras guardar y le quitamos el acceso al boton
                desabiilita(); 
                btnGuardar.Enabled = false;

            }
            catch (Exception ex)
            {
                // Esto es para que le diga si hay un error de conexion en la BD
                MessageBox.Show("Error al actualizar el perfil: " + ex.Message, "Error de Base de Datos");
            }


        }

        //Antes de poder eliminar directamente, voy a hacer un metodo auxiliar porque como cedula esta de fk en tantas tablas el usuario no s epuede eliminar directamente y esw mejor tener un metodo donde se ejecute esto y yo solo le llevo la consulta de sql para la tabla y el parametro para el where de la cedula a eliminar

        private void EjecutarDelete(string sql, string cedula)
        {
            // Reutiliza la lógica de conexión y parámetros.
            SqlCommand cmd = new SqlCommand(sql, cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@Cedula", cedula);
            cmd.ExecuteNonQuery();
            cn.CerrarConexion();
        }

        // Ahora si elimino bien incluyendo el mensaje de confirmacion y el try por si hay error de conexion en la BD

        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar con este paso?", "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string idUsuarioActivo = FrmLoggin.UsuarioActivoCedula;

                try
                {
                    // Primero tengo que eliminar registros que dependen de PROGRESO porque progreso depende de USUARIO
                    EjecutarDelete("DELETE FROM REGISTRO_ACTIVIDAD WHERE ProgresoID IN (SELECT ProgresoID FROM PROGRESO WHERE Cedula = @Cedula)", idUsuarioActivo);
                    EjecutarDelete("DELETE FROM REGISTRO_COMIDAS WHERE ProgresoID IN (SELECT ProgresoID FROM PROGRESO WHERE Cedula = @Cedula)", idUsuarioActivo);

                    // Despues eliminano registros que dependen de PLANDIETA que ese tambien depende de USUARIO
                    EjecutarDelete("DELETE FROM COMIDA_PLANIFICADA WHERE PlanID IN (SELECT PlanID FROM PLANDIETA WHERE Cedula = @Cedula)", idUsuarioActivo);

                    // Elimino tablas que tienen a Cedula como FK directa
                    EjecutarDelete("DELETE FROM PROGRESO WHERE Cedula = @Cedula", idUsuarioActivo);
                    EjecutarDelete("DELETE FROM PLANDIETA WHERE Cedula = @Cedula", idUsuarioActivo);

                    // Eliminar registros de FEEDBACK si Cedula es ID_Usuario
                    EjecutarDelete("DELETE FROM FEEDBACK WHERE Cedula = @Cedula", idUsuarioActivo);

                    // Y elimino el Usuario principal (Cedula PK)
                    EjecutarDelete("DELETE FROM USUARIOS WHERE Cedula = @Cedula", idUsuarioActivo);

                    MessageBox.Show("Tu perfil y todos tus datos han sido eliminados. Gracias por usar FitMeal", "Perfil Eliminado");

                    // Y ya lo regreso al loggin
                    FrmLoggin nuevoFormulario = new FrmLoggin();
                    nuevoFormulario.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el perfil. Asegúrate de que la conexión esté abierta y la secuencia de eliminación sea correcta: " + ex.Message, "Error Crítico");
                }
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
