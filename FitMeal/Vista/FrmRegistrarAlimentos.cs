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

        public FrmRegistrarAlimentos()
        {
            InitializeComponent();
            cn = new cConexion();

        }

        private void Filtrar(DataGridView dtg, String Filtro)
        {
            Filtro = Filtro.ToLower();

            foreach (DataGridViewRow row in dtg.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool visible = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(Filtro))
                        {
                            visible = true;
                            break;
                        }
                    }
                    row.Visible = visible;
                }
            }
        }

        private void txtBuscarReceta_TextChanged(object sender, EventArgs e)
        {
            Filtrar(dgvRegistrarAlimento, txtBuscarReceta.Text);
        }

        private void VerificarPlanActivo()
        {
            try
            {
                string verificar = "select top 1 PlanID, FechaInicio, FechaFin from PLANDIETA where Cedula = @Cedula and estado = 'Activo' order by FechaInicio desc ";

                cmd = new SqlCommand(verificar, cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    DateTime fechaFin = Convert.ToDateTime(dr["FechaFin"]);
                    int planID = Convert.ToInt32(dr["PlanID"]);
                    dr.Close();
                    cn.CerrarConexion();

                    if (fechaFin >= DateTime.Now.Date)
                    {
                        CargarReceta(planID);
                    }
                    else
                    {
                        dr.Close();
                        cn.CerrarConexion();

                        string vencido = "update PLANDIETA set Estado = 'Finalizado' where PlanID = @PlanID";
                        SqlCommand cmdFin = new SqlCommand(vencido, cn.AbrirConexion());
                        cmdFin.Parameters.AddWithValue("@PlanID", planID);
                        cmdFin.ExecuteNonQuery();
                        cn.CerrarConexion();

                        MessageBox.Show("Su plan a expirado, genere uno nuevo");
                    }
                }
                else
                {
                    dr.Close();
                    cn.CerrarConexion();
                    MessageBox.Show("No tienes un plan activo. Genera uno nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al verificar el plan");
            }

        }


        private void CargarReceta(int PlanID)
        {
            dgvRegistrarAlimento.Rows.Clear();

            string llenar = @"select c.Fecha, c.TipoComida, r.Nombre, r.TotalCalorias,r.TotalProteinas, r.TotalCarbohidratos
              from COMIDA_PLANIFICADA c
              inner join RECETA r on  c.RecetaID = r.RecetaID
              where c.PlanID = @PlanID
              order by c.Fecha, c.TipoComida";

            SqlCommand cmd = new SqlCommand(llenar, cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@PlanID", PlanID);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            { 

                dgvRegistrarAlimento.Rows.Add(
                    dr["TipoComida"].ToString(),
                    dr["Nombre"].ToString(),
                    dr["TotalCalorias"].ToString(),
                    dr["TotalProteinas"].ToString(),
                    dr["TotalCarbohidratos"].ToString(),
                    false
                );
            }

            dr.Close();
            cn.CerrarConexion();
        }






        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 🔹 1. Obtener el Plan activo del usuario
                int planID;
                string queryPlan = "select top 1 PlanID from PLANDIETA where Cedula = @Cedula and Estado = 'Activo' order by FechaInicio desc";
                using (SqlCommand cmdPlan = new SqlCommand(queryPlan, cn.AbrirConexion()))
                {
                    cmdPlan.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);
                    object result = cmdPlan.ExecuteScalar();
                    if (result != null)
                        planID = Convert.ToInt32(result);
                }
                cn.CerrarConexion();

                // 🔹 2. Crear (si no existe) un progreso para hoy
                int progresoID;
                DateTime fechaHoy = DateTime.Today;

                string queryProgreso = @"
            if not exists (select 1 from PROGRESO where Cedula = @Cedula and Fecha = @Fecha)
            begin
                insert into PROGRESO (Cedula, Fecha) values (@Cedula, @Fecha);
            end;
            select ProgresoID from PROGRESO where Cedula = @Cedula and Fecha = @Fecha;";

                using (SqlCommand cmdProgreso = new SqlCommand(queryProgreso, cn.AbrirConexion()))
                {
                    cmdProgreso.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);
                    cmdProgreso.Parameters.AddWithValue("@Fecha", fechaHoy);
                    progresoID = Convert.ToInt32(cmdProgreso.ExecuteScalar());
                }
                cn.CerrarConexion();

                // 🔹 3. Recorrer las filas marcadas
                using (SqlConnection con = cn.AbrirConexion())
                {
                    foreach (DataGridViewRow row in dgvRegistrarAlimento.Rows)
                    {
                        if (row.IsNewRow || row.Cells["Selec"].Value == null)
                            continue;

                        bool marcado = Convert.ToBoolean(row.Cells["Selec"].Value);
                        if (!marcado) continue;

                        // Obtener datos de la fila
                        string tipoComida = row.Cells["TipoComida"].Value.ToString();
                        string nombre = row.Cells["Nombre"].Value.ToString();
                        decimal calorias = Convert.ToDecimal(row.Cells["TotalCalorias"].Value);
                        int recetaID = 0;

                        // 🔹 Buscar el RecetaID según el nombre (ya que no está en el datagrid)
                        string buscarReceta = "select RecetaID from RECETA where Nombre = @Nombre";
                        using (SqlCommand cmdBuscar = new SqlCommand(buscarReceta, con))
                        {
                            cmdBuscar.Parameters.AddWithValue("@Nombre", nombre);
                            object id = cmdBuscar.ExecuteScalar();
                            if (id != null) recetaID = Convert.ToInt32(id);
                        }

                        // 🔹 Verificar si ya se registró esa comida hoy (evitar duplicados)
                        string existe = @"select count(*) FROM REGISTRO_COMIDAS 
                                  where ProgresoID = @ProgresoID and RecetaID = @RecetaID and Fecha = @Fecha";
                        using (SqlCommand cmdExiste = new SqlCommand(existe, con))
                        {
                            cmdExiste.Parameters.AddWithValue("@ProgresoID", progresoID);
                            cmdExiste.Parameters.AddWithValue("@RecetaID", recetaID);
                            cmdExiste.Parameters.AddWithValue("@Fecha", fechaHoy);

                            int count = Convert.ToInt32(cmdExiste.ExecuteScalar());
                            if (count > 0) continue;
                        }

                        // 🔹 Insertar en REGISTRO_COMIDAS
                        string insert = @"insert into REGISTRO_COMIDAS 
                                  (ProgresoID, RecetaID, Fecha, NombreComida, Categoria, CantidadCalorias)
                                  values (@ProgresoID, @RecetaID, @Fecha, @Nombre, @Categoria, @Calorias)";
                        using (SqlCommand cmdInsert = new SqlCommand(insert, con))
                        {
                            cmdInsert.Parameters.AddWithValue("@ProgresoID", progresoID);
                            cmdInsert.Parameters.AddWithValue("@RecetaID", recetaID);
                            cmdInsert.Parameters.AddWithValue("@Fecha", fechaHoy);
                            cmdInsert.Parameters.AddWithValue("@Nombre", nombre);
                            cmdInsert.Parameters.AddWithValue("@Categoria", tipoComida);
                            cmdInsert.Parameters.AddWithValue("@Calorias", calorias);
                            cmdInsert.ExecuteNonQuery();
                        }
                    }
                    // 🔹 Desmarcar todas las casillas después de guardar
                    foreach (DataGridViewRow row in dgvRegistrarAlimento.Rows)
                    {
                        if (row.Cells["Selec"].Value != null)
                            row.Cells["Selec"].Value = false;
                    }
                }
                cn.CerrarConexion();

                MessageBox.Show("comidas registradas correctamente.");
            }
            catch (Exception ex)
            {
                cn.CerrarConexion();
                MessageBox.Show("Error al registrar comidas");
            }
        }

        private void FrmRegistrarAlimentos_Load(object sender, EventArgs e)
        {
            VerificarPlanActivo();
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



    }
}
