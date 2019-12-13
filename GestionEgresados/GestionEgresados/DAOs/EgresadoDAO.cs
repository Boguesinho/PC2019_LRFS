﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEgresados.Clases;
using GestionEgresados.DataBase;

namespace GestionEgresados.DAOs
{
    public class EgresadoDAO
    {

        
        
        public ArrayList GetInfoEgresadoByMatricula(String matricula)
        {
            Egresado egresado = null;
            SqlConnection conn = null;
            ArrayList arregloEgresados = new ArrayList();

            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT " +
                        "x.idEgresado," +
                        "x.matricula," +
                        "x.nombre," +
                        "x.apellidos," +
                        "x.correo," +
                        "x.telefono," +
                        "x.licenciatura," +
                        "x.genero," +
                        "x.estatus " +
                        "FROM dbo.egresado x " +
                        "WHERE x.matricula = '{0}';", matricula);
                        
                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        egresado = new Egresado
                        {
                            idEgresado = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0,
                            matricula = (!rd.IsDBNull(1)) ? rd.GetString(1) : "",
                            nombre = (!rd.IsDBNull(2)) ? rd.GetString(2) + " "+ rd.GetString(3) : "",
                            correo = (!rd.IsDBNull(4)) ? rd.GetString(4) : "",
                            licenciatura = (!rd.IsDBNull(5)) ? rd.GetString(5) : "",
                        };

                        arregloEgresados.Add(egresado);

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
            return arregloEgresados;
        }
        

        public ArrayList GetInfoEgresado()
        {
            Egresado egresado = null;
            SqlConnection conn = null;
            ArrayList arregloEgresados = new ArrayList();

            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT " +
                        "x.idEgresado," +
                        "x.nombre," +
                        "x.apellidos," +
                        "x.correo," +
                        "x.telefono," +
                        "x.licenciatura," +
                        "x.genero," +
                        "x.estatus " +
                        "FROM dbo.egresado x ;");

                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        egresado = new Egresado
                        {
                            idEgresado = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0,
                            nombre = (!rd.IsDBNull(1)) ? rd.GetString(1) + " " + rd.GetString(2) : "",
                            correo = (!rd.IsDBNull(3)) ? rd.GetString(3) : "",
                            telefono = (!rd.IsDBNull(4)) ? rd.GetString(4) : "",
                            licenciatura = (!rd.IsDBNull(5)) ? rd.GetString(5) : "",
                            genero = (!rd.IsDBNull(6)) ? rd.GetString(6) : "",
                            estatus = (!rd.IsDBNull(7)) ? rd.GetInt32(7) : 0,
                        };

                        arregloEgresados.Add(egresado);

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
            return arregloEgresados;
        }


    }
}
