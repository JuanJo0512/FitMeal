using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace FitMeal.Vista
{
    public partial class FrmMiProgreso : Form
    {
        public FrmMiProgreso()
        {
            InitializeComponent();
        }

        private void FrmMiProgreso_Load(object sender, EventArgs e)
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

            chrProgreso.Series.Clear();
            chrProgreso.Titles.Clear();

        }

        private void CargarGraficoTiempo()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FitMeal2;Integrated Security=True;Encrypt=False";


            // Consulta del SQL para que solo aparezcan los ultimos 7 dias en el grafico
            string query = @"
                SELECT 
                    CONVERT(DATE, Fecha) AS Dia,
                    SUM(TiempoEjercicio) AS TiempoTot
                FROM
                    REGISTRO_ACTIVIDAD
                WHERE
                    Fecha >= DATEADD(day, -7, GETDATE())
                GROUP BY
                    CONVERT(DATE, Fecha)
                ORDER BY
                    Dia ASC";

            // Limpio el chart pa que no se me junten los que ya estaban

            chrProgreso.Series.Clear();
            chrProgreso.Titles.Clear();


            // Configuro la linea de la grafica ya que esta limpia

            Series serieEjercicio = new Series("Tiempo Actividad");
            serieEjercicio.ChartType = SeriesChartType.Line;
            serieEjercicio.BorderWidth = 4;
            serieEjercicio.MarkerStyle = MarkerStyle.Star4;
            serieEjercicio.MarkerSize = 8;
            serieEjercicio.Color = Color.DarkOliveGreen;

            // Carga de los datos

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // aqui se usa un try catch para tener un error controlado y que al usuario no se le colapse la app
                // en el try va el proposito del codigo

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Esta condicion significa "Mientras haya más filas de datos disponibles para ser leídas del resultado de la consulta SQL, ejecuta el bloque de código siguiente."
                        while (reader.Read()) {

                            // obtiene los valores de la consulta que hicimos arriba
                            DateTime dia = reader.GetDateTime(0);
                            int tiempo = Convert.ToInt32(reader["TiempoTotal"]);

                            // Aca añade el punto al grafico (Eje x: Fecha  y Eje Y: Tiempo)
                            serieEjercicio.Points.AddXY(dia, tiempo);
                        }
                    }

                }
                // en el catch va lo que ocurre si hay una excepcion o algo falla
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar gráfico: {ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            // Y aqui tambien se agrega una opcion si no hay registros de los ultimos 7 dias

            if(serieEjercicio.Points.Count > 0)
            {
                chrProgreso.Series.Add(serieEjercicio);

                //Titulo Principal
                chrProgreso.Titles.Add("Progreso de ejercicio");

                // Configuracion de los ejes
                ChartArea area = chrProgreso.ChartAreas[0];

                // Eje X  que son los dias
                area.AxisX.Title = "Dia";
                area.AxisX.LabelStyle.Format = "dd/MM";
                area.AxisX.IntervalType = DateTimeIntervalType.Days;
                area.AxisX.Interval = 1; // Muestra una etiqueta por cada día

                // Eje Y: Tiempo
                area.AxisY.Title = "Duración (Horas)";
                area.AxisY.Minimum = 0;

                // Mostrar el valor exacto encima de cada punto
                serieEjercicio.IsValueShownAsLabel = true;
                serieEjercicio.LabelFormat = "N0"; // Muestra el valor sin decimales
            }
            else
            {
                chrProgreso.Titles.Add("No se encontraron registros de actividad en los últimos 7 días.");
            }


        }

        private void CargarGraficoConsumo()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FitMeal;Integrated Security=True;Encrypt=False";


            // Consulta del SQL para que solo aparezcan los ultimos 7 dias en el grafico
            // Se hace un JOIN entre REGISTRO_COMIDAS y REGISTRO_ACTIVIDAD porque necesito CaloriasQuemadas y CaloriasConsumidas
            string query = @"
                SELECT
                    ISNULL(C.Dia, A.Dia) AS Dia,
                    ISNULL(C.CaloriasConsumidas, 0) AS CaloriasConsumidas,
                    ISNULL(A.CaloriasQuemadas, 0) AS CaloriasQuemadas
                FROM
                (
                    -- Subconsulta A: Calorías Quemadas por Día
                    SELECT 
                        CONVERT(DATE, Fecha) AS Dia,
                        SUM(CaloriasQuemadas) AS CaloriasQuemadas
                    FROM
                        REGISTRO_ACTIVIDAD
                    WHERE
                        Fecha >= DATEADD(day, -7, GETDATE())
                    GROUP BY
                        CONVERT(DATE, Fecha)
                ) AS A
                FULL OUTER JOIN
                (
                    -- Subconsulta C: Calorías Consumidas por Día
                    SELECT 
                        CONVERT(DATE, Fecha) AS Dia,
                        SUM(CantidadCalorias) AS CaloriasConsumidas
                    FROM
                        REGISTRO_COMIDAS
                    WHERE
                        Fecha >= DATEADD(day, -7, GETDATE())
                    GROUP BY
                        CONVERT(DATE, Fecha)
                ) AS C ON A.Dia = C.Dia
                ORDER BY 
                Dia ASC";


            // Limpio el chart pa que no se me junten los que ya estaban

            chrProgreso.Series.Clear();
            chrProgreso.Titles.Clear();


            // Configuro la linea de la grafica de las calorias que consumio el usuario

            Series serieComidas = new Series("Calorias Consumidas");
            serieComidas.ChartType = SeriesChartType.Line;
            serieComidas.BorderWidth = 4;
            serieComidas.MarkerStyle = MarkerStyle.Star4;
            serieComidas.MarkerSize = 8;
            serieComidas.Color = Color.DarkOliveGreen;


            // Configuro la linea de la grafica de las calorias que quemo el usuario

            Series serieQuemadas = new Series("Calorias Quemadas");
            serieQuemadas.ChartType = SeriesChartType.Line;
            serieQuemadas.BorderWidth = 4;
            serieQuemadas.MarkerStyle = MarkerStyle.Star4;
            serieQuemadas.MarkerSize = 8;
            serieQuemadas.Color = Color.Goldenrod;



            // Conexión y Carga de Datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime dia = reader.GetDateTime(0);
                            double consumidas = reader.GetDouble(1);
                            double quemadas = reader.GetDouble(2);

                            // Añade el punto a la serie correspondiente
                            serieComidas.Points.AddXY(dia, consumidas);
                            serieQuemadas.Points.AddXY(dia, quemadas);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el gráfico: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Configuración Final
            if (serieComidas.Points.Count > 0 || serieQuemadas.Points.Count > 0)
            {
                // Agrega ambas series al gráfico
                chrProgreso.Series.Add(serieComidas);
                chrProgreso.Series.Add(serieQuemadas);

                // Configuración de los Ejes y Título
                chrProgreso.Titles.Add("Balance Calórico (Últimos 7 Días)");

                ChartArea area = chrProgreso.ChartAreas[0];
                area.AxisX.Title = "Día";
                area.AxisX.LabelStyle.Format = "dd/MM";
                area.AxisX.IntervalType = DateTimeIntervalType.Days;
                area.AxisX.Interval = 1;

                area.AxisY.Title = "Calorías";
                area.AxisY.Minimum = 0;

                // Habilita la leyenda para distinguir las líneas
                chrProgreso.Legends[0].Enabled = true;
            }
            else
            {
                chrProgreso.Titles.Add("No se encontraron datos de calorías en los últimos 7 días.");
            }

        }

        private void btnEjercicio_Click(object sender, EventArgs e)
        {
            CargarGraficoTiempo();
        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            CargarGraficoConsumo();
        }

        private void btnIrRegistrarAlimento_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario
            FrmRegistrarAlimentos nuevoFormulario = new FrmRegistrarAlimentos();

            // Muestra el nuevo formulario
            nuevoFormulario.Show();

            //Oculta el formulario actual (FrmMiProgreso)
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
