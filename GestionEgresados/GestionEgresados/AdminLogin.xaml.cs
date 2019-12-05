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
    /// Lógica de interacción para AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        private string user;
        private string contrasenia;
        private string tipoUsuario;

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Button_Clic_iniciar(object sender, RoutedEventArgs e)
        {
            if (validarCampos())
            {
                user = txt_user.Text;
                contrasenia = txt_pass.Password;
                //tipoUsuario = "Administrador";
                //tipoUsuario = ""+ cb_tipoUsuario.SelectedValue;
                /*
                if (cb_tipoUsuario.SelectedIndex >= 0)
                {
                    ComboBoxItem cbi = (ComboBoxItem)cb_tipoUsuario.SelectedValue;
                    tipoUsuario = "" + cbi.Content;
                }
                */

                Usuario userGeneral = UsuarioDAO.GetLogin(user, contrasenia);
                if (userGeneral != null && userGeneral.Idusuario > 0)
                {
                    MessageBox.Show(this, "Bienvenido: " + userGeneral.Nombreuser, "Información");
                    MenuAdmin menuAdmin = new MenuAdmin(userGeneral);
                    menuAdmin.Show();
                    this.Close();
                }
                /*
                if (user != null && user.TipoUsuario == "Egresado")
                {
                    MessageBox.Show(this, "Bienvenido: " + user.User, "Información");
                    menuEgresado menuegresado = new menuEgresado();
                    menuegresado.Show();
                    this.Close();
                }
                if (user != null && user.TipoUsuario == "Empleador")
                {
                    MessageBox.Show(this, "Bienvenido: " + user.User, "Información");
                    menuEmpleador menuEmpleado = new menuEmpleador();
                    menuEmpleado.Show();
                    this.Close();
                }
                */

                else
                {
                    MessageBox.Show(this, "Sin acceso", "Error");
                    txt_user.Text = "";
                    txt_pass.Password = "";
                    txt_user.Focus();
                }

            }
            else
            {
                MessageBox.Show("Usuario y/o password Vacios...", "Error");
            }

        }

        private void btn_cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private bool validarCampos()
        {
            if (txt_user.Text == null || txt_user.Text.Length == 0)
            {
                return false;
            }
            if (txt_pass.Password == null || txt_pass.Password.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
