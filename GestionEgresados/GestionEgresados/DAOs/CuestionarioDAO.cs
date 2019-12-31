using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEgresados.Clases;
using GestionEgresados.DataBase;
using GestionEgresados.ViewController;

namespace GestionEgresados.DAOs
{
    public class CuestionarioDAO
    {
        VentanaSatisfaccion vs = new VentanaSatisfaccion();

        public CuestionarioDAO()
        {

            
        }


        public List<String> llenarCuestionario(String matricula)
        {


            SqlConnection conn = null;
            List<String> respuestas = new List<String>();

            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("Select respuesta from respuesta a," +
                                                " pregunta b, cuestionarioUsuario c, egresado d"+
                                                " where(a.idPregunta = b.idPregunta)"+
                                                " AND(b.idCuestionario = c.idCuestionario)"+
                                                " AND(a.idEgresado = d.idEgresado)"+
                                                " AND(d.matricula = '{0}'); ", matricula);



                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        respuestas.Add((!rd.IsDBNull(0)) ? rd.GetString(0) : "");
                    }
                    rd.Close();
                    command.Dispose();

                }
            }
            //Cambiar las excepciones.
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


            return respuestas;
        }




        /*Select respuesta from respuesta a, pregunta b, cuestionarioUsuario c, egresado d
        where(a.idPregunta = b.idPregunta)
        AND(b.idCuestionario = c.idCuestionario)
        AND(d.matricula = 'S17012963')*/

    }
}
