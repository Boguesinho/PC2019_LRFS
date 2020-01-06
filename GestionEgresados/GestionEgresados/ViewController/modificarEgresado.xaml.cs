using GestionEgresados.Clases;
using GestionEgresados.DAOs;
using GestionEgresados.ViewController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GestionEgresados.ViewController
{
    /// <summary>
    /// Lógica de interacción para modificarEgresado.xaml
    /// </summary>
    public partial class modificarEgresado : Window
    {
        EgresadoDAO egresado = new EgresadoDAO();
        String matriculaActual = "";
        String checado = "";

        public modificarEgresado()
        {
            InitializeComponent();
        }

        private enum CheckResult
        {
            Passed,
            Failed
        }

        public enum OperationResult
        {
            Success,
            NullOrganization,
            InvalidOrganization,
            UnknowFail,
            SQLFail,
            ExistingRecord
        }

        private CheckResult CheckEmptyFields()
        {
            CheckResult check = CheckResult.Failed;
            if (textboxMatricula.Text == String.Empty || textboxNombre.Text == String.Empty || textboxApellidos.Text == String.Empty || comboLicenciatura.SelectedItem == null || textboxCorreo.Text == String.Empty || textboxTelefono.Text == String.Empty)
            {
                check = CheckResult.Failed;
            }
            else
            {
                check = CheckResult.Passed;
            }
            return check;

        }

        private CheckResult CheckFields()
        {
            CheckResult check = CheckResult.Failed;
            Validaciones validaciones = new Validaciones();
            if (CheckEmptyFields() == CheckResult.Failed)
            {
                System.Windows.MessageBox.Show("Hay campos sin rellenar...");
                check = CheckResult.Failed;
            }
            else if (validaciones.validarMatricula(textboxMatricula.Text, matriculaActual) == Validaciones.ResultadosValidacion.MatriculaInvalida)
            {
                System.Windows.MessageBox.Show("La Matrícula es inválida o ya está registrada...");
            }
            else if (validaciones.validarNombre(textboxNombre.Text) == Validaciones.ResultadosValidacion.NombreInvalido)
            {
                System.Windows.MessageBox.Show("Hay caracteres incorrectos en el nombre...");
            }
            else if (validaciones.validarApellidos(textboxApellidos.Text) == Validaciones.ResultadosValidacion.ApellidosInvalidos)
            {
                System.Windows.MessageBox.Show("Hay caracteres incorrectos en el apellido...");
            }
            else if (validaciones.validarCorreo(textboxCorreo.Text) == Validaciones.ResultadosValidacion.CorreoInvalido)
            {
                System.Windows.MessageBox.Show("No cumple las caracteristicas de un correo electronico...");
            }
            else if (validaciones.validarTelefono(textboxTelefono.Text) == Validaciones.ResultadosValidacion.TelefonoInvalido)
            {
                System.Windows.MessageBox.Show("Numero de telefono no correcto...");
            }
            else if (textboxTelefono.Text.Length > 10)
            {
                System.Windows.MessageBox.Show("Numero de teléfono muy largo...");
            }
            else if (comboLicenciatura == null)
            {
                System.Windows.MessageBox.Show("Debes seleccionar una licenciatura...");
            }
            else if (checado == "")
            {
                System.Windows.MessageBox.Show("Debes seleccionar un estatus...");
            }
            else
            {
                check = CheckResult.Passed;
            }
            return check;
        }



        public void llenarDatosEgresado(String matricula)
        {
            InitializeComponent();
            EgresadoDAO egresadoDAO = new EgresadoDAO();
            matriculaActual = matricula;
            string[] egresadoSeleccionado = egresadoDAO.GetInfoEgresadoPorMatricula(matricula);


            textboxMatricula.Text = egresadoSeleccionado[0];
            textboxNombre.Text = egresadoSeleccionado[1];
            textboxApellidos.Text = egresadoSeleccionado[2];
            textboxCorreo.Text = egresadoSeleccionado[4];
            textboxTelefono.Text = egresadoSeleccionado[5];

            if (egresadoSeleccionado[3] == "Ingeniería de Software")
            {
                comboLicenciatura.SelectedIndex = 0;
            }
            if (egresadoSeleccionado[3] == "Redes y servicios de cómputo")
            {
                comboLicenciatura.SelectedIndex = 1;
            }
            if (egresadoSeleccionado[3] == "Tecnologías de la computación")
            {
                comboLicenciatura.SelectedIndex = 2;
            }

            if (egresadoSeleccionado[6] == "1")
                rbEgresado.IsChecked = true;
            else
                rbEstudiante.IsChecked = true;

        }

        private void ButtonGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (CheckFields() == CheckResult.Passed)
            {

                ComboBoxItem cb = (ComboBoxItem)comboLicenciatura.SelectedValue;
                String licenciatura = "" + cb.Content;
                EgresadoDAO egresadoDAO = new EgresadoDAO();                
                egresadoDAO.SetInfoEgresado(textboxMatricula.Text, textboxNombre.Text, textboxApellidos.Text,
                                            licenciatura ,textboxCorreo.Text, textboxTelefono.Text,
                                            matriculaActual, checado);                
                consultarEgresados consultarE = new consultarEgresados();
                consultarE.Show();
                this.Close();
                    
            }
            else
            {
                System.Windows.MessageBox.Show("Modifique el/los campos...");
            }

        }


        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            consultarEgresados consultaEgresados = new consultarEgresados();
            consultaEgresados.Show();
            this.Close();
        }


        private void textboxTelefono_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textboxMatricula_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RbEstudiante_Checked(object sender, RoutedEventArgs e)
        {
            checado = "Estudiante";
        }

        private void RbEgresado_Checked(object sender, RoutedEventArgs e)
        {
            checado = "Egresado";
        }
    }
}
