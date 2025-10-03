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
            CargarGraficoProgreso();
        }

        private void CargarGraficoProgreso()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FitMeal;Integrated Security=True;Encrypt=False";


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

            chrTiempo.Series.Clear();
            chrTiempo.Titles.Clear();


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
                chrTiempo.Series.Add(serieEjercicio);

                //Titulo Principal
                chrTiempo.Titles.Add("Progreso de ejercicio");

                // Configuracion de los ejes
                ChartArea area = chrTiempo.ChartAreas[0];

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
                chrTiempo.Titles.Add("No se encontraron registros de actividad en los últimos 7 días.");
            }


        }
    }
}
