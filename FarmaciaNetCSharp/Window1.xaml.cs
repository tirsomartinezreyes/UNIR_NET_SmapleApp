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

namespace FarmaciaNetCSharp
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(string titulo, string texto, string direccion)
        {
            InitializeComponent();
            pedidoResumenTexto.Content = texto;
            pedidoResumenDireccion.Content = direccion;
        }

        private void ButtonEnviar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pedido enviado", "Pedido", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.Yes);
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
