using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEgresados.Clases
{
    public class Usuario 
    {
        private Int32 idUsuario;
        private string usuario;             
        private string contrasenia;
        private string tipoUsuario;
        
       
        public override string ToString()
        {
            return String.Format("idUsuario: {0} , usuario: {1}, contrasenia: {2}, tipoUsuario: {3} ",
                                 idUsuario, usuario, contrasenia, tipoUsuario);
        }
       

        public int Idusuario { get => idUsuario; set => idUsuario = value; }

        public string Nombreuser { get => usuario; set => usuario = value; }

        public string Contrasenia { get => contrasenia; set => contrasenia = value; }              

        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }


    }
}
