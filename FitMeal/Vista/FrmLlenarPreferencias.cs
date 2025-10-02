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
            if (frmVerPreferencias.Añadir)
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
            }
            if (frmVerPreferencias.Eliminar)
            {

                foreach (DataGridViewRow row in dtgAlimentos.Rows)
                {
                    bool marcado = Convert.ToBoolean(row.Cells["excluirAlimento"].Value);

                    if (marcado)
                    {
                        int alimentoID = Convert.ToInt32(row.Cells["AlimentoID"].Value);

                        string delete = "DELETE FROM PREF_USUARIO WHERE AlimentoID = @alimentoID AND Cedula = @cedula";

                        cmd = new SqlCommand(delete, cn.AbrirConexion());
                        cmd.Parameters.AddWithValue("@alimentoID", alimentoID);
                        cmd.Parameters.AddWithValue("@cedula", FrmLoggin.UsuarioActivoCedula);
                        cmd.ExecuteNonQuery();
                    }
                }

                foreach (DataGridViewRow row in dtgAlergias.Rows)
                {
                    bool marcado = Convert.ToBoolean(row.Cells["checkAlergia"].Value);

                    if (marcado)
                    {
                        int alergiaID = Convert.ToInt32(row.Cells["AlergiaID"].Value);

                        string delete = "DELETE FROM ALERG_USUARIO WHERE AlergiaID = @alergiaID AND Cedula = @cedula";

                        cmd = new SqlCommand(delete, cn.AbrirConexion());
                        cmd.Parameters.AddWithValue("@alergiaID", alergiaID);
                        cmd.Parameters.AddWithValue("@cedula", FrmLoggin.UsuarioActivoCedula);
                        cmd.ExecuteNonQuery();

                    }
                }
            }

            frmVerPreferencias.Añadir = false;
            frmVerPreferencias.Eliminar = false;
            FrmLoggin.AbrirForm(new frmVerPreferencias(), this);
        }

        private void LlenarPreferencias(object sender, EventArgs e)
        {
                if (frmVerPreferencias.Añadir)
            {
                lblTitulo.Text = "Indique lo que desea añadir";
                lblAlimentos.Text = "Ahora por favor, indicamos que alimentos preferirias no comer\r\nLos veras lo menos posible en tu plan de comidas";
                lblAlergias.Text = "Incluye tus alergias/intolerancias a continuacion\r\nLos alimentos que se excluyen con estas NO apareceran en tu plan";
                CargarAlimentosParaAñadir();
                CargarAlergiasParaAñadir();
            }
            else if (frmVerPreferencias.Eliminar)
            {
                lblTitulo.Text = "Indica las preferencias que deseas eliminar";
                lblAlimentos.Text = "Indicamos que alimentos no preferidos deseas eliminar de tu perfil";
                lblAlergias.Text = "Indicanos que alergias deseas eliminar de tu perfil";
                CargarAlimentosParaEliminar();
                CargarAlergiasParaEliminar();
            }
        }


        private void CargarAlimentosParaAñadir()
        {
            dtgAlimentos.Rows.Clear();

            string query = @"
            SELECT AlimentoID, Nombre, Categoria
            FROM ALIMENTO
            WHERE AlimentoID NOT IN (
            SELECT AlimentoID FROM PREF_USUARIO WHERE Cedula = @Cedula
            )";

            cmd = new SqlCommand(query, cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dtgAlimentos.Rows.Add(dr["Nombre"].ToString(), 
                    dr["AlimentoID"].ToString(), 
                    dr["Categoria"].ToString(),
                    false);
            }
            dr.Close();
            cn.CerrarConexion();
        }

        private void CargarAlergiasParaAñadir()
        {
            dtgAlergias.Rows.Clear();

            string query = @"
            SELECT AlergiaID, Nombre, Descripcion
            FROM ALERGIA
            WHERE AlergiaID NOT IN (
            SELECT AlergiaID 
            FROM ALERG_USUARIO 
            WHERE Cedula = @Cedula
            )";

            cmd = new SqlCommand(query, cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dtgAlergias.Rows.Add(dr["Nombre"].ToString(),
                    dr["AlergiaID"].ToString(),
                    dr["Descripcion"].ToString(),
                    false);
            }
            dr.Close();
            cn.CerrarConexion();
        }

        private void CargarAlimentosParaEliminar()
        {
            dtgAlimentos.Rows.Clear();

            string query = @"
        SELECT A.AlimentoID, A.Nombre, A.Categoria
        FROM PREF_USUARIO P
        INNER JOIN ALIMENTO A ON P.AlimentoID = A.AlimentoID
        WHERE P.Cedula = @Cedula";

            cmd = new SqlCommand(query, cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dtgAlimentos.Rows.Add(dr["Nombre"].ToString(),
                    dr["AlimentoID"].ToString(),
                    dr["Categoria"].ToString(),
                    false);
            }
            dr.Close();
            cn.CerrarConexion();
        }

        private void CargarAlergiasParaEliminar()
        {
            dtgAlergias.Rows.Clear();

            string query = @"
        SELECT AL.AlergiaID, AL.Nombre, AL.Descripcion
        FROM ALERG_USUARIO AU
        INNER JOIN ALERGIA AL ON AU.AlergiaID = AL.AlergiaID
        WHERE AU.Cedula = @Cedula";

            cmd = new SqlCommand(query, cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dtgAlergias.Rows.Add(dr["Nombre"].ToString(),
                    dr["AlergiaID"].ToString(),
                    dr["Descripcion"].ToString(),
                    false);
            }
            dr.Close();
            cn.CerrarConexion();
        }
    }
}
