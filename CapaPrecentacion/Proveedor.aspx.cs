using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPrecentacion
{
    public partial class Proveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Declarar un Objeto instanciando una clase
        private static CapaNegocio.Proveedor Proveedor1 = new CapaNegocio.Proveedor();

        protected void btnLeer_Click(object sender, EventArgs e)
        {
            //leer atributos
            string nombre = txtNombre.Text;
            string ruc = txtNombre.Text;
            string direccion = txtDireccion.Text;
            int stock = int.Parse(txtStock.Text);

            Proveedor1.Nombre = nombre;
            Proveedor1.Ruc = ruc;
            Proveedor1.Direccion = direccion;
            Proveedor1.Stock = stock;
            //enviar un mensaje de conformidad
            Response.Write("Se ha agregado los atributos al objeto");
        }

        protected void btnEscribir_Click(object sender, EventArgs e)
        {
            //escribir los atributos del objeto
            Response.Write("Nombre: " + Proveedor1.Nombre + "<br> RUC: " +
                Proveedor1.Ruc + "<br> Dirección: " + Proveedor1.Direccion + "<br>Stock: " + Proveedor1.Stock);
        }

        protected void btnSuministrar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Proveedor1.Suministrar() + "')</script>");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Proveedor1.Elaborar() + "')</script>");
        }

        protected void btnDistribuir_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Proveedor1.Distribuir() + "')</script>");
        }

        protected void btnControlar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Proveedor1.Controlar() + "')</script>");
        }
    }
}