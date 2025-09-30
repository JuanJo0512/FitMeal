using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitMeal.Modelo
{

    class cConexion
    {
        //Se define la ruta de la base de datos
        static private string CadenaConexion = @"Data Source=DESKTOP-44EUCBT;Initial Catalog=FitMeal;Integrated Security=True;Encrypt=False";

        //Definir una variable para cargar la base de datos
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        //Metodo para abrir la base de datos

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
