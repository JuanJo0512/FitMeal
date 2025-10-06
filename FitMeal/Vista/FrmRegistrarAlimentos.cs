using FitMeal.Modelo;
using System;
using System.Collections;
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
    public partial class FrmRegistrarAlimentos : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;

        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FitMeal2;Integrated Security=True;Encrypt=False";
        public FrmRegistrarAlimentos()
        {
            InitializeComponent();
            cn = new cConexion();
            CargarReceta();

        }


        private void txtBuscarReceta_TextChanged(object sender, EventArgs e)
        {
            // Obtiene el texto de búsqueda del TextBox
            string filtro = txtBuscarReceta.Text.Trim();

            // 1. Asegúrate de que el DataGridView esté usando el DataTable
            if (dgvRegistrarAlimento.DataSource is DataTable dataTable)
            {
                // 2. Obtiene la vista de los datos (DataView)
                DataView dv = dataTable.DefaultView;

                if (string.IsNullOrEmpty(filtro))
                {
                    // Si el campo de búsqueda está vacío, elimina el filtro
                    dv.RowFilter = string.Empty;
                }
                else
                {
                    dv.RowFilter = $"Nombre LIKE '%{filtro.Replace("'", "''")}%'";

                    // Nota: El .Replace("'", "''") es crucial para evitar inyecciones SQL
                    // y errores de sintaxis si el usuario escribe una comilla simple.
                }
            }
        }


        private void CargarReceta()
        {
            // Usamos el DataAdapter y DataTable para una carga de datos más eficiente
            dt = new DataTable(); // Reiniciamos el DataTable

            string query = @"
        SELECT 
            RecetaID, 
            Categoria, 
            Nombre, 
            TotalCalorias, 
            TotalCarbohidratos, 
            TotalProteinas
        FROM RECETA";

            // Usamos 'using' para asegurar que la conexión y el adaptador se cierren y liberen recursos.
            using (SqlConnection connection = new SqlConnection(connectionString)) // Usa la cadena de conexión local
            {
                try
                {
                    connection.Open();
                    da = new SqlDataAdapter(query, connection);
                    da.Fill(dt);

                    // Asignar el DataTable como origen de datos.
                    dgvRegistrarAlimento.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las recetas: " + ex.Message, "Error de Base de Datos");
                }
                // No necesitamos 'finally' ya que 'using' se encarga de cerrar la conexión.
            }
        }






        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Variables de la receta DEBEN declararse fuera del try/catch del bucle
            int RecetaID = 0;
            String NombreComida = "";
            String Categoria = "";
            decimal calorias = 0;

            // 1. Validar si hay al menos una fila seleccionada (Checkeada)
            bool algunaRecetaMarcada = false;
            foreach (DataGridViewRow row in dgvRegistrarAlimento.Rows)
            {
                if (!row.IsNewRow && Convert.ToBoolean(row.Cells["Selec"].Value))
                {
                    algunaRecetaMarcada = true;
                    break;
                }
            }

            if (!algunaRecetaMarcada)
            {
                MessageBox.Show("Por favor, selecciona al menos una receta para registrar.", "Advertencia");
                return;
            }

            // 2. Inicia el proceso de guardado para las recetas marcadas
            foreach (DataGridViewRow row in dgvRegistrarAlimento.Rows)
            {
                if (row.IsNewRow || row.Cells["Selec"].Value == null) continue;

                bool marcado = Convert.ToBoolean(row.Cells["Selec"].Value);

                if (marcado)
                {
                    try
                    {
                        // Convertir y Asignar valores a variables declaradas fuera del try.
                        RecetaID = Convert.ToInt32(row.Cells["RecetaID"].Value); // Usar RecetaID si ese es el DataPropertyName
                        NombreComida = Convert.ToString(row.Cells["Nombre"].Value); // Usar Nombre si ese es el DataPropertyName
                        Categoria = Convert.ToString(row.Cells["Categoria"].Value);
                        calorias = Convert.ToDecimal(row.Cells["TotalCalorias"].Value);

                        // Variables de contexto
                        string cedulaUsuario = FrmLoggin.UsuarioActivoCedula;
                        DateTime fechaActual = DateTime.Today.Date;




                        string sqlRegistroComidaScript = @"
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
                    SET @ProgresoIDExistente = SCOPE_IDENTITY();
                END

                -- Inserta el registro de la comida usando el ProgresoID encontrado o creado
                INSERT INTO REGISTRO_COMIDAS 
                (ProgresoID, RecetaID, Fecha, NombreComida, Categoria, CantidadCalorias)
                --         
                VALUES 
                (@ProgresoIDExistente, @RecetaID, @FechaActual, @NombreComida, @CategoriaComida, @CaloriasComida);
            ";


                        SqlCommand cmd = new SqlCommand(sqlRegistroComidaScript, cn.AbrirConexion());

                        // Parámetros
                        cmd.Parameters.AddWithValue("@Cedula", cedulaUsuario);
                        cmd.Parameters.AddWithValue("@FechaActual", fechaActual);
                        cmd.Parameters.AddWithValue("@RecetaID", RecetaID);
                        cmd.Parameters.AddWithValue("@NombreComida", NombreComida);
                        cmd.Parameters.AddWithValue("@CategoriaComida", Categoria);
                        cmd.Parameters.AddWithValue("@CaloriasComida", calorias);

                        cmd.ExecuteNonQuery();
                        cn.CerrarConexion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al registrar la receta '{NombreComida}': " + ex.Message, "Error de Base de Datos");
                        cn.CerrarConexion();
                        return;
                    }
                }
            }
            // Mensaje de éxito después de completar todos los registros
            MessageBox.Show("Recetas registradas con éxito.", "Éxito");
        }




        // -------------- BOTONES DE NAVEGACION ---------------------------------

        private void btnIrRegistrarAlimento_Click(object sender, EventArgs e)
        {
            FrmRegistrarActividad nuevoFormulario = new FrmRegistrarActividad();
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

        private void FrmRegistrarAlimentos_Load(object sender, EventArgs e)
        {
        }

    }
}
