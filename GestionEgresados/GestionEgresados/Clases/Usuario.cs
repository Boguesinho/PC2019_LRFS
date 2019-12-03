using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEgresados.Clases
{
    public class Usuario 
    {
        private Int32 tipoUsuario;
        private String user;             
        private String password;
        //Checar si hay que poner los idEgresado, idAdmin, idCuestionario



        public override string ToString()
        {
            return String.Format("tipoUsuario: {0}, user: {1}, password: {2}",
                                 tipoUsuario, user, password);
        }

        public int TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

        public string User { get => user; set => user = value; }

        public string Password { get => password; set => password = value; }

    }
}
