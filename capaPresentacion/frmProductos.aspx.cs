using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace capaPresentacion
{
    public partial class frmProductos : System.Web.UI.Page
    {
        private Productos objProd = new Productos();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridProductos.DataSource = objProd.listarProductos();
            GridProductos.DataBind();
        }
    }
}