using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cliente
    {
        //atributos
        private string dni;
        private string nombre;
        private string edad;

        //propiedades
        public string DNI
        {
            get { return dni; } //lecutra de atributo
            set { dni = value; }//escritura de atributo
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Edad
        {
            get { return this.edad; }
            set { this.edad = value; }

        }

        public string Comprar()
        {
            return "NO se ha implementado el metodo Comprar";
        }
        public string Preguntar()
        {
            return "No se ha implementado el metodo Preguntar";
        }
    }
}
