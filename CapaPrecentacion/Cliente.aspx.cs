using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPrecentacion
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //Declarar un Objeto instanciando una clase
        private static CapaNegocio.Cliente Cliente1 = new CapaNegocio.Cliente();

        protected void btnLeer_Click(object sender, EventArgs e)
        {
            //leer atributos
            string dni = txtDni.Text;
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            Cliente1.DNI = dni;
            Cliente1.Nombre = nombre;
            Cliente1.Edad = edad;
            //enviar un mensaje de conformidad
            Response.Write("Se ha agregado los atributos al objeto");   
        }

        protected void btnEscribir_Click(object sender, EventArgs e)
        {
            //escribir los atributos del objeto
            Response.Write("DNI: " + Cliente1.DNI + "<br> Nombre: " + Cliente1.Nombre + "<br> Edad: " + Cliente1.Edad);
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Cliente1.Comprar() + "')</script>");
        }

        protected void btnPreguntar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Cliente1.Preguntar() + "')</script>");
        }
    }
}