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
        public String matricula { get; set; }
        public String nombre { get; set; }
        public String correo { get; set; }
        public String telefono { get; set; }
        public String licenciatura { get; set; }
        public String genero { get; set; }
        public Int32 estatus { get; set; }



        public Egresado(String nombre, String correo, String telefono)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;

        }

        public Egresado(String matricula, String nombre, String correo, String telefono, String genero)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
            this.genero = genero;
        }

        public Egresado(String genero)
        {
            this.genero = genero;
        }

        public Egresado()
        {

        }


    }
}
