using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEgresados
{
    class Validaciones
    {
        public enum ResultadosValidacion
        {
            MatriculaValida,
            MatriculaInvalida,
            NombreValido,
            NombreInvalido,
            ApellidosValidos,
            ApellidosInvalidos,
            CorreoInvalido,
            CorreoValido,
            TelefonoValido,
            TelefonoInvalido
        }

        public ResultadosValidacion validarMatricula(string matricula)
        {
            string patron = @"^[A-Z][0-9]+$";
            if (Regex.IsMatch(matricula, patron)) 
            {
                return ResultadosValidacion.MatriculaValida;
            }
            return ResultadosValidacion.MatriculaInvalida;
        }

        public ResultadosValidacion validarNombre(string nombre)
        {
            string patron = @"^[a-zA-Z' ']+$";
            if(Regex.IsMatch(nombre, patron))
            {
                return ResultadosValidacion.NombreValido;
            }
            return ResultadosValidacion.NombreInvalido;
        }

        public ResultadosValidacion validarApellidos(string apellidos)
        {
            string patron = @"^[a-zA-Z' ']+$";
            if (Regex.IsMatch(apellidos, patron))
            {
                return ResultadosValidacion.ApellidosValidos;
            }
            return ResultadosValidacion.ApellidosInvalidos;
        }

        public ResultadosValidacion validarCorreo(string correo)
        {
            string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (Regex.IsMatch(correo, patron))
            {
                return ResultadosValidacion.CorreoValido;
            }
            return ResultadosValidacion.CorreoInvalido;
        }

        public ResultadosValidacion validarTelefono(string telefono)
        {
            string patron = @"^[0-9]*$";
            if (Regex.IsMatch(telefono, patron))
            {
                return ResultadosValidacion.TelefonoValido;
            }
            return ResultadosValidacion.TelefonoInvalido;
        }

    }
}
