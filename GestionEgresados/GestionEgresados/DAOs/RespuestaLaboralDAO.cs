﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEgresados.DataBase;
using GestionEgresados.ViewController;

namespace GestionEgresados.DAOs
{
    public class RespuestaLaboralDAO
    {
        VentanaLaboral ventanaLaboral = new VentanaLaboral();

        public RespuestaLaboralDAO()
        {

        }

        public List<String> mostrarCuestionarioLaboral(Int32 idEgresado)
        {


            SqlConnection conn = null;
            List<String> respuestasLaboral = new List<String>();

            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("Select respuesta from respuestaLaboral a," +
                                                " egresado b" +
                                                " where(a.idEgresado = b.idEgresado)" +
                                                " AND(b.estatus = 1)" +
                                                " AND(b.idEgresado = '{0}'); ", idEgresado);



                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        respuestasLaboral.Add((!rd.IsDBNull(0)) ? rd.GetString(0) : "");
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


            return respuestasLaboral;
        }

    }
}
