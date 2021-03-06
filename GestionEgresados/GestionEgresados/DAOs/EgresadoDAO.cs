﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GestionEgresados.Clases;
using GestionEgresados.DataBase;

namespace GestionEgresados.DAOs
{
    public class EgresadoDAO
    {
        


        public void SetInfoEgresado (String matricula, String nombre, String apellidos, String licenciatura, String correo, String telefono, String matriculaActual)
        {
            SqlConnection conn = null;

            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                if (conn != null)
                {
                    String query = String.Format("UPDATE dbo.egresado SET dbo.egresado.matricula = '{0}', "+  
                        "dbo.egresado.nombre = '{1}', "+
                        "dbo.egresado.apellidos = '{2}', "+
                        "dbo.egresado.licenciatura = '{3}', "+
                        "dbo.egresado.correo = '{4}', "+
                        "dbo.egresado.telefono = '{5}' "+
                        "WHERE dbo.egresado.matricula = '{6}';"
                        , matricula, nombre, apellidos, licenciatura, correo, telefono, matriculaActual);
                    
                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    command.Dispose();

                    MessageBox.Show("Los cambios han sido guardados");

                }
                
            }
            //Cambiar las excepciones.
            catch (Exception ex)
            {
                MessageBox.Show("No se han podido realizar los cambios.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }




        public void CrearEgresado(String matricula, String nombre, String apellidos, String licenciatura, String correo, String telefono, String genero)
        {
            SqlConnection conn = null;
            int cantidadEgresados = getCantiadEgresados() + 1;

            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                if (conn != null)
                {
                    String query = String.Format("INSERT INTO dbo.egresado " +
                        "(idEgresado, matricula, nombre, apellidos, licenciatura, correo, telefono, genero, estatus, idUsuario)	"+	
                        "VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', 1, 1); "
                        , cantidadEgresados, matricula, nombre, apellidos, licenciatura, correo, telefono, genero);

                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    command.Dispose();

                    MessageBox.Show("El egresado ha sido registrado.");

                }

            }
            //Cambiar las excepciones.
            catch (Exception ex)
            {
                MessageBox.Show("No se han podido realizar el registro.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }



        public int getCantiadEgresados()
        {

            SqlConnection conn = null;
            int cantidadEgresados = 0;

            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT matricula FROM dbo.egresado;");

                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    cantidadEgresados = 0;
                    while (rd.Read())
                    {
                        cantidadEgresados++;
                    }
                    rd.Close();
                    command.Dispose();

                }
            }
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
            return cantidadEgresados;
        }


        
        public string[] GetInfoEgresadoPorMatricula(String matricula)
        {

            string[] egresadoSeleccionado = new string[6];
            SqlConnection conn = null;

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
                        egresadoSeleccionado[0] = (!rd.IsDBNull(1)) ? rd.GetString(1) : "";
                        egresadoSeleccionado[1] = (!rd.IsDBNull(2)) ? rd.GetString(2) : "";
                        egresadoSeleccionado[2] = (!rd.IsDBNull(3)) ? rd.GetString(3) : "";
                        egresadoSeleccionado[3] = (!rd.IsDBNull(6)) ? rd.GetString(6) : "";
                        egresadoSeleccionado[4] = (!rd.IsDBNull(4)) ? rd.GetString(4) : "";
                        egresadoSeleccionado[5] = (!rd.IsDBNull(5)) ? rd.GetString(5) : "";

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
            return egresadoSeleccionado;
        }
        
        
        public Int32 GetIdEgresadoPorMatricula(string matricula)
        {

            Int32 idEgresadoSeleccionado = new Int32();
            SqlConnection conn = null;

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
                        "WHERE x.matricula = '{0}' ;", matricula);

                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        idEgresadoSeleccionado = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;

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
            return idEgresadoSeleccionado;
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
                        "x.matricula, " +
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
                            nombre = (!rd.IsDBNull(1)) ? rd.GetString(1) + " " + rd.GetString(2) : "",
                            matricula = (!rd.IsDBNull(3)) ? rd.GetString(3) : "",
                            correo = (!rd.IsDBNull(4)) ? rd.GetString(4) : "",
                            telefono = (!rd.IsDBNull(5)) ? rd.GetString(5) : "",
                            genero = (!rd.IsDBNull(7)) ? rd.GetString(7) : "",

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


        public List<String> GetGeneros()
        {

            SqlConnection conn = null;
            List<String> generos = new List<String>();

            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT genero FROM dbo.egresado;");

                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        generos.Add((!rd.IsDBNull(0)) ? rd.GetString(0) : "");
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
            return generos;
        }




        public List<String> GetCarreras()
        {

            SqlConnection conn = null;
            List<String> listaCarreras = new List<String>();

            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT licenciatura FROM dbo.egresado;");

                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        listaCarreras.Add((!rd.IsDBNull(0)) ? rd.GetString(0) : "");
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
            return listaCarreras;
        }



        public List<String> GetEstudios()
        {

            SqlConnection conn = null;
            List<String> listaEstudios = new List<String>();

            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT nivelEstudios FROM dbo.infoAcademica;");

                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        listaEstudios.Add((!rd.IsDBNull(0)) ? rd.GetString(0) : "");
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
            return listaEstudios;
        }


        public List<int> GetEstatus()
        {

            SqlConnection conn = null;
            List<int> listaTrabajo = new List<int>();

            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT estatusTrabajo FROM dbo.infoLaboral;");

                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        listaTrabajo.Add((!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0);
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
            return listaTrabajo;
        }


        public List<String> GetMatriculas()
        {

            SqlConnection conn = null;
            List<String> listaMatriculas = new List<String>();

            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT matricula FROM dbo.egresado;");

                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        listaMatriculas.Add((!rd.IsDBNull(0)) ? rd.GetString(0) : "");
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
            return listaMatriculas;
        }






    }
}
