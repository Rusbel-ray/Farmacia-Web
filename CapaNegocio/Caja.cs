using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Caja
    {
        //atributos
        private string recepcionista;
        private string tipopago;

        //propiedades
        public string Recepcionista
        {
            get { return recepcionista; } //lecutra de atributo
            set { recepcionista = value; }//escritura de atributo
        }
        public string TipoPago
        {
            get { return tipopago; }
            set { tipopago = value; }
        }

        public string Cobrar()
        {
            return "NO se ha implementado el metodo Cobrar";
        }
        public string Contar()
        {
            return "No se ha implementado el metodo Contar";
        }
        public string Recaudar()
        {
            return "No se ha implementado el metodo Recaudar";
        }
        public string Informar()
        {
            return "No se ha implementado el metodo Informar";
        }
    }
}
