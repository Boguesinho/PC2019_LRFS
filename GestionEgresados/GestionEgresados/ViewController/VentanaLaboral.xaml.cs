<<<<<<< HEAD
﻿using GestionEgresados.DAOs;
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
    /// Lógica de interacción para VentanaLaboral.xaml
    /// </summary>
    public partial class VentanaLaboral : Window
    {
        public VentanaLaboral()
        {
            InitializeComponent();
        }

        public void mostrar(string matricula)
        {
            RespuestaLaboralDAO rsd = new RespuestaLaboralDAO();
            EgresadoDAO ed = new EgresadoDAO();
            String[] egresadoSeleccionado = ed.GetInfoEgresadoPorMatricula(matricula);
            Int32 idEgresadoSeleccionado = ed.GetIdEgresadoPorMatricula(matricula);
            List<String> respuestasLaboral = rsd.mostrarCuestionarioLaboral(idEgresadoSeleccionado);
            labelEgresado.Content = "Egresado: " + egresadoSeleccionado[1] + " " + egresadoSeleccionado[2];

            int i = 1;
            foreach (string respuesta in respuestasLaboral)
            {
                switch (i)
                {
                    case 1:
                        //labelRespuesta1.Content = respuesta;
                        break;
                    case 2:
                        //labelRespuesta2.Content = respuesta;
                        break;
                    case 3:
                        //labelRespuesta3.Content = respuesta;
                        break;
                    case 4:
                        //labelRespuesta4.Content = respuesta;
                        break;
                    case 5:
                        //labelRespuesta5.Content = respuesta;
                        break;
                    case 6:
                        //labelRespuesta6.Content = respuesta;
                        break;
                    case 7:
                        //labelRespuesta7.Content = respuesta;
                        break;
                    case 8:
                        //labelRespuesta8.Content = respuesta;
                        break;
                    case 9:
                        //labelRespuesta9.Content = respuesta;
                        break;
                    case 10:
                        //labelRespuesta10.Content = respuesta;
                        break;
                    case 11:
                        //labelRespuesta11.Content = respuesta;
                        break;
                    case 12:
                        //labelRespuesta12.Content = respuesta;
                        break;
                    case 13:
                        //labelRespuesta13.Content = respuesta;
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
=======
﻿using System;
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
    /// Lógica de interacción para VentanaLaboral.xaml
    /// </summary>
    public partial class VentanaLaboral : Window
    {
        public VentanaLaboral()
        {
            InitializeComponent();
        }
    }
}
>>>>>>> master
