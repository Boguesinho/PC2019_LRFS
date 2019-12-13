using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEgresados.Clases
{
    class Egresado
    {
        public Int32 idEgresado { get; set; }
        public String nombre { get; set; }
        public String correo { get; set; }
        public String telefono { get; set; }


        public Egresado(String nombre, String correo, String telefono)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;

        }

        public Egresado()
        {

        }


    }
}
