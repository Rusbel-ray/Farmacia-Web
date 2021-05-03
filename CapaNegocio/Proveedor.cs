using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Proveedor
    {
        //atributos
        private string nombre;
        private string ruc;
        private string dirección;
        private int stock;

        //propiedades
        public string Nombre
        {
            get { return nombre; } //lecutra de atributo
            set { nombre = value; }//escritura de atributo
        }
        public string Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }
        public string Direccion
        {
            get { return this.dirección; }
            set { this.dirección = value; }

        }
        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }

        }

        public string Suministrar()
        {
            return "NO se ha implementado el metodo suministrar";
        }
        public string Distribuir()
        {
            return "No se ha implementado el metodo distribuir";
        }
        public string Elaborar()
        {
            return "No se ha implementado el metodo elaborar";
        }
        public string Controlar()
        {
            return "No se ha implementado el metodo operación";
        }
    }
}
