using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPrecentacion
{
    public partial class Caja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Declarar un Objeto instanciando una clase
        private static CapaNegocio.Caja Caja1 = new CapaNegocio.Caja();

        protected void btnLeer_Click(object sender, EventArgs e)
        {
            string recepcionar = txtRecepcionar.Text;
            string tipopago = txtTipoPago.Text;
            Caja1.Recepcionista = recepcionar;
            Caja1.TipoPago = tipopago;
            //enviar un mensaje de conformidad
            Response.Write("Se ha agregado los atributos al objeto");
        }

        protected void btnEscribir_Click(object sender, EventArgs e)
        {
            //escribir los atributos del objeto
            Response.Write(" <br> Recepcionar: " + Caja1.Recepcionista + " <br> Tipo Pago: " + Caja1.TipoPago);
        }

        protected void btnCobrar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Caja1.Cobrar() + "')</script>");
        }

        protected void btnContar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Caja1.Contar() + "')</script>");
        }

        protected void btnRecaudar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Caja1.Recaudar() + "')</script>");
        }

        protected void btnInformar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Caja1.Informar() + "')</script>");
        }
    }
}