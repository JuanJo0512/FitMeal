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
    public partial class frmVerPreferencias : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public frmVerPreferencias()
        {
            InitializeComponent();
            cn = new cConexion();
            CargarPreferencias();
            CargarAlergias();
        }

        private void CargarPreferencias()
        {
            dtgPreferencias.Rows.Clear();

            string query = @"
            SELECT A.AlimentoID, A.Nombre
            FROM PREF_USUARIO P
            INNER JOIN ALIMENTO A ON P.AlimentoID = A.AlimentoID
            WHERE P.Cedula = @Cedula";

            cmd = new SqlCommand(query, cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dtgPreferencias.Rows.Add(
                    dr["Nombre"].ToString(),
                    dr["AlimentoID"].ToString()
                );
            }

            dr.Close();
            cn.CerrarConexion(); 
        }

        private void CargarAlergias()
        {
            dtgAlergias.Rows.Clear();

            string query = @"
            SELECT AL.AlergiaID, AL.Nombre AS Alergia, A.Nombre AS Alimento
            FROM ALERG_USUARIO AU
            INNER JOIN ALERGIA AL ON AU.AlergiaID = AL.AlergiaID
            LEFT JOIN ALERG_ALIMENTO AA ON AL.AlergiaID = AA.AlergiaID
            LEFT JOIN ALIMENTO A ON AA.AlimentoID = A.AlimentoID
            WHERE AU.Cedula = @Cedula";

            cmd = new SqlCommand(query, cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@Cedula", FrmLoggin.UsuarioActivoCedula);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dtgAlergias.Rows.Add(
                    dr["Alergia"].ToString(),
                    dr["Alimento"] != DBNull.Value ? dr["Alimento"].ToString() : "",
                    dr["AlergiaID"].ToString()
                );
            }

            dr.Close();
            cn.CerrarConexion(); // cierras manualmente
        }
        
    }
}
