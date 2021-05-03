using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Producto
    {
        //atributos
        private string nombres;
        private Double precio;
        private string fechaCaducada;
        private string fechaFabricacion;
        private int uniDisponible;

        //Metodos
        public string Nombres { get => nombres; set => nombres = value; }
        public string FechaCaducada { get => fechaCaducada; set => fechaCaducada = value; }
        public string FechaFabricacion { get => fechaFabricacion; set => fechaFabricacion = value; }
        public int UniDisponible { get => uniDisponible; set => uniDisponible = value; }
        public double Precio { get => precio; set => precio = value; }

        //Propiedades
        public string Curar()
        {
            return "No se ha implementado el metodo Curar";
        }
        public string Aliviar()
        {
            return "No se ha implementado el metodo Aliviar";
        }
        public string Caducar()
        {
            return "No se ha implementado el metodo Caducar";
        }
    }
}
