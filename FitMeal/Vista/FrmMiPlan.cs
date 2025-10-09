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
    public partial class FrmMiPlan : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public FrmMiPlan()
        {
            InitializeComponent();
            cn = new cConexion();
        }

        private void FrmMiPlan_Load(object sender, EventArgs e)
        {
            //Verifica si el usuario tiene un plan activo y lo muestra en el datagridview
            VerificarPlanActivo();
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
            FrmLoggin.AbrirForm(new FrmRegistrarAlimentos(), this);
        }

        private void btnIrRegistrarActividad_Click(object sender, EventArgs e)
        {
            FrmLoggin.AbrirForm(new FrmRegistrarActividad(), this);
        }

        private void btnIrRegistrarPlan_Click(object sender, EventArgs e)
        {
            FrmMiPlan nuevoFormulario = new FrmMiPlan();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnIrRegistrarProgreso_Click(object sender, EventArgs e)
        {
            FrmLoggin.AbrirForm(new FrmMiProgreso(), this);
        }

        private void btnIrFeedback_Click(object sender, EventArgs e)
        {
            FrmLoggin.AbrirForm(new FrmFeedback(), this);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmLoggin.AbrirForm(new FrmPerfil(), this);
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

                        btnGenerarPlan.Enabled = false;
                        btnAprobarPlan.Enabled = false;
                        CargarPlanActivo(planID);
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
                        btnGenerarPlan.Enabled = true;
                        btnAprobarPlan.Enabled = false;
                    }
                }
                else
                {
                    dr.Close();
                    cn.CerrarConexion();
                    MessageBox.Show("No tienes un plan activo. Genera uno nuevo.");
                    btnGenerarPlan.Enabled = true;
                    btnAprobarPlan.Enabled = false;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al verificar el plan");
            }

        }

        private void CargarPlanActivo(int PlanID)
        {
            dtgMiPlan.Rows.Clear();

            string llenar = @"select c.Fecha, c.TipoComida, r.Nombre, r.TotalCalorias,r.TotalProteinas, r.TotalCarbohidratos
              from COMIDA_PLANIFICADA c
              inner join RECETA r on  c.RecetaID = r.RecetaID
              where c.PlanID = @PlanID
              order by c.Fecha, c.TipoComida";

            SqlCommand cmd = new SqlCommand(llenar, cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@PlanID", PlanID);
            SqlDataReader dr = cmd.ExecuteReader();

            DateTime fechaInicio = DateTime.MinValue;

            while (dr.Read())
            {

                DateTime fecha = Convert.ToDateTime(dr["Fecha"]);


                if (fechaInicio == DateTime.MinValue)
                    fechaInicio = fecha;

                int numeroDia = (int)(fecha - fechaInicio).TotalDays + 1;
                string diaTexto = "Día " + numeroDia;

                dtgMiPlan.Rows.Add(
                    diaTexto,
                    dr["TipoComida"].ToString(),
                    dr["Nombre"].ToString(),
                    dr["TotalCalorias"].ToString(),
                    dr["TotalProteinas"].ToString(),
                    dr["TotalCarbohidratos"].ToString()
                );
            }

            dr.Close();
            cn.CerrarConexion();
        }


        private void Filtrar(DataGridView dtg, String Filtro)
        {
            Filtro = Filtro.ToLower();

            if (string.IsNullOrEmpty(Filtro) || Filtro == "todos")
            {
                foreach (DataGridViewRow row in dtg.Rows)
                {
                    if (!row.IsNewRow)
                        row.Visible = true;
                }
                return;
            }


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
        

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar(dtgMiPlan, cmbCategoria.Text);
        }

        private void btnGenerarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                cmbCategoria.Enabled = false;
                dtgMiPlan.Rows.Clear();

                // Obtener meta del usuario
                string metaUsuario = "";
                string meta = "select Meta from USUARIOS where Cedula = @Cedula";
                cmd = new SqlCommand(meta, cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    metaUsuario = dr["Meta"].ToString();
                }
                dr.Close();
                cn.CerrarConexion();

                // Obtener alergias y preferencias
                var alimentosAlergia = new List<int>();
                var alimentosNoPreferidos = new List<int>();

                // Alergias
                string Alergias = @"select a.AlimentoID from 
                          ALERG_USUARIO b inner join ALERG_ALIMENTO a on b.AlergiaID = a.AlergiaID
                          where b.Cedula = @Cedula";
                cmd = new SqlCommand(Alergias, cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    alimentosAlergia.Add(Convert.ToInt32(dr["AlimentoID"]));
                dr.Close();
                cn.CerrarConexion();

                // No preferidos
                string NoPreferidos = "select AlimentoID from PREF_USUARIO where Cedula = @Cedula";
                cmd = new SqlCommand(NoPreferidos, cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    alimentosNoPreferidos.Add(Convert.ToInt32(dr["AlimentoID"]));
                dr.Close();
                cn.CerrarConexion();

                // Tipos de comida
                string[] tipoComida = { "Desayuno", "Almuerzo", "Cena", "Snack" };
                Random rnd = new Random();

                //aqui guardaremos las recetas ya usadas para evitar duplicados
                var recetasUsadas = new HashSet<int>();

                //Recorremos los 7 días
                for (int dia = 1; dia <= 7; dia++)
                {
                    foreach (string tipo in tipoComida)
                    {
                        string seleccion = "select top 15 * from Receta where Categoria = @Categoria ";

                        // Filtros según meta
                        if (metaUsuario == "Perder Peso")
                            seleccion += "order by TotalCarbohidratos asc";
                        else if (metaUsuario == "Ganar Masa")
                            seleccion += "order by TotalProteinas desc";
                        else
                            seleccion += "order by newid()";

                        SqlCommand cmdRec = new SqlCommand(seleccion, cn.AbrirConexion());
                        cmdRec.Parameters.AddWithValue("@Categoria", tipo);
                        SqlDataReader drRec = cmdRec.ExecuteReader();

                        var recetasPosibles = new List<(int id, string nombre, decimal cal, decimal pro, decimal carb, string desc)>();

                        while (drRec.Read())
                        {
                            int recetaID = Convert.ToInt32(drRec["RecetaID"]);

                            //Se evita que ingresen recetas duplicadas a las recetas posibles
                            if (recetasUsadas.Contains(recetaID))
                                continue;

                            recetasPosibles.Add((
                                Convert.ToInt32(drRec["RecetaID"]),
                                drRec["Nombre"].ToString(),
                                Convert.ToDecimal(drRec["TotalCalorias"]),
                                Convert.ToDecimal(drRec["TotalProteinas"]),
                                Convert.ToDecimal(drRec["TotalCarbohidratos"]),
                                drRec["Descripcion"].ToString()
                            ));
                        }

                        drRec.Close();
                        cn.CerrarConexion();

                        // Filtrar por alergias y preferencias
                        var recetasFiltradas = new List<(int id, string nombre, decimal cal, decimal pro, decimal carb, string desc, int puntaje)>();

                        foreach (var receta in recetasPosibles)
                        {
                            string Ingrediente = "select AlimentoID from INGREDIENTES_RECETA where RecetaID = @RecetaID";
                            SqlCommand Ingredientes = new SqlCommand(Ingrediente, cn.AbrirConexion());
                            Ingredientes.Parameters.AddWithValue("@RecetaID", receta.id);
                            SqlDataReader drIngredientes = Ingredientes.ExecuteReader();

                            bool contieneAlergia = false;
                            bool contieneNoPreferido = false;

                            while (drIngredientes.Read())
                            {
                                int alimentoID = Convert.ToInt32(drIngredientes["AlimentoID"]);
                                if (alimentosAlergia.Contains(alimentoID))
                                    contieneAlergia = true;
                                if (alimentosNoPreferidos.Contains(alimentoID))
                                    contieneNoPreferido = true;
                            }

                            drIngredientes.Close();
                            cn.CerrarConexion();

                            if (contieneAlergia)
                                continue;

                            int puntaje = 10; // base
                            if (metaUsuario == "Perder Peso")
                                puntaje += (int)(-receta.carb / 10);
                            if (metaUsuario == "Ganar Masa")
                                puntaje += (int)(receta.pro / 10);
                            if (contieneNoPreferido)
                                puntaje -= 5; // penaliza

                            recetasFiltradas.Add((receta.id, receta.nombre, receta.cal, receta.pro, receta.carb, receta.desc, puntaje));
                        }

                        if (recetasFiltradas.Count > 0)
                        {
                            // Ordenar por puntaje y elegir una receta aleatoria del top 3
                            var ordenadas = recetasFiltradas.OrderByDescending(r => r.puntaje).ToList();
                            var topOpciones = ordenadas.Take(3).ToList();
                            var aleatoria = topOpciones[rnd.Next(topOpciones.Count)];

                            //se añade la receta para que no se vuelva a repetir en otra iteracion
                            recetasUsadas.Add(aleatoria.id);

                            //Agregamos la receta al plan semanal (una por día y tipo)
                            dtgMiPlan.Rows.Add(
                                "Día " + dia,
                                tipo,
                                aleatoria.nombre,
                                aleatoria.cal,
                                aleatoria.pro,
                                aleatoria.carb
                            );
                        }
                    }
                }
                cmbCategoria.Enabled = false;
                btnGenerarPlan.Enabled = true;
                btnAprobarPlan.Enabled = true;
                MessageBox.Show("Plan semanal generado, puede aprobarlo o generar otro nuevamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar plan: " + ex.Message);
            }

        }

        private void btnAprobarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgMiPlan.Rows.Count == 0)
                {
                    MessageBox.Show("Primero debe generar un plan.");
                    return;
                }

                DialogResult Confirmar = MessageBox.Show(
                    "¿Desea aprobar este plan?", "Confirmar Aprobacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Confirmar == DialogResult.No)
                    return;

                DateTime fechaInicio = DateTime.Now.Date;
                DateTime fechaFin = fechaInicio.AddDays(7);

                // Calcular objetivo de calorías (columna índice 3)
                decimal objetivoCalorias = 0;
                foreach (DataGridViewRow row in dtgMiPlan.Rows)
                {
                    if (row.IsNewRow) continue;
                    object v = row.Cells[3].Value;
                    if (v != null && decimal.TryParse(v.ToString(), out decimal c))
                        objetivoCalorias += c;
                }

                // Insertar PLANDIETA y obtener PlanID con SCOPE_IDENTITY (más compatible)
                string insertarPlan = @"
            INSERT INTO PLANDIETA (Cedula, FechaInicio, FechaFin, ObjetivoCalorias, Estado)
            VALUES (@Cedula, @FechaInicio, @FechaFin, @ObjetivoCalorias, 'Activo');
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                cmd = new SqlCommand(insertarPlan, cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                cmd.Parameters.AddWithValue("@ObjetivoCalorias", objetivoCalorias);

                object planObj = cmd.ExecuteScalar();
                if (planObj == null)
                {
                    cn.CerrarConexion();
                    MessageBox.Show("No se pudo obtener el PlanID al insertar el plan.");
                    return;
                }
                int nuevoPlanID = Convert.ToInt32(planObj);
                cn.CerrarConexion();

                // Insertar filas en COMIDA_PLANIFICADA (columna Fecha y TipoComida)
                foreach (DataGridViewRow fila in dtgMiPlan.Rows)
                {
                    if (fila.IsNewRow) continue;

                    string diaTexto = fila.Cells[0].Value?.ToString() ?? "Día 1";
                    string tipoComida = fila.Cells[1].Value?.ToString() ?? "";
                    string nombreReceta = fila.Cells[2].Value?.ToString() ?? "";

                    string digitos = new string(diaTexto.Where(Char.IsDigit).ToArray());
                    int numeroDia = 1;
                    if (!int.TryParse(digitos, out numeroDia)) numeroDia = 1;
                    DateTime fechaComida = fechaInicio.AddDays(numeroDia - 1);

                    // Buscar RecetaID por nombre
                    string buscarReceta = "select RecetaID from RECETA where Nombre = @Nombre";
                    cmd = new SqlCommand(buscarReceta, cn.AbrirConexion());
                    cmd.Parameters.AddWithValue("@Nombre", nombreReceta);
                    object resultado = cmd.ExecuteScalar();
                    cn.CerrarConexion();


                    int recetaID = Convert.ToInt32(resultado);

                    // Insertar en COMIDA_PLANIFICADA
                    string insertarComida = @"
                insert into COMIDA_PLANIFICADA (PlanID, RecetaID, Fecha, TipoComida)
                values (@PlanID, @RecetaID, @Fecha, @TipoComida)";

                    cmd = new SqlCommand(insertarComida, cn.AbrirConexion());
                    cmd.Parameters.AddWithValue("@PlanID", nuevoPlanID);
                    cmd.Parameters.AddWithValue("@RecetaID", recetaID);
                    cmd.Parameters.AddWithValue("@Fecha", fechaComida);
                    cmd.Parameters.AddWithValue("@TipoComida", tipoComida);
                    cmd.ExecuteNonQuery();
                    cn.CerrarConexion();
                }
  
                MessageBox.Show("Plan aprobado correctamente.");
                btnGenerarPlan.Enabled = false;
                btnAprobarPlan.Enabled = false;
                cmbCategoria.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aprobar plan");
            }
        }

        private void dtgMiPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nombreReceta = dtgMiPlan.Rows[e.RowIndex].Cells["NombreReceta"].Value.ToString();

                // Buscar el ID de la receta
                string buscarReceta = "select RecetaID from RECETA where Nombre = @Nombre";
                cmd = new SqlCommand(buscarReceta, cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@Nombre", nombreReceta);
                object result = cmd.ExecuteScalar();
                cn.CerrarConexion();

                if (result != null)
                {
                    int recetaID = Convert.ToInt32(result);
                    FrmDetallesReceta frm = new FrmDetallesReceta(recetaID);
                    frm.ShowDialog();
                }
            }
        }
    }
}
