using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEgresados.Clases
{
    class Egresado
    {

        public String nombre { get; set; }
        public String correo { get; set; }
        public String telefono { get; set; }

        public Egresado(String nombre, String correo, String telefono)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
        }

        public static List<Egresado> GetDatosEgresados()
        {
            return new List<Egresado>(new Egresado[4] {
            new Egresado("Alejandro", "Alescaale978@gmail.com", "2282736412"),
            new Egresado("Edgar Alejandro Ortega Cortes", "Alex-blanco-00@hotmail.com", "2282736412"),
            new Egresado("Alejandro", "Alescaale978@gmail.com", "2282736412"),
            new Egresado("Alejandro", "Alescaale978@gmail.com", "2282736412")
        });
        }

    }
}
