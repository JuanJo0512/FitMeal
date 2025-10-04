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
    public partial class FrmGestionarRecetas : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public FrmGestionarRecetas()
        {
            InitializeComponent();
            cn = new cConexion();
            Limpiar();
            CargarAlimentos();
        }

        private void CargarAlimentos()
        {
            dtgAlimentos.Rows.Clear();

            string query = "SELECT AlimentoID, Nombre, Categoria, Calorias, Proteinas, Carbohidratos FROM ALIMENTO";
            SqlCommand cmd = new SqlCommand(query, cn.AbrirConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dtgAlimentos.Rows.Add(
                    dr["Nombre"].ToString(),
                    dr["AlimentoID"].ToString(),
                    dr["Categoria"].ToString(),
                    dr["Calorias"].ToString(),
                    dr["Proteinas"].ToString(),
                    dr["Carbohidratos"].ToString(),
                    "",
                    false
                );
            }

            dr.Close();
            cn.CerrarConexion();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmLoggin.AbrirForm(new FrmAdmin(),this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de modificar esta receta?", "Confirmar Modificación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No) return;

                string modificar = @"update RECETA 
                    set Descripcion = @Descripcion, Categoria = @Categoria, TipoDieta = @TipoDieta, 
                        TipoDieta2 = @TipoDieta2, TotalCalorias = @Calorias, TotalProteinas = @Proteinas, TotalCarbohidratos = @Carbohidratos
                    where lower(Nombre) = lower(@Nombre)";

                cmd = new SqlCommand(modificar, cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@Categoria", cmbCategoria.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@TipoDieta", cmbTipo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@TipoDieta2", cmbTipo2.SelectedItem != null ? cmbTipo2.SelectedItem.ToString() : "");
                cmd.Parameters.AddWithValue("@Calorias", Convert.ToDecimal(txtTotalCalorias.Text));
                cmd.Parameters.AddWithValue("@Proteinas", Convert.ToDecimal(txtTotalProteinas.Text));
                cmd.Parameters.AddWithValue("@Carbohidratos", Convert.ToDecimal(txtTotalCarbohidratos.Text));

                cmd.ExecuteNonQuery();
                cn.CerrarConexion();

                // Actualizar ingredientes (eliminamos y volvemos a insertar)
                string eliminarIng = "delete from INGREDIENTES_RECETA where RecetaID = (select RecetaID from RECETA where lower(Nombre) = lower(@Nombre))";
                SqlCommand cmdEliminarIng = new SqlCommand(eliminarIng, cn.AbrirConexion());
                cmdEliminarIng.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmdEliminarIng.ExecuteNonQuery();
                cn.CerrarConexion();

                int recetaID = ObtenerRecetaID(txtNombre.Text);

                foreach (DataGridViewRow row in dtgAlimentos.Rows)
                {
                    bool seleccionado = row.Cells["Seleccionar"].Value != null && (bool)row.Cells["Seleccionar"].Value;
                    if (seleccionado)
                    {
                        int alimentoID = Convert.ToInt32(row.Cells["AlimentoID"].Value);
                        string cantidad = row.Cells["Cantidad"].Value?.ToString() ?? "";

                        string insertarIng = "insert into INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) values (@RecetaID, @AlimentoID, @Cantidad)";
                        SqlCommand cmdIng = new SqlCommand(insertarIng, cn.AbrirConexion());
                        cmdIng.Parameters.AddWithValue("@RecetaID", recetaID);
                        cmdIng.Parameters.AddWithValue("@AlimentoID", alimentoID);
                        cmdIng.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmdIng.ExecuteNonQuery();
                        cn.CerrarConexion();
                    }
                }

                MessageBox.Show("Receta modificada correctamente.");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar receta: " + ex.Message);
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si ya existe una receta con ese nombre
                string verificar = "select count(*) from RECETA where lower(Nombre) = lower(@Nombre)";
                SqlCommand cmdVerificar = new SqlCommand(verificar, cn.AbrirConexion());
                cmdVerificar.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());

                int existe = (int)cmdVerificar.ExecuteScalar();
                cn.CerrarConexion();

                if (existe > 0)
                {
                    MessageBox.Show("Ya existe una receta con este nombre.");
                    return;
                }

                // Insertar la receta
                string insertarReceta = @"insert into RECETA 
                    (Nombre, Descripcion, Categoria, TipoDieta, TipoDieta2, TotalCalorias, TotalProteinas, TotalCarbohidratos) 
                    output inserted.RecetaID
                    values (@Nombre, @Descripcion, @Categoria, @TipoDieta, @TipoDieta2, @Calorias, @Proteinas, @Carbohidratos)";

                cmd = new SqlCommand(insertarReceta, cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text.Trim());
                cmd.Parameters.AddWithValue("@Categoria", cmbCategoria.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@TipoDieta", cmbTipo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@TipoDieta2", cmbTipo2.SelectedItem != null ? cmbTipo2.SelectedItem.ToString() : "");
                cmd.Parameters.AddWithValue("@Calorias", Convert.ToDecimal(txtTotalCalorias.Text));
                cmd.Parameters.AddWithValue("@Proteinas", Convert.ToDecimal(txtTotalProteinas.Text));
                cmd.Parameters.AddWithValue("@Carbohidratos", Convert.ToDecimal(txtTotalCarbohidratos.Text));

                int recetaID = (int)cmd.ExecuteScalar();
                cn.CerrarConexion();

                // Insertar ingredientes seleccionados
                foreach (DataGridViewRow row in dtgAlimentos.Rows)
                {
                    bool seleccionado = row.Cells["Seleccionar"].Value != null && (bool)row.Cells["Seleccionar"].Value;
                    if (seleccionado)
                    {
                        int alimentoID = Convert.ToInt32(row.Cells["AlimentoID"].Value);
                        string cantidad = row.Cells["Cantidad"].Value?.ToString() ?? "";

                        string insertarIng = "insert into INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) values (@RecetaID, @AlimentoID, @Cantidad)";
                        SqlCommand cmdIng = new SqlCommand(insertarIng, cn.AbrirConexion());
                        cmdIng.Parameters.AddWithValue("@RecetaID", recetaID);
                        cmdIng.Parameters.AddWithValue("@AlimentoID", alimentoID);
                        cmdIng.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmdIng.ExecuteNonQuery();
                        cn.CerrarConexion();
                    }
                }

                MessageBox.Show("Receta registrada correctamente.");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar receta");
            }
        }

        private void frmGestionRecetas_Load(object sender, EventArgs e)
        {
            CargarAlimentos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta receta? Esta acción no se puede deshacer.",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.No) return;

                string eliminarIng = "delete from INGREDIENTES_RECETA where RecetaID = (select RecetaID from RECETA where lower(Nombre) = lower(@Nombre))";
                cmd = new SqlCommand(eliminarIng, cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                cmd.ExecuteNonQuery();
                cn.CerrarConexion();

                string eliminarReceta = "delete from RECETA where lower(Nombre) = lower(@Nombre)";
                cmd = new SqlCommand(eliminarReceta, cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                cmd.ExecuteNonQuery();
                cn.CerrarConexion();

                MessageBox.Show("Receta eliminada correctamente.");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar receta: " + ex.Message);
            }
        }

        private int ObtenerRecetaID(string nombre)
        {
            string query = "select RecetaID from RECETA where lower(Nombre) = lower(@Nombre)";
            SqlCommand cmdID = new SqlCommand(query, cn.AbrirConexion());
            cmdID.Parameters.AddWithValue("@Nombre", nombre);
            int id = (int)cmdID.ExecuteScalar();
            cn.CerrarConexion();
            return id;
        }

        private void Limpiar()
        {

            txtDescripcion.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            cmbTipo2.SelectedIndex = -1;
            txtTotalCalorias.Clear();
            txtTotalProteinas.Clear();
            txtTotalCarbohidratos.Clear();
            dtgAlimentos.Rows.Clear();
            CargarAlimentos();

            btnAñadir.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void Llenar()
        {
            btnAñadir.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) return;

            string query = "select * from RECETA where lower(Nombre) = lower(@Nombre)";
            SqlCommand cmdBuscar = new SqlCommand(query, cn.AbrirConexion());
            cmdBuscar.Parameters.AddWithValue("@Nombre", txtNombre.Text);

            SqlDataReader dr = cmdBuscar.ExecuteReader();

            if (dr.Read())
            {
                txtDescripcion.Text = dr["Descripcion"].ToString();
                cmbCategoria.SelectedItem = dr["Categoria"].ToString();
                cmbTipo.SelectedItem = dr["TipoDieta"].ToString();
                cmbTipo2.SelectedItem = dr["TipoDieta2"].ToString();
                txtTotalCalorias.Text = dr["TotalCalorias"].ToString();
                txtTotalProteinas.Text = dr["TotalProteinas"].ToString();
                txtTotalCarbohidratos.Text = dr["TotalCarbohidratos"].ToString();

                int recetaID = Convert.ToInt32(dr["RecetaID"]);
                dr.Close();
                cn.CerrarConexion();

                // cargar alimentos de esa receta
                CargarAlimentos();
                CargarIngredientesDeReceta(recetaID);

                Llenar();
                btnAñadir.Enabled = false;
            }
            else
            {
                dr.Close();
                cn.CerrarConexion();
                MessageBox.Show("No existe esa receta, puede crearla.");
                Limpiar();
                Llenar();
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void CargarIngredientesDeReceta(int recetaID)
        {
            string query = "select AlimentoID, Cantidad from INGREDIENTES_RECETA where RecetaID = @RecetaID";
            SqlCommand cmdIng = new SqlCommand(query, cn.AbrirConexion());
            cmdIng.Parameters.AddWithValue("@RecetaID", recetaID);
            SqlDataReader dr = cmdIng.ExecuteReader();

            while (dr.Read())
            {
                int alimentoID = Convert.ToInt32(dr["AlimentoID"]);
                string cantidad = dr["Cantidad"].ToString();

                foreach (DataGridViewRow row in dtgAlimentos.Rows)
                {
                    if (Convert.ToInt32(row.Cells["AlimentoID"].Value) == alimentoID)
                    {
                        row.Cells["Seleccionar"].Value = true;
                        row.Cells["Cantidad"].Value = cantidad;
                        break;
                    }
                }
            }

            dr.Close();
            cn.CerrarConexion();
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

        private void txtBuscarAlimento_TextChanged(object sender, EventArgs e)
        {
            Filtrar(dtgAlimentos, txtBuscarAlimento.Text);
        }
    }
}
