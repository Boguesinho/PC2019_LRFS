using GestionEgresados.Clases;
using GestionEgresados.DAOs;
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
        public modificarEgresado()
        {
            InitializeComponent();
        }

        public modificarEgresado(String matricula )
        {
            //InitializeComponent();
            //EgresadoDAO egresadoDAO = new EgresadoDAO();
            //var egresado = egresadoDAO.GetInfoEgresadoByMatricula(matricula);
            //textboxNombre.Text = egresado.ToString(matricula, nombre );




            
        }
        
        private void ButtonGuardar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextboxMatricula_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextboxNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextboxApellidos_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextboxLicenciatura_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextboxCorreo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
