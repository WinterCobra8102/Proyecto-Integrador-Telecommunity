using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.BO
{
    internal class Usuarios_BO
    {
        //Atributos//
        private int ID;
        private string Nombre;
        private string Apellido_1;
        private string Apellido_2;
        private DateTime Fecha_hora;
        private string Correo;
        private string Username;
        private string Passwordd;

        //Propiedades//
        public int ID1 { get => ID; set => ID = value; }
        public string NOMBRE { get => Nombre; set => Nombre = value; }
        public string APELLIDO_1 { get => Apellido_1; set => Apellido_1 = value; }
        public string APELLIDO_2 { get => Apellido_2; set => Apellido_2 = value; }
        public DateTime FECHA_HORA { get => Fecha_hora; set => Fecha_hora = value; }
        public string CORREO { get => Correo; set => Correo = value; }
        public string USERNAME { get => Username; set => Username = value; }
        public string PASSWORDD { get => Passwordd; set => Passwordd = value; }




    }
}
