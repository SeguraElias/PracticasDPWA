using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capaDatos;

namespace capaNegocio
{
    public class Productos
    {
        private Datos objDatos = new Datos();

        public DataTable listarProductos()
        {
            return objDatos.selectProductos();
        }
    }
}
