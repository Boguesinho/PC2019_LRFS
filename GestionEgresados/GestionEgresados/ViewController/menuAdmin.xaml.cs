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
    /// Lógica de interacción para menuAdmin.xaml
    /// </summary>
    public partial class MenuAdmin : Window
    {
        private Usuario loguser { get; set; }

        public MenuAdmin(Usuario user)
        {
            this.loguser = user;
            InitializeComponent();
            
        }
    }
}
