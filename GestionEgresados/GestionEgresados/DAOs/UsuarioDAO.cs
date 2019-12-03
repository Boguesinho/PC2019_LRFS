using GestionEgresados.DataBase;
using GestionEgresados.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GestionEgresados
{
    public class UsuarioDAO
    {

        public static Usuario getLogin(String usuario, String password)
        {
            Usuario user = null;
            SqlConnection conn = null;
            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT " +
                        "x.tipoUsuario," +
                        "x.user," +                       
                        "x.password " +
                        "FROM dbo.usuario x " +
                        "WHERE x.user = '{0}' AND x.password = '{1}';", user, password);
                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        user = new Usuario();
                        user.TipoUsuario = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
                        user.User = (!rd.IsDBNull(1)) ? rd.GetString(1) : "";                        
                        user.Password = (!rd.IsDBNull(7)) ? rd.GetString(7) : "";
                    }
                    rd.Close();
                    command.Dispose();
                    Console.WriteLine(user);
                }
            }
            //Cambiar las excepciones, buscar cuáles nos podría dar
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return user;
        }
    }
}
