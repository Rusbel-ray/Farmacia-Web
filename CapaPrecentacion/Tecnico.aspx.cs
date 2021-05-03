using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPrecentacion
{
    public partial class Tecnico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                    }


        private static CapaNegocio.Tecnico Tecnico1 = new CapaNegocio.Tecnico();

        protected void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string profesion = txtProfesion.Text;
            string dni = txtDni.Text;
            string domicilio = txtDomicilio.Text;
            Tecnico1.Nombres = nombres;
            Tecnico1.Apellidos = apellidos;
            Tecnico1.Profesion = profesion;
            Tecnico1.Dni = dni;
            Tecnico1.Domicilio = domicilio;

            //enviar un mensaje de conformidad
            Response.Write("Se ha agregado los atributos al objeto");
        }

        protected void btnEscribir_Click(object sender, EventArgs e)
        {
            //escribir los atributos del objeto
            Response.Write("Nombres: " + Tecnico1.Nombres + " <br> Apellidos: " + Tecnico1.Apellidos +
                " <br> Profesion: " + Tecnico1.Profesion + " <br> Dni: " + Tecnico1.Dni + "<br> Domicilio: " + Tecnico1.Domicilio);
        }

        protected void btnControlar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Tecnico1.Controlar() + "')</script>");
        }

        protected void btnAtender_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Tecnico1.Atender() + "')</script>");
        }

        protected void btnBalancear_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Tecnico1.Balancear() + "')</script>");
        }

        protected void btnRecibir_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Tecnico1.Recibir() + "')</script>");
        }
    }
}