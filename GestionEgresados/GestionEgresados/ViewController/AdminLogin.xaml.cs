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
        private string usuario;
        private string contrasenia;
        private int tipoUsuario;

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Button_Clic_iniciar(object sender, RoutedEventArgs e)
        {
            if (validarCampos())
            {
                usuario = txt_user.Text;
                contrasenia = txt_pass.Password;
                //tipoUsuario= 

                Usuario user = UsuarioDAO.GetLogin(tipoUsuario, usuario, contrasenia);
                if (user != null && user.TipoUsuario == 1)
                {
                    MessageBox.Show(this, "Bienvenido: " + user.User, "Información");
                    menuAdmin menuAdmin = new menuAdmin();
                    menuAdmin.Show();
                    this.Close();
                }
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
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
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
    }
}
