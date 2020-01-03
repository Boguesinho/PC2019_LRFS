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
using GestionEgresados.Clases;

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

        public void mostrar(string matricula)
        {
            RespuestaSatisfaccionDAO rsd = new RespuestaSatisfaccionDAO();
            EgresadoDAO ed = new EgresadoDAO();
            String[] egresadoSeleccionado = ed.GetInfoEgresadoPorMatricula(matricula);
            Int32 idEgresadoSeleccionado = ed.GetIdEgresadoPorMatricula(matricula);
            List<String> respuestasSatisfaccion = rsd.mostrarCuestionarioSatisfaccion(idEgresadoSeleccionado);
            labelEgresado.Content = "Egresado: " + egresadoSeleccionado[1] + " " + egresadoSeleccionado[2];

            int i = 1;
            foreach(string respuesta in respuestasSatisfaccion)
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
                    case 12:
                        labelRespuesta12.Content = respuesta;
                        break;
                    case 13:
                        labelRespuesta13.Content = respuesta;
                        break;
                    case 14:
                        labelRespuesta14.Content = respuesta;
                        break;
                    case 15:
                        labelRespuesta15.Content = respuesta;
                        break;
                    case 16:
                        labelRespuesta16.Content = respuesta;
                        break;
                    case 17:
                        labelRespuesta17.Content = respuesta;
                        break;
                    case 18:
                        labelRespuesta18.Content = respuesta;
                        break;
                    case 19:
                        labelRespuesta19.Content = respuesta;
                        break;
                    case 20:
                        labelRespuesta20.Content = respuesta;
                        break;
                    case 21:
                        labelRespuesta21.Content = respuesta;
                        break;
                    case 22:
                        labelRespuesta22.Content = respuesta;
                        break;
                    case 23:
                        labelRespuesta23.Content = respuesta;
                        break;
                    case 24:
                        labelRespuesta24.Content = respuesta;
                        break;
                    case 25:
                        labelRespuesta25.Content = respuesta;
                        break;
                    case 26:
                        labelRespuesta26.Content = respuesta;
                        break;
                    case 27:
                        labelRespuesta27.Content = respuesta;
                        break;
                    case 28:
                        labelRespuesta28.Content = respuesta;
                        break;
                    case 29:
                        labelRespuesta29.Content = respuesta;
                        break;
                    case 30:
                        labelRespuesta30.Content = respuesta;
                        break;
                    case 31:
                        labelRespuesta31.Content = respuesta;
                        break;
                    case 32:
                        labelRespuesta32.Content = respuesta;
                        break;
                    case 33:
                        labelRespuesta33.Content = respuesta;
                        break;
                    case 34:
                        labelRespuesta34.Content = respuesta;
                        break;
                    case 35:
                        labelRespuesta35.Content = respuesta;
                        break;
                    case 36:
                        labelRespuesta36.Content = respuesta;
                        break;
                    case 37:
                        labelRespuesta37.Content = respuesta;
                        break;
                    case 38:
                        labelRespuesta38.Content = respuesta;
                        break;
                    case 39:
                        labelRespuesta39.Content = respuesta;
                        break;
                    case 40:
                        labelRespuesta40.Content = respuesta;
                        break;
                    case 41:
                        labelRespuesta41.Content = respuesta;
                        break;
                    case 42:
                        labelRespuesta42.Content = respuesta;
                        break;
                    case 43:
                        labelRespuesta43.Content = respuesta;
                        break;
                    case 44:
                        labelRespuesta44.Content = respuesta;
                        break;
                    case 45:
                        labelRespuesta45.Content = respuesta;
                        break;
                    case 46:
                        labelRespuesta46.Content = respuesta;
                        break;
                    case 47:
                        labelRespuesta47.Content = respuesta;
                        break;
                    case 48:
                        labelRespuesta48.Content = respuesta;
                        break;
                    case 49:
                        labelRespuesta49.Content = respuesta;
                        break;
                    case 50:
                        labelRespuesta50.Content = respuesta;
                        break;
                    case 51:
                        labelRespuesta51.Content = respuesta;
                        break;
                    case 52:
                        labelRespuesta52.Content = respuesta;
                        break;
                    case 53:
                        labelRespuesta53.Content = respuesta;
                        break;
                    case 54:
                        labelRespuesta54.Content = respuesta;
                        break;
                    case 55:
                        labelRespuesta55.Content = respuesta;
                        break;
                    case 56:
                        labelRespuesta56.Content = respuesta;
                        break;
                    case 57:
                        respuesta1.Text = respuesta;
                        break;
                    case 58:
                        respuesta2.Text = respuesta;
                        break;
                    case 59:
                        respuesta3.Text = respuesta;
                        break;
                    case 60:
                        respuesta4.Text = respuesta;
                        break;
                    case 61:
                        respuesta5.Text = respuesta;
                        break;
                    case 62:
                        respuesta6.Text = respuesta;
                        break;
                    case 63:
                        respuesta7.Text = respuesta;
                        break;
                    case 64:
                        respuesta8.Text = respuesta;
                        break;
                    case 65:
                        respuesta9.Text = respuesta;
                        break;
                    case 66:
                        respuesta10.Text = respuesta;
                        break;
                    case 67:
                        respuesta11.Text = respuesta;
                        break;


                }
                i++;

            }
        }
        

        /*
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
                    case 12:
                        labelRespuesta12.Content = respuesta;
                        break;
                    case 13:
                        labelRespuesta13.Content = respuesta;
                        break;
                    case 14:
                        labelRespuesta14.Content = respuesta;
                        break;
                    case 15:
                        labelRespuesta15.Content = respuesta;
                        break;
                    case 16:
                        labelRespuesta16.Content = respuesta;
                        break;
                    case 17:
                        labelRespuesta17.Content = respuesta;
                        break;
                    case 18:
                        labelRespuesta18.Content = respuesta;
                        break;
                    case 19:
                        labelRespuesta19.Content = respuesta;
                        break;
                    case 20:
                        labelRespuesta20.Content = respuesta;
                        break;
                    case 21:
                        labelRespuesta21.Content = respuesta;
                        break;
                    case 22:
                        labelRespuesta22.Content = respuesta;
                        break;
                    case 23:
                        labelRespuesta23.Content = respuesta;
                        break;
                    case 24:
                        labelRespuesta24.Content = respuesta;
                        break;
                    case 25:
                        labelRespuesta25.Content = respuesta;
                        break;
                    case 26:
                        labelRespuesta26.Content = respuesta;
                        break;
                    case 27:
                        labelRespuesta27.Content = respuesta;
                        break;
                    case 28:
                        labelRespuesta28.Content = respuesta;
                        break;
                    case 29:
                        labelRespuesta29.Content = respuesta;
                        break;
                    case 30:
                        labelRespuesta30.Content = respuesta;
                        break;
                    case 31:
                        labelRespuesta31.Content = respuesta;
                        break;
                    case 32:
                        labelRespuesta32.Content = respuesta;
                        break;
                    case 33:
                        labelRespuesta33.Content = respuesta;
                        break;
                    case 34:
                        labelRespuesta34.Content = respuesta;
                        break;
                    case 35:
                        labelRespuesta35.Content = respuesta;
                        break;
                    case 36:
                        labelRespuesta36.Content = respuesta;
                        break;
                    case 37:
                        labelRespuesta37.Content = respuesta;
                        break;
                    case 38:
                        labelRespuesta38.Content = respuesta;
                        break;
                    case 39:
                        labelRespuesta39.Content = respuesta;
                        break;
                    case 40:
                        labelRespuesta40.Content = respuesta;
                        break;
                    case 41:
                        labelRespuesta41.Content = respuesta;
                        break;
                    case 42:
                        labelRespuesta42.Content = respuesta;
                        break;
                    case 43:
                        labelRespuesta43.Content = respuesta;
                        break;
                    case 44:
                        labelRespuesta44.Content = respuesta;
                        break;
                    case 45:
                        labelRespuesta45.Content = respuesta;
                        break;
                    case 46:
                        labelRespuesta46.Content = respuesta;
                        break;
                    case 47:
                        labelRespuesta47.Content = respuesta;
                        break;
                    case 48:
                        labelRespuesta48.Content = respuesta;
                        break;
                    case 49:
                        labelRespuesta49.Content = respuesta;
                        break;
                    case 50:
                        labelRespuesta50.Content = respuesta;
                        break;
                    case 51:
                        labelRespuesta51.Content = respuesta;
                        break;
                    case 52:
                        labelRespuesta52.Content = respuesta;
                        break;
                    case 53:
                        labelRespuesta53.Content = respuesta;
                        break;
                    case 54:
                        labelRespuesta54.Content = respuesta;
                        break;
                    case 55:
                        labelRespuesta55.Content = respuesta;
                        break;
                    case 56:
                        labelRespuesta56.Content = respuesta;
                        break;
                    case 57:
                        respuesta1.Text = respuesta;
                        break;
                    case 58:
                        respuesta2.Text = respuesta;
                        break;
                    case 59:
                        respuesta3.Text = respuesta;
                        break;
                    case 60:
                        respuesta4.Text = respuesta;
                        break;
                    case 61:
                        respuesta5.Text = respuesta;
                        break;
                    case 62:
                        respuesta6.Text = respuesta;
                        break;
                    case 63:
                        respuesta7.Text = respuesta;
                        break;
                    case 64:
                        respuesta8.Text = respuesta;
                        break;
                    case 65:
                        respuesta9.Text = respuesta;
                        break;
                    case 66:
                        respuesta10.Text = respuesta;
                        break;



                }
                i++;

            }

        }
        */

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Close();
        }
    }
}
