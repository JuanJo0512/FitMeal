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
    public partial class frmGestionAlimentos : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public frmGestionAlimentos()
        {
            InitializeComponent();
            cn = new cConexion();
            Limpiar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmLoggin.AbrirForm(new FrmAdmin(), this);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select count(*) from ALIMENTO where lower(Nombre) = lower(@Nombre)";
                SqlCommand cmdverificar = new SqlCommand(query, cn.AbrirConexion());
                cmdverificar.Parameters.AddWithValue("@Nombre", txtNombre.Text);

                int existe = (int)cmdverificar.ExecuteScalar();
                cn.CerrarConexion();

                if (existe > 0)
                {
                    MessageBox.Show("Ya existe un alimento con este nombre.");
                    return;
                }

                string Añadir = "insert into ALIMENTO (Nombre, Categoria, Calorias, Proteinas, Carbohidratos, Grasas) values (@Nombre, @Categoria, @Calorias, @Proteinas, @Carbohidratos, @Grasas)";

                    cmd = new SqlCommand(Añadir, cn.AbrirConexion());

                    decimal Calorias;
                    if (!decimal.TryParse(txtCalorias.Text, out Calorias) || Calorias <= 0)
                    {
                        MessageBox.Show("Ingrese una cantidad de calorias válida.");
                        return;
                    }
                    decimal Proteinas;
                    if (!decimal.TryParse(txtProteinas.Text, out Proteinas) || Proteinas <= 0)
                    {
                        MessageBox.Show("Ingrese una cantidad de proteinas válida.");
                        return;
                    }
                    decimal Carbohidratos;
                    if (!decimal.TryParse(txtCarbohidratos.Text, out Carbohidratos) || Carbohidratos <= 0)
                    {
                        MessageBox.Show("Ingrese una cantidad de Carbohidratos válida.");
                        return;
                    }
                    decimal Grasas;
                    if (!decimal.TryParse(txtGrasas.Text, out Grasas) || Grasas <= 0)
                    {
                        MessageBox.Show("Ingrese una cantidad de Grasas válida.");
                        return;
                    }

                    String Categoria = cmbCategoria.SelectedItem.ToString();
                    if (string.IsNullOrEmpty(Categoria))
                    {
                        MessageBox.Show("Seleccione una categoría válida.");
                        return;
                    }

                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Categoria", Categoria);
                    cmd.Parameters.AddWithValue("@Calorias", Calorias);
                    cmd.Parameters.AddWithValue("@Proteinas", Proteinas);
                    cmd.Parameters.AddWithValue("@Carbohidratos", Carbohidratos);
                    cmd.Parameters.AddWithValue("@Grasas", Grasas);
                    cmd.ExecuteNonQuery();
                    cn.CerrarConexion();
                    MessageBox.Show("Alimento registrado correctamente.");
                    Limpiar();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el alimento");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Debe ingresar el nombre del alimento a modificar.");
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de modificar este alimento?",
                    "Confirmar Modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (resultado == DialogResult.No)
                    {
                        return;
                    }

                        string modificar = "update ALIMENTO " +
                                           "set Categoria = @Categoria, Calorias = @Calorias, Proteinas = @Proteinas, " +
                                           "Carbohidratos = @Carbohidratos, Grasas = @Grasas " +
                                           "where lower(Nombre) = lower(@Nombre)";

                        cmd = new SqlCommand(modificar, cn.AbrirConexion());

                        decimal Calorias, Proteinas, Carbohidratos, Grasas;

                        if (!decimal.TryParse(txtCalorias.Text, out Calorias) || Calorias <= 0)
                        {
                            MessageBox.Show("Ingrese una cantidad de Calorías válida.");
                            return;
                        }
                        if (!decimal.TryParse(txtProteinas.Text, out Proteinas) || Proteinas <= 0)
                        {
                            MessageBox.Show("Ingrese una cantidad de Proteínas válida.");
                            return;
                        }
                        if (!decimal.TryParse(txtCarbohidratos.Text, out Carbohidratos) || Carbohidratos <= 0)
                        {
                            MessageBox.Show("Ingrese una cantidad de Carbohidratos válida.");
                            return;
                        }
                        if (!decimal.TryParse(txtGrasas.Text, out Grasas) || Grasas <= 0)
                        {
                            MessageBox.Show("Ingrese una cantidad de Grasas válida.");
                            return;
                        }

                        string Categoria = cmbCategoria.SelectedItem.ToString();

                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Categoria", Categoria);
                        cmd.Parameters.AddWithValue("@Calorias", Calorias);
                        cmd.Parameters.AddWithValue("@Proteinas", Proteinas);
                        cmd.Parameters.AddWithValue("@Carbohidratos", Carbohidratos);
                        cmd.Parameters.AddWithValue("@Grasas", Grasas);

                        cmd.ExecuteNonQuery();
                        cn.CerrarConexion();
                        MessageBox.Show("Alimento modificado correctamente.");
                        Limpiar();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el alimento");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el nombre del alimento a eliminar.");
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                "¿Está seguro de Eliminar este alimento? No se puede recuperar el alimento eliminado",
                "Confirmar Eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    Limpiar();
                    return;
                }
                    string eliminar = "delete from ALIMENTO where lower(Nombre) = lower(@Nombre)";

                    cmd = new SqlCommand(eliminar, cn.AbrirConexion());
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.ExecuteNonQuery();
                    cn.CerrarConexion();

                    MessageBox.Show("Alimento eliminado correctamente.");
                    Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el alimento");
            }
        }

        private void Limpiar()
        {
            txtNombre.Focus();
            txtNombre.Clear();
            txtCalorias.Clear();
            txtCarbohidratos.Clear();
            txtProteinas.Clear();
            txtGrasas.Clear();
            txtCalorias.Enabled = false;
            txtCarbohidratos.Enabled = false;
            txtProteinas.Enabled = false;
            txtGrasas.Enabled = false;
            cmbCategoria.Enabled = false;
            btnAñadir.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void Llenar()
        {
            txtCalorias.Enabled = true;
            txtCarbohidratos.Enabled = true;
            txtProteinas.Enabled = true;
            txtGrasas.Enabled = true;
            cmbCategoria.Enabled = true;
            btnAñadir.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) return;


            string query = "select * from ALIMENTO where lower(Nombre) = lower(@Nombre)";
            SqlCommand cmdBuscar = new SqlCommand(query, cn.AbrirConexion());
            cmdBuscar.Parameters.AddWithValue("@Nombre", txtNombre.Text);

            SqlDataReader dr = cmdBuscar.ExecuteReader();

            if (dr.Read())
            {
                cmbCategoria.SelectedItem = dr["Categoria"].ToString();
                txtCalorias.Text = dr["Calorias"].ToString();
                txtProteinas.Text = dr["Proteinas"].ToString();
                txtCarbohidratos.Text = dr["Carbohidratos"].ToString();
                txtGrasas.Text = dr["Grasas"].ToString();
                Llenar();
                btnAñadir.Enabled = false;
            }
            else
            {
                MessageBox.Show("No existe un alimento con ese nombre creelo o intente de nuevo con otro.");
                Llenar();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
            dr.Close();
            cn.CerrarConexion();
        }
    }
}
