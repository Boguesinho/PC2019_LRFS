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
using GestionEgresados.DAOs;

namespace GestionEgresados.ViewController
{
    /// <summary>
    /// Lógica de interacción para GenerarEstadísticas.xaml
    /// </summary>
    public partial class GenerarEstadísticas : Window
    {
        public GenerarEstadísticas()
        {
            InitializeComponent();
        }

        private void BtnGenerarReporte_Click(object sender, RoutedEventArgs e)
        {
            EstadisticasGeneradas estadisticasGeneradas = new EstadisticasGeneradas();
            EgresadoDAO egresado = new EgresadoDAO(); 




            if (radioButtonCarrera.IsChecked == true)
            {
                estadisticasGeneradas.Show();
                estadisticasGeneradas.generarPorCarrera();
                estadisticasGeneradas.setTextoLabel("Cantidad de egresados por Carrera");
                this.Close();
            }

            if (radioButtonEstatusTrabajo.IsChecked == true)
            {
                estadisticasGeneradas.Show();
                estadisticasGeneradas.generarPorTrabajo();
                estadisticasGeneradas.setTextoLabel("Cantidad de egresados por Estatus de trabajo");
                this.Close();
            }

            if (radioButtonGenero.IsChecked == true)
            {
                estadisticasGeneradas.Show();
                estadisticasGeneradas.generarPorGenero();
                estadisticasGeneradas.setTextoLabel("Cantidad de egresados por Género");
                this.Close();
            }

            if (radioButtonNivelEstudios.IsChecked == true)
            {
                estadisticasGeneradas.Show();
                estadisticasGeneradas.generarPorEstudios();
                estadisticasGeneradas.setTextoLabel("Cantidad de egresados por Nivel de estudios");
                this.Close();
            }

            
            

        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            this.Close();
        }

       
    }
}
