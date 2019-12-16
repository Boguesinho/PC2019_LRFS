using GestionEgresados.Clases;
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
    /// Lógica de interacción para menuAdmin.xaml
    /// </summary>
    public partial class MenuAdmin : Window
    {
        private Usuario loguser { get; set; }

        public MenuAdmin(Usuario user)
        {
            this.loguser = user;
            InitializeComponent();            
        }
               
        private void Button_Click_Reportes(object sender, RoutedEventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Close();
        }

        private void Button_Click_Egresados(object sender, RoutedEventArgs e)
        {
            consultarEgresados egresados = new consultarEgresados();
            egresados.Show();
            this.Close();
        }

        private void Button_Click_Estadisticas(object sender, RoutedEventArgs e)
        {
            GenerarEstadísticas estadisticas = new GenerarEstadísticas();
            estadisticas.Show();
            this.Close();
        }

        private void btn_cancelar(object sender, RoutedEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();
        }
    }
}
