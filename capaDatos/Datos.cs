using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace capaDatos
{
    public class Datos
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString);

        public DataTable selectCategoria()
        {
            SqlCommand comando = new SqlCommand("SelectCategoria", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        public DataTable selectProductos()
        {
            SqlCommand comando = new SqlCommand("selectProductos", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
    }
}
