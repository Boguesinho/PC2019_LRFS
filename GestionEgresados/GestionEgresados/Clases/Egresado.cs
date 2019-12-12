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
        public bool seleccionado { get; set; }


        public Egresado(String nombre, String correo, String telefono, bool seleccionado)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
            this.seleccionado = seleccionado;
        }

        public static List<Egresado> GetDatosEgresados()
        {
            return new List<Egresado>(new Egresado[12] {
            new Egresado("Pancho Francisco Perez Gomez", "asddsdssffdsassa@gmail.com", "2282736412", false),
            new Egresado("Pancho Francisco Perez Gomez", "asdassgfdadsdasa@gmail.com", "2282736412", false),
            new Egresado("Pancho Francisco Perez Gomez", "asdasdsdssffdssa@gmail.com", "2282736412", false),
            new Egresado("Pancho Francisco Perez Gomez", "assdsdsdsddaffsa@gmail.com", "2282736412", false),
            new Egresado("Pancho Francisco Perez Gomez", "asdsdsdsdssasffa@gmail.com", "2282736412", false),
            new Egresado("Pancho Francisco Perez Gomez", "asdsdsdsdssasffa@gmail.com", "2282736412", false),
            new Egresado("Pancho Francisco Perez Gomez", "asdsdsdsdssasffa@gmail.com", "2282736412", false),
            new Egresado("Pancho Francisco Perez Gomez", "asdsdsdsdssasffa@gmail.com", "2282736412", false),
            new Egresado("Pancho Francisco Perez Gomez", "asdsdsdsdssasffa@gmail.com", "2282736412", false),
            new Egresado("Pancho Francisco Perez Gomez", "asdsdsdsdssasffa@gmail.com", "2282736412", false),
            new Egresado("Pancho Francisco Perez Gomez", "asdsdsdsdssasffa@gmail.com", "2282736412", false),
            new Egresado("Pancho Francisco Perez Gomez", "asdsdsdsdssasffa@gmail.com", "2282736412", false)

        });
        }

    }
}
