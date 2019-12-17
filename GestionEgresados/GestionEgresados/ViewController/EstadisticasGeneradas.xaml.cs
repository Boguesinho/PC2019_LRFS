using System;
using System.Collections;
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
using LiveCharts;
using LiveCharts.Wpf;

namespace GestionEgresados.ViewController
{
    public partial class EstadisticasGeneradas : Window
    {
        EgresadoDAO egresado = new EgresadoDAO();
            

        public EstadisticasGeneradas()
        {
            InitializeComponent();
            
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }


        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            GenerarEstadísticas generarEstadisticas = new GenerarEstadísticas();
            generarEstadisticas.Show();
            this.Close();

        }



        public void generarPorGenero()
        {
            List<String> listaGeneros = new List<String>();
            listaGeneros = egresado.GetGeneros();

            int cantidadHombres = 0;
            int cantidadMujeres = 0;
            int cantidadEgresados = 0;

            foreach (String genero in listaGeneros)
            {
                

                if (genero == "Masculino")
                {
                    cantidadHombres++;
                }
                if (genero == "Femenino")
                {
                    cantidadMujeres++;
                }
                cantidadEgresados++;
            }

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Hombres",
                    Values = new ChartValues<double> { cantidadHombres }
                }
            };

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Mujeres",
                Values = new ChartValues<double> { cantidadMujeres }
            });

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Total",
                Values = new ChartValues<double> { cantidadEgresados }
            });

            DataContext = this;
        }




        public void generarPorCarrera()
        {
            List<String> listaCarreras = new List<String>();
            listaCarreras = egresado.GetCarreras();

            int cantidadEnIngenieria = 0;
            int cantidadEnRedes = 0;
            int cantidadEnTecnologias = 0;

            foreach (String carreras in listaCarreras)
            {


                if (carreras == "Ingeniería de Software")
                {
                    cantidadEnIngenieria++;
                }
                if (carreras == "Redes y servicios de cómputo")
                {
                    cantidadEnRedes++;
                }
                if (carreras == "Tecnologías de la computación")
                {
                    cantidadEnTecnologias++;
                }
            }

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Ingeniería de Software",
                    Values = new ChartValues<double> { cantidadEnIngenieria }
                }
            };

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Redes y servicios de cómputo",
                Values = new ChartValues<double> { cantidadEnRedes }
            });

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Tecnologías de la computación",
                Values = new ChartValues<double> { cantidadEnTecnologias }
            });

            DataContext = this;
        }




        public void generarPorEstudios()
        {
            List<String> listaEstudios = new List<String>();
            listaEstudios = egresado.GetEstudios();

            int cantidadLicenciatura = 0;
            int cantidadMaestria = 0;
            int cantidadDoctorado = 0;

            foreach (String estudios in listaEstudios)
            {


                if (estudios == "Licenciatura")
                {
                    cantidadLicenciatura++;
                }
                if (estudios == "Maestría")
                {
                    cantidadMaestria++;
                }
                if (estudios == "Doctorado")
                {
                    cantidadDoctorado++;
                }
            }

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Licenciatura",
                    Values = new ChartValues<double> { cantidadLicenciatura }
                }
            };

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Maestría",
                Values = new ChartValues<double> { cantidadMaestria }
            });

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Doctorado",
                Values = new ChartValues<double> { cantidadDoctorado }
            });

            DataContext = this;
        }


        public void generarPorTrabajo()
        {
            List<int> listaTrabajos = new List<int>();
            listaTrabajos = egresado.GetEstatus();

            int cantidadEmpleados = 0;
            int cantidadDesempleados = 0;

            foreach (int estatus in listaTrabajos)
            {


                if (estatus == 1)
                {
                    cantidadEmpleados++;
                }
                if (estatus == 0)
                {
                    cantidadDesempleados++;
                }
            }

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Empleados",
                    Values = new ChartValues<double> { cantidadEmpleados }
                }
            };

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Desempleados",
                Values = new ChartValues<double> { cantidadDesempleados }
            });

            DataContext = this;
        }





        public void setTextoLabel (string texto)
        {
            labelEstadistica.Content = texto;
        }

    }
}