using GestionEgresados.Clases;
using GestionEgresados.DAOs;
using GestionEgresados.ViewController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GestionEgresados.ViewController
{
    /// <summary>
    /// Lógica de interacción para modificarEgresado.xaml
    /// </summary>
    public partial class modificarEgresado : Window
    {
        EgresadoDAO egresado = new EgresadoDAO();
        String matriculaActual = "";
        
        public modificarEgresado()
        {
            InitializeComponent();
        }
        
        public void llenarDatosEgresado(String matricula)
        {
            InitializeComponent();
            EgresadoDAO egresadoDAO = new EgresadoDAO();
            matriculaActual = matricula;
            string[] egresadoSeleccionado = egresadoDAO.GetInfoEgresadoPorMatricula(matricula);

            textboxMatricula.Text = egresadoSeleccionado[0];
            textboxNombre.Text = egresadoSeleccionado[1];
            textboxApellidos.Text = egresadoSeleccionado[2];
            textboxLicenciatura.Text = egresadoSeleccionado[3];
            textboxCorreo.Text = egresadoSeleccionado[4];
            textboxTelefono.Text = egresadoSeleccionado[5];
                        
        }
        
        private void ButtonGuardar_Click(object sender, RoutedEventArgs e)
        {
            EgresadoDAO egresadoDAO = new EgresadoDAO();
            egresadoDAO.SetInfoEgresado(textboxMatricula.Text, textboxNombre.Text, textboxApellidos.Text, 
                                        textboxLicenciatura.Text, textboxCorreo.Text, textboxTelefono.Text,
                                        matriculaActual);

            
            consultarEgresados consultarE = new consultarEgresados();
            consultarE.Show();
            this.Close();
        }


        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            consultarEgresados consultaEgresados = new consultarEgresados();
            consultaEgresados.Show();
            this.Close();
        }

    }
}
