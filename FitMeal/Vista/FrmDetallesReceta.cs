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
    public partial class FrmDetallesReceta : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        int recetaID;
        public FrmDetallesReceta(int id)
        {
            InitializeComponent();
            cn = new cConexion();
            recetaID = id;
        }

        private void FrmDetallesReceta_Load(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT Nombre, Descripcion, Categoria, TipoDieta, TipoDieta2,
                                 TotalCalorias, TotalProteinas, TotalCarbohidratos
                                 FROM RECETA WHERE RecetaID = @RecetaID";

                SqlCommand cmd = new SqlCommand(query, cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@RecetaID", recetaID);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblNombreReceta.Text = dr["Nombre"].ToString();
                    txtDescripcion.Text = dr["Descripcion"].ToString();
                    lblCategoria.Text = dr["Categoria"].ToString();
                    lblTipo.Text = dr["TipoDieta"].ToString();
                    lblTipo2.Text = dr["TipoDieta2"].ToString();
                    lblCalorias.Text = dr["TotalCalorias"].ToString();
                    lblProteinas.Text = dr["TotalProteinas"].ToString();
                    lblCarbohidratos.Text = dr["TotalCarbohidratos"].ToString();
                }
                dr.Close();
                cn.CerrarConexion();

                // Cargar ingredientes
                string Ingredientes = @"SELECT a.Nombre, i.Cantidad 
                                    FROM INGREDIENTES_RECETA i
                                    INNER JOIN ALIMENTO a ON i.AlimentoID = a.AlimentoID
                                    WHERE i.RecetaID = @RecetaID";
                cmd = new SqlCommand(Ingredientes, cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@RecetaID", recetaID);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dtgIngredientes.Rows.Add(
                        dr["Nombre"].ToString(),
                        dr["Cantidad"].ToString()
                        );
                }

                
                dtgIngredientes.Rows.Add(
                    
                    );
                cn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles de la receta: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
