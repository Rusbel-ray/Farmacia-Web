using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Tecnico
    {
        //atributos
        private string nombres;
        private string apellidos;
        private string profesion;
        private string dni;
        private string domicilio;
        //propiedades
        public string Nombres
        {
            get { return nombres; } //lecutra de atributo
            set { nombres = value; }//escritura de atributo
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        public string Controlar()
        {
            return "No se ha implementado el metodo Controlar";
        }
        public string Atender()
        {
            return "No se ha implementado el metodo Atender";
        }
        public string Balancear()
        {
            return "No se ha implementado el metodo Balancear";
        }
        public string Recibir()
        {
            return "No se ha implementado el metodo Recibir";
        }

    }
}
