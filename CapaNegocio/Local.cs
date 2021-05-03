using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Local
    {
        //atributos 
        private string nombre;
        private string ruc;
        private string direccion;
        private string area;

        //Propiedades 
        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Area { get => area; set => area = value; }


        //metodos 
        public string Recibir()
        {
            return "metodo recibir no esta implementado ";
        }
        public string Almacenar()
        {
            return "metodo almacenar no esta implementado ";
        }
    }
}
