using GestionEgresados.Clases;
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
        ArrayList arregloEgresados = new ArrayList();

        public consultarEgresados()
        {
            InitializeComponent();
            
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
               
        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            this.Close();
        }



        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            String matrica = textFiltro.Text;

            Egresado egu = new Egresado();
            string[] egresadoBusqueda = egresado.GetInfoEgresadoPorMatricula(matrica);
            ArrayList arregloBusqueda = new ArrayList();

            egu = new Egresado
            {
                nombre = egresadoBusqueda[1]+" "+egresadoBusqueda[2],
                matricula = egresadoBusqueda[0],
                correo = egresadoBusqueda[4],
                telefono = egresadoBusqueda[5],

            };
            arregloBusqueda.Add(egu);
            
            dataGridEgresados.ItemsSource = arregloBusqueda;
            
        }

        private void BtnMostrarTodos_Click(object sender, RoutedEventArgs e)
        {
            arregloEgresados = egresado.GetInfoEgresado();
            dataGridEgresados.ItemsSource = arregloEgresados;
        }

        

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            NuevoEgresado nuevoEgresado = new NuevoEgresado();
            nuevoEgresado.Show();
            this.Close();
        }
    }
}
