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

        
        private void Button_Click_Modificar(object sender, RoutedEventArgs e)
        {
            if (dataGridEgresados.SelectedIndex != -1)
            {
                //revisar si es correcto pasar los datos de egresado de esta mnera o atributo por atributo
                modificarEgresado modificarEgresad = new modificarEgresado(dataGridEgresados.SelectedValue.ToString());
                modificarEgresad.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un alumno");
            }
        }

        private void DataGridEgresados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void btn_cancelar(object sender, RoutedEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();
        }
    }
}
