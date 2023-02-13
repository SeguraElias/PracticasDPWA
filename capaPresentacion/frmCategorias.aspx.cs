using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace capaPresentacion
{
    public partial class frmCategorias : System.Web.UI.Page
    {
        private Categorias objCategorias = new Categorias();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridCategorias.DataSource = objCategorias.listarCategorias();
            GridCategorias.DataBind();
        }
    }
}