using FitMeal.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitMeal.Vista
{
    public partial class FrmRegistrarActividad : Form
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
        public FrmRegistrarActividad()
        {
            InitializeComponent();


            cn = new cConexion();
            cmd = new SqlCommand("Select * from REGISTRO_ACTIVIDAD", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Ejercicio = TipoEjercicio();


            // Validacion de que ingrese un tiempo mayor a cero
            if (!int.TryParse(txtDuracion.Text, out int tiempo) || tiempo <= 0)
            {
                MessageBox.Show("El tiempo debe ser un número entero válido mayor a cero.", "Error de Validación");
                return;
            }

            // Usamos CultureInfo.InvariantCulture para asegurar que el punto (.) sea reconocido como decimal.
            // Añadimos una verificación explícita de campo vacío/espacios en blanco
            if (string.IsNullOrWhiteSpace(txtCalorias.Text) ||
                !decimal.TryParse(txtCalorias.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal calorias) ||
                calorias <= 0)
            {
                MessageBox.Show("Por favor ingrese un número válido para las calorías (debe ser mayor a cero).", "Error de Validación");
                return;
            }

            string sqlRegistroActividadScript = @"
                -- Intenta obtener el ProgresoID existente para esta Cédula y Fecha
                DECLARE @ProgresoIDExistente INT;

                SELECT @ProgresoIDExistente = ProgresoID 
                FROM PROGRESO 
                WHERE Cedula = @Cedula AND Fecha = @FechaActual;

                -- Si NO existe un ProgresoID para hoy, créalo
                IF @ProgresoIDExistente IS NULL
                BEGIN
                    INSERT INTO PROGRESO (Cedula, Fecha)
                    VALUES (@Cedula, @FechaActual);
    
                    -- Obtiene el ID que acaba de generar la BD
                    SET @ProgresoIDExistente = SCOPE_IDENTITY();
                END

                -- 3. Inserta el registro de actividad usando el ProgresoID encontrado o creado
                INSERT INTO REGISTRO_ACTIVIDAD 
                (ProgresoID, TipoEjercicio, Fecha, CaloriasQuemadas, TiempoEjercicio)
                VALUES 
                (@ProgresoIDExistente, @Ejercicio, @FechaActual, @Calorias, @Tiempo);
";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlRegistroActividadScript, cn.AbrirConexion());

                // Parámetros de la lógica condicional PROGRESO:
                cmd.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);
                cmd.Parameters.AddWithValue("@FechaActual", DateTime.Today.Date);

                // Parámetros específicos de REGISTRO_ACTIVIDAD:
                // Nota: Asume que las variables 'ejercicioSeleccionado', 'calorias' y 'tiempo' ya están definidas.
                cmd.Parameters.AddWithValue("@Ejercicio", Ejercicio);
                cmd.Parameters.AddWithValue("@Calorias", calorias);
                cmd.Parameters.AddWithValue("@Tiempo", tiempo);

                

                cmd.ExecuteNonQuery();
                cn.CerrarConexion();
                MessageBox.Show("Actividad registrada con éxito.", "Éxito");
                chbActividadDiaria.Checked = false;
                chbActividadesAireLibre.Checked = false;
                chbCardioAerobico.Checked = false;
                chbDeportes.Checked = false;
                chbFlexibilidad.Checked = false;
                chbFuerza.Checked = false;

            }
            catch (Exception ex)
            {
                // Esto es para que le diga si hay un error de conexion en la BD
                MessageBox.Show("Error al Registrar la actividad: " + ex.Message, "Error de Base de Datos");
            }



        }



        private string TipoEjercicio()
        {
            int checkBoxesSeleccionados = 0;
            string TipoEjercicio = "";

            // Iterar sobre todos los controles dentro del GroupBox
            foreach (Control control in grpEjercicio.Controls)
            {
                // Verificar si el control es un CheckBox
                if (control is CheckBox checkbox)
                {
                    // Contar y guardar el texto si está marcado
                    if (checkbox.Checked)
                    {
                        checkBoxesSeleccionados++;
                        // Guardamos el texto (solo si es el primero, o se dejará el último si hay varios)
                        // Usamos la validación posterior para asegurar que solo uno es el que cuenta
                        TipoEjercicio = checkbox.Text;
                    }
                }
            }

            
            //  Aplicar la lógica de confirmación: Si hay más de 1 CheckBox seleccionado
            if (checkBoxesSeleccionados > 1)
            {
                MessageBox.Show("Solo puedes seleccionar una actividad por registro. Se desmarcarán las selecciones.", "Error de Selección");

                // Desmarcar todos los CheckBox para corregir el error del usuario
                foreach (Control control in grpEjercicio.Controls)
                {
                    if (control is CheckBox checkbox)
                    {
                        checkbox.Checked = false;
                    }
                }

                // Retornar cadena vacía para indicar que no hubo una selección válida
                return "";
            }

            // 2. Aplicar la lógica de confirmación: Si no hay CheckBox seleccionado
            if (checkBoxesSeleccionados == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una actividad.", "Error de Selección");
                // Retornar cadena vacía para indicar que no hubo una selección válida
                return "";
            }

            // Si la validación pasa (solo 1 seleccionado), se retorna el texto guardado
            return TipoEjercicio;
        }









        // -------------------------------------------------------------------------
        // BOTONES DE NAVEGACION 
        // -------------------------------------------------------------------------

        private void btnRegistrarAlimento_Click(object sender, EventArgs e)
        {
            FrmRegistrarAlimentos nuevoFormulario = new FrmRegistrarAlimentos();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnRegistrarActividad_Click(object sender, EventArgs e)
        {
            FrmRegistrarActividad nuevoFormulario = new FrmRegistrarActividad();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            FrmMiPlan nuevoFormulario = new FrmMiPlan();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnProgreso_Click(object sender, EventArgs e)
        {
            FrmMiProgreso nuevoFormulario = new FrmMiProgreso();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnCalificar_Click(object sender, EventArgs e)
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
