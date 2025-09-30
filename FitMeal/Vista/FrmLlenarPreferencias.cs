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
    public partial class FrmLlenarPreferencias : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public FrmLlenarPreferencias()
        {
            InitializeComponent();
            cn = new cConexion();
            CargarAlimentos();
            CargarAlergias();
        }

        private void CargarAlimentos()
        {
                dtgAlimentos.Rows.Clear();

                string query = "SELECT AlimentoID, Nombre, Categoria FROM ALIMENTO";
                cmd = new SqlCommand(query, cn.AbrirConexion());
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtgAlimentos.Rows.Add(
                        dr["Nombre"].ToString(),
                        dr["AlimentoID"].ToString(),
                        dr["Categoria"].ToString()
                    );
                }
                cn.CerrarConexion();
        }

        private void CargarAlergias()
        {
                dtgAlergias.Rows.Clear();

                string query = "SELECT AlergiaID, Nombre, Descripcion FROM ALERGIA";
                 cmd = new SqlCommand(query, cn.AbrirConexion());
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtgAlergias.Rows.Add(
                        dr["Nombre"].ToString(),
                        dr["AlergiaID"].ToString(),
                        dr["Descripcion"].ToString()
                    );
                }
                cn.CerrarConexion();
        }

        private void txtBuscarAlimento_TextChanged(object sender, EventArgs e)
        {
            Filtrar(dtgAlimentos, txtBuscarAlimento.Text);
        }

        private void txtBuscarAlergia_TextChanged(object sender, EventArgs e)
        {
            Filtrar(dtgAlergias, txtBuscarAlergia.Text);
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgAlimentos.Rows)
            {
                bool marcado = Convert.ToBoolean(row.Cells["excluirAlimento"].Value);
                if (marcado)
                {
                    int alimentoID = Convert.ToInt32(row.Cells["AlimentoID"].Value);

                    string insert = "insert into PREF_USUARIO (AlimentoID, Cedula) VALUES (@alimentoID, @cedula)";

                    cmd = new SqlCommand(insert, cn.AbrirConexion());
                        cmd.Parameters.AddWithValue("@alimentoID", alimentoID);
                        cmd.Parameters.AddWithValue("@cedula", FrmLoggin.UsuarioActivoCedula);
                        cmd.ExecuteNonQuery();
                }
            }

            // Guardar alergias seleccionadas
            foreach (DataGridViewRow row in dtgAlergias.Rows)
            {
                bool marcado = Convert.ToBoolean(row.Cells["checkAlergia"].Value);
                if (marcado)
                {
                    int alergiaID = Convert.ToInt32(row.Cells["AlergiaID"].Value);

                    string insert = "insert into ALERG_USUARIO (AlergiaID, Cedula) VALUES (@alergiaID, @cedula)";

                      cmd = new SqlCommand(insert, cn.AbrirConexion());
                        cmd.Parameters.AddWithValue("@alergiaID", alergiaID);
                        cmd.Parameters.AddWithValue("@cedula", FrmLoggin.UsuarioActivoCedula);
                        cmd.ExecuteNonQuery();
                    
                }
            }

            FrmLoggin.AbrirForm(new frmVerPreferencias(), this);
        }
    }
}
