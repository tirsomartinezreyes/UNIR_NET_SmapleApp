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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FarmaciaNetCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBorrar_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("on Borrar");
            medicamentoNombre.Text = "";
            medicamentoTipo.SelectedIndex = 0;
            medicamentoCantidad.Text = "0";
            medicamentoDistribuidor1.IsChecked = false;
            medicamentoDistribuidor2.IsChecked = false;
            medicamentoDistribuidor3.IsChecked = false;
            medicamentoEntregaPrincipal.IsChecked = false;
            medicamentoEntregaSecundaria1.IsChecked = false;
            medicamentoValidacion.Content = "";
        }
    }
}
