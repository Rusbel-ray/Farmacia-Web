using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPrecentacion
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnQf_Click(object sender, EventArgs e)
        {
            //Llamar al formulario del "Qf"
            Response.Redirect("Qf.aspx");
        }

        protected void btnCaja_Click(object sender, EventArgs e)
        {
            //Llamar al formulario del "Caja"
            Response.Redirect("Caja.aspx");
        }

        protected void btnCliente_Click(object sender, EventArgs e)
        {
            //Llamar al formulario del "Cliente"
            Response.Redirect("Cliente.aspx");
        }

        protected void btnLocal_Click(object sender, EventArgs e)
        {
            //Llamar al formulario del "Local"
            Response.Redirect("Local.aspx");
        }

        protected void btnProducto_Click(object sender, EventArgs e)
        {
            //Llamar al formulario del "Producto"
            Response.Redirect("Producto.aspx");
        }

        protected void btnProveedor_Click(object sender, EventArgs e)
        {
            //Llamar al formulario del "Proveedor"
            Response.Redirect("Proveedor.aspx");
        }

        protected void btnTecnico_Click(object sender, EventArgs e)
        {
            //Llamar al formulario del "Tecnico"
            Response.Redirect("Tecnico.aspx");
        }
    }
}