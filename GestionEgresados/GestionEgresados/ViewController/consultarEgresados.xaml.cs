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
    /// Lógica de interacción para consultarEgresados.xaml
    /// </summary>
    public partial class consultarEgresados : Window
    {
        EgresadoDAO egresado = new EgresadoDAO();

        public consultarEgresados()
        {
            InitializeComponent();
            dataGridEgresados.ItemsSource = egresado.GetInfoEgresado();
        }

        private void DataGridEgresados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
