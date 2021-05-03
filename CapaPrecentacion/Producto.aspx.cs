using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPrecentacion
{
    public partial class Producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Declarar un Objeto instanciando una clase
        private static CapaNegocio.Producto Producto1 = new CapaNegocio.Producto();


        protected void txtFechaFabricacion_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //leer atributos
            string nombre = txtNombre.Text;
            double precio = double.Parse(txtPrecio.Text);
            string fechaCaducada = txtFechaCaducidad.Text;
            string fechaFabricacion = txtFechaFabricacion.Text;
            int unidadesDisponibles = int.Parse(txtPrecio.Text);
            Producto1.Nombres = nombre;
            Producto1.Precio = precio;
            Producto1.FechaCaducada = fechaCaducada;
            Producto1.FechaFabricacion = fechaFabricacion;
            Producto1.UniDisponible = unidadesDisponibles;

            //enviar un mensaje de conformidad
            Response.Write("Se ha agregado los atributos al objeto");
        }

        protected void btnEscribir_Click(object sender, EventArgs e)
        {
            //escribir los atributos del objeto
            Response.Write("Nombre: " + Producto1.Nombres + "<br> Precio: " + Producto1.Precio + 
                "<br> Fecha de Caducidad: " + Producto1.FechaCaducada + "<br> Fecha de Fabricacion: " + Producto1.FechaFabricacion +
                "<br> Unidades Disponibles: " + Producto1.UniDisponible);
        }

        protected void btnCurar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Producto1.Curar() + "')</script>");
        }

        protected void btnAliviar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Producto1.Aliviar() + "')</script>");
        }

        protected void btnCaducar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + Producto1.Caducar() + "')</script>");
        }
    }
}