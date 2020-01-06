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
    public partial class NuevoEgresado : Window
    {
        EgresadoDAO egresado = new EgresadoDAO();
        String matriculaActual = "";
        String checado = "";

        public NuevoEgresado()
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
            if (textboxMatricula.Text == String.Empty || textboxNombre.Text == String.Empty || textboxApellidos.Text == String.Empty || comboLicenciatura.SelectedItem == null || textboxCorreo.Text == String.Empty || comboGenero.SelectedItem == null || textboxTelefono.Text == String.Empty)
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
            else if (textboxMatricula.Text.Length != 9)
            {
                System.Windows.MessageBox.Show("La matrícula debe contener 9 caracteres...");
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
            else if (comboLicenciatura.SelectedItem == null)
            {
                System.Windows.MessageBox.Show("Debes seleccionar una licenciatura...");
            }
            else if (comboGenero.SelectedItem == null)
            {
                System.Windows.MessageBox.Show("Debes seleccionar un género...");
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



        private void ButtonGuardar_Click(object sender, RoutedEventArgs e)
        {

            if (CheckFields() == CheckResult.Passed)
            {
                ComboBoxItem cg = (ComboBoxItem)comboGenero.SelectedValue;
                String genero = "" + cg.Content;
                ComboBoxItem cb = (ComboBoxItem)comboLicenciatura.SelectedValue;
                String licenciatura = "" + cb.Content;
                EgresadoDAO egresadoDAO = new EgresadoDAO();

                egresadoDAO.CrearEgresado(textboxMatricula.Text, textboxNombre.Text, textboxApellidos.Text,
                                            licenciatura, textboxCorreo.Text, textboxTelefono.Text,
                                            genero, checado);
                consultarEgresados consultarE = new consultarEgresados();
                consultarE.Show();
                this.Close();
            }
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            consultarEgresados consultaEgresados = new consultarEgresados();
            consultaEgresados.Show();
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
