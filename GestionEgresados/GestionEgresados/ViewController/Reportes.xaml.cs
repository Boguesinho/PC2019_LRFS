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
using GestionEgresados.Clases;
using GestionEgresados.DAOs;

namespace GestionEgresados.ViewController
{
    /// <summary>
    /// Lógica de interacción para Reportes.xaml
    /// </summary>
    public partial class Reportes : Window
    {

        EgresadoDAO egresado = new EgresadoDAO();
        String matriculaSeleccionada = "";

        public Reportes()
        {
            InitializeComponent();
            dataGridEgresados.ItemsSource = egresado.GetInfoEgresado();
            
        }

        private void GridEgresados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }


        private void DataGridEgresados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowColumn = dataGrid.Columns[1].GetCellContent(row).Parent as DataGridCell;
            string CellValue = ((TextBlock)RowColumn.Content).Text;
            matriculaSeleccionada = CellValue;

        }

        private void BtnSeleccionar_Click(object sender, RoutedEventArgs e)
        {

        }


        private void BtnGenerarReporte_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridEgresados.SelectedIndex != -1)
            {
                if (rb_satisfaccion.IsChecked == true)
                {
                    VentanaSatisfaccion ventanaSatisfaccion = new VentanaSatisfaccion();
                    ventanaSatisfaccion.Show();
                    ventanaSatisfaccion.llenar(matriculaSeleccionada);

                    this.Close();
                }
                else if (rb_laboral.IsChecked == true)
                {
                    VentanaLaboral ventanaLaboral = new VentanaLaboral();
                    ventanaLaboral.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una opcion");
                }
            }           
            else
            {
                MessageBox.Show("Debes seleccionar una opcion");
            }
        }

        private void RadioButton_Checked_Satisfaccion(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_Laboral(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            this.Close();
        }
    }
}
