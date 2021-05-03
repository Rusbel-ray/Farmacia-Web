using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPrecentacion
{
    public partial class Local : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Declarar un Objeto instanciando una clase

        static CapaNegocio.Local Local1 = new CapaNegocio.Local();

        protected void btnLeer_Click(object sender, EventArgs e)
        {
            
            string nombres = txtNombre.Text;
            string ruc = txtRuc.Text;
            string direccion = txtDireccion.Text;
            string area = txtArea.Text;
            Local1.Nombre = nombres;
            Local1.Ruc = ruc;
            Local1.Direccion = direccion;
            Local1.Area = area;
            //enviar un mensaje de conformidad
            Response.Write("Se ha agregado los atributos al objeto");
        }

        protected void btnEscribir_Click(object sender, EventArgs e)
        {
            //Escribir los atributos del objeto
            Response.Write("Nombres: " + Local1.Nombre + " <br> Ruc: " + Local1.Ruc + " <br> Direccion: " + 
                Local1.Direccion + "<br> Area: " + Local1.Area);
        }

        protected void btnRecibir_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Local1.Recibir() + "')</script>");
        }

        protected void btnAlmacenar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Local1.Almacenar() + "')</script>");
        }
    }
}