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
    /// Lógica de interacción para VentanaSatisfaccion.xaml
    /// </summary>
    public partial class VentanaSatisfaccion : Window
    {
        public VentanaSatisfaccion()
        {
            InitializeComponent();


        }

        public void llenar(String matricula)
        {
            CuestionarioDAO cd = new CuestionarioDAO();
            List<String> respuestas = cd.llenarCuestionario(matricula);
            EgresadoDAO ed = new EgresadoDAO();
            String[] egresadoSeleccionado = ed.GetInfoEgresadoPorMatricula(matricula);
            labelEgresado.Content = "Egresado: "+egresadoSeleccionado[1]+ " "+ egresadoSeleccionado[2];


            int i = 1;
            foreach (String respuesta in respuestas)
            {
                switch (i)
                {
                    case 1:
                        labelRespuesta1.Content = respuesta;
                        break;
                    case 2:
                        labelRespuesta2.Content = respuesta;
                        break;
                    case 3:
                        labelRespuesta3.Content = respuesta;
                        break;
                    case 4:
                        labelRespuesta4.Content = respuesta;
                        break;
                    case 5:
                        labelRespuesta5.Content = respuesta;
                        break;
                    case 6:
                        labelRespuesta6.Content = respuesta;
                        break;
                    case 7:
                        labelRespuesta7.Content = respuesta;
                        break;
                    case 8:
                        labelRespuesta8.Content = respuesta;
                        break;
                    case 9:
                        labelRespuesta9.Content = respuesta;
                        break;
                    case 10:
                        labelRespuesta10.Content = respuesta;
                        break;
                    case 11:
                        labelRespuesta11.Content = respuesta;
                        break;
                }
                i++;

            }

        }


        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Close();
        }
    }
}
