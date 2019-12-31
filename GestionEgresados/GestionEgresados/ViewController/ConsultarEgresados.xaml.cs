using GestionEgresados.DAOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
        public String matriculaSeleccionada = "";

        public consultarEgresados()
        {
            InitializeComponent();
            ArrayList arregloEgresados = new ArrayList();
            arregloEgresados = egresado.GetInfoEgresado();
            dataGridEgresados.ItemsSource = arregloEgresados;
            
        }

   
        
        
        private void Button_Click_Modificar(object sender, RoutedEventArgs e)
        {
            if (dataGridEgresados.SelectedIndex != -1)
            {
                modificarEgresado modificarEgresado = new modificarEgresado();
                modificarEgresado.Show();
                this.Close();
                modificarEgresado.llenarDatosEgresado(matriculaSeleccionada);

            }
            else
            {
                MessageBox.Show("Debes seleccionar un alumno");
            }
        }

        private void DataGridEgresados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowColumn = dataGrid.Columns[1].GetCellContent(row).Parent as DataGridCell;
            string CellValue = ((TextBlock)RowColumn.Content).Text;
            matriculaSeleccionada = CellValue;
        }

        private void btn_cancelar(object sender, RoutedEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();
        }
    }
}
